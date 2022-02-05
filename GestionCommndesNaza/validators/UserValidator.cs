using FluentValidation;
using GestionCommndesNaza.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommndesNaza.validators
{
    class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor( u => u.Firstname).Empty().WithMessage("Veuillez entrer un nom svp");
        }
    }
}
