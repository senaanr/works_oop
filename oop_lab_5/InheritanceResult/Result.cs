using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceResult
{
    public class Result
    {
        //field - property
        public bool Status { get; set; }
        public string Message { get; set; }

        //methods
        public Result()
        {

        }
        public Result(bool status, string message)
        {
            Status = status;
            Message = message;
        }



    }
}
