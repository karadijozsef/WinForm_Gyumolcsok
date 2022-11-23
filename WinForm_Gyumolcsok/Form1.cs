using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinForm_Gyumolcsok
{
    public partial class Form1 : Form
    {
        Adatbazis adatbazis = new Adatbazis();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gyumolcsBetoltese();
        }

        private void gyumolcsBetoltese()
        {
            listBox_gyumolcsok.Items.Clear();
            foreach (gyumolcs item in adatbazis.getAllGyumolcs())
            {
                listBox_gyumolcsok.Items.Add(item);
            }
        }
    }
}
