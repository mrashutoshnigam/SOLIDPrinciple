using System;

namespace DesignPatterns.MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Memento Design Patter!");
            CareTakerBackupContainer careTaker = new CareTakerBackupContainer();
            WindowsComputerOriginator windows1 = new WindowsComputerOriginator(DateTime.Now.AddDays(5));
            careTaker.Add(windows1.Backup());
            windows1.InstallApplication("VSCode");
            careTaker.Add(windows1.Backup());
            windows1.InstallApplication("Visual Studio");
            windows1.InstallApplication("MS Word");
            careTaker.Add(windows1.Backup());
            windows1.InstallApplication("MS Power Point");
            windows1.InstallApplication("Node JS");
            careTaker.Add(windows1.Backup());
            windows1.Print();
            careTaker.Print();

            windows1.RemoveApplication("MS Word");
            windows1.Print();
            careTaker.Add(windows1.Backup());
            careTaker.Print();
            int opt = 1;
            while (opt != 0)
            {
                Console.WriteLine("Please Choose an Option:");
                opt = int.Parse(Console.ReadLine());
                windows1.Restore(careTaker.GetState(opt));
                windows1.Print();
            }

            Console.ReadLine();
        }
    }
}
