using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region assignment

            #region Q1

            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());


            //if (number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion

            #region Q2

            //    Console.Write("Enter a number: ");
            //    int number = Convert.ToInt32(Console.ReadLine());


            //    if (number > 0)
            //    {
            //        Console.WriteLine("positive");
            //    }
            //    else
            //    {
            //        Console.WriteLine("negative");
            //    }
            //}


            #endregion

            #region Q3

            //Console.Write("Enter first number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter secend number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter third number: ");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //int max = Math.Max(num1, Math.Max(num2, num3));
            //int min = Math.Min(num1, Math.Min(num2, num3));

            //Console.WriteLine("max element = " + max);
            //Console.WriteLine("max element = " + min);



            #endregion

            #region Q4
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("odd");
            //}
            //else
            //{
            //    Console.WriteLine("even");
            #endregion

            #region Q5

            //Console.Write("Enter a Char : ");
            //Char input = Convert.ToChar(Console.ReadLine());

            //switch (input)
            //{

            //    case 'a':
            //    case 'e':
            //    case 'i':
            //    case 'o':
            //    case 'u':

            //        Console.Write("vowel");
            //        break;

            //    default:

            //        Console.Write("consonant");
            //        break;
            //}
            #endregion

            #region Q7

            //Console.Write("Enter Number : ");
            //int numb = int.Parse(Console.ReadLine());

            //Console.Write("Result : ");
            //int i = 1;
            //while (i <= 12)
            //{
            //    Console.Write($"{numb * i} ");
            //    i = i + 1;
            //}
            //Console.WriteLine();


            #endregion

            #region @9

            //Console.WriteLine("Enter number: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Power: ");
            //int power = int.Parse(Console.ReadLine());


            //int result = (int)Math.Pow(number, power);

            //Console.WriteLine($"Result: {result}");
            #endregion

            #region Q10
            //Console.WriteLine("Enter mark subject 1 : ");
            //int sub1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter mark subject 2 ");
            //int sub2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter mark subject 3 : ");
            //int sub3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter mark subject 4 ");
            //int sub4 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter mark subject 5 ");
            //int sub5 = int.Parse(Console.ReadLine());

            //int sum = sub1 + sub2 + sub3 + sub4 + sub5;

            //Console.WriteLine(sum);

            //int avarge = sum / 5;
            //    Console.WriteLine(avarge);


            #endregion

            #region Q11


            //Console.Write("Enter month number: ");
            //int month = Convert.ToInt32(Console.ReadLine());

            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:

            //        Console.WriteLine("Number of days: 31");
            //        break;

            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("Number of days: 30");
            //        break;

            //    case 2:
            //        Console.WriteLine("Number of days: 28");
            //        break;
            // }
            #endregion

            #region Q17
            //Console.WriteLine("first point (x1, y1): ");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //double y1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("second point (x2, y2): ");
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //double y2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("third point (x3, y3): ");
            //double x3 = Convert.ToDouble(Console.ReadLine());
            //double y3 = Convert.ToDouble(Console.ReadLine());

            //if ((y2 - y1) * (x3 - x1) == (y3 - y1) * (x2 - x1))
            //{
            //    Console.WriteLine("The points lie on a single straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a single straight line.");
            //}
            #endregion

            #region Q18
            //Console.WriteLine("Enter time: ");
            //int time =int.Parse(Console.ReadLine());

            //    if (time >= 2 && time <= 3)
            //    Console.WriteLine("Highly efficient");

            //    else if (time > 3 && time <= 4)
            //    Console.WriteLine("Increase their speed");

            //    else if (time > 4 && time <= 5)
            //    Console.WriteLine("Provide training to enhance their speed");

            //    else if (time > 5)
            //    Console.WriteLine("They are required to leave the company");

            #endregion

            #region Q21
            //int x = 20;
            //int y =100;



            //Console.WriteLine(x);
            //Console.WriteLine(x.GetHashCode());
            //Console.WriteLine(y);
            //Console.WriteLine(y.GetHashCode());
            //Console.WriteLine();
            //y = x;
            //Console.WriteLine(x);
            //Console.WriteLine(x.GetHashCode());
            //Console.WriteLine(y);
            //Console.WriteLine(y.GetHashCode());

            //both of X and Y = 20

            #endregion

            #region Q22

            //Point p1 = new Point();
            //    p1.x = 1;
            //    p1.y = 2;

            //Point p2 = new Point(); 
            //p2.x = 3; 
            //p2.y = 4;


            //Console.WriteLine($"{p1.x} , {p1.y}");
            //Console.WriteLine($"{p2.x} , {p2.y}");

            //p2.x=p1.x;
            //Console.WriteLine($"{p1.x} , {p1.y}");
            //Console.WriteLine($"{p2.x} , {p2.y}");


            ////Put p2.x=1


            #endregion

            #region Q23


            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //Console.WriteLine(d);

            ////d=1 answer b

            #endregion

            #region Q24


            //Console.WriteLine(13 / 2 + " " + 13 % 2);


            ////answer d) 6 1
            #endregion

            #region Q25

            //int num = 1, z = 5;

            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);


            ////answer d 7 7
            #endregion

            #endregion

        

            #endregion

        }
    }
}
