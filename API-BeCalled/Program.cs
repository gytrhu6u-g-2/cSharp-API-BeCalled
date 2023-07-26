using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

/// に対して POST が来たら呼ばれる処理を登録
app.MapPost("/", (int? one, int? two, RequestBody yourAnswer) =>
{
    if (one + two != 30)
    {
        return Results.Ok(new Response { Result = $"答えが違うよ! Your answer is {yourAnswer.Answer}" });
    }

    return Results.Ok(new Response { Result = $"正解！", Result2 = one + two });
});

app.Run();

//リクエストとレスポンス
class RequestBody
{
    public int? Answer { get; set; }
}

class Response
{
    public string? Result { get; set; }
    public int? Result2 { get; set; }
}
