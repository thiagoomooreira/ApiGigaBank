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
            if (!ContaCorrentePossuiValor(contaOrigem, valor))
            {
                throw new SaldoInsuficienteException(
                    "A conta de origem não possui saldo para realizar esta transferência");
            }

            AlterarSaldoContaCorrente(contaOrigem, -valor);
            AlterarSaldoContaCorrente(contaDestino, valor);
        }

        private bool ContaCorrentePossuiValor(ContaCorrente contaCorrente, decimal valor)
        {
            if (contaCorrente.Saldo < valor)
                return false;

            return true;
        }

        private void AlterarSaldoContaCorrente(ContaCorrente contaCorrente, decimal valor)
        {
            contaCorrente.Saldo += valor;
            
            _contaCorrenteService.AtualizarContaCorrente(contaCorrente);
        }
    }
}