using FluentValidation;
using CinemaDomain;

namespace CinemaService.Validators
{
    public class IngressoItemValidator : AbstractValidator<IngressoItem>
    {
        public IngressoItemValidator()
        {
            RuleFor(ii => ii.Fileira)
                .GreaterThan(0).WithMessage("O número da fileira deve ser maior que zero.");

            RuleFor(ii => ii.Assento)
                .GreaterThan(0).WithMessage("O número do assento deve ser maior que zero.");

            // MeiaEntrada é bool; não precisa de validação de null, pois aceita apenas true ou false.
        }
    }
}