using Abstractions.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.IRepository
{
    interface IStoryRepository
    {
        Story Get(long id);
        IEnumerable<Story> Get(int skip, int take);
        Story Save(Story story);
        void Remove(Story story);
    }
}
