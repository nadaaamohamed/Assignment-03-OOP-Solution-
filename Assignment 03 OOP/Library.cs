using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOP
{
    internal class Library
    {
        #region Properties
        public string ?Title { get; set; }
        public string ?Author { get; set; }
        public string? ISBN { get; set; }
        
            #endregion
            #region Methods
           public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}";
        }

        #endregion



    }
}
