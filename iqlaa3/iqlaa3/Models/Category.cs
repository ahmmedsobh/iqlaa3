using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace iqlaa3.Models
{
    [Table("Category")]
    public class Category
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descrption { get; set; }
        public string ImgUrl { get; set; }


        [OneToMany]
        public List<Website>  websites { get; set; }
    }
}
