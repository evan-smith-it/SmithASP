using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.Models
{
    public class Cryptogram
    {

        public int CryptogramId { get; set; }
        [Required]
        public String message { get; set; }
        [Required]
        public String key { get; set; }
        [Required]
        public String result { get; set; }

    }
}
