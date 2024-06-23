using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_27_06
{
    internal class MyLinkedList<T> where T : Book //датя понять компилятору что T это Book
    {
        private LinkedList<T> _item;

        public MyLinkedList() 
        {
            _item = new LinkedList<T>();
        }
        public MyLinkedList(LinkedList<T> item)
        {
            _item = item;
        }

        public void AddtoEnd(T item) 
        {
            _item.AddLast(item);

        }
        public void AddtoStart(T item) 
        {
            _item.AddFirst(item);
        }


        public void InsertInPosition( T book,  int position) 
        {
            if(position < 0 || position > _item.Count) 
            {
                throw new IndexOutOfRangeException("problem with position");
            }

            if(position == 0) 
            {
                _item.AddFirst(book);
            }

            var currentPos = _item.First;
            for(int i = 1; i<position; i++) 
            { 
                currentPos = currentPos.Next;
            }
            _item.AddAfter(currentPos, book);
        }

        public void RemovefromPosition( int position ) 
        { 
            if(position != 0)
            {
                 var currentPos = _item.First;
                for(int i = 1;i<position;i++)
                {
                currentPos = currentPos.Next;
                }
            _item.Remove(currentPos);
            }
        }
        public void RemoveBookFromStart() 
        {
            if(_item.First != null)
            {
                _item.RemoveFirst();
            }
        }

        public void RemoveBookFromEnd()
        {
            if (_item.Last != null) 
            {
                _item.RemoveLast();
            }
        }

        public void RemoveBook(T book )
        {
            if(_item != null)
            { 
            _item.Remove(book);
            }
        }

        public void Show()
        {
            foreach(var book in _item)
            {
                Console.WriteLine(book);
            }
        }
        public void ChangeInfo(T newBook, int position)
        {
            var currentPos = _item.First;
            for (int i = 1; i < position; i++)
            {
                currentPos = currentPos.Next;
            }
            currentPos.Value = newBook;
        }


        public List<Book> SearchBooks(string searchBy, string value)
        {
            List<Book> foundBooks = new List<Book>();
            
            foreach (var book in _item)
            {
                if (searchBy.Equals("title", StringComparison.OrdinalIgnoreCase))
                {
                    if (book.Title.Equals(value, StringComparison.OrdinalIgnoreCase))
                    {
                        foundBooks.Add(book);
                        
                    }
                    
                }
                else if (searchBy.Equals("author", StringComparison.OrdinalIgnoreCase))
                {
                    if (book.Author.Equals(value, StringComparison.OrdinalIgnoreCase))
                    {
                        foundBooks.Add(book);
                    }
                }
                else if (searchBy.Equals("genre", StringComparison.OrdinalIgnoreCase))
                {
                    if (book.Gengre.Equals(value, StringComparison.OrdinalIgnoreCase))
                    {
                        foundBooks.Add(book);
                    }
                }
                else if (searchBy.Equals("year", StringComparison.OrdinalIgnoreCase))
                {
                    if (int.TryParse(value, out int year))
                    {
                        if (book.Year == year)
                        {
                            foundBooks.Add(book);
                        }
                    }
                    
                }
            }

            return foundBooks;
        }
    }
}
