using Calculator;
using System;
using System.Diagnostics;
using System.Globalization;
Console.WriteLine("Welcome Calculate Program");
Console.WriteLine("Please Enter For The Process You Want To Do : Collect + , Extraction - , Hitting *, Divide / ");
char process = Convert.ToChar(Console.ReadLine());

switch (process)
{

    case '+':

        MathOperation mopSum = new MathOperation();
        Console.WriteLine("Please Enter Number");
        mopSum.NumberX = double.Parse(Console.ReadLine());
        Console.WriteLine("Please Enter Number");
        mopSum.NumberY = double.Parse(Console.ReadLine());
        Console.WriteLine(MathOperation.sumDelegate(mopSum.NumberX, mopSum.NumberY));
        Console.ReadLine();
        break;
    case '-':
        MathOperation mopDif = new MathOperation();
        Console.WriteLine("Please Enter Number");
        mopDif.NumberX = double.Parse(Console.ReadLine());
        Console.WriteLine("Please Enter Number");
        mopDif.NumberY = double.Parse(Console.ReadLine());
        Console.WriteLine(MathOperation.difDelegate(mopDif.NumberX, mopDif.NumberY));
        Console.ReadLine();
        break;
    case '*':
        MathOperation mopMul = new MathOperation();
        Console.WriteLine("Please Enter Number");
        mopMul.NumberX = double.Parse(Console.ReadLine());
        Console.WriteLine("Please Enter Number");
        mopMul.NumberY = double.Parse(Console.ReadLine());
        Console.WriteLine(MathOperation.mulDelegate(mopMul.NumberX, mopMul.NumberY));
        Console.ReadLine();
        break;
    case '/':
        MathOperation mopDiv = new MathOperation();
        Console.WriteLine("Please Enter Number");
        mopDiv.NumberX = double.Parse(Console.ReadLine());
        Console.WriteLine("Please Enter Number");
        mopDiv.NumberY = double.Parse(Console.ReadLine());
        Console.WriteLine(MathOperation.divDelegate(mopDiv.NumberX, mopDiv.NumberY));
        Console.ReadLine();
        break;
    default:
        Console.WriteLine("Unhandled Process ");
        break;
}
//bool alwaysRun = true;
//while (alwaysRun)
//{
//    Console.WriteLine("Welcome Calculate Program");
//    int numberx = 0; int numbery = 0;
//    Console.WriteLine("Please Enter For The Process You Want To Do : Collect + , Extraction - , Hitting *, Divide / ");
//    char process = Convert.ToChar(Console.ReadLine());
//    switch (process)
//    {
//        case '+':
//            Console.WriteLine("Please Enter Number");
//            numberx = int.Parse(Console.ReadLine());
//            Console.WriteLine("Please Enter Number");
//            numbery = int.Parse(Console.ReadLine());
//            Console.WriteLine("Result=" + " " + (numberx + numbery));
//            Console.ReadLine();
//            break;
//        case '-':
//            Console.WriteLine("Please Enter Number");
//            numberx = int.Parse(Console.ReadLine());
//            Console.WriteLine("Please Enter Number");
//            numbery = int.Parse(Console.ReadLine());
//            Console.WriteLine("Result=" + " " + (numberx - numbery));
//            Console.ReadLine();
//            break;
//        case '*':
//            Console.WriteLine("Please Enter Number");
//            numberx = int.Parse(Console.ReadLine());
//            Console.WriteLine("Please Enter Number");
//            numbery = int.Parse(Console.ReadLine());
//            Console.WriteLine("Result=" + " " + (numberx * numbery));
//            Console.ReadLine();
//            break;
//        case '/':
//            Console.WriteLine("Please Enter Number");
//            numberx = int.Parse(Console.ReadLine());
//            Console.WriteLine("Please Enter Number");
//            numbery = int.Parse(Console.ReadLine());
//            if (numbery == 0)
//            {
//                Console.Clear();
//                Console.WriteLine("Divide by zero exception");
//                Console.WriteLine("Please Enter Number");
//                numbery = int.Parse(Console.ReadLine());

//            }
//            Console.WriteLine("Result=" + " " + (numberx / numbery));
//            Console.ReadLine();
//            break;
//        default:
//            Console.WriteLine("Unhandled Process ");

//            break;

//    }

//}



