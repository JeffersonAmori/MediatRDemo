using MediatR;
using MediatRDemo.Core.Commands;
using MediatRDemo.Core.Commands.Cliente.Queries;
using MediatRDemo.Core.Commands.Proposta.Queries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRDemo.Web.Controllers
{
    public class MediatorController : Controller
    {
        private IMediator _mediator;

        public MediatorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult ConsultarProposta(string numeroProposta)
        {
            return Ok(_mediator.Send(new ConsultarPropostaQuery(numeroProposta)));
        }

        [HttpPost]
        public IActionResult CadastrarProposta(CadastrarPropostaCommand cadastrarPropostaCommand)
        {
            return Ok(_mediator.Send(cadastrarPropostaCommand));
        }

        public IActionResult ConsultarCliente([FromQuery]string codigoCliente)
        {
            return Ok(_mediator.Send(new ConsultarClienteQuery(codigoCliente)));
        }

        [HttpPost]
        public IActionResult InserirCliente( DML.Cliente cliente)
        {
            return Ok(_mediator.Send(new InserirClienteCommand(cliente)));
        }
    }
}
