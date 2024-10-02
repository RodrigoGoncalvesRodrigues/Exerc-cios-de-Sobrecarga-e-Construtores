var retangulo1 = new Retangulo();
var retangulo2 = new Retangulo(5,5);
var retangulo3 = new Retangulo(6,4);
Console.WriteLine($"O retangulo 1 possui Área de: {retangulo1.CalcularArea()} e Perímetro: {retangulo1.CalcularPerimetro()}");
Console.WriteLine($"O retangulo 2 possui Área de: {retangulo2.CalcularArea()} e Perímetro: {retangulo2.CalcularPerimetro()}");
Console.WriteLine($"O retangulo 3 possui Área de: {retangulo3.CalcularArea()} e Perímetro: {retangulo3.CalcularPerimetro()}");

retangulo3.Redimensionar(2);
Console.WriteLine($"O retangulo 3 redimencionado : Área {retangulo3.CalcularArea()} e Perímetro: {retangulo3.CalcularPerimetro()}");

retangulo2.Redimensionar(10,15);
Console.WriteLine($"O retangulo 2 redimencionado : Área {retangulo2.CalcularArea()} e Perímetro: {retangulo2.CalcularPerimetro()}");
