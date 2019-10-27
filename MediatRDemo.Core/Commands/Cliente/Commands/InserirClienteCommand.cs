using MediatR;
using MediatRDemo.DML;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRDemo.Core.Commands
{
    public class InserirClienteCommand : IRequest<string>
    {
        public DML.Cliente cliente { get; private set; }

        public InserirClienteCommand(DML.Cliente cliente)
        {
            this.cliente = cliente;
        }

        public class InserirClienteCommandHandler : IRequestHandler<InserirClienteCommand, string>
        {
            public Task<string> Handle(InserirClienteCommand request, CancellationToken cancellationToken)
            {
                return Task.FromResult(string.Empty);
            }
        }
    }
}
