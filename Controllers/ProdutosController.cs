using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MeuPrimeiroCrud.Data;
using MeuPrimeiroCrud.Models;

namespace MeuPrimeiroCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly AppDbContext _context;

        // Injeção de Dependência: O sistema nos entrega o banco pronto para uso
        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }

        // 1. CREATE (Criar)
        [HttpPost]
        public async Task<ActionResult<Produto>> PostProduto(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();

            // Retorna 201 Created e o local para consultar o novo item
            return CreatedAtAction(nameof(GetProduto), new { id = produto.Id }, produto);
        }

        // 2. READ (Ler Tudo)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
        {
            return await _context.Produtos.ToListAsync();
        }

        // 2. READ (Ler por ID)
        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetProduto(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);

            if (produto == null) return NotFound(); // Retorna 404

            return produto;
        }

        // 3. UPDATE (Atualizar)
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduto(int id, Produto produto)
        {
            if (id != produto.Id) return BadRequest();

            // Marca o objeto como modificado
            _context.Entry(produto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Produtos.Any(e => e.Id == id)) return NotFound();
                else throw;
            }

            return NoContent(); // Retorna 204 (Sucesso sem conteúdo)
        }

        // 4. DELETE (Apagar)
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduto(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null) return NotFound();

            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
