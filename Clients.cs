using System.Collections.Generic;
using System.Xml;

namespace LR8
{
    class Clients
    {
        List<Client> allClients;
        public Clients()
        {
            allClients = new List<Client>();
        }
        public void AddClient(Client client){ allClients.Add(client); }//метод добавления клиента в список
        public void DelClient(Client client){ allClients.Remove(client); }//метод удаления клиента из списка
        public List<Client> GetAllClients() { return allClients;  }
        public void ReplaceInfoClient(Client client)//метод для обновления информации о клиенте
        {
            int index = allClients.FindIndex(x => x.ID == client.ID);
            allClients[index] = client;
        }
        public Client GetPrevious(int id)//получение предыдущего клиента
        {
            int index = allClients.FindIndex(x => x.ID == id);
            if (index > 0)
            {
                return allClients[index - 1];
            }
            return allClients[0];
        }
        public Client GetNext(int id)//получение следующего клиента
        {
            int index = allClients.FindIndex(x => x.ID == id);
            if (index < allClients.Count - 1)
            {
                return allClients[index + 1];
            }
            return allClients[index];
        }
        public int GetMaxID()//получение максимального значения id(последний клиент)
        {
            int max = 0;
            foreach (Client client in allClients)
            {
                if (max < client.ID) max = client.ID;
            }
            return max;
        }
        public Client findByID(int id)//метод для нахождения клиента по id
        {
            return allClients.Find(x => x.ID == id);
        }
        public Client findByFIO(string FIO)//метод нахождения клиента по ФИО
        {
            return allClients.Find(x => x.FIO == FIO);
        }
        public List<string> GetAllFIO()//вывод списка фио клиентов
        {
            List<string> fios = new List<string>();
            foreach (Client client in allClients)
            {
                fios.Add(client.FIO);
            }
            return fios;
        }
    }
    class Client
    {
        private int id;
        private string fio;
        public Client(int id)
        {
            this.id = id;
        }
        public Client(int id, string FIO)
        {
            this.id = id;
            this.fio = FIO;
        }
        public int ID { get { return id; } set { id = value; } }
        public string FIO { get { return fio; } set { fio = value; } }
    }
}
