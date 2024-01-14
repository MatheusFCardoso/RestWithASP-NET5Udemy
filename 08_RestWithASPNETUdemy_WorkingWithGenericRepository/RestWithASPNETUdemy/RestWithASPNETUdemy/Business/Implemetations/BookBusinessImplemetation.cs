using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business.Implemetations
{
    public class BookBusinessImplemetation : IBookBusiness
    {
        private IRepository<Book> _repository;

        public BookBusinessImplemetation(IRepository<Book> repository)
        {
            _repository = repository;
        }
        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Book> Index()
        {
            return _repository.FindAll();
        }

        public Book Show(long id)
        {
            return _repository.FindById(id);
        }

        public Book Store(Book book)
        {
            return _repository.Create(book);
        }

        public Book Update(Book book)
        {
            return _repository.Update(book);
        }

    }
}
