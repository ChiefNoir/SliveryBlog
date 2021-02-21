using System.Diagnostics.CodeAnalysis;

namespace Abstractions.Model
{
    [ExcludeFromCodeCoverage]
    /// <summary> Account </summary>
    public class Account
    {
        /// <summary> Unique id or <c>null</c> if account is brand new </summary>
        public int? Id { get; set; }

        /// <summary> Login </summary>
        public string Login { get; set; }

        /// <summary> Password as a hex string </summary>
        public string Password { get; set; }

        /// <summary> Is user admin? </summary>
        public bool IsAdmin { get; set; }

        /// <summary> Entity version </summary>
        public long Version { get; set; }
    }
}
