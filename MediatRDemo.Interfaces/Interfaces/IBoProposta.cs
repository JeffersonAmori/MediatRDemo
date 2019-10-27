using MediatRDemo.DML;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatRDemo.Core.Interfaces
{
    public interface IBoProposta
    {
        Proposta ConsultarProposta(string numeroProposta);
        void CadastrarProposta(Proposta proposta);
    }
}
