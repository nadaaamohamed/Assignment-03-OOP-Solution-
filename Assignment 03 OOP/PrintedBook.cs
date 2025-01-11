using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOP
{
    internal class PrintedBook : Library
    {
        public int PageCount { get; set; }
        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}, PageCount: {PageCount}";
        }
    }
}
