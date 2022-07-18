namespace Dictionary
{
    public class MyDictionary : IMyDictionary
    {
        private string? Word { get; set; }
        private string? Description { get; set; }

        private readonly IRepository? _repository;

        public MyDictionary(IRepository repository)
        {
            _repository = repository;
        }

        public void Add(Dictionary<string, string> dictionary, string word, string description)
        {
            Word = word;
            Description = description;
            dictionary.Add(word!, description!);
            _repository!.Save(dictionary);
        }

        public void Search(Dictionary<string, string> dictionary, string word)
        {
         
            foreach (var pesq in dictionary)
            {

                if (pesq.Key.Contains(word, StringComparison.InvariantCultureIgnoreCase))
                {
                    
                    Console.WriteLine($"{pesq.Key.ToUpper()}: {pesq.Value.ToUpper()}");

                }
                                 
            }
        }
    }
}
