using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.ViewModels
{
    public class EncryptionMethodViewModel
    {
        public IEnumerable<SelectListItem> MyMethods { get; set; }

        public EncryptionMethodViewModel()
        {

        }

    }
}
