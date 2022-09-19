namespace EntityFrameworkMentorMate
{
    using EntityFrameworkMentorMate.Data;
    using EntityFrameworkMentorMate.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class StartUp
    {
        static void Main(string[] args)
        {
            LibraryContext lc = new LibraryContext();
           

            string infoPeople = GetFullInfoAboutPerson(lc);
            string infoBook = GetFullInfoAboutBook(lc);
            //AddPerson(lc,"Petur","7879456123",3);
            Console.WriteLine(infoPeople);
            Console.WriteLine("-------------------------------");
            //AddBook(lc, 4, "Taxes are fake", "M.Yordanov", 50);
            Console.WriteLine(infoBook);
        }

        public static string GetFullInfoAboutPerson(LibraryContext libraryContext)
        {
            StringBuilder sb = new StringBuilder();

            Person[] personInfo = libraryContext.People.OrderBy(i => i.Egn).ToArray();

            foreach (var item in personInfo)
            {
                sb
                    .AppendLine($"{item.Egn} => {item.Name} => {item.GetBookId}");
            }

            return sb.ToString().Trim();
        }

        public static string GetFullInfoAboutBook(LibraryContext libraryContext)
        {
            StringBuilder sb = new StringBuilder();

            Book[] bookInfo = libraryContext.Books.OrderBy(i => i.Price).ToArray();

            foreach (var item in bookInfo)
            {
                sb
                    .AppendLine($"{item.Id} => {item.Name} => {item.Author} => {item.Price}");
            }

            return sb.ToString().Trim();
        }

        public static void AddPerson(LibraryContext library,string name,string egn,int getBookId)
        {
            Person p = new Person()
            {
                Egn = egn,
                Name = name,
                GetBookId = getBookId
            };

            library.People.Add(p);
            library.SaveChanges();
        }

        public static void AddBook(LibraryContext library, int id, string name, string  author,decimal price)
        {
            Book book = new Book()
            {
                Id = id,
                Name = name,
                Author = author,
                Price = price
            };

            library.Books.Add(book);
            library.SaveChanges();
        }

    }
}
