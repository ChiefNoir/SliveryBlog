using Abstractions.Model;
using System.Collections.Generic;

namespace Abstractions.IRepository
{
    interface ITagRepository
    {
        Tag Get(long id);
        Tag Save(Tag tag);
        void Delete(Tag tag);
        
        IEnumerable<Tag> GetHubs();
    }
}
