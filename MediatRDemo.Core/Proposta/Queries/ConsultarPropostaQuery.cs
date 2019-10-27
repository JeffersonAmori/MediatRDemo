using MediatR;
using MediatRDemo.Core.Interfaces;
using MediatRDemo.DML;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRDemo.Core.Commands.Proposta.Queries
{
    public class ConsultarPropostaQuery : IRequest<DML.Proposta>
    {
        public ConsultarPropostaQuery(string numeroProposta)
        {
            NumeroProposta = numeroProposta;
        }

        public string NumeroProposta { get; set; }

        public class Handler : IRequestHandler<ConsultarPropostaQuery, DML.Proposta>
        {
            private readonly IBoProposta _boProposta;

            public Handler(IBoProposta boProposta)
            {
                _boProposta = boProposta;
            }

            public Task<DML.Proposta> Handle(ConsultarPropostaQuery request, CancellationToken cancelationToken)
            {
                return Task.FromResult(_boProposta.ConsultarProposta(request.NumeroProposta));
            }
        }
    }
}
