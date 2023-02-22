using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using GigaBank.Dao;
using GigaBank.Dtos;
using GigaBank.Dtos.Response;
using GigaBank.Dtos.Response.ContaCorrente;
using GigaBank.Models;
using GigaBank.Service;
using Microsoft.AspNetCore.Mvc;

namespace GigaBank.Controllers
{
    [ApiController][Route("api/[controller]")]
    public class ContaController : ControllerBase
    {
        private readonly IContaCorrenteService _contaCorrenteService;

        public ContaController(IContaCorrenteService contaCorrenteService)
        {
            this._contaCorrenteService = contaCorrenteService;
        }
        
        [HttpGet][Route("/Listar")]
        public IEnumerable<ContaCorrenteResponse> Listar()
        {
            return _contaCorrenteService.BuscarTodos();
        }

        [HttpPost][Route("/AbrirNovaConta")]
        public ActionResult<ContaCorrenteDto> AbrirNovaConta(ContaCorrenteDto contaCorrenteDto)
        {
            _contaCorrenteService.AdicionaNovaContaCorrente(contaCorrenteDto);

            return Ok(contaCorrenteDto);
        }

        [HttpGet][Route("/Depositar")]
        public ActionResult Depositar(string numeroConta, decimal valor)
        {
            try
            {
                ContaCorrente contaCorrente = 
                    this._contaCorrenteService.BuscarContaPeloNumero(numeroConta);

                this._contaCorrenteService.DepositarValor(contaCorrente, valor);
                
                return new JsonResult(new
                {
                    mensagem = "Deposito realizado!"
                });
            }
            catch (Exception e)
            {
                return new JsonResult(new
                {
                    mensagem = e.Message
                });
            }
        }
    }
}