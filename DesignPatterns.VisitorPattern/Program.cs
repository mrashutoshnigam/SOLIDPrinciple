using System;

namespace DesignPatterns.VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Visitor Pattern!");
            LinuxVisitor linuxVisitor = new LinuxVisitor();
            MacOSVisitor macOSVisitor = new MacOSVisitor();
            DLinkRouter dLinkRouter = new DLinkRouter();
            TPLinkRouter tPLinkRouter = new TPLinkRouter();

            dLinkRouter.Accept(linuxVisitor);
            // dLinkRouter.SendData();
            tPLinkRouter.Accept(linuxVisitor);
            Console.Read();
        }
    }
}
