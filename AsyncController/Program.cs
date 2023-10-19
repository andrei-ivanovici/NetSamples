var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

async IAsyncEnumerable<string> Generate()
{
    for (int i = 0; i < 100; i++)
    {
        await Task.Delay(100);
        yield return Faker.Lorem.Sentence(2);
    }
}

app.MapGet("/", Generate);

app.Run();