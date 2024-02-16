using System;

namespace DataType
{
    class DataTypeProgram
    {
        static void Main()
        {
            Console.Write("Enter the pieces of apple: ");
            int piecesOfApple = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter total price of " + piecesOfApple + " apple(s): ");
            double priceOfApple = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine"The total price of " + piecesOfApple + "pieces(s) is " + priceOfApple);

            Console.WriteLine("The value of original price is " + priceOfApple);

            Console.WriteLine("The value of converted price is " + (int)priceOfApple);

            Console.WriteLine("Press any key to exit.... ");
            Console.ReadKey();
        }
    }
}

 