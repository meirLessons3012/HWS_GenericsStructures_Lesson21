using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HWS_GenericsStructures_Lesson21
{
    internal class Book
    {
        public string  Title { get; set; }
        public int Pages { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }

        public Book(string title, int pages, string author, string category)
        {
            Title = title;
            Pages = pages;
            Author = author;
            Category = category;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
