using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entitys
{
    public class TbConfiguration
    {
        [Key]
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
