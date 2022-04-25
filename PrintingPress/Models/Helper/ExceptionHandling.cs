using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingPress.Models.Helper
{
    class ExceptionHandling : Exception
    {
        public ExceptionHandling(string message, Exception innnerException)
            : base(message, innnerException)
        {

        }

    }
}
