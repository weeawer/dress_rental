//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR8
{
    class Rents
    {
        List<Rent> allRents;
        public Rents()
        {
            allRents = new List<Rent>();
        }
        public Rent FindByID(int id)//метод для нахождения клиента по id
        {
            return allRents.Find(x => x.ID == id);
        }
        public void saveRents()//сохранение данных всех клиентов в xml-файл
        {
            FileOperations.SaveRents(allRents);
        }
        public void AddRent(Rent rent) { allRents.Add(rent); }//метод добавления клиента в список
        public void DelRent(Rent rent) { allRents.Remove(rent); }
        public void ReplaceInfoRent(Rent rent)//метод для обновления информации 
        {
            int index = allRents.FindIndex(x => x.ID == rent.ID);
            allRents[index] = rent;
        }
        public Rent GetPrevious(int id)//получение предыдущей аренды 
        {
            int index = allRents.FindIndex(x => x.ID == id);
            if (index > 0)
            {
                return allRents[index - 1];
            }
            return allRents[0];
        }
        public Rent GetNext(int id)//получение следующего аренды
        {
            int index = allRents.FindIndex(x => x.ID == id);
            if (index < allRents.Count - 1)
            {
                return allRents[index + 1];
            }
            return allRents[index];
        }
        public int GetMaxID()//получение максимального значения id(последний клиент)
        {
            int max = 0;
            foreach (Rent rent in allRents)
            {
                if (max < rent.ID) max = rent.ID;
            }
            return max;
        }
    }
    class Rent
    {
        private int id;
        private Client client;
        private Dress dress;
        private string clientNumber;
        private decimal price;//цена за 1 день
        private decimal deposit;//залог
        private int period;//срок проката
        private List<int> addservices = new List<int>();//список дополнительных услуг
        public Rent (int id)
        {
            this.id = id;
        }
        public Rent (int id, Client client, Dress dress, string clientNumber, decimal price, decimal deposit, int period,List<int> addservices)
        {
            this.id = id;
            this.client = client;
            this.dress = dress;
            this.clientNumber = clientNumber;
            this.price = price;
            this.deposit = deposit;
            this.period = period;
            this.addservices = addservices;
        }
        public int ID { get { return id; } set { id = value; } }
        public Client Client { get { return client; } set { client = value; } }
        public Dress Dress { get { return dress; } set { dress = value; } }
        public string ClientNumber { get { return clientNumber; } set { clientNumber = value; } }
        public int Period { get { return period; } set { period = value; } }
        public decimal Price { get { return price; } set { price = value; } }
        public decimal Deposit { get { return deposit; } set { deposit = value; } }
        public List<int> AddServices { get { return addservices; } set { addservices = value; } }

        public override string ToString() => $"{ID};{ Dress.ID};{ClientNumber};{Period}{Dress.Price};{ Deposit};{AddServices}";


        public string AddServicesString
        {
            get
            {
                string str = "";
                foreach (int elem in addservices)
                {
                    str = str + (elem);
                }
                return str;
            }
        }
        public string GetAddServicesString()
        {
            string str = "";
            foreach (int elem in addservices)
            {
                str = str + (elem);
            }
            return str;
        }
    }
    
}