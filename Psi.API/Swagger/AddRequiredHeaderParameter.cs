using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;

namespace Psi.API.Swagger
{
    public class AddRequiredHeaderParameter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {

            if (operation.Parameters == null)
                operation.Parameters = new List<OpenApiParameter>();

            operation.Parameters.Add(new OpenApiParameter()
            {
                Name = "Authorization",
                Description = "Authorization",
                In = ParameterLocation.Header,
                Schema = new OpenApiSchema() { Type = "String" },
                Required = false,
                Example = new OpenApiString("Tenant ID example")
            });
        }
    }
}
