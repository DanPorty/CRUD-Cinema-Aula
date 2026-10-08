using FluentValidation;
using CinemaDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaService.Validators
{
    public class FilmeValidator : AbstractValidator<Filme>
    {
        public FilmeValidator()
        {
            RuleFor(f => f.Classificacao).NotEmpty().NotNull().WithMessage("A classificação do filme é obrigatória.")
                .Length(1, 100).WithMessage("A classificação do filme deve ter entre 1 e 100 caracteres.");
            RuleFor(f => f.Duracao).NotEmpty().NotNull().WithMessage("A duração do filme é obrigatória.")
                .GreaterThan(0).WithMessage("A duração do filme deve ser maior que zero.");
            RuleFor(f => f.Nome).NotEmpty().NotNull().WithMessage("O nome do filme é obrigatório.")
                .Length(2, 50).WithMessage("O nome do filme deve ter entre 2 e 50 caracteres.");
        }
    }
}
