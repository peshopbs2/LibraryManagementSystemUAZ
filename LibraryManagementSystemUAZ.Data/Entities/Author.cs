using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemUAZ.Data.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }

        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
