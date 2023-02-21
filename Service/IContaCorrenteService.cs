using System.Collections.Generic;
using GigaBank.Dtos;
using GigaBank.Dtos.Response;
using GigaBank.Dtos.Response.ContaCorrente;
using GigaBank.Models;

namespace GigaBank.Service
{
    public interface IContaCorrenteService
    {
        IEnumerable<ContaCorrenteResponse> BuscarTodos();
        ContaCorrente BuscarContaPeloNumero(string numeroDaConta);
        void AdicionaNovaContaCorrente(ContaCorrenteDto contaCorrente);
        void AtualizarContaCorrente(ContaCorrente contaCorrente);
    }
}