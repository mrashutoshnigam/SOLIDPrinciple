using System;

namespace DesignPatterns.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract factory!");
            int i = 1;
            
            IControlFactory controlFactory = null;
            while(i!=0)
            {
                Console.WriteLine("Ente a number other 1,2,3,0");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        controlFactory = new MacFactory();
                        break;
                    case 2:
                        controlFactory = new LinuxFactory();
                        break;
                    case 3:
                        controlFactory = new WindowsFactory();
                        break;
                    default:
                        break;
                }

                ILabel label1 = controlFactory.CreateLabel();
                IButton button1 = controlFactory.CreateButton();
                IDialog dialog1 = controlFactory.CreateDialog();

                Console.WriteLine(label1.ToString());
                Console.WriteLine(button1.ToString());
                Console.WriteLine(dialog1.ToString());
            }
            

            Console.ReadLine();
        }
    }
}
