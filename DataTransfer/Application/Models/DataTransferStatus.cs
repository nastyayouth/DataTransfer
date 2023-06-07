using System;

namespace DataTransfer.Application.Models
{
    /// <summary>
    /// Модель данных статуса данных
    /// </summary>
    public class DataTransferStatus
    {
        public int ID { get; set; }
        /// <summary>
        /// Идентификатор набора данных
        /// </summary>
        public int DataSetID { get; set; }
        /// <summary>
        /// Статус передачи данных
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Дата создания записи
        /// </summary>
        public DateTime DateCreated { get;set;}
    }
}
