using AuthServer.Core.Configurations;
using AuthServer.Core.DTOs;
using AuthServer.Core.Models;
using System.Threading.Tasks;

namespace AuthServer.Core.Services
{
    public interface ITokenService
    {
        Task<TokenDto> CreateToken(UserApp userApp);

        ClientTokenDto CreateTokenByClient(Client client);
    }
}
