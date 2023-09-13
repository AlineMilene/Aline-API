using System.Net;
using Aline.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aline.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClienteController : ControllerBase
{
    private readonly ILogger<ClienteController> _logger;

    public ClienteController(ILogger<ClienteController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "CadastrarCliente")]
    public async Task<IActionResult> PostClient([FromBody] Cliente cliente)
    {
        try
        {
            return Ok(cliente);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode((int)HttpStatusCode.InternalServerError, HttpStatusCode.InternalServerError.ToString());
        }
    }

    [HttpGet(Name = "ListarTodosCliente")]
    public async Task<IActionResult> GetAllClients()
    {
        try
        {
            return Ok($" Retornando todos clientes: {1}, {2}, {3}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode((int)HttpStatusCode.InternalServerError, HttpStatusCode.InternalServerError.ToString());
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetDetailClient(int id)
    {
        try
        {
            return Ok($" Retornando os detalhes do cliente {id}: aaaa");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode((int)HttpStatusCode.InternalServerError, HttpStatusCode.InternalServerError.ToString());
        }
    }
}
