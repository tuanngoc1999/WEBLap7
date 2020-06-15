using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lap7.Models
{
    public class Sach
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
    }
}