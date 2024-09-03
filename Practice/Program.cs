using Adapter;
using Bridge.Implementation;
using Strategy;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ITarget, EmployeeAdapter>();

//Bridge pattern class registrations
builder.Services.AddKeyedSingleton<IDiscount, AutoOwnersDiscount>("aod");
builder.Services.AddKeyedSingleton<IDiscount, NoClaimsDiscount>("ncd");
builder.Services.AddKeyedSingleton<IDiscount, SafeDriverDiscount>("sdd");

//Strategy pattern class registrations
//builder.Services.AddKeyedSingleton<IPaymentStrategy, CreditCardPayment>("cc");
//builder.Services.AddKeyedSingleton<IPaymentStrategy, PayPalPayment>("paypal");
//builder.Services.AddKeyedSingleton<IPaymentStrategy, CryptoPayment>("crytpo");
//builder.Services.AddSingleton<IPaymentService, PaymentService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
