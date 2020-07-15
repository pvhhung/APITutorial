using BooksApi.Models;

namespace BooksApi.DataAccess
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly BookDbContext _context;

        public DataAcessProvider(BookDbContext context)
        {
            _context = context;
        }

        public List<Book> GetAll()
        {
            return _context.books.ToList();
        }
        public void AddBook(Book patient)
        {
            _context.books.Add(patient);
            _context.SaveChanges();
        }

        public void UpdateBook(Book patient)
        {
            _context.books.Update(patient);
            _context.SaveChanges();
        }

        public void DeleteBook(string id)
        {
            var entity = _context.books.FirstOrDefault(t => t.Id == id);
            _context.books.Remove(entity);
            _context.SaveChanges();
        }

        public Book GetBook(string id)
        {
            return _context.books.FirstOrDefault(t => t.Id == id);
        }

    }
}
