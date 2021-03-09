using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.ISecurity
{
    public static class Restrictions
    {
        public const string EditorRoles = RoleNames.Admin + " , " + RoleNames.Moderator + " , " + RoleNames.User;
    }
}
