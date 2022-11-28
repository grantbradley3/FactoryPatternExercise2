namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {

            string userInput;
            bool correctInput;

            do
            {
                correctInput= true;
                Console.WriteLine("What database would you like to use?");
                Console.WriteLine("Type: sql");
                Console.WriteLine("Type: mongo");
                Console.WriteLine("Type: list");

                userInput = Console.ReadLine();

                if (userInput != "sql" && userInput != "mongo" && userInput != "list")
                {
                    correctInput= false;
                    Console.WriteLine("Incorrect Input");
                }

            } while (correctInput == false);


            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);

            var products = db.LoadData();
            db.SaveData();

            foreach(var item in products ) 
            {
                Console.WriteLine($"Name: {item.Name} Price:{item.Price}");
            }

        }
    }
}
