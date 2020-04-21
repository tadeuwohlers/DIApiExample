namespace DIApiExample
{
    public class WorkerSerice
    {
        private IService _service;
        public WorkerSerice(IService service)
        {
            _service = service;
        }

        public string ReturnServiceValue() => _service.ReturnValue();
    }
}