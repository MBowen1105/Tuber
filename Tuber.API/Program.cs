using Tuber.API.BankAccounts;
using Tuber.API.Banks;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

Tuber.API.DependencyInjection.AddDependencyInjection(builder.Services);
Tuber.BLL.DependencyInjection.AddDependencyInjection(builder.Services);
Tuber.DAL.DependencyInjection.AddDependencyInjection(builder.Services, builder.Configuration);
Tuber.SystemClock.DependencyInjection.AddDependencyInjection(builder.Services);
Tuber.Users.DependencyInjection.AddDependencyInjection(builder.Services);

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
