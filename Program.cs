using System;
using System.Linq;

namespace CodeSmell
{
    class Program
    {
        static void Main(string[] args)
        {
            var myString = "Program";
            MoreControlFlowInIf refactorif = new MoreControlFlowInIf();
         //   myString = refactorif.FirstVersion(myString);
            myString = refactorif.RefactorVersion(myString);
            Console.WriteLine($"{myString} is Final");
        }
    }
}
