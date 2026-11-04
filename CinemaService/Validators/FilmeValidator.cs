using FluentValidation;
using CinemaDomain;

namespace CinemaService.Validators
{
    public class FilmeValidator : AbstractValidator<Filme>
    {
        public FilmeValidator()
        {
            RuleFor(f => f.Classificacao)
                .NotEmpty().NotNull().WithMessage("A classificação do filme é obrigatória.")
                .Length(1, 50).WithMessage("A classificação do filme deve ter entre 1 e 50 caracteres.");

            RuleFor(f => f.Duracao)
                .GreaterThan(0).WithMessage("A duração do filme deve ser maior que zero.");

            RuleFor(f => f.Nome)
                .NotEmpty().NotNull().WithMessage("O nome do filme é obrigatório.")
                .Length(2, 50).WithMessage("O nome do filme deve ter entre 2 e 50 caracteres.");

            RuleFor(f => f.Genero)
                .NotNull().WithMessage("O gênero do filme deve ser informado!");
        }
    }
}