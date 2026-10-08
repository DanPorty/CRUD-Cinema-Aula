using CinemaDomain;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaService.Validators
{
    public class IngressoValidator : AbstractValidator<Ingresso>
    {
        public IngressoValidator()
        {
            RuleFor(i => i.DataCompra).NotEmpty().NotNull().WithMessage("A data da compra do ingresso é obrigatória.");
            RuleFor(i => i.Documento).NotEmpty().NotNull().WithMessage("O documento do comprador é obrigatório.")
                .Length(11, 14).WithMessage("O documento do comprador deve ter entre 11 e 14 caracteres.");
            RuleFor(i => i.FormaPagamento).NotEmpty().NotNull().WithMessage("A forma de pagamento do ingresso é obrigatória.")
                .Length(2, 50).WithMessage("A forma de pagamento do ingresso deve ter entre 2 e 50 caracteres.");
            RuleFor(i => i.ValorTotal).NotEmpty().NotNull().WithMessage("O valor do ingresso é obrigatório.")
                .GreaterThan(0).WithMessage("O valor do ingresso deve ser maior que zero.");
        }
    }
}
