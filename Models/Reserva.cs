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

        public void CadastrarHospedes(List<Pessoa> Hospedes)
        {
            if (Hospedes.Count <= Suite.Capacidade)
            {
                this.Hospedes = Hospedes;
            }
            else
            {
                throw new Exception("A quantidade de hospedes é maior que a capacidade da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = 0;

            if (DiasReservados >= 10)
            {
                valor = DiasReservados * Suite.ValorDiaria;
                decimal desconto = valor * 0.10m;
                valor = valor - desconto;
            }
            else
            {
                valor = Suite.ValorDiaria * DiasReservados;
            }

            return valor;
        }
    }
}