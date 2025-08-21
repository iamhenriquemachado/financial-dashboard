using System.Threading.Tasks;
using FinancialDashboard.Data;
using FinancialDashboard.Entities;
using FinancialDashboard.Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace FinancialDashboard.Services
{
    public class AuthService
    {
        private readonly ITokenService _tokenService;
        private readonly AppDbContext _dbContext; 
        public AuthService(ITokenService tokenService, AppDbContext dbContext)
        {
            _tokenService = tokenService;
            _dbContext = dbContext; 
            
        }

       public async Task<bool> CheckAuthenticationUser(LoginModelDTO loginDTO)
        {
            var userExists = await _dbContext.LoginModelDTO.FirstOrDefaultAsync(u => u.Email == loginDTO.Email);
            if(userExists == null) 
            {
                return UnauthorizedAccessException();
            }

        }
    }
}
