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

        public void Adiciona(ContaCorrente contaCorrente)
        {
            _db.ContaCorrentes.Add(contaCorrente);
            this.SaveChanges();
        }

        public ContaCorrente BuscarPorTitular(string titular)
        {
            throw new System.NotImplementedException();
        }

        private void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}