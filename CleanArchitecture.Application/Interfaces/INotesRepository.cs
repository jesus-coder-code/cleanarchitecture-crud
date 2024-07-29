using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    public interface INotesRepository
    {
        Task<List<Notes>> GetAllNotes();
        Task<List<Notes>> GetNoteById(int Id);
        Task<Notes> PostNotes();
        Task<Notes> UpdateNote(int Id);
        Task<Notes> DeleteNote(int Id);
    }
}
