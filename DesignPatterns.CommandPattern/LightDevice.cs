namespace DesignPatterns.CommandPattern
{
    internal class LightDevice: IOnOffDevices
    {
        public void On()
        {
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine("Light on: O");            
        }
        public void Off()
        {
            System.Console.ForegroundColor = System.ConsoleColor.Blue;
            System.Console.WriteLine("Light Off: O");
        }
    }
}