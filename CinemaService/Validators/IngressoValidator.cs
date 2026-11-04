using CinemaDomain;
using FluentValidation;
using System;

namespace CinemaService.Validators
{
    public class IngressoValidator : AbstractValidator<Ingresso>
    {
        public IngressoValidator()
        {
            RuleFor(i => i.DataCompra)
                .NotEmpty().WithMessage("A data da compra do ingresso é obrigatória.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("A data da compra não pode ser futura!");

            RuleFor(i => i.Documento)
                .NotNull().WithMessage("O documento do comprador é obrigatório.")
                .NotEmpty().WithMessage("O documento do comprador é obrigatório.")
                .Length(11, 14).WithMessage("O documento do comprador deve ter entre 11 e 14 caracteres.");

            RuleFor(i => i.IngressoItens)
                .NotNull().WithMessage("Os itens do ingresso devem ser informados!")
                .NotEmpty().WithMessage("Deve haver pelo menos um item no ingresso!")
                .ForEach(item => item.SetValidator(new IngressoItemValidator()));

            RuleFor(i => i.Sessao)
                .NotNull().WithMessage("A sessão deve ser informada!");

            RuleFor(i => i.ValorTotal)
                .GreaterThan(0).WithMessage("O valor do ingresso deve ser maior que zero.");

            RuleFor(i => i.FormaPagamento)
                .NotNull().WithMessage("A forma de pagamento do ingresso é obrigatória.")
                .NotEmpty().WithMessage("A forma de pagamento do ingresso é obrigatória.")
                .Length(2, 20).WithMessage("A forma de pagamento deve ter entre 2 e 20 caracteres.");
        }
    }
}