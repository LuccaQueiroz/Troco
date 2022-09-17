Console.WriteLine("-----Troco da compra-----\n");

int valorCompra, valorRecebido, troco;
 
Console.Write("Valor total da compra: ");
valorCompra = Convert.ToInt32(Console.ReadLine());

Console.Write("Valor recebido: ");
valorRecebido = Convert.ToInt32(Console.ReadLine());

troco = valorRecebido - valorCompra;

Console.WriteLine($"Troco: R${troco}");
