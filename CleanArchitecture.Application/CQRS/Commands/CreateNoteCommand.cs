using CleanArchitecture.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.CQRS.Commands
{
    public class CreateNoteRequest: IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }


    public class CreateNoteCommand : IRequestHandler<CreateNoteRequest>
    {
        private readonly INotesRepository _notesRepository;
        private readonly IMediator _mediator;

        public CreateNoteCommand(INotesRepository notesRepository, IMediator mediator)
        {
            _notesRepository = notesRepository;
            _mediator = mediator;
        }

        public async Task Handle(CreateNoteRequest request, CancellationToken cancellationToken)
        {
            await _notesRepository.PostNotes();
        }
    }
}
