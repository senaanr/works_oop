using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceResult
{
    public class Successed : Result
    {
        public Successed() : base(true,"Successed")  // aldığı değerleri üstünde bulunduğu sınıfa yollar
        {

        }

        //overload
        public Successed(string message) : base(true,message)
        {

        }
    }
}
