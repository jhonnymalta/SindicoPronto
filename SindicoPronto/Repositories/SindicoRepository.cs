using Microsoft.EntityFrameworkCore;
using SindicoPronto.Data;
using SindicoPronto.Models;

namespace SindicoPronto.Repositories
{
    public class SindicoRepository : ISindicoRepository
    {
        private readonly ApplicationDbContext _context;

        public SindicoRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<Sindico> Create(Sindico sindico)
        {
            if (sindico != null)
            {
                sindico.Nome = sindico.Nome;
                await _context.AddAsync(sindico);
                await _context.SaveChangesAsync();
            } 
            return sindico;
        }

        public async Task<bool> Delete(int sindicoId)
        {
            var sindico = await _context.Sindico.FindAsync(sindicoId);
            if (sindico != null)
            {
                 _context.Sindico.Remove(sindico);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Sindico>> GetAll()
        {
            return await _context.Sindico.ToListAsync();
        }

        public async Task<Sindico> GetById(int sindicoId)
        {
            var sindico = _context.Sindico.Find(sindicoId); 
            if(sindico == null) return new Sindico();
            return sindico;
        }

        public async Task<Sindico> Update(int sindicoId, Sindico sindicoUpdated)
        {
            var sindico = await _context.Sindico.FindAsync(sindicoId);
            if (sindico != null) sindico.Nome = sindicoUpdated.Nome;            
            await _context.SaveChangesAsync();
            return sindico;
            
        }
    }
}
