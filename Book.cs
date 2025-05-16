using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lib
{
    public class Book : LibItem, Loanable
    {
        private static int lastCode = 1;

        private BookGenre genre;
        private string author;
        private bool isAvailable;
        private int code;

        // ctor
        public Book(string title, int pubYear, BookGenre genre, string author, bool isAvailable) : base(title, pubYear)
        {
            this.genre = genre;
            this.author = author;
            this.isAvailable = isAvailable;
            this.code = lastCode++;
        }

        public BookGenre Genre
        {
            get { return genre; }
        }

        public string Author
        {
            get { return author; }
        }

        public bool IsAvailable
        {
            get { return isAvailable; }
        }

        public int Code
        {
            get { return code; }
        }

        // --> override
        public override string ShowDetails()
        {
            return $"\nTitle: {Title}" +
                    $"\nCode: {code}" +
                    $"\nPub Year: {PubYear}" +
                    $"\nGenre: {genre}" +
                    $"\nAuthor: {author}" +
                    $"\nIs available: {(isAvailable ? "Available" : "Unavailable")}";
        }

        // --> overload

        public string ShowDetails(bool brief)
        {
            return brief ? $"\nTitle: {Title}" + $"\nAuthor: {author}" : ShowDetails();
        }

        // --> implementation
        public bool CanBeBorrowed()
        {
            return isAvailable;
        }

    }
}