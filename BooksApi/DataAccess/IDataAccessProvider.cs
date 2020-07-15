using BooksApi.Models;

namespace BooksApi.DataAccess
{
    public interface IDataAccessProvider
    {
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(string id);
        Book GetBook(string id);
        List<Book> GetAll();
    }
}
