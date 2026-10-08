using FluentValidation;
using CinemaDomain;

namespace CinemaService.Validators
{
    public class IngressoItemValidator : AbstractValidator<IngressoItem>
    {
        public IngressoItemValidator()
        {
            RuleFor(ii => ii.Fileira)
                .NotEmpty().WithMessage("O número da fileira é obrigatório.")
                .GreaterThan(0).WithMessage("O número da fileira deve ser maior que zero.");

            RuleFor(ii => ii.Assento)
                .NotEmpty().WithMessage("O número do assento é obrigatório.")
                .GreaterThan(0).WithMessage("O número do assento deve ser maior que zero.");

            // MeiaEntrada é bool; não precisa de validação de null, mas podemos garantir que seja true ou false
            RuleFor(ii => ii.MeiaEntrada).IsInEnum().WithMessage("O valor da meia entrada deve ser true ou false.");
        }
    }
}
