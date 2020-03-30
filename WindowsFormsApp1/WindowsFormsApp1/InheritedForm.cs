using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InheritedForm : WindowsFormsApp1.Form1
    {
        public InheritedForm()
        {
            InitializeComponent();
        }

        private void InheritedForm_Load(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.ToLongDateString();
        }
    }
}
