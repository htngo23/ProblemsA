using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeA
{
    class cccComboBreaker
    {
      public List<string> comboBreak()
        {
            List<String> finn = new List<String>();
            finn.Add("Up");
            finn.Add("Down");
            finn.Add("left");
            finn.Add("left");
            finn.Add("right");
            finn.Add("right");
            finn.Add("down");
            finn.Add("spin");
            finn.Add("down");
            finn.Add("up");
            finn.Add("left");
            finn.Add("right");
            finn.Add("left");
            finn.Add("Down");
            finn.Add("spin");
            finn.Add("up");
            finn.Add("down");
            finn.Add("Jump");
            return finn;
        }
        public void sayCombo()
        {
            foreach (String i in comboBreak())
            {
                Console.WriteLine(i);
            }
        }
    }
}
