using System;
using System.Collections.Generic;
using System.Text;

namespace MediatRDemo.Cliente
{
    public interface IDispatcherCliente
    {
        void InserirCliente(DML.Cliente cliente);
        DML.Cliente ConsultarCliente(string codigoCliente);
    }
}
