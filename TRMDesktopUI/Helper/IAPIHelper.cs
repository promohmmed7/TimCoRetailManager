using System.Threading.Tasks;
using TRMDesktopUI.Models;

namespace TRMDesktopUI.Helper
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}