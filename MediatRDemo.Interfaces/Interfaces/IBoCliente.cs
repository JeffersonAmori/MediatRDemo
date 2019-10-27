using MediatRDemo.DML;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatRDemo.Core.Interfaces
{
    public interface IBoCliente
    {
        void InserirCliente(Cliente cliente);
        Cliente ConsultarCliente(string codigoCliente);
    }
}
