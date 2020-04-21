namespace DIApiExample
{
    public class Service : IService
    {
        private int count;
        public Service()
        {
            count = 0;
        }

        public string ReturnValue()
        {
            count++;
            return $"Service: {count}";
        }
    }
}