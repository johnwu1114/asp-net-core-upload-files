using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Controllers
{
    [Route("api/[controller]")]
    public class UploadController : Controller
    {
        private readonly string _uploadFolder;

        public UploadController(IHostingEnvironment hostingEnvironment)
        {
            _uploadFolder = $"{hostingEnvironment.WebRootPath}\\Upload";
        }

        [HttpPost]
        public async Task<IActionResult> Post(List<IFormFile> files)
        {
            var size = files.Sum(f => f.Length);

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream($"{_uploadFolder}\\{formFile.FileName}", FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            return Ok(new { count = files.Count, size });
        }
    }
}