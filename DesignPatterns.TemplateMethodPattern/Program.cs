using System;

namespace DesignPatterns.TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Template Method Patterns!");

            DisplayFormat displayFormat1 = new StringDisplay();
            DisplayFormat displayFormat2 = new NumberDisplay();
            displayFormat1.Show();
            displayFormat2.Show();

       
            Console.Read();
        }
    }
}
