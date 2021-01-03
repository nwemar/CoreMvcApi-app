using CoreMvcApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookAPIController : ControllerBase
    {
        [HttpGet]
        [ActionName("GetBookList")]
        public IActionResult GetBookList()
        {
            List<Book_Class> book_Lst = new List<Book_Class>();

            for (int i = 0; i < 3; i++)
            {
                Book_Class obj = new Book_Class();
                obj.id = i + 1;
                if (i == 0)
                    obj.Title = "C#";
                if (i == 1)
                    obj.Title = "PHP";
                if (i == 2)
                    obj.Title = "Ruby";
                obj.Price = 500;
                obj.Description = obj.Title + " BOOK";
                book_Lst.Add(obj);
            }
            return Ok(book_Lst);
        }
    }
}
