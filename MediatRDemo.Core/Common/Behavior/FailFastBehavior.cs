using System.Linq;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace MediatRDemo.Application.Common.Behavior
{
    public class FailFastBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private IEnumerable<IValidator<TRequest>> _validators;

        public FailFastBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            var failures = _validators
                .Select(v => v.Validate(request))
                .SelectMany(e => e.Errors)
                .Where(x => x != null);

            return failures.Any()
                ? throw new ValidationException(failures)
                : next();
        }
    }
}
