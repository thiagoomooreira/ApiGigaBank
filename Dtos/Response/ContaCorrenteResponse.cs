namespace GigaBank.Dtos.Response
{
    public class ContaCorrenteResponse
    {
        public decimal Saldo { get; set; }
        public string Conta { get; set; }
        public string Titular { get; set; }
    }
}