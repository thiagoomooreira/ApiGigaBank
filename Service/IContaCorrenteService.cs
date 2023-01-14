using System.Collections.Generic;
using GigaBank.Dtos;
using GigaBank.Dtos.Response;
using GigaBank.Models;

namespace GigaBank.Service
{
    public interface IContaCorrenteService
    {
        IEnumerable<ContaCorrenteResponse> BuscarTodos();
        void AdicionaNovaContaCorrente(ContaCorrenteDto contaCorrente);
    }
}