using System;
using System.Windows.Forms;
using System.Xml;

namespace LR8
{    public partial class Form1 : Form
    {
        Dresses dresses = new Dresses();
        Clients clients = new Clients();
        AddServices addServices = new AddServices();
        Rents rents = new Rents();
        public Form1()
        {
            InitializeComponent();
            FileOperations.ReadAll(out dresses, out addServices, out clients, out rents);
        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (FileOperations.CheckLogin(loginField.Text, passwordField.Text))
            {
                int currentID = 1;
                ClientForm clientForm = new ClientForm(currentID, rents, dresses, clients, addServices);
                this.Hide();
                clientForm.ShowDialog();
                this.Show();
                Close();
            }
            else
                MessageBox.Show("Введен неправильный логин или пароль!");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(sender,e);
            }
            if (e.KeyCode == Keys.Down)
            {
                passwordField.Select();
            }
            if (e.KeyCode == Keys.Up)
            {
                loginField.Select();
            }
        }
    }
}
