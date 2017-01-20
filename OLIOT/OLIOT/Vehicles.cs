using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace OLIOT
{
    public class Vehicles
    {
        public static void VehicleTesting()
        {
            Tyre Hakkapeliitta = new Tyre("Hakkapeliitta", "Nokia", "205R16");
            List<Tyre> Hakkapeliitat = new List<Tyre>();

            int x = 0;

            Vehicle Car1 = new Vehicle("911", "Porche",4, Hakkapeliitat);
            

            for (int i = 0; i<Car1.Wheel; i++)
            {
                Hakkapeliitat.Add(Hakkapeliitta);
            }

            List<Vehicle> Cars = new List<Vehicle>();
            Cars.Add(new Vehicle("Zonda", "Pagani", 4, Hakkapeliitat));
            Cars.Add(Car1);

            
            foreach(var Vehicle in Cars)
            {
                x = 0;
                Console.WriteLine("\n"+Vehicle.OutPut());
                foreach (var Tyre in Hakkapeliitat)
                {
                    if (x == 0) { Console.WriteLine("Tyres: "); x++; }
                    Console.WriteLine("\t"+Hakkapeliitta.OutPut());
                }
            }

            

        }
    }
}
