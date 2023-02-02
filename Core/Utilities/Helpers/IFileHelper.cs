using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers
{
    public interface IFileHelper
    {
        void Upload(IFormFile file);
        string GetFilePath(IFormFile file);
        void Delete(string filePath);
    }
}
