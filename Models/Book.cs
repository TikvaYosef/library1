using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace library1.Models
{
    public class Book
    {
        public string name;
        public string author;
        public int year;
        public int numOfPages;

        public Book(string name, string author, int year, int numOfPages)
        {
            this.name = name;
            this.author = author;
            this.year = year;
            this.numOfPages = numOfPages;

        }
    }
}