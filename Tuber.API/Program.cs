using Tuber.API.BankAccounts;
using Tuber.API.Banks;
using Tuber.API.ImportTemplates;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

Tuber.API.DependencyInjection.AddDependencyInjection(builder.Services);
Tuber.BLL.DependencyInjection.AddDependencyInjection(builder.Services);
Tuber.DAL.DependencyInjection.AddDependencyInjection(builder.Services, builder.Configuration);
Tuber.FileSystem.DependencyInjection.AddDependencyInjection(builder.Services);
Tuber.SystemClock.DependencyInjection.AddDependencyInjection(builder.Services);
Tuber.Authentication.DependencyInjection.AddDependencyInjection(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

BankExtensions.QueryEndpoints(app);
BankExtensions.CommandEndpoints(app);

BankAccountExtensions.QueryEndpoints(app);

ImportTemplateExtensions.QueryEndpoints(app);
ImportTemplateExtensions.CommandEndpoints(app);

ImportExtensions.QueryEndpoints(app);
ImportExtensions.CommandEndpoints(app);

app.Run();
