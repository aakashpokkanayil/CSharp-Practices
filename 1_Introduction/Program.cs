namespace _1_Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");  //console is a class & WriteLine is a method.
            //console.WriteLine("What is your name?"); //compile time error
            string? name = Console.ReadLine();
            Console.WriteLine($"Hi {name}");
            Console.WriteLine("What is your age?");
            string? age = Console.ReadLine();
            Console.WriteLine("Age entered is {age}");
            //Console.WriteLine('HI!'); //compile time error
            Console.WriteLine("Hi,");
            Console.Write("How are you ?");

            // Console.WriteLine(0 / 1); //runtime error
        }
    }
}

// It compiles your code into an executable format that a computer can understand.
// C# is a case-sensitive language 
    // so spelling mistakes and incorrect cases leads to error.
// Comments usage
    // Comment down unwanted code but need for future references.
    // for adding notes about logic or other details.
// Console.WriteLine() vs Console.Write()
    // both prints msg to output console
    // WriteLine function adds a new line like pressing enter.
// Programming languages
    // let you write instructions(source code) that you want the computer to carry out (computer understands 0's and 1's only)
    // each prog language has its own syntax.
    // I think prog language purpose is to make source code more human readable form.
    // how easy a prog language depend upon how short and simple language it uses. 
// compilation
    // A special program called a compiler converts your source code into a different format that the computer's central processing unit (CPU) can execute. 
    // its not directly complied to native code we can discuss it later
    // explain syntax, why syntax is important.
    // Compiler wont run code it just checks for syntax,casting or assignment issues etc.. 
    // Compile time error vs runtime error
// Background Compilation (for C#):
    // In some languages like C#, Visual Studio has a background compiler that continuously analyzes your code while you write.
    // This doesn't produce a complete compiled binary, but it does a "mini-compilation" to spot syntax issues or common logical mistakes. 
    