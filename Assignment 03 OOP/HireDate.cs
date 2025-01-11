using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment_03_OOP
{
    internal struct HireDate
    {
        #region Attributes
        public int day;
        public int month;
        public int year;
        #endregion

        

        #region Methods
        public override string ToString()
        {
            return $"{day:D2}/{month:D2}/{year}";
        }
        #endregion

    }
}
