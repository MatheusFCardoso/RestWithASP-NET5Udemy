using RestWithASPNETUdemy.Data.Converter.Implementations;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business.Implemetations
{
    public class BookBusinessImplemetation : IBookBusiness
    {
        private IRepository<Book> _repository;
        private BookConverter _converter;

        public BookBusinessImplemetation(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }
        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<BookVO> Index()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public BookVO Show(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public BookVO Store(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Create(bookEntity);
            return _converter.Parse(bookEntity);
        }

        public BookVO Update(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Update(bookEntity);
            return _converter.Parse(bookEntity);
        }

    }
}
