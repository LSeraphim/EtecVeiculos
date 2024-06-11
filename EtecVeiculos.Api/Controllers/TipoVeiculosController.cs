using EtecVeiculos.Api.Data;
using EtecVeiculos.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EtecVeiculos.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TipoVeiculosController : ControllerBase
{
    private readonly AppDbContext _context;

    public TipoVeiculosController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<TipoVeiculo>>> Get()
    {
        var tipos = await _context.TipoVeiculos.ToListAsync();
        return Ok(tipos);
    }
}
