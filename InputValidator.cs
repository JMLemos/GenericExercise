namespace Dictionary
{
    public class InputValidator : IInputValidator
    {
        public int ValidateInput()
        {
            int option;
            bool selection;
            do
            {
                Console.Write("OPÇÃO: ");
                selection = int.TryParse(Console.ReadLine()!, out option);
            } while (!selection || option < 0 || option > 2);

            return option;
        }
    }
}
