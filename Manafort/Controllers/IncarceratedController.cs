﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Manafort.Models;

namespace Manafort.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncarceratedController : ControllerBase
    {
        static List<Incarcerated> Prisoners;

        static IncarceratedController()
        {
            Prisoners = new List<Incarcerated>
            {
                new Incarcerated {Name = "Paul Manafort", PrisonerNo = 001, Interests = "Tax Fraud", Gender = Gender.Male, ActuallyGuilty = true, EducationalLevel = EducationalLevel.GradSchool, PrefferedVice = "Cigarettes", TypeofCrime = "Fraud", Weapon = "Snakes" },
                new Incarcerated {Name = "Michael Flynn", PrisonerNo = 002, Interests = "Tax Fraud", Gender = Gender.Male, ActuallyGuilty = true, EducationalLevel = EducationalLevel.GradSchool, PrefferedVice = "Russian Vodka", TypeofCrime = "Lying", Weapon = "Mouth"},
                new Incarcerated {Name = "George Papadopulous", PrisonerNo = 004, Interests = "Murder", Gender = Gender.Male, ActuallyGuilty = true, EducationalLevel = EducationalLevel.College, PrefferedVice = "Hookers", TypeofCrime = "Conspiracy", Weapon = "Blow Torch"},
                new Incarcerated {Name = "Michael Cohen ", PrisonerNo = 003,  Interests = "Chess", Gender = Gender.Male, ActuallyGuilty = true, EducationalLevel = EducationalLevel.GradSchool, PrefferedVice = "Cigar", TypeofCrime = "Lying", Weapon ="Manuiplation"},
                new Incarcerated {Name = "Omarosa Manigault Newman ", PrisonerNo = 005, Interests = "Stealing", Gender = Gender.Female, ActuallyGuilty = false, EducationalLevel = EducationalLevel.GradSchool, PrefferedVice = "Fame", TypeofCrime = "Breach of Cotract", Weapon ="Breathe Fire"},
            };
        }

        [HttpGet]
        public ActionResult<IEnumerable<Incarcerated>> GetAll()
        {
            return Prisoners;
        }

        [HttpPost]
        public IActionResult AddAPrisoner (Incarcerated incarcerated)
        {
            Prisoners.Add(incarcerated);
            return Ok();
        }
    }
}