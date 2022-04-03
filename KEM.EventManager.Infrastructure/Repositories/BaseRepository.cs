using AutoMapper;
using KEM.EventManager.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.EventManager.Infrastructure.Repositories
{
    public class BaseRepository
    {
        public readonly IMapper _mapper;
        public BaseRepository(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}
