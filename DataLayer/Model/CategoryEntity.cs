namespace DataLayer.Model
{
    public class CategoryEntity
    {
        /// <summary>
        /// id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// наименование
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// картинка категории
        /// </summary>
        public byte[] Picture { get; set; }

        /// <summary>
        /// книги
        /// </summary>
        public List<BookEntity> Books { get; set; }
    }
}
