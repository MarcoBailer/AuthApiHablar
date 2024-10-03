using AuthApiHablar.Core.Dtos;

namespace AuthApiHablar.Core.Interfaces
{
    public interface IAuthService
    {
        Task<AuthServiceResponseDto> ResgisterAsync(RegisterDto registerDto);
        Task<AuthServiceResponseDto> LoginAsync(LoginDto loginDto);
    }
}
