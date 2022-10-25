using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceResult
{
    public class ResultSet
    {
        public static Result Action01()
        {
            return new Successed();
        }
    
        public static Result Action02()
        {
            return new Successed("ıslem basarılı tamamlandı");
        }
        public static Result Action03()
        {
            return new Failed();
        }
        public static Result Action04()
        {
            return new Failed("ıslem basarısız tamamlandı");
        }
    
    }
}
