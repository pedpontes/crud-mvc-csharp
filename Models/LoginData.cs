
using System.Text.Json.Serialization;

namespace crud_api_view.Models{
    }
    public class LoginData{
        [JsonPropertyName("username")]   //definição da propriedade JSON em POST
        public string Name { get; set; }
        [JsonPropertyName("pass")]   //definição da propriedade JSON em POST
        public string Pass { get; set; }
        
        public LoginData() { }
}