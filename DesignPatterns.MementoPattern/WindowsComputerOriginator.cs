using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MementoPattern
{
    class WindowsComputerOriginator
    {
        DateTime _dateTime { get; set; }
        string _OSName { get; set; }
        List<string> _ApplicationInstalled { get; set; }
        public WindowsComputerOriginator()
        {
            _ApplicationInstalled = new List<string>();
        }
        public WindowsComputerOriginator(DateTime date, string osName = "Windows10", List<string> apps = null) : this()
        {
            _dateTime = date;
            _OSName = osName;
            if (apps != null)
                _ApplicationInstalled = apps;
        }
        public void InstallApplication(string name)
        {
            this._ApplicationInstalled.Add(name);
        }
        public void RemoveApplication(string name)
        {
            if (this._ApplicationInstalled.Contains(name))
                this._ApplicationInstalled.Remove(name);
        }

        public BackupState Backup()
        {
            return new BackupState(this._dateTime, this._OSName, this._ApplicationInstalled);
        }

        public void Restore(BackupState backup)
        {
            this._OSName = backup.GetStateName();
            this._ApplicationInstalled = backup.GetInstalledApps();
            this._dateTime = backup.GetDateTime();
        }

        public void Print()
        {
            Console.WriteLine($"Operation System: {this._OSName}");
            Console.WriteLine($"DateTime: {this._dateTime.ToString()}");
            Console.WriteLine("Installed Applications:");
            foreach (var item in this._ApplicationInstalled)
            {
                Console.WriteLine(item);
            }
        }

    }
}
