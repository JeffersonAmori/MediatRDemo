using MediatR;
using MediatRDemo.Core.Commands.Cliente.Queries;
using MediatRDemo.Core.Commands.Proposta.Queries;
using MediatRDemo.DAL;
using MediatRDemo.Proposta;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace MediatRDemo.Application.Tests
{
    public class TestesProposta
    {

        [Fact]
        public async Task ConsultaDeProposta_Sucesso()
        {
            // Arrange
            Mock<IMediator> mediator = new Mock<IMediator>();
            var sut = new ConsultarPropostaQuery.Handler(new BoProposta(new DispatcherProposta(), mediator.Object));
            var codigoProposta = "0000004484";

            // Act
            var proposta = await sut.Handle(new ConsultarPropostaQuery(codigoProposta), CancellationToken.None);

            // Assert
            Assert.Equal(codigoProposta, proposta.NumeroProposta);
        }
    }
}
