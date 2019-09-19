using System;

namespace DesignPatterns.ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proxy Pattern!");
            string content = @"We have reviewed your appeal and determined that your account has violated our Terms of Use. Your sandbox access will not be reinstated. However, you can continue to access Microsoft Learn's training content. Many module exercises can be completed using your own Azure subscription, but charges may apply, and you may need to modify the instructions to work with your subscription.
You decide to create an Azure Database for PostgreSQL server to store routes captured from runners' fitness devices. Based on historic captured data volumes, you know your server storage requirements should be set at 20 GB. To support your processing requirements, you need compute Gen 5 support with 1 vCore. You also know that you require a retention period of 15 days for data backups.";
            IBookParser bookParser = new BookParserProxy(content);
            Console.WriteLine(bookParser.NoOfPages);
            Console.WriteLine(bookParser.NoOfWords);
            Console.ReadLine();
        }
    }
}
