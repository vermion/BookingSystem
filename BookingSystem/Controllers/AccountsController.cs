using BookingSystem.Models.Entities;
using BookingSystem.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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

        // Post api/Accounts
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]UserVerificationModel value)
        {
            var user = await _userManager.FindByNameAsync(value.UserName);

            if (user == null)
                return NotFound("");

            return Ok("");
        }
    }
}
