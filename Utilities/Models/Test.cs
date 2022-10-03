using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullTaskRepository.Models
{
   public class Test:IBaseEntity
    {
        public string Id { set; get; }
        public string Names { set; get; }
    }
}
