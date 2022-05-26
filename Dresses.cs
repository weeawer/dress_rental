using System.Collections.Generic;
using System.Xml;

namespace LR8
{
    class Dresses
    {
        List<Dress> allDresses;
        public Dresses()
        {
            allDresses = new List<Dress>();
        }
        public void AddDresses(Dress dress) { allDresses.Add(dress); }
        public List<Dress> GetAllDresses(){ return allDresses; }
        public Dress findByID(int id)//метод для нахождения клиента по id
        {
            return allDresses.Find(x => x.ID == id);
        }
        public Dress findByModel(string model)//метод для нахождения клиента по id
        {
            return allDresses.Find(x => x.Model == model);
        }
    }
    class Dress
    {
        int id; 
        private string model;
        private int price;
        private int deposit;
        public Dress(int id, string model, int price, int deposit)
        {
            this.id = id; 
            this.model = model;
            this.price = price;
            this.deposit = deposit;
        }
        public int ID { get { return id; } }
        public string Model { get { return model; } }
        public int Price { get { return price; } }
        public int Deposit { get { return deposit; } }

        public override string ToString() => $"{ID};{Model};{Price};{Deposit}";
    }
}

