using BakeryFinal.Data;
using BakeryFinal.Model.Domain;
using BakeryFinal.Repository.BakeryOfficeRepository;
using BakeryFinal.Repository.BreadOrderRepository;
using BakeryFinal.Repository.BreadRepository;
using BakeryFinal.Repository.OrderRepository;
using BakeryFinal.Service.Implementation;
using BakeryFinal.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace BakeryFinal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddTransient<IOrderRepository, OrderRepository>();
            builder.Services.AddTransient<IOrder, OrderService>();

            builder.Services.AddTransient<IBreadOrderRepository, BreadOrderRepository>();
            builder.Services.AddTransient<IBreadOrder, BreadOrderService>();

            builder.Services.AddTransient<IBakeryOfficeRepository, BakeryOfficeRepository>();
            builder.Services.AddTransient<IBakeryOffice, BakeryOfficeService>();

            builder.Services.AddTransient<IBreadRepository, BreadRepository>();
            builder.Services.AddTransient<IBread, BreadService>();

            builder.Services.AddDbContext<ApplicationDBContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
            });

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}