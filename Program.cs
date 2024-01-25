namespace PAPP_221_lab1 {
    public class Program {
        private static void Main() {
            var library = new Library();
            library.Add(new Book("The Secret Garden", "Frances Hodgson Burnett", "978-1-234-56789-0"));
            library.Add(new Book("Sapiens: A Brief History of Humankind", "Yuval Noah Harari", "978-0-987-65432-1"));
            library.Add(new Book("The Catcher in the Rye", "J.D. Salinger", "978-3-210-56789-2"));
            library.Add(new Book("The Martian", "Andy Weir", "978-5-432-10987-6"));
            library.Add(new Book("To Kill a Mockingbird", "Harper Lee", "978-4-321-09876-5"));

            foreach(var item in library.GetBooks()) {
                Console.WriteLine(item?.ToString());
            }

            library.RemoveByIndex(3);

        }
    }
}