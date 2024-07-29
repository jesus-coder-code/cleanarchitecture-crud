using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class NotesRepository : INotesRepository
    {

        public Task<Notes> DeleteNote(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Notes>> GetAllNotes()
        {
            //throw new NotImplementedException();
            var notes = new List<Notes>
            {
                new Notes{Id = 1, Name = "tarea1", Description = "hacer tarea 1"},
                new Notes{Id = 2, Name = "tarea2", Description = "hacer tarea 2"},
                new Notes{Id = 3, Name = "tarea3", Description = "hacer tarea 3"}
            };
            return Task.FromResult(notes);
        }

        public Task<List<Notes>> GetNoteById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Notes> PostNotes()
        {
            throw new NotImplementedException();
        }

        public Task<Notes> UpdateNote(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
