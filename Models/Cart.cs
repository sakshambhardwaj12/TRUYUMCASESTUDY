using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Turuyum.Models
{
    public class Cart
    {
        [Key]
        public int CatrtId { get; set; }
        public MenuItem MenuItem { get; set; }
        public int MenuItemId { get; set; }
    }
}