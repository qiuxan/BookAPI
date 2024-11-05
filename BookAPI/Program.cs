namespace BookAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();

        builder.Services.AddCors(options => 
        {
            options.AddPolicy("MyCors", builder => 
            {
                builder
                .WithOrigins("http://localhost:4200")// Angular App URL
                .AllowAnyHeader()
                .AllowAnyMethod();
            });
        });

        var app = builder.Build();

        app.UseCors("MyCors");

        app.MapControllers();

        app.MapGet("/", () =>
        {
            return Results.Redirect("/api/books");

        });

        app.Run();
    }
}
