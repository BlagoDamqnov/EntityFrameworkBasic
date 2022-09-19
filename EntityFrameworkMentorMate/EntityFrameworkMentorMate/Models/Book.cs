using System;
using System.Collections.Generic;

#nullable disable

namespace EntityFrameworkMentorMate.Data.Models
{
    public partial class Book
    {
        public Book()
        {
            People = new HashSet<Person>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}
