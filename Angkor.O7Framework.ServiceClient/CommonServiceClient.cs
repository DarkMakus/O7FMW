using Angkor.O7Framework.ServiceClient.SecurityClient;

namespace Angkor.O7Framework.ServiceClient
{
    public class CommonServiceClient
    {
        public static SecurityContract GetSecurityContract()
        {
            return new SecurityContractClient();
        }
    }
}