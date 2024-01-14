using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business
{
    public interface IBookBusiness
    {
        Book Store(Book book);
        Book Update(Book book);
        List <Book> Index();
        Book Show(long id);
        void Delete(long id);
    }
}
