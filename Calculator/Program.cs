bool alwaysRun = true;
while (alwaysRun)
{
    Console.WriteLine("Welcome Calculate Program");
    double numberx = 0; double numbery = 0;
    Console.WriteLine("Please Enter For The Process You Want To Do : \nCollect + , Extraction - , Hitting *, Divide /, Square S ,Log10 L");
    char process = Convert.ToChar(Console.ReadLine().ToUpper());
    switch (process)
    {
        case '+':
            Console.Clear();
            Console.WriteLine("Please Enter Number");
            numberx = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Number");
            numbery = double.Parse(Console.ReadLine());
            Console.WriteLine("Result=" + " " + (numberx + numbery));
            Console.ReadLine();
            break;
        case '-':
            Console.Clear();
            Console.WriteLine("Please Enter Number");
            numberx = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Number");
            numbery = double.Parse(Console.ReadLine());
            Console.WriteLine("Result=" + " " + (numberx - numbery));
            Console.ReadLine();
            break;
        case '*':
            Console.Clear();
            Console.WriteLine("Please Enter Number");
            numberx = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Number");
            numbery = double.Parse(Console.ReadLine());
            Console.WriteLine("Result=" + " " + (numberx * numbery));
            Console.ReadLine();
            break;
        case '/':
            Console.Clear();
            Console.WriteLine("Please Enter Number");
            numberx = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Number");
            numbery = double.Parse(Console.ReadLine());
            if (numbery == 0)
            {
                Console.Clear();
                Console.WriteLine("Divide by zero exception");
                Console.WriteLine("Please Enter Number");
                numbery = double.Parse(Console.ReadLine());

            }
            Console.WriteLine("Result=" + " " + (numberx / numbery));
            Console.ReadLine();
            break;
        case 'S':
            Console.Clear();
            Console.WriteLine("Please Enter Number");
            numberx = double.Parse(Console.ReadLine());
            Console.WriteLine("Result=" + " " + Math.Sqrt(numberx));
            Console.ReadLine();
            break;
        case 'L':
            Console.Clear();
            Console.WriteLine("Please Enter Number");
            numberx = double.Parse(Console.ReadLine());
            Console.WriteLine("Result=" + " " + Math.Log10(numberx));
            Console.ReadLine();
            break;
        default:
            Console.Clear();
            Console.WriteLine("Unhandled Process ");

            break;

    }

}



