using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCoperation.Models
{

    public class dbModel:DbContext
    {
        public DbSet<Article> Articles { get; set; }
    }
    public class Article
    {
        public int Id { get; set; }
        [MaxLength(10)]
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
    }
}