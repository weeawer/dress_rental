using System.Collections.Generic;
using System.Xml;

namespace LR8
{
    class AddServices
    {
        List<AddService> allServices;
        public AddServices()
        {
            allServices = new List<AddService>();
        }
        public void AddService(AddService service) { allServices.Add(service); }
        public AddService FindByName(string name){ return allServices.Find(x => x.Name == name); }
        public List<AddService> GetAddServices(){ return allServices; }
    }
    class AddService
    {
        private int id;
        private string name;
        private int price;
        public AddService(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        public int ID { get { return id; } }
        public string Name{ get { return name; } }
        public int Price{ get { return price; } }
    }
}
