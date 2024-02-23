using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VizyoneksCase.DtoLayer.Dtos.AppUserDto;

namespace VizyoneksCase.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidation:AbstractValidator<AppUserRegisterDto>
    {

        public AppUserRegisterValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş Geçilemez"); 
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş Geçilemez"); 
            RuleFor(x => x.SurnName).NotEmpty().WithMessage("Soyadı alanı boş Geçilemez"); 
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş Geçilemez"); 
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şİfre Tekrar alanı boş Geçilemez"); 
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı alanı boş Geçilemez"); 
            RuleFor(x => x.ConfirmPassword).Equal(y=>y.Password).WithMessage("Parolalar Eşleşmiyor"); 
       
        }
    }
}
