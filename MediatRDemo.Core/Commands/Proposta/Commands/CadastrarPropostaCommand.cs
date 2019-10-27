using MediatR;
using MediatRDemo.Core.Interfaces;

namespace MediatRDemo.Core.Commands
{
    public class CadastrarPropostaCommand : IRequest
    {
        public DML.Proposta Proposta;

    }
    public class CadastrarPropostaHandler : RequestHandler<CadastrarPropostaCommand>
    {
        private readonly IBoProposta _boProposta;

        public CadastrarPropostaHandler(IBoProposta boProposta)
        {
            _boProposta = boProposta;
        }

        protected override void Handle(CadastrarPropostaCommand request)
        {
            _boProposta.CadastrarProposta(request.Proposta);
        }
    }
}
