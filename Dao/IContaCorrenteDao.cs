using System.Collections.Generic;
using GigaBank.Models;

namespace GigaBank.Dao
{
    public interface IContaCorrenteDao
    {
        List<ContaCorrente> BuscarTodos();
        void Adiciona(ContaCorrente contaCorrente);
        ContaCorrente BuscarPorTitular(string titular);
    }
}