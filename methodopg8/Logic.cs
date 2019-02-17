using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodopg8
{
    class Logic
    {
        public static List<int> Removenumbers3goesinto(List<int> liste)
        {
            for (int i = 0; i < liste.Count; i++) // we use count with list to see the length of the list 
            {

                if (liste[i] % 3 == 0) // if one of our numbers in our list modulus 3 is the same as 0 3 goes up in the number
                {
                   liste.Remove(liste[i]); // then remove the numbers we found
                }
            }

            return liste;
        }

        public static List<int> InsertANumberToList(List<int> liste, int index, int number) // insert a number on which index u choose
        {
            liste.Insert(index, number);

            return liste;
        }

        public static List<int> ReverseNumber(List<int> liste) //reversing numbers in a list
        {
            liste.Reverse();

            return liste;
        }

        public static List<int> PrintListGui(List<int> Liste) //printing the list u choose
        {
            foreach (int item in Liste)
            {
                Console.WriteLine(item);
            }

            return Liste;
        }

           
    }
}
