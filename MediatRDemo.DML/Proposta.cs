using System;

namespace MediatRDemo.DML
{
    public class Proposta
    {
        public string NumeroProposta { get; set; }
        public DateTime DataBase { get; set; }
        public Cliente Cliente { get; set; }
    }
}
