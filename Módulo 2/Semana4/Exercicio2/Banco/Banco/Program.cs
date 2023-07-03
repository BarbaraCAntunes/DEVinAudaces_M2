using Banco;

ContaBancária conta1 = new(123);
Console.WriteLine("Saldo de abertura da conta:");
conta1.GetSaldo();
Console.WriteLine("Deposita 1000.");
conta1.Depositar(1000.00);
Console.WriteLine("Saldo depois do depósito:");
conta1.GetSaldo();
Console.WriteLine("Saca 500.");
conta1.Saca(500.00);
Console.WriteLine("Saldo depois do saque:");
conta1.GetSaldo();
