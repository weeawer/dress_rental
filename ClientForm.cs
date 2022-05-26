using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LR8
{
    public partial class ClientForm : Form
    {
        Rents rents = new Rents();
        Clients clients = new Clients();
        Dresses dresses = new Dresses();
        AddServices addServices = new AddServices();
        
        int currentId;
        internal ClientForm(Rents rents, Dresses dresses, Clients clients, AddServices addServices)
        {
            InitializeComponent();
            this.rents = rents;
            this.clients = clients;
            this.dresses = dresses; 
            this.addServices = addServices;
        }
        int currentID;
        internal ClientForm(int currentID, Rents rents, Dresses dresses, Clients clients, AddServices addServices)//конструктор для открытия формы уже существующего клиента
        {
            InitializeComponent();
            this.currentID = currentID;
            this.rents = rents; 
            this.clients = clients;
            this.dresses = dresses; 
            this.addServices = addServices;
        }
        private void ClientForm_Load(object sender, EventArgs e)//загрузка формы клиента
        {
            BuildDressesBox();
            BuildClientsBox();
            BuildPeriodsBox();
            
            BuildAddServicesListBox();//заполнение списка доп.услуг
            if (currentID == 1)//заполнение формы существующего клиента
            {
                Rent currentRent = rents.FindByID(currentID);
                FillForm(currentRent);
            }
            else//при пустом списке клиентов
            {
                Rent newRent = new Rent(1);
            }
        }
        private void FillForm(Rent rent)//заполнение формы клиента
        {
            currentId = rent.ID;
            if (rent.Client != null)
            {
                clientsBox.SelectedItem = rent.Client.FIO;
            }
            else
            {
                clientsBox.SelectedIndex = 0;
            }
            if (rent.Dress != null) 
            { 
                dressesBox.SelectedItem = rent.Dress.Model;
            }
            else
            {
                dressesBox.SelectedIndex = 0;
            }
            priceBox.Text = rent.Price.ToString();
            depositBox.Text = rent.Deposit.ToString();
            rentsBox.Text = rent.Period.ToString();
            addCl.Text = rent.ClientNumber;

            for (int i = 0; i < DopYslygiListBox.Items.Count; i++)//простановка галочек в листбоксе
            {
                if (rent.AddServices.Contains(i)){ DopYslygiListBox.SetItemChecked(i, true); }
                else{ DopYslygiListBox.SetItemChecked(i, false); }
            }
            this.Text = "Аренда №" + rent.ID.ToString();
        }
        private void BuildClientsBox()//заполнение списка машин
        {
            foreach (Client client in clients.GetAllClients())
            {
                clientsBox.Items.Add(client.FIO);
            }
        }
        private void BuildDressesBox()//заполнение списка машин
        {
            foreach (Dress dress in dresses.GetAllDresses())
            {
                dressesBox.Items.Add(dress.Model);
            }
        }
        private void BuildPeriodsBox()//заполнение списка сроков
        {
            for (int i = 1;i <= 50; i++)
            {
                    rentsBox.Items.Add(i);
            }
        }
       
        private void BuildAddServicesListBox()//заполнение списка листбокса доп.услуг
        {
            foreach (AddService add in addServices.GetAddServices())
            {
                DopYslygiListBox.Items.Add(add.Name);
            }
        }
        private void SaveThisForm()//сохранение обновленной (или нет) формы
        {
            Rent rent = rents.FindByID(currentId);
            rent.ID = currentId;

            rent.Client = clients.findByFIO(clientsBox.Text);
            rent.Dress = dresses.findByModel(dressesBox.Text);

            rent.Deposit = decimal.Parse(depositBox.Text);
            rent.ClientNumber = addCl.Text;
            
            rent.Period = int.Parse(rentsBox.GetItemText(rentsBox.Text));
            List<int> list = new List<int>();
            rent.AddServices = list;
           
            foreach (string elem in DopYslygiListBox.CheckedItems)
            {
                AddService ads = addServices.FindByName(elem);
                rent.AddServices.Add(ads.ID);
            }
            rents.ReplaceInfoRent(rent);

        }

        private void saveButton_Click(object sender, EventArgs e)//сохранение в файл
        {
            SaveThisForm();
            rents.saveRents();
            MessageBox.Show("Данные успешно сохранены!");
        }
        private void deleteClient_Click(object sender, EventArgs e)//удаление клиента и открытие формы другого клиента
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить аренду?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Rent rent = rents.FindByID(currentId);
                Rent next = rents.GetNext(currentId);
                if (next.ID == currentId)
                {
                    next = rents.GetPrevious(currentId);
                    if (next.ID == currentId)
                    {
                        int ID = rents.GetMaxID() + 1;
                        next = new Rent(ID);
                        rents.AddRent(next);
                    }
                }
                rents.DelRent(rent);
                FillForm(next);
            }
        }

        private void newClient_Click(object sender, EventArgs e)//создание нового клиента
        {
            if (addCl.Text == "")
            {
                MessageBox.Show("Вы не можете создать новую форму, так как текущая форма незаполненна полностью!");
            }
            else
            {
                SaveThisForm();
                int id = rents.GetMaxID() + 1;
                Rent rent = new Rent(id);
                rents.AddRent(rent);
                FillForm(rent);
                clientsBox.SelectedIndex = 0;
                dressesBox.SelectedIndex = 0;
                priceBox.Text = dresses.GetAllDresses()[0].Price.ToString();
                depositBox.Text = dresses.GetAllDresses()[0].Deposit.ToString();
                rentsBox.SelectedIndex = 0;
                
                addCl.Text = "";
                DopYslygiListBox.ClearSelected();
            }
        }

        private void next_Click(object sender, EventArgs e)//перемещение к след.клиенту
        {
            SaveThisForm();
            Rent rent = rents.GetNext(currentId);
            addCl.Text = "";
            FillForm(rent);
        }

        private void previous_Click(object sender, EventArgs e)//перемещение к предыдущему клиенту 
        {
            SaveThisForm();
            Rent rent = rents.GetPrevious(currentId);
            addCl.Text = "";
            FillForm(rent);
        }

        private void backToListButton_Click(object sender, EventArgs e)//возвращение к списку клиентов
        {
            this.Hide();
            this.Show();
            Close();
        }
        private void Calculator(object sender, EventArgs e)
        {
            List<AddService> ads = addServices.GetAddServices();
            decimal p = 0m;
            foreach (string elem in DopYslygiListBox.CheckedItems)
            {
                AddService adds = addServices.FindByName(elem);
                p += adds.Price;
            }
            try
            {
                cost.Text = (decimal.Parse(priceBox.Text) * decimal.Parse(rentsBox.Text) + p).ToString() + " рублей";
            }
            catch { cost.Text = "0 рублей"; }
        }
       
        private void pricesBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;
        }

        private void depositsBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            pricesBox_KeyPress(sender, e);
        }

        private void periodsBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            pricesBox_KeyPress(sender, e);
        }

        private void addServicesListBox_Click(object sender, EventArgs e)
        {
            DopYslygiListBox.CheckOnClick = true;
        }

        private void priceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;
        }

        private void BoundPrice(object sender, EventArgs e)
        {
            string nameModel = dressesBox.GetItemText(dressesBox.SelectedItem);
            decimal recomP = dresses.findByModel(nameModel).Price / 2;
            decimal pr = decimal.Parse(priceBox.Text);
            if (pr < recomP)
            {
                MessageBox.Show("Вы ввели слишком низкую цену!");
                priceBox.Text = dresses.findByModel(nameModel).Price.ToString();
            }
        }

        private void BoundDeposit(object sender, EventArgs e)
        {
            string nameModel = dressesBox.GetItemText(dressesBox.SelectedItem);
            decimal recomD = dresses.findByModel(nameModel).Deposit / 2;
            decimal de = decimal.Parse(depositBox.Text);
            if (de < recomD)
            {
                MessageBox.Show("Вы ввели слишком маленький залог!");
                depositBox.Text = dresses.findByModel(nameModel).Deposit.ToString();
            }
        }

        private void dressesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dress dress = dresses.GetAllDresses().Find(d => d.Model == dressesBox.Text);
            priceBox.Text = dress.Price.ToString();
            depositBox.Text = dress.Deposit.ToString();
        }
    }
}
