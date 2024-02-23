using Microsoft.AspNetCore.Identity;

namespace VizyoneksCase.PresentationLayer.Models
{
    public class CustomIdentityValidator:IdentityErrorDescriber
    {

        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {

                Code = "PasswordRequiresUpper",
                Description = "Parola en az 6 uzunlugunda  olmalıdır "
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code= "PasswordRequiresUpper",
                Description = "Parola en az 1 tane büyük harf olmalıdır"
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code= "PasswordRequiresLower",
                Description="Şifrede en 1 tane Küçük Harf olmalıdır"

            } ;
        }

        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresDigit",
                Description = "Şifrede en 1 tane rakam olmalıdır"

            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Şifrede en 1 tane sembol olmalıdır"

            };
        }
    }
}
