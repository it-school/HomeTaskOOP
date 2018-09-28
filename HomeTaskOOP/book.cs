using System;

namespace HomeTaskOOP
{
    class Book
    {
        string author;
        string title;
        int pages;
        string genre;
        string publishingHouse;
        string language;

        public Book()
        {
        }

        public Book(string author, string title, int pages, string genre, string publishingHouse, string language)
        {
            Author = "Aleister Crowley";
            Title = "The Book of the Law.";
            Pages = 128;
            Genre = "occultism";
            PublishingHouse = "Weiser Books";
            Language = "english";
        }

        public string Author { get => author; set => author = value; }
        public string Title { get => title; set => title = value; }
        public int Pages { get => pages; set => pages = value; }
        public string Genre { get => genre; set => genre = value; }
        public string PublishingHouse { get => publishingHouse; set => publishingHouse = value; }
        public string Language { get => language; set => language = value; }

        public void GetInfo()
        {
            Console.Write(Author + " ", Title + " ", Pages + " ", Genre + " ", PublishingHouse + " ", Language + " ");
        }

        public override string ToString()
        {
            return Author + " " + Title + " " + Pages + " " + Genre + " " + PublishingHouse + " " + Language + " ";
        }
    }    
}
