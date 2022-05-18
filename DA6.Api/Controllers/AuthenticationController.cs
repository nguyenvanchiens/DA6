using DA6.Api.Common;
using DA6.Core.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DA6.Api.Controllers
{

    public class AuthenticationController : BaseController
    {
        private readonly IConfiguration _config;
        public AuthenticationController(DA6DbContext context, IConfiguration config) : base(context)
        {
            _config = config;
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(string UserName, string PassWord, bool RememberMe)
        {
            try
            {
                var user = _context.NguoiDungs.FirstOrDefault(x => x.TaiKhoan == UserName && x.MatKhau == PassWord);
                if (user == null)
                {
                    return Ok(new { StatusCode = 500, Message = "Tài khoản mật khẩu sai" });
                }
                else
                {
                    var Claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Email,user.TaiKhoan),
                        new Claim(ClaimTypes.GivenName,user.TenNguoiDung),
                        new Claim(ClaimTypes.Role,user.Quyen)

                    };
                    //var identity = new ClaimsIdentity(Claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    //var principal = new ClaimsPrincipal(identity);
                    //await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties()
                    //{
                    //    IsPersistent = RememberMe
                    //});
                    var Key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
                    var Token = new JwtSecurityToken(
                            _config["Tokens:Issuer"],
                            _config["Tokens:Issuer"],
                            Claims,
                            expires: DateTime.Now.AddDays(30.0),
                            signingCredentials: new SigningCredentials(Key, SecurityAlgorithms.HmacSha256)
                    );
                    return Ok(new JwtSecurityTokenHandler().WriteToken(Token));
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("LogOut")]
        public async Task<IActionResult> LogOut()
        {
            //SignOutAsync is Extension method for SignOut    
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            //Redirect to home page    
            return Ok("Success");
        }
    }
}
