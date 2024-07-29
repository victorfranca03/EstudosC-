using ContaBancaria;

Conta conta1 = new Conta();
conta1.Id = 113322;
conta1.saldo = 99999999;
//conta1.Titular = "Teste Victor";
conta1.senha =250798;

Conta conta2 = new Conta();
conta2.Id = 332211;
//conta2.saldo = 000001111;
conta2.Titular = "Teste conta 2";
conta2.senha = 90901110;

conta1.ExibirContaBanco();
conta2.ExibirContaBanco();