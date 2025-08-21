using System.Threading.Tasks;
using FinancialDashboard.Data;
using FinancialDashboard.Entities;
using FinancialDashboard.Entities.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FinancialDashboard.Services { 
  public interface IAuthService
    {
        Task<(bool isSuccess, string token)> AuthenticateUser(LoginRequestDTO loginRequestDto);
    }



public class AuthService : IAuthService
    {
        private readonly ITokenService _tokenService;
        private readonly UserManager<User> _userManager;

        public AuthService(ITokenService tokenService, AppDbContext dbContext, UserManager<User> userManager)
        {
            _tokenService = tokenService;
            _userManager = userManager;
        }

        public async Task<(bool isSuccess, string token)> AuthenticateUser(LoginRequestDTO loginDTO)
        {
            var user = await _userManager.FindByEmailAsync(loginDTO.Email);
            if (user == null)
            {
                return (false, null);
            }

            var checkPassword = await _userManager.CheckPasswordAsync(user, loginDTO.Password);
            if (!checkPassword)
            {
                return (false, null);
            }

            if (user == null) 
            {
                return (false, null);
            }

            var token = _tokenService.GenerateToken(user.Id.ToString(), loginDTO.Email); 
            return (true, token);
        }
    }
}
