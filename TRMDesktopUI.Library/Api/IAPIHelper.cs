using System.Net.Http;
using System.Threading.Tasks;
using TRMDesktopUI.Library.Models;

namespace TRMDesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);

        Task GetLogginInUserInfo(string token);

        HttpClient ApiClient { get; }
    }
}
