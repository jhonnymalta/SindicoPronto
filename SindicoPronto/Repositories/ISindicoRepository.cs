using SindicoPronto.Models;

namespace SindicoPronto.Repositories
{
    public interface ISindicoRepository
    {
        public Task<List<Sindico>> GetAll();
        public Task<Sindico> GetById(int sindicoId);
        public Task<Sindico> Create(Sindico sindico);
        public Task<Sindico> Update(int sindicoId,Sindico sindicoUpdated);
        public Task<bool> Delete(int sindicoId);


    }
}
