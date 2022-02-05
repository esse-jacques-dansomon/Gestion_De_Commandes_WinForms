using FluentValidation;
using GestionCommndesNaza.models;
using System.Linq;

namespace GestionCommndesNaza.validators
{
    class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleFor(c => c.Firstname).NotNull().Length(2, 255).WithMessage("Le champ prenoms est obligatoire");
            RuleFor(c => c.Lastname).NotNull().Length(2, 255).WithMessage("Le champ nom est obligatoire");
            RuleFor(c => c.Login).NotNull().WithMessage("Veuillez entrer un email correct").Must(UniqueEmail).WithMessage("Ce Login existe deja").EmailAddress();
            RuleFor(c => c.Password).NotNull().WithMessage("Le Mot de passe ne peut pas etre null").Length(6, 255).WithMessage("Le Mot de passe doit avoir mini 6 caracteres");
            RuleFor(c => c.Phone).NotNull().Length(8, 15).WithMessage("Le numero de téléphone n'est pas correct");
        }

        private bool UniqueEmail(string login)
        {
            Model1Container model = new Model1Container();
            User client = model.Users.Where(x => x.Login == login).FirstOrDefault();
            if (client == null) return true;
            return false;
        }
    }
}
