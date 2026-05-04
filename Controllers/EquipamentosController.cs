using Microsoft.AspNetCore.Mvc;
using ValeAtivos324147097.Data;
using ValeAtivos324147097.Models;

namespace ValeAtivos324147097.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EquipamentosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EquipamentosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Criar(Equipamento equipamento)
        {
            _context.Equipamentos.Add(equipamento);
            _context.SaveChanges();
            return Ok(equipamento);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_context.Equipamentos.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Buscar(int id)
        {
            var equipamento = _context.Equipamentos.Find(id);

            if (equipamento == null)
                return NotFound();

            return Ok(equipamento);
        }
    }
}