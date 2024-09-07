using DesafioProjetoHospedagem.Models;

namespace DesafioProjetoHospedagem.Models
{
    class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        // Construtor da classe Reserva
        public Reserva(int diasReservados)
        {
            Hospedes = new List<Pessoa>();
            DiasReservados = diasReservados;
        }

        // Método para cadastrar hóspedes
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count > Suite.Capacidade)
            {
                throw new Exception("Capacidade da suíte insuficiente para o número de hóspedes.");
            }
            Hospedes = hospedes;
        }

        // Método para cadastrar a suíte
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        // Método para obter a quantidade de hóspedes
        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        // Método para calcular o valor da diária
        public decimal CalcularValorDiaria()
        {
            decimal valorTotal = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados >= 10)
            {
                valorTotal -= valorTotal * 0.10m; // Desconto de 10%
            }
            return valorTotal;
        }
    }
}