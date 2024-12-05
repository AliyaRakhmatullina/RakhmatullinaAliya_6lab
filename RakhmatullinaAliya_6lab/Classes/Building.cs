using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RakhmatullinaAliya_6lab.Classes
{
    internal class Building
    {
        
            
            private static int lastBuildingNumber = 0;

       
            private int buildingNumber;
            private double height;
            private int floors;
            private int apartments;
            private int entrances;

         
            public Building()
            {
                
                buildingNumber = GenerateBuildingNumber();
            }

            
            private int GenerateBuildingNumber()
            {
                return ++lastBuildingNumber;
            }

            
            public void SetHeight(double height)
            {
                this.height = height;
            }

            public void SetFloors(int floors)
            {
                this.floors = floors;
            }

            public void SetApartments(int apartments)
            {
                this.apartments = apartments;
            }

            public void SetEntrances(int entrances)
            {
                this.entrances = entrances;
            }

            
            public int GetBuildingNumber()
            {
                return buildingNumber;
            }

            public double GetHeight()
            {
                return height;
            }

            public int GetFloors()
            {
                return floors;
            }

            public int GetApartments()
            {
                return apartments;
            }

            public int GetEntrances()
            {
                return entrances;
            }

          
            public void DisplayInfo()
            {
                Console.WriteLine($"Building Number: {buildingNumber}");
                Console.WriteLine($"Height: {height} meters");
                Console.WriteLine($"Floors: {floors}");
                Console.WriteLine($"Apartments: {apartments}");
                Console.WriteLine($"Entrances: {entrances}");
            }

          
            public double CalculateFloorHeight()
            {
                if (floors == 0)
                {
                    return 0;
                }
                return height / floors;
            }

            
            public int CalculateApartmentsPerEntrance()
            {
                if (entrances == 0)
                {
                    return 0;
                }
                return apartments / entrances;
            }

          
            public int CalculateApartmentsPerFloor()
            {
                if (floors == 0)
                {
                    return 0;
                }
                return apartments / floors;
            }
    }
}
