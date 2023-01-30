using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Areas.Admin.MyClass;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.MyClass
{
    public class HelperClass : IClassHelper
    {
        public IHostingEnvironment Hosting { get; }

        public HelperClass(IHostingEnvironment _Hosting )
        {
            Hosting = _Hosting;
            
        }
 

        public string SaveImage(IFormFile File , string folder)
        {
            string[] extentionFilae = { ".gif", ".png", ".jpeg", ".jpg" };

            string wwwPath = this.Hosting.WebRootPath;
            string contentPath = this.Hosting.ContentRootPath;

            string path = Path.Combine(this.Hosting.WebRootPath, folder);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string FileName = "";
            if (File != null)
            {
                Guid g = Guid.NewGuid();

                string UploadIamge = Path.Combine(Hosting.WebRootPath, folder);
                FileName = File.FileName;
                FileInfo f = new FileInfo(FileName);
                FileName = folder + g + DateTime.Now.ToString().Replace("/", "").Replace("-", "").Replace(":", "").Replace(" ","").ToString() + f.Extension;

                string FullPath = Path.Combine(UploadIamge, FileName);

            
                    if (extentionFilae.Contains(f.Extension))
                    {
                        File.CopyTo(new FileStream(FullPath, FileMode.Create));
                    }
                    else
                    {
                   
                    return "Error";
                    
                    }

            }

            return FileName;
        }
        public bool acc(bool g)
        {

            if (g == true)
            {
                g = false;
            }
            else if (g == false)
            {
                g = true;
            }
            return g;
        }
    }
}
