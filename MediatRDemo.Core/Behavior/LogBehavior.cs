using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRDemo.Core.Behavior
{
    public class LogBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            Console.WriteLine("Executando requisição...");

            var response = await next();

            Console.WriteLine("Requisição executada.");

            return response;
        }
    }
}
