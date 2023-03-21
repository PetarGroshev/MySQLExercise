using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL
{
    public partial class Form1 : Form
    {
        string connstr = "server=192.168.1.235;" +
        "port=3306;" +
        "user=REMOTE;" +
        "password=Aa123456@;" +
        "database=minions;";
        MySqlConnection connect;






        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
