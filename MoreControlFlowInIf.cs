using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSmell
{
    class MoreControlFlowInIf
    {
        public string FirstVersion(string mystring)
        {
            string[] cars1 = { "Volvo", "BMW", "Ford", "Mazda" };
            string[] cars2 = { "Volvo", "BMW", "Ford", "Mazda" };
            string chuoitam = "";
            for (var j = 0; j < 4; j++)
            {
                string mycar1 = cars1[j];
                string mycar2 = cars2[j];

                if (mycar1 == mycar2 && (mystring == "Program")) // nest more control flow statements 
                {
                    chuoitam += " * " + mycar1.ToString();
                }
            }
            return chuoitam;
        }
        public string RefactorVersion(string mystring)
        {
            string[] cars1 = { "Volvo", "BMW", "Ford", "Mazda" };
            string[] cars2 = { "Volvo", "BMW2", "Ford2", "Mazda" };
            string chuoitam = "";
            for (var j = 0; j < 4; j++)
            {
                string mycar1 = cars1[j];
                string mycar2 = cars2[j];

                if (!(mystring == "Program"))
                {
                    continue;
                }
                if (!(mycar1 == mycar2))
                {
                    continue;
                }
                chuoitam += " * " + mycar1.ToString(); 
            }
            return chuoitam;
        }
    }
}
