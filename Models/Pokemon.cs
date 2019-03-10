using System;
using System.ComponentModel.DataAnnotations;

namespace EfcoreConsoleApp.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}