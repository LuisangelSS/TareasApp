using BudgetControlApp.Data;
using BudgetControlApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BudgetControlApp.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ApplicationDbContext _context;

        public CategoriaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Categoria>> GetAllAsync()
        {
            return await _context.Categorias.ToListAsync();
        }

        public async Task<Categoria> GetByIdAsync(int id)
        {
            return await _context.Categorias.FindAsync(id);
        }

        public async Task AddAsync(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Categoria categoria)
        {
            _context.Categorias.Update(categoria);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var categoria = await _context.Categorias.FindAsync(id);
            if (categoria != null)
            {
                _context.Categorias.Remove(categoria);
                await _context.SaveChangesAsync();
            }
        }
    }
}
