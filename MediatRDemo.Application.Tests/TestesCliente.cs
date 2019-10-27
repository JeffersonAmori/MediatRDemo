using MediatRDemo.Cliente;
using MediatRDemo.Core.Commands.Cliente.Queries;
using MediatRDemo.Core.Interfaces;
using MediatRDemo.DAL;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace MediatRDemo.Application.Tests
{
    public class TestesCliente
    {
        [Fact]
        public async Task ConsultaDeCliente_Sucesso()
        {
            // Arrange
            var sut = new ConsultarClienteQuery.Handler(new BoCliente(new DispatcherCliente()));
            var codigoCliente = "000001";

            // Act
            var cliente = await sut.Handle(new ConsultarClienteQuery(codigoCliente), CancellationToken.None);

            // Assert
            Assert.Equal(codigoCliente, cliente.CodigoCliente);
        }
    }
}
