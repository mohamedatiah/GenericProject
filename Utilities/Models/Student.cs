using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullTaskRepository.Models
{
  public  class Student:IBaseEntity
    {
        [Key]
        public string Name { get; set; }
        [Range(10,33)]
        public int Age { get; set; }
    }
}
