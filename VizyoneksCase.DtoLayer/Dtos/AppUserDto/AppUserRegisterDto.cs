using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizyoneksCase.DtoLayer.Dtos.AppUserDto
{
    public class AppUserRegisterDto
    {
        public string Name { get; set; }
        public string SurnName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
