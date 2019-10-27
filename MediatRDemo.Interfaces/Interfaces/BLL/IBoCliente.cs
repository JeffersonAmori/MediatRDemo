using MediatRDemo.DML;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatRDemo.Core.Interfaces
{
    public interface IBoCliente
    {
        void InserirCliente(DML.Cliente cliente);
        DML.Cliente ConsultarCliente(string codigoCliente);
    }
}
