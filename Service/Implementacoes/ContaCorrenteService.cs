using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using AutoMapper;
using GigaBank.Dao;
using GigaBank.Dtos;
using GigaBank.Dtos.Response;
using GigaBank.Models;

namespace GigaBank.Service.Implementacoes
{
    public class ContaCorrenteService: IContaCorrenteService
    {
        private readonly IContaCorrenteDao _contaCorrenteDao;
        private readonly IMapper _mapper;

        public ContaCorrenteService(IContaCorrenteDao contaCorrenteDao, IMapper mapper)
        {
            this._contaCorrenteDao = contaCorrenteDao;
            this._mapper = mapper;
        }
        
        public IEnumerable<ContaCorrenteResponse> BuscarTodos()
        {
            return this._contaCorrenteDao.BuscarTodos().Select(
                l => this._mapper.Map<ContaCorrenteResponse>(l));
        }

        public void AdicionaNovaContaCorrente(ContaCorrenteDto contaCorrenteDto)
        {
            this._contaCorrenteDao.Adiciona(
                this._mapper.Map<ContaCorrente>(contaCorrenteDto));
        }

        private bool VerificaSeExisteContaCorrente(string titular)
        {
            throw new System.NotImplementedException();
        }
    }
}