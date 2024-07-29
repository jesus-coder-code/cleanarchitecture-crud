using CleanArchitecture.Application.CQRS.Queries;
using CleanArchitecture.Application.DTOs;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Mappings;
using CleanArchitecture.Infrastructure.ExceptionHandlers;
using CleanArchitecture.Infrastructure.Repositories;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<INotesRepository, NotesRepository>();
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddTransient<IRequestHandler<NotesRequest, IList<NotesResult>>, GetNotesQuery>();
builder.Services.AddProblemDetails();
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblies(typeof(Program).Assembly);
} );
builder.Services.AddAutoMapper(typeof(NotesProfile));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseExceptionHandler();

app.MapControllers();

app.Run();
