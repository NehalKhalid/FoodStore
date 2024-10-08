using Microsoft.OpenApi.Models;

namespace Store.Web.Extensions
{
    public static class SwaggerServiceExtension
    {

        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services) 
        {
            services.AddSwaggerGen(options => 
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Store Api",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "Nehal Khaled Youssef",
                        Email = "nehalkha92@gmail.com"
                    }
                });

                var securityScheme = new OpenApiSecurityScheme
                {
                    Description = "Jwt Authorization Header Using Bearer Scheme . Example : \"Authorization : Bearer {Token}\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "bearer",
                    Reference = new OpenApiReference
                    {
                        Id = "bearer",
                        Type = ReferenceType.SecurityScheme,
                    }
                };
                options.AddSecurityDefinition("bearer" , securityScheme);

                var securityRequirments = new OpenApiSecurityRequirement
                {
                    {securityScheme , new[] {"bearer"} }
                };
                options.AddSecurityRequirement(securityRequirments);
            });
            return services;
        }
    }
}
