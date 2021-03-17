﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCore.Models;

namespace WebApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        static List<Player> listPlayers = new List<Player>
        {
            new Player{PId=1,PName="Raj",PDob=DateTime.Parse("12/12/1997"),PTeam="India"},
            new Player{PId=5,PName="Root",PDob=DateTime.Parse("05/06/1995"),PTeam="England"},
            new Player{PId=9,PName="Virat",PDob=DateTime.Parse("01/03/1990"),PTeam="India"},
            new Player{PId=12,PName="Williamson",PDob=DateTime.Parse("08/12/1988"),PTeam="New Zealand"},
            new Player{PId=155,PName="Babar",PDob=DateTime.Parse("06/11/1996"),PTeam="Pakistan"}
        };

        [HttpGet]
        public IEnumerable<Player> Get()
        {
            return listPlayers;
        }
    }
}