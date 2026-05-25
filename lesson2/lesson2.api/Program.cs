var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
    {
        var forecast = Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast
                (
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    summaries[Random.Shared.Next(summaries.Length)]
                ))
            .ToArray();
        return forecast;
    })
    .WithName("GetWeatherForecast")
    .WithOpenApi();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

// Kien truc 3 layer.

// Tang api?
    // Chiu trach nhiem khai bao cac endpoint, request, tra respone
    // Config hệ thống
    // Tang API goi toi Service
// Tang service?
    // Chịu trách nhiệm xu ly nghiep vu
    // Tuong tac voi tang Repository de lay du lieu
// Tang repository?
    // Chiu trach nhiem tuong tac voi DB
    // Cau hinh nhung thu lien quan den DB

// Co 1 request login
    // Tang API: Muon login vao he thong thi vao day
        // Chui vo day: POST /api/auth/login
            // Nhan request body {email: "haha", pwd: "ahaha"}
    // -> Luc nay tang API goi qua service
        // Tim xem, co ham nao xu ly login: vd - loginHandler(email, password)
        // Luc nay ham login trong service hay chay nhu sau
            //  Kiem tra email 1 nguoi co ton tai trong DB hay khong?
            // Nguoi dung nay co bi banned hay khong?
            // Neu co loi thi tra ve loi
            // Neu khong co loi thi tra ve token dang nhap
    // Tang service luc nay goi qua Repository co cai ham la
        // GetUserByEmail(email)
        // Ham nya se chay cau lenh SQL de
            // lay thong tin nguoi dung ra khoi DB