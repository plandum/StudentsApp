using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace StudentsApp
{
    [Table("Students")]
    public class Students
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Group { get; set; }
        public string FIO { get; set; }
    }
}
