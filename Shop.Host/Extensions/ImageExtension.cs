using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Host.Extensions
{
    public class ImageExtension
    {
        public static string SaveToCdn(IFormFile form, string cdn, string path)
        {
            try
            {
                if (!Directory.Exists(cdn))
                {
                    Directory.CreateDirectory(cdn);
                }
                string relativePath = path + '\\' + form.FileName;
                cdn = cdn + relativePath;
                byte[] file;
                using (var stream = form.OpenReadStream())
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        stream.CopyTo(ms);
                        file = ms.ToArray();
                    }
                }
                File.WriteAllBytes(cdn, file);
                return relativePath.Replace('\\','/');
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
