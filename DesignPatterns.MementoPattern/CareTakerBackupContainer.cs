using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MementoPattern
{
    class CareTakerBackupContainer
    {
        List<BackupState> backups;
        public CareTakerBackupContainer()
        {
            backups = new List<BackupState>();
        }
        public void Add(BackupState backup)
        {
            this.backups.Add(backup);
        }
        public BackupState GetState(int index)
        {
            return this.backups[index - 1];
        }
        public void Print()
        {
            Console.WriteLine("Backup List");
            int index = 1;
            foreach (var item in this.backups)
            {
                Console.WriteLine($"{index}: {item.BackupDateTime}");
                index++;
            }
        }
    }
}
