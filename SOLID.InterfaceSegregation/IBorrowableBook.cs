using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.InterfaceSegregation
{
    interface IBorrowableBook : IBorrowable, IBook
    {
    }
}
