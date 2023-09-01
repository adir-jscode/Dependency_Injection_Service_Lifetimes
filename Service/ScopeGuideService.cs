namespace Dependency_Injection_Service_Lifetimes.Service
{
    public class ScopeGuideService : IScopedService
    {
        private readonly Guid _id;

        public ScopeGuideService()
        {
            _id = Guid.NewGuid();
        }
        public string GetGuid()
        {
           return _id.ToString();
        }
    }
}
