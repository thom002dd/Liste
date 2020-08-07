using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;



namespace Practice

{

    class Program

    {

        static void Main(string[] args)

        {   //delcaring list and adding/removing items

            List<int> listeb = new List<int>();



            listeb.Add(2);

            listeb.Add(4);

            listeb.Add(6);

            listeb.Add(8);

            listeb.Add(10);

            listeb.Add(12);

            listeb.Add(14);

            listeb.Add(16);

            listeb.Add(18);

            listeb.Add(20);



            listeb.Insert(3, 17);



            listeb.Remove(6);

            listeb.Remove(12);

            listeb.Remove(18);

            //prints list



            for (int i = 0; i < listeb.Count; i++)

            {

                Console.WriteLine(listeb[i]);

            }



            //reverses list and prints it below the original

            listeb.Reverse();

            Console.WriteLine();

            foreach (int b in listeb)
            {
                Console.WriteLine(b);
            }


            Console.ReadKey();

        }

    }

}