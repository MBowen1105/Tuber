using Tuber.API.AppConfigs;
using Tuber.API.Categories;
using Tuber.API.CategorySubcategories;
using Tuber.API.ImportTemplates;
using Tuber.API.InstitutionAccounts;
using Tuber.API.Institutions;
using Tuber.API.Ledgers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

Tuber.API.DependencyInjection.AddDependencyInjection(builder.Services);
Tuber.Application.DependencyInjection.AddDependencyInjection(builder.Services);
Tuber.Persistence.DependencyInjection.AddDependencyInjection(builder.Services, builder.Configuration);
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

InstitutionEndpoints.CommandEndpoints(app);
InstitutionEndpoints.QueryEndpoints(app);

InstitutionAccountEndpoints.CommandEndpoints(app);
InstitutionAccountEndpoints.QueryEndpoints(app);

ImportTemplateEndpoints.CommandEndpoints(app);
ImportTemplateEndpoints.QueryEndpoints(app);

ImportEndpoints.CommandEndpoints(app);
ImportEndpoints.QueryEndpoints(app);

CategoryEndpoints.CommandEndpoints(app);
CategoryEndpoints.QueryEndpoints(app);

SubcategoryEndpoints.CommandEndpoints(app);
SubcategoryEndpoints.QueryEndpoints(app);

CategorySubcategoryEndpoints.CommandEndpoints(app);
CategorySubcategoryEndpoints.QueryEndpoints(app);

LedgerEndpoints.CommandEndpoints(app);
LedgerEndpoints.QueryEndpoints(app);

AppConfigEndpoints.CommandEndpoints(app);
AppConfigEndpoints.QueryEndpoints(app);

app.Run();
