﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Space.Models;

namespace Space.Controllers
{
    public class ImagesController : Controller
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly SpaceContext _context;

        public ImagesController(SpaceContext context, IWebHostEnvironment webhost)
        {
            _context = context;
            webHostEnvironment = webhost;
        }

        [HttpGet]
        public IActionResult Create()
        {
            Planets planets = new Planets();
            return View(planets);
        }

        public IActionResult Index()
        {
            List<Planets> planets;
            planets = _context.Images.ToList();
            return View(planets);
        }
    }
}
