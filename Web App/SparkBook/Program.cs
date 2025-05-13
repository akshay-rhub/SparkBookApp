using BusinessLogic;
using BusinessLogic.Interface;
using DataObjects.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(ModelMapper));

//Dependency Injection
builder.Services.AddScoped<ICategory, CategoryService>();


builder.Services.AddHttpClient<ICategory, CategoryService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["APIurl:BaseURl"]);
    client.DefaultRequestHeaders.Add("Accept", "application/json");
});

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseCors();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
