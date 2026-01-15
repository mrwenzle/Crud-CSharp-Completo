using MeuPrimeiroCrud.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 1. ADICIONE ISSO (Configura o CORS para aceitar tudo)
builder.Services.AddCors(options =>
{
    options.AddPolicy("LiberarGeral",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// 2. ADICIONE ISSO (Ativa o CORS antes do Redirection)
app.UseCors("LiberarGeral");

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();