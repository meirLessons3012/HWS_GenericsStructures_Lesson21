using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_GenericsStructures_Lesson21
{
    internal class MyLibrary : IDictManagment<string, Book>
    {
        private Dictionary<string, Book> books;

        public int Count { get => books.Count; }

        public MyLibrary()
        {
            books = new Dictionary<string, Book>();
        }

        public bool HaveThisValue(string key)
        {
            return books.ContainsKey(key);
        }

        public bool Add(Book value)
        {
            if (value == null)
                return false;
            return books.TryAdd(value.Title, value);
        }

        public void Delete(string key)
        {
            books.Remove(key);
        }

        public void Update(string key, Book value)
        {
            books[key] = value;
        }

        public Book Get(string key)
        {
            return books[key];
        }

        public List<Book> GetAll()
        {
            return books.Values.ToList();
        }

        public void Clear()
        {
            books = new Dictionary<string, Book>();
        }

        public List<string> GetAllAuthors()
        {
            List<string> authors = new List<string>();
            foreach (Book book in books.Values)
            {
                authors.Add(book.Author);
            }

            return authors;
        }

        public List<Book> GetBooksSortedByAuthor()
        {

            return books.Values.OrderBy(book => book.Author).ToList();
        }

        public override string ToString()
        {
            string res = "";
            foreach (KeyValuePair<string,Book> keyValuePair in books)
            {
                res += keyValuePair.Key + " : " + keyValuePair.Value + "\n" ;
            }
            return res;
        }
    }
}
