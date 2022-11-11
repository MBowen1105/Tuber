using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.API.BankAccounts;
using Tuber.API.Banks;
using Tuber.BLL.BankAccounts.Queries.GetBankAccountPaged;
using Tuber.BLL.Banks.Commands;
using Tuber.BLL.Banks.Queries.GetBankById;
using Tuber.BLL.Banks.Queries.GetBankPaged;
using Tuber.BLL.Extensions;
using Tuber.Domain.Exceptions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

Tuber.API.DependencyInjection.AddDependencyInjection(builder.Services);
Tuber.BLL.DependencyInjection.AddDependencyInjection(builder.Services);
Tuber.DAL.DependencyInjection.AddDependencyInjection(builder.Services, builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

BankEndpoints.QueryEndpoints(app);
BankEndpoints.CommandEndpoints(app);

BankAccountEndpoints.QueryEndpoints(app);

app.Run();
