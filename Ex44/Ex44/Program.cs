using Ex44.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<IQuestionRepo, QuestionRepo>();
builder.Services.AddSingleton<IAnswerRepo, AnswerRepo>();

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

app.UseAuthorization();

/*app.MapControllerRoute(
    name: "Question",
    pattern: "question/details/{id?}");
*/

app.MapControllerRoute(
    name: "request routing",
    pattern: "{controller=Home}/{action=Index}/{author}/{id?}");


app.MapControllerRoute(
    name: "routed",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
