using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEntryAndSearchApp
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void studentEntryButton_Click(object sender, EventArgs e)
        {
            StudentEntryUI aStudentEntryUi=new StudentEntryUI();
            aStudentEntryUi.Show();
        }

        private void studentSearchButton_Click(object sender, EventArgs e)
        {
            StudentSearchUI aStudentSearchUi= new StudentSearchUI();
            aStudentSearchUi.Show();
        }
    }
}
