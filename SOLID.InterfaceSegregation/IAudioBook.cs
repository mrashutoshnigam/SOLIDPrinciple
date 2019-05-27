using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.InterfaceSegregation
{
    interface IAudioBook :ILibraryItem
    {
        int RuntimeInMinutes { get; set; }
    }
}
