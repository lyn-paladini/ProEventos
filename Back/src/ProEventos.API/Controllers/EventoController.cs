﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {      
        private readonly DataContext _context;
        public EventoController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet()]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
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