using MediatR;
using MediatRDemo.Core.Interfaces;
using MediatRDemo.DML;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRDemo.Core.Commands
{
    public class InserirClienteCommand : IRequest
    {
        public DML.Cliente Cliente { get; private set; }

        public InserirClienteCommand(DML.Cliente cliente)
        {
            this.Cliente = cliente;
        }

        public class Handler : RequestHandler<InserirClienteCommand>
        {
            private readonly IBoCliente _boCliente;

            public Handler(IBoCliente boCliente)
            {
                _boCliente = boCliente;
            }

            protected override void Handle(InserirClienteCommand request)
            {
                _boCliente.InserirCliente(request.Cliente);
            }
        }
    }
}
