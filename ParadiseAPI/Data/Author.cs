using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;

namespace ParadiseAPI.Data
{
    public partial class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}