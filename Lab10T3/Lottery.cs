using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Lab10T3
{
    class Lottery
    {
        Random rnd = new Random();
        public int Number {
            get { return number; }
            set { number = value; }
        }
        private int number;
        List<int> list = new List<int>();

        public Lottery()
        {
            Number = number;
        }

        public void randomize()
        {
            for (int i = 0; i < 39; i++)
            {
                number = rnd.Next(1, 39 + 1);
                for (int j = 0; j < 7; j++)
                {
                    list.Add(number);
                }
            }
        }
    }
}
