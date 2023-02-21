using System.Collections.Generic;
using System.IO;
using System.Linq;
using GigaBank.Context;
using GigaBank.Models;
using Newtonsoft.Json;

namespace GigaBank.Dao.Implementacoes
{
    public class ContaCorrenteDao: IContaCorrenteDao
    {
        private readonly ContextModel _db;

        public ContaCorrenteDao(ContextModel contextModel)
        {
            this._db = contextModel;
        }
        
        public List<ContaCorrente> BuscarTodos()
        {
            return _db.ContaCorrentes.ToList();
        }
        public ContaCorrente BuscarContaPeloNumero(string numeroDaConta)
        {
            return _db.ContaCorrentes.First(l => l.Conta == numeroDaConta);
        }

        public void Adiciona(ContaCorrente contaCorrente)
        {
            _db.ContaCorrentes.Add(contaCorrente);
            this.SaveChanges();
        }
        
        public void Atualizar(ContaCorrente contaCorrente)
        {
            _db.Update(contaCorrente);
            this.SaveChanges();
        }

        private void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}