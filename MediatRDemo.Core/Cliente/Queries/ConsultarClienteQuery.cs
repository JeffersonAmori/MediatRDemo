using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MediatRDemo.Core.Interfaces;
using MediatRDemo.DML;

namespace MediatRDemo.Core.Commands.Cliente.Queries
{
    public class ConsultarClienteQuery : IRequest<DML.Cliente>
    {
        public ConsultarClienteQuery(string codigoCliente)
        {
            CodigoCliente = codigoCliente;
        }

        public string CodigoCliente { get; private set; }

        public class Handler : IRequestHandler<ConsultarClienteQuery, DML.Cliente>
        {
            private IBoCliente _boCliente;

            public Handler(IBoCliente boCliente)
            {
                _boCliente = boCliente;
            }

            public Task<DML.Cliente> Handle(ConsultarClienteQuery request, CancellationToken cancellationToken)
            {
                return Task.FromResult(_boCliente.ConsultarCliente(request.CodigoCliente));
            }
        }
    }
}
