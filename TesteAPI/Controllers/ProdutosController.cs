using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TesteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly AppDbContext _context;

    }
}
