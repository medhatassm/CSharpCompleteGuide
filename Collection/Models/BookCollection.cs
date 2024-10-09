using System;

namespace Collection.Models;

public class BookCollection
{
    private Book[] books = new Book[5];

    public Book this[int Index]
    {
        get
        {
            return books[Index];
        }
        set
        {
            books[Index] = value;
        }
    }

    public Book this[string Title]
    {
        get
        {
            foreach (var book in books)
            {
                if (book.Title == Title)
                {
                    return book;
                }
            }
            return null;
        }
        set
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Title == Title)
                {
                    books[i] = value;
                    return;
                }
            }


            // Throw Exception if Not Found (Or Create new Book).
        }
    }

}
