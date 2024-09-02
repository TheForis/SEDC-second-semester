using Microsoft.IdentityModel.Tokens;
using Qinshift.EShop.DataAccess.Interface;
using Qinshift.EShop.DomainModels;
using Qinshift.EShop.DTOs.User;
using Qinshift.EShop.Services.Interface;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Sockets;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Qinshift.EShop.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public string LoginUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Username and password must be provided!");
            }
            
            MD5 md5CryptoService = MD5.Create();
            byte[] passwordBytes = Encoding.ASCII.GetBytes(password);
            byte[] hashBytes = md5CryptoService.ComputeHash(passwordBytes);
            string hashedPassword = Encoding.ASCII.GetString(hashBytes);

            var user = _userRepository.LoginUser(username, hashedPassword);
            if(user == null)
            {
                throw new Exception("User not found!");
            }

            JwtSecurityTokenHandler tokenHander = new JwtSecurityTokenHandler();
            byte[] secretKeyBytes = Encoding.ASCII.GetBytes("This is our custom secret key that is top secret");

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Expires = DateTime.UtcNow.AddHours(1),
                //Congigure Signature!
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKeyBytes),
                                                                SecurityAlgorithms.HmacSha256Signature),

                //Payload

                Subject = new ClaimsIdentity(
                    new[]
                    {
                        new Claim(ClaimTypes.Name, user.UserName),
                        new Claim("userFullName", $"{user.FirstName}{user.LastName}")
                    })
            };

            //Generate Toekn

            SecurityToken token = tokenHander.CreateToken(tokenDescriptor);


            return tokenHander.WriteToken(token);

        }

        public int RegisterUser(RegisterUserDto registerUserDto)
        {
            if (String.IsNullOrEmpty(registerUserDto.UserName) ||
                String.IsNullOrEmpty(registerUserDto.Password))
            {
                throw new Exception("Username and password must be provided!");
            }

            MD5 md5CryptoServiceProvider = MD5.Create();
            byte[] passwordBytes = Encoding.ASCII.GetBytes(registerUserDto.Password);
            byte[] hashBytes = md5CryptoServiceProvider.ComputeHash(passwordBytes);
            string hashedPassword = Encoding.ASCII.GetString(hashBytes);

            User user = new User()
            {
                FirstName = registerUserDto.UserName,
                LastName = registerUserDto.Password,
                UserName = registerUserDto.UserName,
                Password = hashedPassword
            };

            return _userRepository.Add(user);

        }
    }
}
