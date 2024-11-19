using PS.BioBoard_Simple.Web;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
      .AddPresentation(builder.Configuration);
}

var app = builder.Build();
{

    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthorization();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    app.Run();
}
