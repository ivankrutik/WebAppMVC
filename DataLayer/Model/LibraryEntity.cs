namespace DataLayer.Model
{
    public class LibraryEntity
    {
        /// <summary>
        /// id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// владелец
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// адресс
        /// </summary>
        public string Adress { get; set; }

        /// <summary>
        /// книги
        /// </summary>
        public List<BookEntity> Books { get; set; }
    }
}