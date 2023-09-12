//Daniel Frykman, .NET23
namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //set a number.
            int myNumber = 7;
            
            //if-else to check how big the number is and output a message depending on result.
            if(myNumber > 10)
            {
                Console.WriteLine("Talet är stort!");
            }
            else
            {
                Console.WriteLine("Oj. Lågt tal!");
            }

            //initiate variable for input. Ask user's name, add input to yourName. Output message containing the user's name.
            string yourName;

            Console.WriteLine("\nVad heter du?");
            Console.Write(">");
            yourName = Console.ReadLine();

            Console.WriteLine($"Hej {yourName}!\n");

            //loop through numbers from zero to number set in myNumber.
            for (int i = 0; i <= myNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}