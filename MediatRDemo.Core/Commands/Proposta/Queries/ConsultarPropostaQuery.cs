using MediatR;
using MediatRDemo.Core.Interfaces;
using MediatRDemo.DML;

namespace MediatRDemo.Core.Commands.Proposta.Queries
{
    public class ConsultarPropostaQuery : IRequest<DML.Proposta>
    {
        public ConsultarPropostaQuery(string numeroProposta)
        {
            NumeroProposta = numeroProposta;
        }

        public string NumeroProposta { get; set; }

        class ConsultarPropostaHandler : RequestHandler<ConsultarPropostaQuery, DML.Proposta>
        {
            private readonly IBoProposta _boProposta;

            public ConsultarPropostaHandler(IBoProposta boProposta)
            {
                _boProposta = boProposta;
            }

            protected override DML.Proposta Handle(ConsultarPropostaQuery request)
            {
                return _boProposta.ConsultarProposta(request.NumeroProposta);
            }
        }
    }
}
