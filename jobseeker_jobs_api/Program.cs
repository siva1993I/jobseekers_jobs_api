using jobseeker_jobs_api.Context;
using jobseeker_jobs_api.Contracts;
using jobseeker_jobs_api.Repository;

namespace jobseeker_jobs_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddSingleton<DapperContext>();
            builder.Services.AddScoped<IJobRepository, JobRepository>();
            builder.Services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().
                 AllowAnyHeader());
            });

            var app = builder.Build();

            app.UseDeveloperExceptionPage();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //	{
            app.UseSwagger();
            app.UseSwaggerUI();
            //}

            app.UseCors(x => x
                   .AllowAnyMethod()
                   .AllowAnyHeader()
                   .SetIsOriginAllowed(origin => true) // allow any origin
                   .AllowCredentials()); // allow credentials

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }

}