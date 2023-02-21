using System.Collections.Generic;
using GigaBank.Models;

namespace GigaBank.Dao
{
    public interface IContaCorrenteDao
    {
        List<ContaCorrente> BuscarTodos();
        ContaCorrente BuscarContaPeloNumero(string numeroDaConta);
        void Adiciona(ContaCorrente contaCorrente);
        void Atualizar(ContaCorrente contaCorrente);
    }
}