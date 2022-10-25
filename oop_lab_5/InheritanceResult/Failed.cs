namespace InheritanceResult
{
    public class Failed : Result
    {
        public Failed() : base(false,"Failed")  // aldığı değerleri üstünde bulunduğu sınıfa yollar
        {

        }

        //overload
        public Failed(string message) : base(false,message)
        {

        }
    }
}
