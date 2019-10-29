using FluentValidation;
using MediatRDemo.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatRDemo.Application.Cliente
{
    public class ClienteValidator : AbstractValidator<InserirClienteCommand>
    {
        public ClienteValidator()
        {
            RuleFor(a => a.Cliente)
                .NotNull();

            RuleFor(a => a.Cliente.CodigoCliente)
                .NotNull()
                .NotEmpty()
                .WithMessage("Código do cliente não pode ser nulo nem branco.");

            RuleFor(a => a.Cliente.Nome)
                .NotNull()
                .NotEmpty()
                .WithMessage("Nome do cliente não pode ser branco ou nulo.")
                .Length(5, 20)
                .WithMessage("Nome do cliente deve conter entre 5 e 20 letras e espaços.");

            RuleFor(a => a.Cliente.Renda)
                .GreaterThan(0);
               
        }
    }
}
