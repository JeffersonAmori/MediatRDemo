using MediatR;
using MediatRDemo.Core.Interfaces;

namespace MediatRDemo.Core.Commands.Cliente.Queries
{
    public class ConsultarClienteQuery : IRequest<DML.Cliente>
    {
        public ConsultarClienteQuery(string codigoCliente)
        {
            CodigoCliente = codigoCliente;
        }

        public string CodigoCliente { get; private set; }

        public class ConsultarClienteQueryHandler : RequestHandler<ConsultarClienteQuery, DML.Cliente>
        {
            private IBoCliente _boCliente;

            public ConsultarClienteQueryHandler(IBoCliente boCliente)
            {
                _boCliente = boCliente;
            }

            protected override DML.Cliente Handle(ConsultarClienteQuery request)
            {
                return _boCliente.ConsultarCliente(request.CodigoCliente);
            }
        }
    }
}
