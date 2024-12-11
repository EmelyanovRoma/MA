var builder = WebApplication.CreateBuilder(args);

// Добавляем сервисы для контроллеров
builder.Services.AddControllers();

var app = builder.Build();

// Конфигурируем маршрутизацию
app.MapControllers();

app.Run();