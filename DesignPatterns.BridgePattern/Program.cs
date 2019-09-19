using System;

namespace DesignPatterns.BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bridge Pattern!");

            IContent stringC = new StringContent();
            IContent numC = new NumbersContent();

            View redStr = new RedColorView(stringC);
            View blueStr = new BlueColorView(stringC);
            View greenStr = new GreenColorView(stringC);

            View redNum = new RedColorView(numC);
            View blueNum = new BlueColorView(numC);
            View greenNum = new GreenColorView(numC);

            redStr.Show();
            blueStr.Show();
            greenStr.Show();

            redNum.Show();
            blueNum.Show();
            greenNum.Show();


            Console.ReadLine();
        }
    }
}
