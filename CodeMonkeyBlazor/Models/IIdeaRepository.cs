using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeMonkeyBlazor.Models
{
    public interface IIdeaRepository
    {
        Task<Idea> AddIdea(Idea idea);
        Task<List<Idea>> GetIdeas();
         
    }
}
