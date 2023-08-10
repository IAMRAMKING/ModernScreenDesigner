using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernScreenDesigner
{
    public partial class NewForm : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string LayoutXml
        {
            get { return this.obDesigner.LayoutXML; }
            set { this.obDesigner.LayoutXML = value; }
        }

        public NewForm()
        {
            InitializeComponent();
        }
        // public When designing, events are available
        public void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click1");
        }
        public void button1_Click2(object sender, EventArgs e)
        {
            MessageBox.Show("Click2");
        }
    }
}
