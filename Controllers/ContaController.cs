using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using GigaBank.Dao;
using GigaBank.Dtos;
using GigaBank.Dtos.Response;
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
        
        [HttpGet]
        public IEnumerable<ContaCorrenteResponse> Listar()
        {
            return _contaCorrenteService.BuscarTodos();
        }

        [HttpPost]
        public ActionResult<ContaCorrenteDto> Adicionar(ContaCorrenteDto contaCorrenteDto)
        {
            _contaCorrenteService.AdicionaNovaContaCorrente(contaCorrenteDto);

            return Ok(contaCorrenteDto);
        }
    }
}