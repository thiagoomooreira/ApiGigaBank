namespace GigaBank.Dtos.Request.Transferencia
{
    public class TransferenciaDto
    {
        public string ContaDestino { get; set; }
        public string ContaOrigem { get; set; }
        public decimal Valor { get; set; }
    }
}