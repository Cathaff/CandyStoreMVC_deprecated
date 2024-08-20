﻿using CandyStore.Interface;
using CandyStore.Services;
using Microsoft.AspNetCore.Mvc;

namespace CandyStore.Controllers
{
    [ApiController]
    [Route("api/candies")]
    public class CandyStoreController : Controller
    {
        private readonly ICandyService _candyService;
        public CandyStoreController(ICandyService candyService) 
        {
            _candyService = candyService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCandies()
        {
            var candies = await _candyService.GetAllCandies();
            return Ok(candies);
        }
    }
}
