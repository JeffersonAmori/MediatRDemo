using MediatR;
using MediatRDemo.Core.Commands.Cliente.Queries;
using MediatRDemo.Core.Interfaces;
using MediatRDemo.DML;
using System;

namespace MediatRDemo.Proposta
{
    public class BoProposta : IBoProposta
    {
        private readonly IDispatcherProposta _dispatcherProposta;
        private readonly IMediator _mediator;

        public BoProposta(IDispatcherProposta dispatcherProposta, IMediator mediator)
        {
            _dispatcherProposta = dispatcherProposta;
            _mediator = mediator;
        }

        public DML.Proposta ConsultarProposta(string numeroProposta)
        {
            var proposta = _dispatcherProposta.ConsultarProposta(numeroProposta);
            proposta.Cliente = _mediator.Send(new ConsultarClienteQuery("000001")).Result;

            return proposta;
            
        }

        public void CadastrarProposta(DML.Proposta proposta)
        {
            _dispatcherProposta.CadastrarProposta(proposta);
        }
    }
}
