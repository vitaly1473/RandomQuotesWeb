using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// ����� html ��� ����������� ������
app.UseFileServer(new FileServerOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(builder.Environment.ContentRootPath, "html")),
    RequestPath = "", //������������� �������� ���� ��� ����������� ������.
    EnableDefaultFiles = true //�������� ��������� ������ �� ��������� (��������, index.html)
});

app.Run();
