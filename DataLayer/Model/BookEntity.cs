namespace DataLayer.Model
{
    public class BookEntity
    {
        /// <summary>
        /// id
        /// </summary>
        public long Id { get; set; }
        
        /// <summary>
        /// Пролог
        /// </summary>
        public string Prologue { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Title { get; set; }
        
        /// <summary>
        /// Обложка
        /// </summary>
        public byte Image { get; set; }
        
        /// <summary>
        /// Кол. в библиотеке
        /// </summary>
        public int QuantityUnit { get; set; }
        
        /// <summary>
        /// Штраф за утерю
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Категория
        /// </summary>
        public CategoryEntity Сategory { get; set; }

        /// <summary>
        /// библиотека
        /// </summary>
        public LibraryEntity Library { get; set; }


    }
}
