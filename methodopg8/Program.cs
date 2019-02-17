using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodopg8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listeB = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };


          
            //list b 
            Logic.Removenumbers3goesinto(listeB); // removes all numbers 3 goes into
            Logic.InsertANumberToList(listeB, 2, 17); //insert number 17 to index 3 in list
            Logic.PrintListGui(listeB); // printing our list



            //reversed numbers list
            List<int> reversedNumbers = new List<int>(listeB); // copy old lists numbers so we can reverse it

            Logic.ReverseNumber(reversedNumbers); //reversing the numbers of list reversednumbers

            Logic.PrintListGui(reversedNumbers); // printing our list



        }
    }
}
