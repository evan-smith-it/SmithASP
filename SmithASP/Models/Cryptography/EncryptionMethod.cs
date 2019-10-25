using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.Models
{

    public class EncryptionMethod
    {
        [Key]
        public int EncryptionMethodId { get; set; }
        [Required]
        public String Name { get; set; }
        public String Description { get; set; }
    }
}
