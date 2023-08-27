using System.ComponentModel.DataAnnotations;

namespace MySqlCoreDemo.Data
{
    public class Person
    {
        public int id { get; set; }

        [MaxLength(50)]
        public string firstName { get; set; }

        [MaxLength(50)]
        public string lastName { get; set; }
        public int age { get; set; }
        public bool isPlayer { get; set; }
    }
}
