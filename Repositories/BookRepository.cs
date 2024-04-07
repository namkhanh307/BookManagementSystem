using Microsoft.EntityFrameworkCore;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookRepository
    {

        public List<Book> GetBooks()
        {
            using BookManagementDbContext _context = new();
            return _context.Books.ToList();

        }

        public void UpdateBook(Book book)
        {
            using BookManagementDbContext _context = new();
            _context.Books.Update(book);
            _context.SaveChanges();
        }

        public void CreateBook(Book book)
        {
            using (BookManagementDbContext _context = new BookManagementDbContext())
            {
                _context.Books.Add(book);
                _context.SaveChanges();
            }


            //check duplicate primary key -ChatGPT
        }

        public void DeleteBook(Book book)
        {
            using BookManagementDbContext _context = new();
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}
