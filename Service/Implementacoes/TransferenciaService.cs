using GigaBank.Exceptions;
using GigaBank.Models;

namespace GigaBank.Service.Implementacoes
{
    public class TransferenciaService: ITransferenciaService
    {
        private readonly IContaCorrenteService _contaCorrenteService;

        public TransferenciaService(IContaCorrenteService contaCorrenteService)
        {
            _contaCorrenteService = contaCorrenteService;
        }
        
        public void Transferir(ContaCorrente contaOrigem, ContaCorrente contaDestino, decimal valor)
        {
            contaOrigem.Sacar(valor);
            _contaCorrenteService.AtualizarContaCorrente(contaOrigem);
            
            contaDestino.Depositar(valor);
            _contaCorrenteService.AtualizarContaCorrente(contaDestino);
        }
    }
}