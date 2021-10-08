using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validator
{
    public class SupplierRegistratorValidators : AbstractValidator<SupplierRegistration>
    {
        public SupplierRegistratorValidators()
        {
            RuleFor(prop => prop.Name)
            .NotEmpty().WithMessage("Autor Vazio")
            .NotNull().WithMessage("Campo autor vazio não permitido");

            RuleFor(prop => prop.Responsible)
            .NotEmpty().WithMessage("Genero Vazio")
            .NotNull().WithMessage("Campo Genero vazio não permitido");

            RuleFor(prop => prop.CellPhone)
            .NotEmpty().WithMessage("Titulo Vazio")
            .NotNull().WithMessage("Campo titulo vazio não permitido");

            RuleFor(prop => prop.Whatsapp)
            .NotEmpty().WithMessage("Genero Vazio")
            .NotNull().WithMessage("Campo Genero vazio não permitido");

        }
    }
}
