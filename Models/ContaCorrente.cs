using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GigaBank.Models
{
    public class ContaCorrente
    {
        [Key]
        public int Id { get; set; }
        
        public decimal Saldo { get; set; }
        
        [MaxLength(10)]
        public string Conta { get; set; }
        
        [MaxLength(150)]
        public string Titular { get; set; }
    }
}