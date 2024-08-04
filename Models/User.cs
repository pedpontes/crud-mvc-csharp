
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace crud_api_view.Models{
    public class User{
        public int Id { get; set;}
        public string Name { get; set;}
        public int Age { get; set;}
        [BindProperty(Name = "pass")]
        public string Password { get; set;}
    }
}