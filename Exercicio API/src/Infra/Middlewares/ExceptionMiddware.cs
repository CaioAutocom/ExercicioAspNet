using Domain.Common;
using Domain.Common.Exceptions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Middlewares
{
    public class ExceptionMiddware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
			try
			{
				await next(context);
			}
			catch (Exception ex)
			{
				var errorId = Guid.NewGuid().ToString();
				ErrorResult error = new()
				{
					Source = ex.TargetSite?.DeclaringType.FullName,
					Exception = ex.Message.Trim(),
					ErrorId = errorId,
					SupportMessage = $"Id de Erro: {errorId}",
					StackTrace = ex.StackTrace
				};
				switch (ex)
				{
					case CustomException e:
						error.StatusCode = (int)e.StatusCode;
						if (e.ErrorMessages is not null)
						{
							error.Messages = e.ErrorMessages;
						}
						break;
					case KeyNotFoundException:
						error.StatusCode = (int)HttpStatusCode.NotFound;
						break;
                    case ValidationException:
						error.StatusCode = (int)HttpStatusCode.BadRequest;
						break;
                    default:
						error.StatusCode = (int)HttpStatusCode.InternalServerError;
						break;
				}
			}
        }
    }
}
