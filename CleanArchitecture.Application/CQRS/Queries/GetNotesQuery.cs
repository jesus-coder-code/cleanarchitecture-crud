using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.CQRS.Queries
{

    public class NotesRequest: IRequest<IList<NotesResult>>
    {

    }

    public class NotesResult
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
    public class GetNotesQuery : IRequestHandler<NotesRequest, IList<NotesResult>>
    {
        private readonly INotesRepository _notesRepository;
        private readonly IMapper _mapper;

        public GetNotesQuery(INotesRepository notesRepository, IMapper mapper)
        {
            _notesRepository = notesRepository;
            _mapper = mapper;
        }

        public async Task<IList<NotesResult>> Handle(NotesRequest request, CancellationToken cancellationToken)
        {
            var retorno = await _notesRepository.GetAllNotes();
            var result = new List<NotesResult>();
            _mapper.Map(retorno, result);
            return result;
        }
    }
}
