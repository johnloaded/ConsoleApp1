using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter 1st number : ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter 2nd number : ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter 3rd number : ");
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("1st number {0} plus 2nd number {1} equals {2} ", num1, num2, num1+num2);
            //Console.WriteLine($"1st number {num1} plus 2nd number {num2} equals {num1 + num2} ");
            //Console.WriteLine("Result of operation between {0}," + " {1} and {2}, (a+b).c is {3} and a.b + a.c is {4}", num1, num2, num3, ((num1 + num2) * num3), (num1 + num2 * num1 + num3) );
            //Console.WriteLine("1st number displayed 4 times {0} {0} {0} {0}", num1);
            //Console.WriteLine($"2nd number displayed 4 times {num2} {num2} {num2} {num2}");

            //Console.Write("Enter number : ");
            //int numA = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Height : ");
            //int height = Convert.ToInt32(Console.ReadLine());

            //int width = height;

            //for (int i = 0; i < height; i++)
            //{
            //    for (int j = 0; j < width; j++)
            //    {
            //        Console.Write($"{numA}");
            //    }

            //    width--;
            //    Console.WriteLine();
            //}

            // Interpolation
            //int a, b;
            //char operation;

            //Console.Write("Enter first number: ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter operation: ");
            //operation = Convert.ToChar(Console.ReadLine());
            //Console.Write("Enter second number: ");
            //b = Convert.ToInt32(Console.ReadLine());

            //switch (operation)
            //{
            //    case '+':
            //        Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            //        break;
            //    case '-':
            //        Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            //        break;
            //    case 'x':
            //    case '*':
            //        Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            //        break;
            //    case '/':
            //        Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            //        break;
            //    default:
            //        Console.WriteLine("Wrong Character");
            //        break;

            //}

            // Diagonal
            //double diagonal = Math.Sqrt(a * a + b * b);
            //Console.WriteLine("Diagonal: {0}", diagonal);

            //for (char i = 'B'; i <= 'N'; i++)
            //{
            //    Console.Write("{0} ", i);
            //}
            //Console.WriteLine();

            // Binary
            //for (int i = 0; i <= 255; i++)
            //{
            //    if (i < 16)  // 0 in the beginning of the first row
            //        Console.Write("0");

            //    Console.Write("{0} ",
            //        Convert.ToString(i, 16));  // Hexadecimal

            //    if (i % 16 == 15)    // Jump to next line after 16 data
            //        Console.WriteLine();
            //}

            // Vehicles
            ////Car myCar = new Car();
            ////myCar.Drive();

            ////Sportscar mySportsCar = new Sportscar();
            ////mySportsCar.Drive();

            //Van myVan = new Van();
            //myVan.Drive();

            //Minivan myMiniVan = new Minivan();
            //myMiniVan.Drive();

            ////ExcursionVan myExcursionVan = new ExcursionVan();
            ////myExcursionVan.Drive();

            // File Writer
            //string sentence = " ";
            //StreamWriter myfile;
            //myfile = File.CreateText("test.txt");
            //do
            //{
            //    Console.Write("Enter a sentence: ");
            //    sentence = Console.ReadLine();
            //    if (sentence.Length != 0)
            //    {
            //        myfile.WriteLine(sentence);
            //    }
            //}
            //while (sentence.Length != 0);
            //myfile.Close();

            // Logger
            ////Logger Logger1 = new Logger();
            ////Logger1.Write("text.txt", "Hola");
            //Logger.Write("text.txt", "Hola");

            // Table
            //Table[] tableList = new Table[10];
            //Random random = new Random();

            //for (int i = 0; i < tableList.Length - 1; i++)
            //{
            //    tableList[i] = new Table(
            //        random.Next(50, 201),
            //        random.Next(50, 201));
            //}
            //tableList[0].Save("1.dat");
            //tableList[9] = new Table(0, 0);
            //tableList[9].Load("1.dat");

            //for (int i = 0; i < tableList.Length; i++)
            //{
            //    tableList[i].ShowData();
            //}

            //Car car1 = new Car
            //{
            //    Make = "Ford",
            //    Year = "2012"
            //};

            var feature = new Feature
            {
                Type = "Feature",
                Geometry = new Geometry()
                {
                    Type = "Point",
                    //coordinates = new List<List<List<double>>>[] { 52.11, 1.3 }
                    //coordinatesSimple = new[] { getCoords?.Longitude ?? 0, getCoords?.Latitude ?? 0 }
                },
                XVetro = new XVetro { PlanId = 51, LayerId = 21 },
                Properties = new Properties
                {
                    Id = 123,
                    Name = "Unknown",
                    GlideReference = "missing",
                    Status = "missing",
                    Address = "missing"
                }
            };

            List<double> coords = new List<double>();

            feature.Geometry.Coordinates.Add(new List<List<List<double>>>[] { });

            Console.ReadLine();
        }
    }
}
