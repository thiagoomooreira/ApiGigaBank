using System.ComponentModel.DataAnnotations;
using GigaBank.Exceptions;

namespace GigaBank.Models
{
    public class ContaCorrente
    {
        [Key]
        public int Id { get; set; }
        
        public decimal Saldo { get; private set; }

        [MaxLength(10)]
        public string Conta { get; set; }
        
        [MaxLength(150)]
        public string Titular { get; set; }

        public void Depositar(decimal valor)
        {
            this.Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (this.Saldo < valor)
                throw new SaldoInsuficienteException(
                    "A conta de origem não possui saldo para realizar esta transferência");

            this.Saldo -= valor;
        }
    }
}