using MediatRDemo.DML;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatRDemo.Core.Interfaces
{
    public interface IBoProposta
    {
        DML.Proposta ConsultarProposta(string numeroProposta);
        void CadastrarProposta(DML.Proposta proposta);
    }
}
