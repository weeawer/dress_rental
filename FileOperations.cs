using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace LR8
{
    static class FileOperations
    {
        

        public static void ReadAll(out Dresses dresses, out AddServices addServices, out Clients clients, out Rents rents)
        {
            dresses = FileOperations.ReadDresses();
            clients = FileOperations.ReadClients();
            addServices = FileOperations.ReadServices();
            rents = FileOperations.ReadRents(dresses, clients);
        }
        public static bool CheckLogin(string myLogin, string myPassword)
        {
            bool check = false;
            XmlDocument docAuthor = new XmlDocument();
            docAuthor.Load("Data.xml");
            XmlElement xRoot = docAuthor.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                string login = ""; string password = "";
                if (xnode.Name == "User")
                {
                    // получаем атрибут login
                    if (xnode.Attributes.Count > 0)
                    {
                        XmlNode attr = xnode.Attributes.GetNamedItem("login");
                        if (attr != null)
                            login = attr.Value;
                    }
                    // обходим дочерний узел элемента
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "password")
                        {
                            password = childnode.InnerText;
                        }
                    }
                }
                if (login == myLogin && password == myPassword) { check = true; }
            }
            return check;
        }
        public static Dresses ReadDresses()
        {
            Dresses list = new Dresses();
            XmlDocument docDresses = new XmlDocument();
            docDresses.Load("Data.xml");
            XmlElement xRoot = docDresses.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "Dress")
                {
                    int id = 0; string model = ""; int price = 0;
                    int deposit = 0;
                    // получаем атрибут id
                    if (xnode.Attributes.Count > 0)
                    {
                        XmlNode attr = xnode.Attributes.GetNamedItem("id");
                        if (attr != null)
                            id = int.Parse(attr.Value);
                    }
                    // обходим все дочерние узлы элемента
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "model") { model = childnode.InnerText; }
                       
                        if (childnode.Name == "price") { price = int.Parse(childnode.InnerText); }
                        if (childnode.Name == "deposit") { deposit = int.Parse(childnode.InnerText); }
                    }
                    Dress dress = new Dress(id, model, price, deposit);
                    list.AddDresses(dress);
                }
            }
            return list;
        }

        public static Clients ReadClients()
        {
            Clients list = new Clients();
            XmlDocument docDresses = new XmlDocument();
            docDresses.Load("Data.xml");
            XmlElement xRoot = docDresses.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "Client")
                {
                    int id = 0; string fio = ""; 
                    // получаем атрибут id
                    if (xnode.Attributes.Count > 0)
                    {
                        XmlNode attr = xnode.Attributes.GetNamedItem("id");
                        if (attr != null)
                            id = int.Parse(attr.Value);
                    }
                    // обходим все дочерние узлы элемента
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "fio") { fio = childnode.InnerText; }
                    }
                    Client client = new Client(id, fio);
                    list.AddClient(client);
                }
            }
            return list;
        }


        public static AddServices ReadServices()
        {
            AddServices list = new AddServices();
            XmlDocument docClients = new XmlDocument();
            docClients.Load("Data.xml");
            XmlElement xRoot = docClients.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "AddService")
                {
                    int id = 0; string name = ""; int price = 0;
                    if (xnode.Attributes.Count > 0)
                    {
                        XmlNode attr = xnode.Attributes.GetNamedItem("id");
                        if (attr != null) { id = int.Parse(attr.Value); }
                    }
                    // обходим все дочерние узлы элемента
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "name") { name = childnode.InnerText; }
                        if (childnode.Name == "price") { price = int.Parse(childnode.InnerText); }
                    }
                    AddService addService = new AddService(id, name, price);
                    list.AddService(addService);
                }
                // получаем атрибут id
            }
            return list;
        }
        
        public static Rents ReadRents(Dresses dresses, Clients clients)
        {
            Rents list = new Rents();
            XmlDocument docClients = new XmlDocument();
            docClients.Load("Data.xml");
            XmlElement xRoot = docClients.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "Rents")
                {
                    foreach (XmlNode node in xnode.ChildNodes)
                    {
                        int id = 0;
                        Dress dress = null;
                        Client client= null;
                        string clientNumber = ""; 
                        decimal price = 0; 
                        decimal deposit = 0;
                        int period = 0; 
                        List<int> addservices = new List<int>();
                        foreach (XmlNode childnode in node.ChildNodes)
                        {
                            if (childnode.Name == "id") { id = int.Parse(childnode.InnerText); }
                            if (childnode.Name == "ClientID") 
                            { 
                                client = clients.findByID(int.Parse(childnode.InnerText)); 
                            }
                            if (childnode.Name == "DressID")  
                            {
                                dress = dresses.findByID(int.Parse(childnode.InnerText)); 
                            }
                            if (childnode.Name == "ClientNumber") { clientNumber = childnode.InnerText; }
                            
                            if (childnode.Name == "price") { price = decimal.Parse(childnode.InnerText); }
                            if (childnode.Name == "deposit") { deposit = decimal.Parse(childnode.InnerText); }
                            if (childnode.Name == "period") { period = int.Parse(childnode.InnerText); }
                            if (childnode.Name == "addservices")
                            {
                                if (childnode.InnerText.Contains("3")) { addservices.Add(3); }
                                if (childnode.InnerText.Contains("2")) { addservices.Add(2); }
                                if (childnode.InnerText.Contains("1")) { addservices.Add(1); }
                                if (childnode.InnerText.Contains("0")) { addservices.Add(0); }
                            }
                        }
                        Rent rent = new Rent(id, client, dress, clientNumber, price, deposit, period, addservices);
                        list.AddRent(rent);
                    }
                    
                }
            }
            return list;
        }
        public static void SaveRents(List<Rent> allRents)//сохранение данных всех клиентов в xml-файл
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Data.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNodeList childnodes = xRoot.SelectNodes("*");
            foreach (XmlNode n in childnodes)
            {
                if (n.Name == "Rents")
                {
                    xRoot.RemoveChild(n);
                }
            }
            XmlElement rents = xDoc.CreateElement("Rents");
            foreach (Rent rent in allRents)
            {
                // создаем новый элемент client
                XmlElement rentElem = xDoc.CreateElement("Rent");
                // создаем элементы 
                XmlElement IDElem = xDoc.CreateElement("id");
                XmlElement clIDElem = xDoc.CreateElement("ClientID");
                XmlElement dressIDElem = xDoc.CreateElement("DressID");
                XmlElement clAddElem = xDoc.CreateElement("ClientNumber");
                XmlElement priceElem = xDoc.CreateElement("price");
                XmlElement depositElem = xDoc.CreateElement("deposit");
                XmlElement periodElem = xDoc.CreateElement("period");
                XmlElement addservicesElem = xDoc.CreateElement("addservices");
                // создаем текстовые значения для элементов и атрибута
                XmlText IDText = xDoc.CreateTextNode(rent.ID.ToString());
                XmlText clIDText = xDoc.CreateTextNode(rent.Client.ID.ToString());
                XmlText dressIDText = xDoc.CreateTextNode(rent.Dress.ID.ToString());
                XmlText clAddText = xDoc.CreateTextNode(rent.ClientNumber);
                
                XmlText priceText = xDoc.CreateTextNode(rent.Price.ToString());
                XmlText depositText = xDoc.CreateTextNode(rent.Deposit.ToString());
                XmlText periodText = xDoc.CreateTextNode(rent.Period.ToString());
                XmlText addservicesText = xDoc.CreateTextNode(rent.AddServicesString);
                //добавляем узлы
                IDElem.AppendChild(IDText);
                clIDElem.AppendChild(clIDText);
                dressIDElem.AppendChild(dressIDText);
                clAddElem.AppendChild(clAddText);
                
                priceElem.AppendChild(priceText);
                depositElem.AppendChild(depositText);
                periodElem.AppendChild(periodText);
                addservicesElem.AppendChild(addservicesText);

                rentElem.AppendChild(IDElem);
                rentElem.AppendChild(clIDElem);
                rentElem.AppendChild(dressIDElem);
                rentElem.AppendChild(clAddElem);
                
                rentElem.AppendChild(priceElem);
                rentElem.AppendChild(depositElem);
                rentElem.AppendChild(periodElem);
                rentElem.AppendChild(addservicesElem);

                rents.AppendChild(rentElem);
            }
            xRoot.AppendChild(rents);
            xDoc.Save("Data.xml");
        }
        
    }
}

        
