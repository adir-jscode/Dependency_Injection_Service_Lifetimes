namespace Dependency_Injection_Service_Lifetimes.Service
{
    public class SingeltonGuideService : ISingeltonService
    {
        private readonly Guid _id;

        public SingeltonGuideService()
        {
            _id= Guid.NewGuid();
        }
        public string GetGuid()
        {
           return _id.ToString();
        }
    }
}
