
using System.Text.Json.Serialization;

namespace rinha_backend_cs.Model{
    public class LoginData{
        // public int Id { get; set;}
        public string Name { get; set;}
        public string Pass { get; set;}

        public LoginData(string name, string pass){
            Name = name;
            Pass = pass;
        }
    }
}