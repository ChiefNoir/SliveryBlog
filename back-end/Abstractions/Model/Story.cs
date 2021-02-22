using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace Abstractions.Model
{
    /// <summary> Story </summary>
    [ExcludeFromCodeCoverage]
    public class Story
    {
        /// <summary> Unique id or <c>null</c> if story is brand new </summary>
        public ulong? Id { get; set; }

        /// <summary> Creation date </summary>
        public DateTime CreationDate { get; set; }

        /// <summary> Title </summary>
        public string Title { get; set; }

        /// <summary> Subtitle </summary>
        public string SubTitle { get; set; }

        /// <summary> Content </summary>
        public StringBuilder Content { get; set; }

        /// <summary> List of <see cref="Tag"/>s</summary>
        public List<Tag> Tags { get; set; }

        /// <summary> <see cref="Account"/> wich created story </summary>
        public Account Author { get; set; }
    }
}
