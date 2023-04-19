bool alwaysRun = true;
while (alwaysRun)
{
    Console.WriteLine("Welcome Calculate Program");
    int numberx = 0; int numbery = 0;
    Console.WriteLine("Please Enter For The Process You Want To Do : Collect + , Extraction - , Hitting *, Divide / ");
    char process = Convert.ToChar(Console.ReadLine());
    switch (process)
    {
        case '+':
            Console.WriteLine("Please Enter Number");
            numberx = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Number");
            numbery = int.Parse(Console.ReadLine());
            Console.WriteLine("Result=" + " " + (numberx + numbery));
            Console.ReadLine();
            break;
        case '-':
            Console.WriteLine("Please Enter Number");
            numberx = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Number");
            numbery = int.Parse(Console.ReadLine());
            Console.WriteLine("Result=" + " " + (numberx - numbery));
            Console.ReadLine();
            break;
        case '*':
            Console.WriteLine("Please Enter Number");
            numberx = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Number");
            numbery = int.Parse(Console.ReadLine());
            Console.WriteLine("Result=" + " " + (numberx * numbery));
            Console.ReadLine();
            break;
        case '/':
            Console.WriteLine("Please Enter Number");
            numberx = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Number");
            numbery = int.Parse(Console.ReadLine());
            if (numbery == 0)
            {
                Console.Clear();
                Console.WriteLine("Divide by zero exception");
                Console.WriteLine("Please Enter Number");
                numbery = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Result=" + " " + (numberx / numbery));
            Console.ReadLine();
            break;
        default:
            Console.WriteLine("Unhandled Process ");

            break;

    }

}



