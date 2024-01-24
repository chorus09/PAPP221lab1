using System;

namespace PAPP_221_lab1 {
    public class Book {
        public Book() {

        }
        public Book(string? title, string? author, string? iSBN) {
            Title = title;
            Author = author;
            ISBN = iSBN;
        }

        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }

        public override string ToString() {
            return $"Title: {Title}\tAuthor: {Author}\tISBN: {ISBN}";
        }
    }
}
