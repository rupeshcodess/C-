//write a c# program to read the price of an item in double for exanple 75.95 and print the output in paise for example 7595 paise using command line input




    class Program
    {
        static void Main(string[] args)
        {
            double price = System.Convert.ToDouble(args[0]);
	    int paise = (int)(price * 100);
	    System.Console.WriteLine(paise);
        }
    }






write a c# program to read a real number from keyboard and print the following in one line
smallest integer
largest integer
not less than integer
not greater than integer