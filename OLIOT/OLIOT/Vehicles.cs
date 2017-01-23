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

           
           

            List<Vehicle> Cars = new List<Vehicle>();
            
            
            Vehicle Car1 = new Vehicle("911", "Porche", 4, Hakkapeliitat);
            Cars.Add(new Vehicle("Zonda", "Pagani", 4, Hakkapeliitat));

            Vehicle Mopedi = new Vehicle("Mopo", "jep", 2, MICS);

            Cars.Add(Car1);
            Cars.Add(Mopedi);
            Car1.AddTyres(Hakkapeliitta);

            foreach (var Vehicle in Cars)
            {
                //Prints every Vehicle in the Cars list
                Console.WriteLine("\n" + Vehicle.OutPut());
                foreach(var Tyre in Vehicle.Tyres)
                {
                    Console.WriteLine(Tyre.OutPut());
                }
               
            }

            

        }
    }
}
