namespace _3_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaration and assignment
            int age; //declaration
            age = 20; //assignment
            Console.WriteLine($"variable age value: {age}");

            int age2 = 65; // both together
            Console.WriteLine($"variable age2 value: {age2}");

            age2 = 45; //reassignment
            Console.WriteLine($"variable age2 reassigned value: {age2}");

            //int age2; // we cant define a variable more than once.

            // why assignment required before variable usage?
            // C# dont want variables to be in an undefined state,that why its defined in that way. 
            // if a unassignment variable set as undefined like javascript it will effect c#'s type safety property, means ""Undefined"" type dont belongs to int,string or any of types.

           
        }
    }

    public class sop
    {
        public int age;
        public void displayAge()
        {
            Console.WriteLine($"Your Age is {age}");
        }
    }
}

