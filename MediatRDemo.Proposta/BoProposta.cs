using MediatRDemo.Core.Interfaces;
using MediatRDemo.DML;
using System;

namespace MediatRDemo.Proposta
{
    public class BoProposta : IBoProposta
    {
        private IBoCliente _boCliente;

        public BoProposta(IBoCliente boCliente)
        {
            _boCliente = boCliente;
        }

        public DML.Proposta ConsultarProposta(string numeroProposta)
        {
            return new DML.Proposta()
            {
                Cliente = new Cliente(),
                DataBase = DateTime.Now,
                NumeroProposta = "0000004484"
            };
        }

        public void CadastrarProposta(DML.Proposta proposta)
        {
            throw new NotImplementedException();
        }
    }
}
