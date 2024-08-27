namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // *IMPLEMENTADO*
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // *IMPLEMENTADO*
                Console.WriteLine($"O valor atual ultrapassa o numero máximo de hóspedes. O numero máximo de hóspedes atualmente são(é): {Suite.Capacidade}hospede(s).");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // *IMPLEMENTADO*
            int quantidadeDeHospedes = Hospedes.Count;
 
            return quantidadeDeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            int dias = DiasReservados;
            decimal valor = Suite.ValorDiaria;
            decimal valorTotal = valor * dias;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (dias >= 10)
            {
                valor = valor - valor/100*10;
                valorTotal = valor * dias;
                Console.WriteLine($"Valor total: {valorTotal}");
            }

            return valor;
        }
    }
}