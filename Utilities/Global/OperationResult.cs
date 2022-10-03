using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FullTaskRepository.Global
{
    public class OperationResult<T> where T:class
    {
        public HttpStatusCode Status { get; set; }

        public T Data { get; set; }

        public string  Message { get; set; }
        public List<string> Messages { get; set; }


        public OperationResult()
         : this(HttpStatusCode.OK)
        {
        }
        public OperationResult(HttpStatusCode status)
        {
            this.Status = status;
        }
        public OperationResult(T data, HttpStatusCode status = HttpStatusCode.OK) : this(status)
        {
            this.Data = data;
        }
        public OperationResult(HttpStatusCode status, string message): this(status)
        {
            this.Message = message;
        }
        public OperationResult(HttpStatusCode status,List<string> messages):this(status)
        {
            this.Messages = messages;
        }
    }

}
