using MediatRDemo.Proposta;
using System;

namespace MediatRDemo.DAL
{
    public class DispatcherProposta : IDispatcherProposta
    {
        public void CadastrarProposta(DML.Proposta proposta)
        {
            // Grava proposta na base.
        }

        public DML.Proposta ConsultarProposta(string numeroProposta)
        {
            return new DML.Proposta()
            {
                DataBase = DateTime.Now,
                NumeroProposta = "0000004484"
            };
        }
    }
}
