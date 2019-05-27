using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.InterfaceSegregation
{
    interface IBorrowableDVD : IDVD, IBorrowable
    {
    }
}
