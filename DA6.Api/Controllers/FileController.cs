using DA6.Api.Entities;
using DA6.Api.ViewModel.Common;
using DA6.Api.ViewModel.Files;
using DA6.Core.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DA6.Api.Controllers
{

    public class FileController : BaseController
    {
        public FileController(DA6DbContext context) : base(context)
        {
        }

        [HttpGet("get-all-paging")]
        public async Task<IActionResult> GetAllPagingFile([FromQuery]PagingRequest request )
        {
            var query = from f in _context.Files select f;
            if (!string.IsNullOrEmpty(request.textSearch))
            {
                query = query.Where(x => x.TenFile.Contains(request.textSearch));
            }
            int totoRecord = await query.CountAsync();
            var result = await query
                .Select(x => new Files()
                {
                    MaFile = x.MaFile,
                    TenFile = x.TenFile,
                    Path = x.Path,
                    Size = x.Size,
                    CreatedDate = x.CreatedDate,
                    CreatedBy = x.CreatedBy,
                    ModifiedBy = x.ModifiedBy,
                    ModifiedDate = x.ModifiedDate,
                }).ToListAsync();
            var pageResult = new PageResult<Files>()
            {
                items = result,
                totalRecord = totoRecord
            };
            return Ok(pageResult);
        }
        [HttpPost("importfile")]
        public async Task<IActionResult> ImportFile(IFormFile file)
        {

            FileRespon result = new FileRespon();
            if (file != null)
            {
                result = await UploadFile(file);
            }
            if (result.status == 400)
            {
                return Ok(result);
            }
            var files = new Files();
            files.TenFile = result.fileName;
            files.Path = result.filePath;
            files.Size = result.size;
           
            _context.Files.Add(files);
            _context.SaveChanges();
            return Ok(files);
        }
        private async Task<FileRespon> UploadFile(IFormFile ufile)
        {
            if (ufile != null && ufile.Length > 0)
            {
                var fileName = Path.GetFileName(ufile.FileName);
                var extension = Path.GetExtension(fileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"Template", fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await ufile.CopyToAsync(fileStream);
                }
                return new FileRespon() { status = 200, fileName = fileName, filePath = filePath, size = (ufile.Length).ToString() };
            }
            return new FileRespon();
        }
        [HttpDelete("delete-file")]
        public IActionResult deletefile([FromQuery] int mafile)
        {
            var file = _context.Files.Where(x=>x.MaFile == mafile).First();
            if(file == null)
            {
                return BadRequest("Can not find by id");
            }
            string _fileToBeDeleted = Path.Combine(Directory.GetCurrentDirectory(), @"Template", file.TenFile);
            if ((System.IO.File.Exists(_fileToBeDeleted)))
            {
                System.IO.File.Delete(_fileToBeDeleted);
            }
            _context.Files.Remove(file);
            _context.SaveChanges();
            return Ok();
        }
        [HttpGet("downloadFile")]
        public FileResult DownloadFile([FromQuery] string fileName)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"Template", fileName);

            byte[] bytes = System.IO.File.ReadAllBytes(path);

            return File(bytes, "application/octet-stream", fileName);
        }
    }
}
