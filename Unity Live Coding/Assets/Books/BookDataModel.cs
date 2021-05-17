using System.Collections.Generic;
using UnityEngine;

namespace Books
{
    [CreateAssetMenu(menuName = "Book", fileName = "NewBook")]
    public class BookDataModel : ScriptableObject
    {
        /// <summary>
        /// The cover of the book
        /// </summary>
        public Texture2D coverImage;

        /// <summary>
        /// The human readable title of the book for display
        /// </summary>
        public string title;

        /// <summary>
        /// The book's author, list first, middle, last
        /// </summary>
        public string author;

        /// <summary>
        /// A short description of the book
        /// </summary>
        public string blurb;

        /// <summary>
        /// Tags for filtering, searching, and sorting books.
        /// </summary>
        public List<string> tags;
    }
}
