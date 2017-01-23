using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace OLIOT
{
    class NisakasTeht3
    {
        public static void Teht3()
        {


            Human Dude = new Human(125,122,"setämies",15);
            Human Human2 = new Human(125,22,"dude",14);
            Baby Babi = new Baby(22,15,"stsast",2,"pampers");
            GrownUp Adult = new GrownUp(180,90,"Mister Human",35,"Lada");

            Console.WriteLine(Human2.ToString());
            Console.WriteLine(Dude.ToString());
            Console.WriteLine(Babi.ToString());
            Console.WriteLine(Adult.ToString());

            Adult.Grow();
            Adult.Liiku();
            Babi.Liiku();
            Dude.Liiku();

            Console.WriteLine(Adult.ToString());

        }
    }
}
