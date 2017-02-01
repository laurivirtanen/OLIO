using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABRA08_
{
    class Dice
    {


        public static int ThrowDice(Random r)
        {
            int t = r.Next(1, 7);
            return t;
        }
    }
}
