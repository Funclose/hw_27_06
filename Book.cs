using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_27_06
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Gengre { get; set; }
        public int Year { get; set; }

        public Book(string title, string author, string gengre, int year)
        {
            Title = title;
            Author = author;
            Gengre = gengre;
            Year = year;
        }


        public override string ToString() => $"title: {Title}, Author: {Author}, Gengre: {Gengre}, Year: {Year} ";



    }
}
