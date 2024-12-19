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

            #region Demo
            #region Value Type Casting

            //            #region Implicit Casting - Safe Casting
            //            //int X = 4; // 4 Bytes
            //            //long Y =/*(long)*/X;
            #endregion

            #region Explict Casting - UnSafe Casting
            //            //long X = 101010101010; // 8 Bytes
            //            //int Y = (int)X;
            //            //Console.WriteLine(Y);

            //            //int X = 88;
            //            //double Y = /*(double)*/X;

            //            //double X = 88.8;
            //            //int Y = (int)X;
            #endregion

            #region Parse [Convert from String to any Datatype]
            //            //int Number = int. Parse(Console.ReadLine());

            //            Console.WriteLine("Enter Data User");

            //            Console.Write("Enter Name : ");
            //            string Name = Console.ReadLine();

            //            Console.Write("Enter Age : ");
            //            int Age = int.Parse(Console.ReadLine());

            //            Console.Write("Enter Salary : ");
            //            double Salary = double.Parse(Console.ReadLine());
            #endregion

            #region Convert [Convert from Any Datatype to Any DateType]
            //            Console.WriteLine("Enter Data User");

            //            Console.Write("Enter Name : ");
            //            string Name = Console.ReadLine();

            //            Console.Write("Enter Age : ");
            //            int Age = Convert.ToInt32(Console.ReadLine());

            //            Console.Write("Enter Salary : ");
            //            double Salary = Convert.ToDouble(Console.ReadLine());

            //            Console.Clear();

            //            Console.WriteLine("Name : " + Name + " Age : " + Age + " Salary : " +
            #endregion

            #region Oprators


            #region Unary Operators [++ , -- ]
            //            //int X = 5;
            //            //X++;
            //            //++X;


            #endregion
            #region Binary Operator
            //            //int Sum, Mul, Sub, Div, Mod;

            //            //int A = 8;
            //            //int B = 5;


            #endregion
            #region Assignment Operator
            //            //int X = 10;

            //            //X += 10;
            //            //X -= 10;
            //            //X *= 10;
            //            //X /= 10;
            //            //X %= 10;
            #endregion
            #region Relational Operators
            //            //int A = 5;
            //            //int B = 10;

            #endregion
            #region Logical Operators [Long Circut]
            //            //Console. WriteLine( !true);

            //            //Console.WriteLine(true && false);
            //            // True && True => True
            //            // True && False => False
            //            // False && True => False
            //            // False && False => False

            //            //Console.WriteLine(true || false);

            //            // True | | True => True
            //            // True | | False => True
            //            // False | | True => True
            //            // False | | False => False
            #endregion
            #region Bitwise Operators [Long Circut]
            //            //Console.WriteLine(true & false);
            //            // True & True => True
            //            // True & False => False
            //            // False & True => False
            //            // False & False => False

            //            //Console.WriteLine(true | false);
            //            // True | True => True
            //            // True | False => True
            //            // False | True => True
            //            // False | False => False
            #endregion
            #region Ternary Operator [Conditional Operator]

            //            // 4
            //            //int X = 4;
            //            //string Message = X > 4 ? "X Greater Than 4" : "X Less than Or Equal 4"
            #endregion

            #endregion

            #region Operator Periorety

            //            // 1. Unary Operator [PreFix]
            //            // 2. ()
            //            // 3. * / % I
            //            // 4. + -

            #endregion

            #region String Formating
            //            // Equation = X + Y = Result
            //            // Equation = 10 + 5 = 15

            //            //int x = 5;
            //            //int Y = 10;
            //            //int Result = X + Y;

            //            //Console.WriteLine("Equation : " + X + " + " + Y + " = " + Result);
            //            // String => Immutable Datatype
            //            //string Name = "Ahmed";
            //            //Name = "Ali";

            #region 1. Composite Format
            //            string Message = string.Format("Equation = {0} + {1} = {2}", X, Y, Result)
            //            Console.WriteLine(Message);
            #endregion

            #region 2. String Manipolition
            //            // string Interpolation => $

            //            Console.WriteLine($"Equation = {X} + {Y} = {Result}");
            #endregion



            #endregion

            #region IF Else - Switch Case

            #region IF
            //            Console.WriteLine("Enter Month Number");
            //            int MonthNumber = int.Parse(Console.ReadLine());
            //            // 1 => Month is Jan
            //            // 2 => Month is Feb
            //            // 3 => Month is Mar

            //            //if(MonthNumber == 1)
            //            //Console.WriteLine("Month is Jan");
            //            //else if(MonthNumber == 2)
            //            // Console.WriteLine("Month is Feb");
            //            //else if(MonthNumber == 3)
            //            // Console.WriteLine("Month is Mar");
            //            //else
            //            //  Console.WriteLine("InValid Input");


            #endregion

            #region switch

            //            switch (MonthNumber)
            //            {
            //                case 1:
            //                    Console.WriteLine("Month is Jan");
            //                    break;

            //                case 2:
            //                    Console.WriteLine("Month is Feb");
            //                    break;

            //                case 3:
            //                    Console.WriteLine("Month is Mar");
            //                    break;
            //                default:
            //                    Console.WriteLine("InValid Input");
            //                    break;
            //            }


            //            //Console.WriteLine("Enter Name");
            //            //string Name = Console.ReadLine();

            //            //if (Name == "marwan")

            //            //Console.WriteLine("Hello marwan");

            //            //else if (Name == "ahmed")

            //            //Console.WriteLine("Hello ahmed");

            //            //else if (Name == "Ahmed")

            //            //Console.WriteLine("Hello Aliaa");



            //            //switch (Name)
            //            //{

            //            //case "Mostafa":
            //            //Console.WriteLine("Hello Mostafa");
            //            //break;
            //            //case "marwan":
            //            //Console.WriteLine("Hello marwan");
            //            //break;
            //            //case "Ahmed":
            //            //Console.WriteLine("Hello Ahmed");
            //            //break;


}










            #endregion

            #region GoTo

            //            Console.WriteLine("Enter Option");
            //            // 3000 => "Option 01" ,"Option 02" ."Option 03"
            //            // 2000 => "Option D1" ,"Option 02"
            //            // 1000 => "Option 01"

            //            int Option = int.Parse(Console.ReadLine());
            //            Console.WriteLine(Option);

            //            switch (Option)
            //            {

            //                case 3000:
            //                    Console.WriteLine("Option 03");
            //                    Console.WriteLine("Option 02");
            //                    Console.WriteLine("Option 01");
            //                    break;
            //                case 2000:
            //                    Console.WriteLine("Option 02");
            //                    Console.WriteLine("Option 01");
            //                    break;
            //                case 1000:
            //                    Console.WriteLine("Option 01");
            //                    break;
            //            }

            //            int option = int.Parse(Console.ReadLine());
            //            switch (Option)
            //            {
            //                case 3000:
            //                    Console.WriteLine("Option 03");
            //                    goto case 2000;
            //                case 2000:
            //                    Console.WriteLine("Option 02");
            //                    goto case 1000;
            //                case 1000:
            //                    Console.WriteLine("Option 01");
            //                    break;

            //            }


            #endregion

            #region Evaluation Of Switch Case

            //            #region C# 06
            //            switch (Age)
            //            {
            //                case > 22:
            //                    Console.WriteLine("Age Greater Than 22");
            //                    break;
            //                case < 22:
            //                    Console.WriteLine("Age Less Than 22");
            //                    break;
            //                default:
            //                    Console.WriteLine("Age Equal 22");
            //                    break;
            //            }

            #endregion

            #region C# 07
            //            //object obj = new object();
            //            //obj = "Mostafa";
            //            //obj = 10;
            //            //obj = true;

            //            //switch (obj)
            //            //{

            //                //case int Number when Number > 10 && Number < 20:
            //                    //Console.WriteLine($"{Number} is int");
            //                    //break;
            //                //case string Name:
            //                    //Console.WriteLine($"{Name} is String");
            //                    //break;
            //                //case bool Flag:
            //                    //Console.WriteLine($"{Flag} is Bool");
            //                    //break;


            //            //}

            #endregion


            #region C# 08
            //            Console.WriteLine("Enter Option");
            //            int Opation = int.Parse(Console.ReadLine());

            //            string Message = Opation switch
            //            {

            //                1 => "Option 01",
            //                2 => "Option 02",
            //                3 => "Option 03",
            //                _ => "Invalid"
            //            };

            //#region EX02
            //            //Empolyee E01 = new employee();
            //            //E01.Name = "Alaa":
            //            //E01.Id = 10;
            //            //E01.Age = 22;

            //            //string Massege = E01
            //            //{

            //            //{ Id: 10, Name: "Alaa", Age: 22 } => $"{E01.Id} 

            //            //{ Id: 10, Name: "Ali", Age: 22 } => $"{E01.Id} : {E01.Name} : {E01.Age}",

            //            //{ Id: 20, Name: "Mona", Age: 20 } => $"{E01.Id}

            //            //}
            #endregion


            #region C# 09
            //            //Empolyee E01 = new Empolyee();
            //            //E01.Name = "Alaa";
            //            //E01.Id = 10;
            //            //E01.Age = 22;

            //            //string Massege = E01 switch
            //            //{
            //            //{ Age: > 22 and < 25 }

            //            //{ Age: 25 or 23 }
            //            //};
            #endregion

            #endregion

            #endregion

        }
    }
}
