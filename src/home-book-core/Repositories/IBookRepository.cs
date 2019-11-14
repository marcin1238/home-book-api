using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HomeBook.Core.Models;

namespace HomeBook.Core.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetBooks();
        Task<Book> GetBook(Guid bookKey);
        Task<Book> Create(Book book);
        Task<Book> Update(Book book);
        Task Delete(Guid bookKey);
    }
}