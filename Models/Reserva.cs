namespace DesafioProjetoHospedagem.Models;

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
        {   // Verifica se a capacidade da suite é maior ou igual ao número de hóspedes recebidos        
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {   // Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebidos
                throw new Exception("Número de hóspedes é maior que a capacidade da Suite");
            } 
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Retorna a quantidade de hóspedes
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Calcula o valor da diária
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Se os dias reservados forem maior ou igual a 10, concede um desconto de 10% no valor total das diarias
            if (DiasReservados >= 10)
            {
                return valor = (valor - valor/10);
            }

            return valor;
        }
    }
