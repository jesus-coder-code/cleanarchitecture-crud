using AutoMapper;
using CleanArchitecture.Application.CQRS.Queries;
using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Mappings
{
    public class NotesProfile: Profile
    {
        public NotesProfile()
        {
            CreateMap<Notes, NotesResult>();
        }
    }
}
