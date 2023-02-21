using System;
using GigaBank.Dtos.Request.Transferencia;
using GigaBank.Exceptions;
using GigaBank.Models;
using GigaBank.Service;
using Microsoft.AspNetCore.Mvc;

namespace GigaBank.Controllers
{
    [ApiController][Route("api/[controller]")]
    public class TransferenciaController : ControllerBase
    {
        private readonly ITransferenciaService _transferenciaService;
        private readonly IContaCorrenteService _contaCorrenteService;

        public TransferenciaController(ITransferenciaService transferenciaService,
            IContaCorrenteService contaCorrenteService)
        {
            this._transferenciaService = transferenciaService;
            this._contaCorrenteService = contaCorrenteService;
        }
        
        [HttpPost]
        public JsonResult Tranferir(TransferenciaDto transferencia)
        {
            try
            {
                ContaCorrente contaCorrenteOrigem = 
                    _contaCorrenteService.BuscarContaPeloNumero(transferencia.ContaOrigem);
                
                ContaCorrente contaCorrenteDestino = 
                    _contaCorrenteService.BuscarContaPeloNumero(transferencia.ContaDestino);
                
                _transferenciaService.Transferir(
                    contaCorrenteOrigem,
                    contaCorrenteDestino,
                    transferencia.Valor);

                return new JsonResult(new
                {
                    Mensagem = "Transferência realizada!"
                });
            }
            catch (Exception e)
            {
                return new JsonResult(new
                {
                    e.Message
                });
            }
        }
    }
}