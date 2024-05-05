﻿using FluentValidation;
using FluentValidationLibrary.Web.Models;
using System;
using System.Reflection.Metadata.Ecma335;

namespace FluentValidationLibrary.Web.FluentValidators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public string NotEmptyMessage { get; } = "{PropertyName} alanı boş olamaz.";
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(NotEmptyMessage);
            RuleFor(x => x.Email).NotEmpty().WithMessage(NotEmptyMessage).EmailAddress().WithMessage("Email alanı doğru formatta olmalıdır.");
            RuleFor(x => x.Age).NotEmpty().WithMessage(NotEmptyMessage).InclusiveBetween(18, 60).WithMessage("Age alanı 18 ile 60 arasında olamlıdır.");

            RuleFor(x => x.Birthday).NotEmpty().WithMessage(NotEmptyMessage).Must(x =>
            {
                return DateTime.Now.AddYears(-18) >= x;
            }).WithMessage("Yaşınız 18'den büyük olmalıdır.");
            RuleFor(x => x.Gender).IsInEnum().WithMessage("{PropertyName} alanı Erkek = 1, Kadın = 2 olmalıdır. ");
        
            RuleForEach(x => x.Addresses).SetValidator(new AddressValidator());
        }
    }
}
