using Lap7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lap7.Controllers
{
    public class SachController : ApiController
    {
        Sach[] sachs = new Sach[] {
            new Sach {Id =1, Title = "ABC", Author = "XYZ", Price =1, Content="EGH" },
            new Sach {Id =2, Title = "Mệt", Author = "Tui đó", Price =1, Content="aaaaaaaaaaaaaaaaizzzzzzzzzzzzzzzzzzzzzzzzz" },
        };
        public IEnumerable<Sach> GetAll()
        {
            return sachs;
        }
        public IHttpActionResult GetSach(int id)
        {
            var sach = sachs.FirstOrDefault((p) => p.Id == id);
            if (sach == null)
                return NotFound();
            return Ok(sach);
        }
    }
}
