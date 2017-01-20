using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

/* Example print

    HOMEWORK 1 - WEEK 04

Name&Model: Pagani Zonda
Tyres:
        Name&Model: Nokia Hakkapeliitta Size: 205R16
        Name&Model: Nokia Hakkapeliitta Size: 205R16
        Name&Model: Nokia Hakkapeliitta Size: 205R16
        Name&Model: Nokia Hakkapeliitta Size: 205R16

Name&Model: Porche 911
Tyres:
        Name&Model: Nokia Hakkapeliitta Size: 205R16
        Name&Model: Nokia Hakkapeliitta Size: 205R16
        Name&Model: Nokia Hakkapeliitta Size: 205R16
        Name&Model: Nokia Hakkapeliitta Size: 205R16

Name&Model: Diavel Ducati
Tyres:
        Name&Model: MIC Pilot Size: 160R17
        Name&Model: MIC Pilot Size: 140R16

*/
namespace OLIOT
{
    public class Vehicles
    {
        public static void VehicleTesting()
        {
            Tyre Hakkapeliitta = new Tyre("Hakkapeliitta", "Nokia", "205R16");
            List<Tyre> Hakkapeliitat = new List<Tyre>();

            Tyre MIC = new Tyre("Pilot","MIC",  "160R17");
            Tyre MIC2 = new Tyre("Pilot", "MIC", "140R16");
            List<Tyre> MICS = new List<Tyre>();

            MICS.Add(MIC); MICS.Add(MIC2);

            

            Vehicle Car1 = new Vehicle("911", "Porche",4, Hakkapeliitat);
            

            
            for (int i = 0; i < Car1.Wheel; i++)
            {
                Hakkapeliitat.Add(Hakkapeliitta);
            }

            List<Vehicle> Cars = new List<Vehicle>();

            Cars.Add(new Vehicle("Zonda", "Pagani", 4, Hakkapeliitat));
            Cars.Add(Car1);
            Cars.Add(new Vehicle("Ducati", "Diavel", 2, MICS));

            int x = 0;
            foreach (var Vehicle in Cars)
            {
                //Prints every Vehicle in the Cars list
                x = 0;
                Console.WriteLine("\n"+Vehicle.OutPut());

                
                foreach (var Tyre in Vehicle.Tyres)//Prints every Tyre for the current vehicle
                {
                    if (x == 0) { Console.WriteLine("Tyres: "); x++; }
                    Console.WriteLine("\t"+Tyre.OutPut());
                }
            }

            

        }
    }
}
