namespace MvcShus.Models
{
    public class Frinds
    {
        public string _name { get; set; }
        public string _age { get; set; }
        public int _id { get; set; }
        public Frinds() { }
        public Frinds(string name, string age,int id)
        {
            _age = age;
            _name = name;
            _id = id;
        }
    }
}
