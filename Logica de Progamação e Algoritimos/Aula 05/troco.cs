using static System.Console
 double valorCompra, valorPago, troco;
 Write("Digite o valor da compra: ");
 valorCompra = double.Parse(ReadLine());
 Write("Digite o valor pago: ");
 valorPago = double.Parse(ReadLine());
 troco = valorPago - valorCompra;
 WriteLine("O valor do troco é: " + troco);