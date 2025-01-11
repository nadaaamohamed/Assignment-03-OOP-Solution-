using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOP
{
    internal class EBook : Library

    {
        public int FileSize { get; set; }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}, FileSize: {FileSize}";
        }
    }
}
