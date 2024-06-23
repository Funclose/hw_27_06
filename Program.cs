using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_27_06
{
//     додавати книги;
// видаляти книги; V
// змінювати інформацію про книги; V
// пошук книг за параметрами;
// вставити книги у початок списку; V
// вставити книги у кінець списку; V
// вставити книги у певну позицію; V
// видалити книги з початку списку; V
// видалити книги з кінця списку; V
// видалити книги з певної позиції. V
    internal class Program
    {
        
        static void Main(string[] args)
        {
            MyLinkedList<Book> myLinked = new MyLinkedList<Book>();

            var book1 = new Book("The Catcher in the Rye", "J.D. Salinger", "Fiction", 1951);
            var book2 = new Book("To Kill a Mockingbird", "Harper Lee", "Fiction", 1960);
            var book3 = new Book("1984", "George Orwell", "Dystopian", 1949);


            myLinked.AddtoEnd(book1);
            myLinked.AddtoStart(book2);
            myLinked.InsertInPosition(book3, 2);

            myLinked.AddtoStart(book3);
            myLinked.AddtoEnd(book3);

            myLinked.RemoveBook(book1);
            myLinked.RemovefromPosition(4);

            var newBook = new Book("Brave New World", "Aldous Huxley", "Dystopian", 1932);

            myLinked.ChangeInfo(newBook, 2);
            

            myLinked.Show();
            Console.WriteLine("---------------------");
            myLinked.SearchBooks("Title", "1984");

            
            


        }
    }
}
