using FluentValidation;
using CinemaDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaService.Validators
{
    public class GeneroValidator : AbstractValidator<Genero>
    {
        public GeneroValidator()
        {
            RuleFor(g => g.Nome).NotEmpty().NotNull().WithMessage("O nome do gênero é obrigatório.")
                .Length(2, 50).WithMessage("O nome do gênero deve ter entre 2 e 50 caracteres.");
        }
    }
}
