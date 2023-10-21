using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

hospedes.Add(new Pessoa(nome: "Hóspede 1"));
hospedes.Add(new Pessoa(nome: "Hóspede 2"));
hospedes.Add(new Pessoa(nome: "Hóspede 3"));
hospedes.Add(new Pessoa(nome: "Hóspede 4"));

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 4, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
try
{
    Reserva reserva = new Reserva(suite, hospedes, diasReservados: 10);

    //reserva.CadastrarSuite(suite);
    //reserva.CadastrarHospedes(hospedes);

    // Exibe a quantidade de hóspedes e o valor da diária
    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}       Dias Reservados: {reserva.DiasReservados}");
    Console.WriteLine($"Suite Tipo: {reserva.Suite.TipoSuite}       Valor diária: {reserva.CalcularValorDiaria():C}");

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message );
}
finally
{
    Console.ReadLine();
}


