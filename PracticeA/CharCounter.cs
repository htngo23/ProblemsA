using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeA
{
    public class CharCounter
    {
        public void stringIntake()
        {
            String word1;
            Console.WriteLine("insert a word");
            word1 = Console.ReadLine();
            Console.WriteLine(word1.Length);
        }   
        public List<int> listA()
        {
            List<int> shorts = new List<int>();
            shorts.Add(2);
            shorts.Add(6);
            shorts.Add(8);
            shorts.Add(10);
            return shorts;
        }
        public void ListOut()
        {
            Console.WriteLine(listA().Count);
            
        }
        

      
       

    }
}
