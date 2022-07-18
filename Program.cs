namespace Dictionary
{
    public class Program
    {
        public static void Main()
        {
            var dictionary = new Dictionary<string, string>();

            IRepository repository = new Repository();
            IMyDictionary myDictionary = new MyDictionary(repository);
            IInputValidator inputValidator = new InputValidator();

            var dic = repository.Load(dictionary);

            do
            {
                Console.Clear();

                Console.WriteLine("__LET'S SPEAK - DICIONÁRIO__");
                Console.WriteLine("1 - ADICIONAR PALAVRA");
                Console.WriteLine("2 - BUSCAR PALAVRA");
                Console.WriteLine("0 - ENCERRAR SESSÃO");

                var option = inputValidator.ValidateInput();

               

                switch (option)
                {
                    case 0:
                        break;

                    case 1:
                        Console.WriteLine("ADICIONAR PALAVRA AO DICIONÁRIO");
                        Console.Write("TERMO: ");
                        string addTerm = Console.ReadLine();

                        Console.Write("DESCRIÇÃO: ");
                        string description = Console.ReadLine();

                        myDictionary.Add(dic, addTerm!, description!);
                        break;
                    case 2:
                        Console.WriteLine("BUSCANDO O TERMO");
                        Console.Write("TERMO: ");
                        string searchTerm = Console.ReadLine();

                        myDictionary.Search(dic, searchTerm!);
                        Console.ReadLine();
                        break;
                }
                //if (option == 1)
                //{
                //    Console.Clear();

                //    Console.WriteLine("Que palavra deseja adicionar?");
                //    var word = Console.ReadLine();

                //    Console.WriteLine("\nQual é o seu significado?");
                //    var meaning = Console.ReadLine();

                //    myDictionary.Add(dic, word!, meaning!);
                //}

                //if (option == 2)
                //{
                //    Console.Clear();

                //    Console.WriteLine("Que palavra deseja buscar?");
                //    var word = Console.ReadLine();
                //    myDictionary.Search(dic, word!);
                //    Console.ReadLine();
                //}

                //if (option == 0)
                //    break;

            } while (true);
        }
    }
}
