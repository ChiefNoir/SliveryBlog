using System.Diagnostics.CodeAnalysis;

namespace Abstractions.Model
{
    [ExcludeFromCodeCoverage]
    /// <summary> Account </summary>
    public class Account
    {
        /// <summary> Unique id or <c>null</c> if account is brand new </summary>
        public int? Id { get; set; }

        /// <summary> Name </summary>
        public string Name { get; set; }

        /// <summary> Password as a hex string </summary>
        public string Password { get; set; }

        /// <summary> Is user admin? </summary>
        public bool IsAdmin { get; set; }

        /// <summary> Avatar url </summary>
        public string AvatarURL { get; set; }

        /// <summary> Account description</summary>
        public string Description { get; set; }

        /// <summary> Entity version </summary>
        public long Version { get; set; }
    }
}
