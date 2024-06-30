using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// папка html для статических файлов
app.UseFileServer(new FileServerOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(builder.Environment.ContentRootPath, "html")),
    RequestPath = "", //Устанавливает корневой путь для статических файлов.
    EnableDefaultFiles = true //Включает поддержку файлов по умолчанию (например, index.html)
});

app.Run();
