namespace DataTransfer.Application.Models
{
    /// <summary>
    /// Источник данных
    /// </summary>
    public class DataSource
    {
        /// <summary>
        /// Идентификатор источника данных
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Наименование источника данных
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Параметры подключения к сторонней базе данных(ConnectionParameters), например, хост, порт, имя пользователя, пароль и другие необходимые параметры.
        /// </summary>
        public string ConnectionParameters { get; set; }

    }
}
