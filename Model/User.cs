
namespace rinha_backend_cs.Model{
    public class User{
        public int Id { get; set;}
        public string Name { get; set;}
        public int Age { get; set;}

        public User() { }

        public User(int id, string name, int age){
            Id = id;
            Name = name;
            Age = age;
        }
    }
}