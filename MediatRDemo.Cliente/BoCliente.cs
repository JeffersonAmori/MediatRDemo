using MediatRDemo.Core.Interfaces;
using MediatRDemo.DML;
using System;

namespace MediatRDemo.Cliente
{
    public class BoCliente : IBoCliente
    {
        public DML.Cliente ConsultarCliente(string codigoCliente)
        {
            return new DML.Cliente()
            {
                CodigoCliente = codigoCliente,
                Nome = "Cliente Mediator",
                Renda = Convert.ToDecimal(new Random().NextDouble() * 1000)
            };
        }

        public void InserirCliente(DML.Cliente cliente)
        {
            // Insere cliente na base de dados.
        }
    }
}
