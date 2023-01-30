using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.MyClass
{
    public interface IClassHelper
    {
        String SaveImage(IFormFile File, string folder);
    }
}
