using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.Dtos.EF
{
    public class Person
    {
        [Key]
        public int id { get; set; }

        [MaxLength(40)]
        public string FName { get; set; }

        [MaxLength(40)]
        public string LName { get; set; }

        [MaxLength(3)]
        public int Age { get; set; }
    }
}
