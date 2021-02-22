using Entities.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty().WithMessage("Lütfen araba adı alanını doldurunuz...");
            RuleFor(c => c.CarName).MinimumLength(2).WithMessage("Araba adı 2 karakterden fazla olmalıdır.");
            RuleFor(c => c.DailyPrice).NotEmpty().WithMessage("Lütfen günlük fiyatı girniz..."); ;
            RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage("Arabanın günlük fiyatı sıfırdan büyük olmalıdır."); ;
        }
        
    }
}
