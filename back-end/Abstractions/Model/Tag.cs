using System.Diagnostics.CodeAnalysis;

namespace Abstractions.Model
{
    /// <summary> Tag for <seealso cref="Story"/> </summary>
    [ExcludeFromCodeCoverage]
    public class Tag
    {
        /// <summary> Unique id or <c>null</c> if tag is brand new </summary>
        public long? Id { get; set; }

        /// <summary> Unique name </summary>
        public string Name { get; set; }

        /// <summary> Is hub tag? </summary>
        public bool IsHub { get; set; }

        /// <summary> Tag description </summary>
        public string Description { get; set; }

        /// <summary> Amount of <seealso cref="Story"/> entities with current tag </summary>
        public int Count { get; set; }
    }
}
