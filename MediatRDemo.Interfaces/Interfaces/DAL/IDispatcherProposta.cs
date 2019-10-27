namespace MediatRDemo.Proposta
{
    public interface IDispatcherProposta
    {
        DML.Proposta ConsultarProposta(string numeroProposta);
        void CadastrarProposta(DML.Proposta proposta);
    }
}
