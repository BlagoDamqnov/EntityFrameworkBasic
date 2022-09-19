using System;
using System.Collections.Generic;

#nullable disable

namespace EntityFrameworkMentorMate.Data.Models
{
    public partial class Person
    {
        public string Egn { get; set; }
        public string Name { get; set; }
        public int? GetBookId { get; set; }

        public virtual Book GetBook { get; set; }
    }
}
