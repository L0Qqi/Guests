using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guests
{
    public partial class ClientCardForm : Form
    {
        public ClientCardForm()
        {
            InitializeComponent();
        }
        public char animalscheck;


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void AddValue(string full_name, string bday, string payment, string days, char animals)
        {
            
            this.labelFullName.Text = full_name;
            this.labelBirth.Text = bday;
            this.labelPayment.Text = payment;
            this.labelDays.Text = days;
            this.Animals = '1';
        }
        public new char Animals
        {
            get
            {
                return animalscheck;
            }
            set
            {
                if (value == '1')
                {
                    withAnimalscheckBox.Checked = true;
                }
                else
                {
                    withAnimalscheckBox.Checked = false;
                }
            }
        }
    }
}
