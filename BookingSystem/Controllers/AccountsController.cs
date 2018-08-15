using BookingSystem.Models.Entities;
using BookingSystem.Models.ViewModels;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {

        private readonly UserManager<ApplicationUser> _userManager;

        public AccountsController(UserManager<ApplicationUser> userManager)
        {
            this._userManager = userManager;
        }

        // Generate token for a user.
        [AllowAnonymous]
        // Post api/Accounts
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UserVerificationModel value)
        {
            var user = await _userManager.FindByNameAsync(value.UserName);

            var roles = await _userManager.GetRolesAsync(user);

            var pswdhash = new PasswordHasher<ApplicationUser>();

            var result = pswdhash.VerifyHashedPassword(user, user.PasswordHash, value.Password);

            if (result == PasswordVerificationResult.Failed)
                return NotFound("");

            //var tokenHandler = new JwtSecurityTokenHandler();
            //var key = Encoding.ASCII.GetBytes("MyVeryLongAndVerySecretKeyThatNooneCanCrack");

            //var tokenDescriptor = new SecurityTokenDescriptor
            //{
            //    Subject = new ClaimsIdentity(new Claim[]
            //    {
            //        new Claim(ClaimTypes.Name, user.Id.ToString())
            //    }),
            //    Expires = DateTime.UtcNow.AddDays(1),
            //    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            //};

            //var token = tokenHandler.CreateToken(tokenDescriptor);
            //var tokenString = tokenHandler.WriteToken(token);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.NameId, user.NormalizedUserName),
                new Claim(JwtRegisteredClaimNames.Email, user.NormalizedEmail),
                new Claim(ClaimTypes.Role, roles[0].ToString())
            };

            var credentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ThisIsMySuperSecretKey")),
                SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken
            (
                issuer: "Booking.com",
                audience: "Booking.com",
                claims: claims,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: credentials
            );

            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token),
                expires = DateTime.UtcNow.AddDays(1)
            });
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles="Administrator")]
        public ActionResult Get(string name)
        {
            var claimsPrincipal = this.User;

            return Ok();
        }
    }
}
