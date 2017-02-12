using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Lab10T3
{
    abstract class Lottery
    {
        public int number { get; set; }

        public Random rnd = new Random();
    }

    class Lotto : Lottery
    {
        public int lines = 7;
        public int lottoRand()
        {
            number = rnd.Next(1, 39 + 1);
            return number;
        }
    }

    class VikingLotto : Lottery
    {
        public int lines = 6;
        public int vikingRand()
        {
            number = rnd.Next(1, 48 + 1);
            return number;
        }
    }

    class EuroJackpot : Lottery
    {
        public int lines = 5;
        public int euroRand()
        {
            number = rnd.Next(1, 50 + 1);
            return number;
        }
    }

    class EuroJackpotXtra : Lottery
    {
        public int lines = 2;
        public int euroXtraRand()
        {
            number = rnd.Next(1, 10 + 1);
            return number;
        }
    }
}
