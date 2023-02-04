using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers
{
    public class FileHelperManager : IFileHelper
    {
        private string _filePath;

        public void Delete(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public string GetFilePath(IFormFile file)
        {
            string imageExtension = Path.GetExtension(file.FileName);
            string imageName = Guid.NewGuid() + imageExtension;
            _filePath = /*Directory.GetCurrentDirectory() +*/ $"Images/{imageName}";
            return _filePath;
        }

        public void Update(IFormFile file,string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            //GetFilePath(file);
            Upload(file);
        }

        public void Upload(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                using (var stream = new FileStream(_filePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                    stream.Flush();
                }
            }
        }
    }
}