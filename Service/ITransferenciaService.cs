using GigaBank.Models;

namespace GigaBank.Service
{
    public interface ITransferenciaService
    {
        void Transferir(ContaCorrente contaOrigem, ContaCorrente contaDestino, decimal valor);
    }
}