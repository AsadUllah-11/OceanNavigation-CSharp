using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using problemOne.BL;

namespace problemOne
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ship> shipsData = new List<ship>();
            char option = menu();
            do
            {
                if (option == 'a')
                {
                    // Taking Input for Add A New Ship
                    ship shipsInfo = new ship();
                    Console.Write("Enter Ship Number: ");
                    shipsInfo.shipNumber = Console.ReadLine();


                    Console.WriteLine("Enter Ship Latitude: ");
                    int latitudeDegree;
                    float latitudeMinute;
                    char latitudeDirection;

                    Console.Write("Enter Latitudes Degree: ");
                    latitudeDegree = int.Parse(Console.ReadLine());
                    Console.Write("Enter Latitudes Minute: ");
                    latitudeMinute = float.Parse(Console.ReadLine());
                    Console.Write("Enter Latitudes Direction: ");
                    latitudeDirection = char.Parse(Console.ReadLine());
                    LatitudeAngle checkLatitude = new LatitudeAngle(latitudeDegree, latitudeMinute, latitudeDirection);
                    string latitudeValue = checkLatitude.changeLatitudeAngleValue();

                    Console.WriteLine("Enter Ship Longitude: ");
                    int longitudeDegree;
                    float longitudeMinute;
                    char longitudeDirection;

                    Console.Write("Enter Logitudes Degree: ");
                    longitudeDegree = int.Parse(Console.ReadLine());
                    Console.Write("Enter Longitudes Minute: ");
                    longitudeMinute = float.Parse(Console.ReadLine());
                    Console.Write("Enter Longitudes Direction: ");
                    longitudeDirection = char.Parse(Console.ReadLine());

                    LongitudeAngle checkLongitude = new LongitudeAngle(longitudeDegree, longitudeMinute, longitudeDirection);
                    string longitudeValue = checkLongitude.changeLongitudeAngleValue();

                    string finalDirection = latitudeValue + " " + longitudeValue;
                    shipsInfo.shipLocation = finalDirection;
                    shipsData.Add(shipsInfo);
                    Console.Clear();
                    option = menu();
                }
                else if (option == 'b')
                {
                    string shipNum;
                    Console.Write("Enter Ship Serial Number to find its position: ");
                    shipNum = Console.ReadLine();
                    int idx = 0;
                    for (int x = 0; x<shipsData.Count; x++)
                    {
                        if (shipNum == shipsData[x].shipNumber )
                        {
                            idx = x;
                            break;
                        }
                    }
                    Console.Write("Ship is at " + shipsData[idx].shipLocation);
                }
            }
            while (option == 'e');

            Console.ReadLine();
        }
        static char menu()
        {
            char choice;
            Console.WriteLine("a. Add Ship");
            Console.WriteLine("b. View Ship Position");
            Console.WriteLine("c. View Ship Serial Number");
            Console.WriteLine("d. Change Ship Position");
            Console.WriteLine("e. Exit");
            Console.Write("Enter Your Choice...");
            choice = char.Parse(Console.ReadLine());
            return choice;
        }
    }
}
