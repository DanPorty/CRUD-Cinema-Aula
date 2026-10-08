using FluentValidation;
using CinemaDomain;

namespace CinemaService.Validators
{
    public class SalaValidator : AbstractValidator<Sala>
    {
        public SalaValidator()
        {
            RuleFor(s => s.Numero)
                .NotEmpty().NotNull().WithMessage("O número da sala é obrigatório.")
                .GreaterThan(0).WithMessage("O número da sala deve ser maior que zero.");

            RuleFor(s => s.Capacidade)
                .NotEmpty().NotNull().WithMessage("A capacidade da sala é obrigatória.")
                .GreaterThan(0).WithMessage("A capacidade da sala deve ser maior que zero.");

            RuleFor(s => s.Fileiras)
                .NotEmpty().NotNull().WithMessage("O número de fileiras é obrigatório.")
                .GreaterThan(0).WithMessage("O número de fileiras deve ser maior que zero.");

            RuleFor(s => s.Assentos)
                .NotEmpty().NotNull().WithMessage("O número de assentos por fileira é obrigatório.")
                .GreaterThan(0).WithMessage("O número de assentos por fileira deve ser maior que zero.");

            // Validação a nível de objeto: verifica consistência entre capacidade, fileiras e assentos
            RuleFor(s => s).Custom((s, context) =>
            {
                if (s.Fileiras > 0 && s.Assentos > 0 && s.Capacidade != s.Fileiras * s.Assentos)
                {
                    context.AddFailure("Capacidade", "A capacidade deve ser igual ao número de fileiras multiplicado pelos assentos por fileira.");
                }
            });
        }
    }
}
