using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MementoPattern
{
    class BackupState
    {
        DateTime DateTime { get; set; }
        public DateTime BackupDateTime { get; set; }
        string OSName { get; set; }
        List<string> InstalledApps { get; set; }
        public BackupState(DateTime systemdatetime,string osname,List<string> apps)
        {
            DateTime = DateTime.Now;
            DateTime = systemdatetime;
            OSName = osname;
            InstalledApps = new List<string>(apps);
        }

        public string GetStateName()
        {
            return this.OSName;
        }
        public DateTime GetDateTime() => this.DateTime;
        public List<string> GetInstalledApps() => this.InstalledApps;
    }
}
