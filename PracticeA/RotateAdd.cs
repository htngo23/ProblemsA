using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeA
{
    class RotateAdd
    {

        public void listAlpha()
        {
            List<int> outs = new List<int>();
            outs.Add(1);
            outs.Add(2);
            outs.Add(3);
            

            //int listlength = outs.Count;
            int i = 0;

          
            outs.Insert(0, outs[outs.Count - 1]);
           outs.RemoveAt(outs.Count - 1);

           outs.Insert(0, outs[outs.Count - 1]);
           outs.RemoveAt(outs.Count - 1);


            foreach (int x in outs)

            {


                Console.WriteLine(x + 5);
            }
            Console.ReadLine();




        }





        //public void add5()
        //{
        //    int fun = 0;
        //    foreach (int i in listAlpha())
        //    {
        //        fun = i;
        //        fun += 5;
        //        //Console.WriteLine(fun);
        //    }
        }
    }
   