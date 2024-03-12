
using Desafio_Sistema_Hospedagem.Entities;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa ps1 = new Pessoa(nome:"Itadori", sobrenome: "Mendes");
Pessoa ps2 = new Pessoa(nome: "Carla", sobrenome: "Silva");

hospedes.Add(ps1);  
hospedes.Add(ps2);

Suite suite = new Suite(tipo: "Master", capacidade: 3, diaria: 32);

Reserva reserva = new Reserva(reserva: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Quantidade de Hospedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor da Diária: {reserva.ValorDiaria()}");