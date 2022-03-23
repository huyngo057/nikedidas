using UseCases.UseCaseInterfaces;
using UseCases.DataStoresPluginInterfaces;
using Plugins.DataStore.InMemory;
using UseCases;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    
    //Dependency Injection
    builder.Services.AddScoped<ICategoryRepository, CategoryInMemoryRepository>();
    builder.Services.AddTransient<IViewCategoriesUseCases, ViewCategoriesUseCases>();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();