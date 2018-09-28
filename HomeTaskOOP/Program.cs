using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskOOP
{
    class BookProgram
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Author = "Aleister Crowley";
            book1.Title = "The Book of the Law.";
            book1.Pages = 128;
            book1.Genre = "occultism";
            book1.PublishingHouse = "Weiser Books";
            book1.Language = "english";

            Console.WriteLine(book1.ToString());
        }
    }
}
