using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace iqlaa3.Models
{
    [Table("Website")]
    public class Website
    {
        [PrimaryKey,AutoIncrement ]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descrption { get; set; }
        public string Url { get; set; }
        public string Imgurl { get; set; }
        public bool IsVaforite { get; set; }
        public bool IsTrend { get; set; }
        public bool IsSaved { get; set; }

        [ForeignKey(typeof(Category))]
        public int CategoryId { get; set; }
    }
}
