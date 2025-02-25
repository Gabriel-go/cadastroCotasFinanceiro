﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace cadastroContasFinanceiro.Models
{
    [Table("User")]
    public class User
    {
        [Key()]
        public int Id { get; set; }
        public string Name { get; set; }        
        public string Email { get; set; }
        public string Password { get; set; }

        [JsonIgnore]
        public List<Account> Accounts { get; }
    }
}
