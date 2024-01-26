using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASPNETUdemy.Business;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        private IBookBusiness _bookBusiness;
        public BookController(ILogger<BookController> logger, IBookBusiness bookBusiness)
        {
            _logger = logger;
            _bookBusiness = bookBusiness;
        }

        [HttpGet]
        public IEnumerable<BookVO> Index()
        {
            return _bookBusiness.Index();
        }
        [HttpGet("{id}")]
        public BookVO Show(long id)
        {
            return _bookBusiness.Show(id);
        }
        [HttpPost]
        public BookVO Store(BookVO book)
        {
            return _bookBusiness.Store(book);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _bookBusiness.Delete(id);
            return NoContent(); 
        }
        [HttpPut]
        public BookVO Update(BookVO book)
        {
           return  _bookBusiness.Update(book);
        } 
    }
}
