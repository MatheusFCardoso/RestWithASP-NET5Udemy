using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business
{
    public interface IBookBusiness
    {
        BookVO Store(BookVO book);
        BookVO Update(BookVO book);
        List <BookVO> Index();
        BookVO Show(long id);
        void Delete(long id);
    }
}
