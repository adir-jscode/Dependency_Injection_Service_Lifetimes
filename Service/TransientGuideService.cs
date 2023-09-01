namespace Dependency_Injection_Service_Lifetimes.Service
{
    public class TransientGuideService : ITransientService
    {
        private readonly Guid _id;

        public TransientGuideService()
        {
            _id= Guid.NewGuid();
        }
        public string GetGuid()
        {
            return _id.ToString();
        }
    }
}
