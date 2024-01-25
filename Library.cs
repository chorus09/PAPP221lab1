using System;

namespace PAPP_221_lab1 {
    public class Library {
        public Library() {
            _books = new();
        }
        private List<Book> _books {  get; set; }

        public void Add(Book book) => _books?.Add(book);
        public void RemoveByIndex(int index) => _books?.RemoveAt(index);
        public List<Book> GetBooks() => _books;
    }
}
