using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento() {
                EventoId = 1,
                Tema = "Angular e .NET 5",
                Local = "Belo Horizonte",
                Lote = "Primeiro Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"
            },
            new Evento() {
                EventoId = 2,
                Tema = "Algumas outras coisas sobre Angular",
                Local = "São Paulo",
                Lote = "Segundo Lote",
                QtdPessoas = 50,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "imagem.png"
            }
        };

        public EventoController()
        {
        }

        [HttpGet()]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Post realizado com sucesso";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Put com o id = {id} realizado com sucesso";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Delete com o id = {id} realizado com sucesso";
        }
    }
}