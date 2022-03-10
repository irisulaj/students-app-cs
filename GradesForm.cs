using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gradesApp
{
    public partial class GradesForm : Form
    {
        public GradesForm()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            StudentForm form = new StudentForm();

            form.ShowDialog();
        }
    }
}
