using MediatRDemo.Cliente;
using MediatRDemo.DML;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatRDemo.DAL
{
    public class DispatcherCliente : IDispatcherCliente
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
