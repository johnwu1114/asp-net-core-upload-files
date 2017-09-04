using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace MyWebsite.Models
{
    public class AlbumModel
    {
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public List<IFormFile> Photos { get; set; }
    }
}