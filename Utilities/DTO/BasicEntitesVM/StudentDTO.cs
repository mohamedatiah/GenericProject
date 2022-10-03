using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullTaskManager.DTO
{
   public class StudentDTO:IBaseDto
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
