using Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Interface
{
    public interface IRaceRepository: IRepository<int, RaceEntity>
    {

    }
}
