using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeA
{
    class stickmon
    {
        public void handup() {
            Console.WriteLine(@"

                     *  * 
                   *      * 
                     *  *        * 
                       *      * 
                   *  *  * 
                 *    *     
               *      *       
                       * 
                   *      * 
                 *          * 
               *              * 
             *                  * 
           *                      * 
                
           ");
        }

        public void handDown()
        {
            Console.WriteLine(@"  
                     *  * 
                   *      * 
                     *  *        
                       *    
                   *  *  * 
                 *    *     *
               *      *        * 
                       * 
                   *      * 
                 *          * 
               *              * 
             *                  * 
           *                      * ");
        }

        public void dance() {
            for (int i = 0; i < 5; i++) {
                if (i % 2 == 0)
                {
                    Console.Clear();
                    handup();
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    handDown();
                    Console.ReadLine();
                }
            } 
     
    }
   
    
    }
    }


