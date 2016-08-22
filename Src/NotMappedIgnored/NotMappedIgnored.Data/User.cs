using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotMappedIgnored.Data
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [NotMapped]
        public Guid[] Tokens { get; set; }
    }
}
