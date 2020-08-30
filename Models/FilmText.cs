using System;
using System.Collections.Generic;

namespace Lab3_3_AspNetMVC_Sakila_DBFirst.Models
{
    public partial class FilmText
    {
        public short FilmId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
