using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guests
{
    public partial class mainForm : Form
    {
        public ClientCardForm card;
        public List<Person> persons = new List<Person>();
        public string FullName;
        public string DayOfBirth;
        public string Payment;
        public string Days;
        public char Animals;
        public bool IsClientCardOpend;
        public int num;
        public mainForm()
        {
            InitializeComponent();
            DataInitialization();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void splitter3_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Reserved_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.labelTime.Text = DateTime.Now.ToString("hh:mm:ss");
            int hours = int.Parse(DateTime.Now.ToString("HH"));
            if (hours > 12)
            {
                labelAMPM.Text = "PM";
            }
            else
            {
                labelAMPM.Text = "AM";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void ClientsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Free_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Employed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Leave_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void DataInitialization()
        {
            pictureOfClient.Visible = false;
            roomNumberLabel.Visible = false;
            stLabel.Visible = false;
            statusLabel.Visible = false;
            FullNameLabel.Visible = false;
            gBDateOfEnter.Visible = false;
            gBDateOfLeaving.Visible = false;
            
            foreach (var line in File.ReadLines(@"./../../Clients.txt"))
            {
                var client = line.Split('|');
                persons.Add(new Person(client[0], client[1], client[2], client[3], client[4], char.Parse(client[5]), client[6], client[7], client[8], client[9]));
            }
            foreach (var person in persons)
            {
                ClientsList.Rows.Add(person.full_name, person.status, person.room);
            }
        }
        private void ClientsList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            num = ClientsList.CurrentCell.RowIndex;
            roomNumberLabel.Text = $"Номер № {persons[num].room}";
            statusLabel.Text = persons[num].status;
            FullNameLabel.Text = persons[num].full_name;
            DateOfEnter.Text = persons[num].date_of_entering;
            DateOfLeaving.Text = persons[num].date_of_leaving;
            pictureOfClient.Image = Image.FromFile(persons[num].image);
            pictureOfClient.Visible = true;
            roomNumberLabel.Visible = true;
            stLabel.Visible = true;
            statusLabel.Visible = true;
            FullNameLabel.Visible = true;
            gBDateOfEnter.Visible = true;
            gBDateOfLeaving.Visible = true;
            GetInfo();
            

        }
        
            
        private void GetInfo()
        {
            card = new ClientCardForm();
            {
                FullName = persons[num].full_name;
                DayOfBirth = persons[num].bday;
                Payment = persons[num].payment;
                Days = persons[num].days;
                Animals = '1';
                
            };
            IsClientCardOpend = true;
        }

        private void DateOfEnter_Click(object sender, EventArgs e)
        {

        }

        private void GBDateOfEnter_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IsClientCardOpend)
            {
                ClientCardForm card = new ClientCardForm();
                card.AddValue(FullName, DayOfBirth, Payment, Days, Animals);
                card.Show();
            }
            else
            {
                MessageBox.Show("Выберите клиента");
            }    
        }

        private void ClientsList_DoubleClick(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ClientsList.Rows.Count; i++)
            {
                ClientsList.Rows[i].Visible = ClientsList[1, i].Value.ToString() == "зарезервировано";
            }
        }

        private void rBFree_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ClientsList.Rows.Count; i++)
            {
                ClientsList.Rows[i].Visible = ClientsList[1, i].Value.ToString() == "свободно";
            }
        }

        private void rBEmployed_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ClientsList.Rows.Count; i++)
            {
                ClientsList.Rows[i].Visible = ClientsList[1, i].Value.ToString() == "занято";
            }
        }

        private void rBLeave_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ClientsList.Rows.Count; i++)
            {
                ClientsList.Rows[i].Visible = ClientsList[1, i].Value.ToString() == "выписывается";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ClientsList.Rows.Count; i++)
            {
                if (textBoxSearch.Text != String.Empty)
                {
                    ClientsList.Rows[i].Visible = false;
                }
                for (int c = 0; c < ClientsList.Columns.Count; c++)
                {
                    if (ClientsList[c, i].Value.ToString().Contains(textBoxSearch.Text))
                    {
                        ClientsList.Rows[i].Visible = true;
                        break;
                    }
                }
            }
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ClientsList.Rows.Count; i++)
            {
                ClientsList.Rows[i].Visible = true;
            }
        }
    }
    public class Person
    {
        public string full_name;
        public string status;
        public string room;
        public string bday;
        public string days;
        public char animals;
        public string payment;
        public string date_of_entering;
        public string date_of_leaving;
        public string image;
        public Person(string full_name, string status, string room, string bday, string days, char animals, string payment, string date_of_entering, string date_of_leaving, string image)
        {
            this.full_name = full_name;
            this.status = status;
            this.room = room;
            this.bday = bday;
            this.days = days;
            this.animals = animals;
            this.payment = payment;
            this.date_of_entering = date_of_entering;
            this.date_of_leaving = date_of_leaving;
            this.image = image;
        }
    }
}
