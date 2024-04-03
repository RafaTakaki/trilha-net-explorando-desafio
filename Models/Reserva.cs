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
            int quantidadeHospedes = 0;
            quantidadeHospedes = hospedes.Count;

            if (quantidadeHospedes <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                
                Console.WriteLine("Quantidade de hospedes maior que a capacidade da suíte");
                Environment.Exit(0);
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidadeHospedes = Hospedes.Count;
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

             if (DiasReservados > 9)
            {
                valor = valor * 0.9m ;
            }
         

            return valor;
        }
    }
}