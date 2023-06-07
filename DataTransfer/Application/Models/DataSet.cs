namespace DataTransfer.Application.Models
{
    /// <summary>
    /// Набор данных
    /// </summary>
    /// 
    public class DataSet
    {
        /// <summary>
        /// Идентификатор набора данных
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Наименование набора данных
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Идентификатор связанного источника данных 
        /// </summary>
        public int DataSourceID { get; set; }
        /// <summary>
        /// Список полей с информацией о названии колонки и типе данных
        /// </summary>
        public string Fields { get; set; }

    }
}
