using MediatRDemo.Core.Interfaces;
using MediatRDemo.DML;
using System;

namespace MediatRDemo.Cliente
{
    public class BoCliente : IBoCliente
    {
        private readonly IDispatcherCliente _dispatcherCliente;

        public BoCliente(IDispatcherCliente dispatcherCliente)
        {
            _dispatcherCliente = dispatcherCliente;
        }

        public DML.Cliente ConsultarCliente(string codigoCliente)
        {
            return _dispatcherCliente.ConsultarCliente(codigoCliente);
        }

        public void InserirCliente(DML.Cliente cliente)
        {
            _dispatcherCliente.InserirCliente(cliente);
        }
    }
}
