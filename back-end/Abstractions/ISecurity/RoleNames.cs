using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Abstractions.ISecurity
{
    [ExcludeFromCodeCoverage]
    public static class RoleNames
    {
        public const string Admin = "admin";
        public const string Moderator = "moderator";
        public const string User = "user";

        public static List<string> GetRoles()
        {
            return new List<string>
            {
                Admin,
                Moderator,
                User
            };
        }
    }
}
