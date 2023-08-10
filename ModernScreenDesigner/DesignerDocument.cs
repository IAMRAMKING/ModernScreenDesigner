using ModernDesigner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace ModernScreenDesigner
{
    public partial class DesignerDocument : DockContent
    {
        public DesignerControl DesignerControl { get; private set; }
        public Designer Designer { get { return this.DesignerControl.Designer; } }
        public Type RootComponentType { get; }

        public DesignerDocument(string text, Type rootType)
        {
            this.Text = text;
            this.RootComponentType = rootType;
            InitializeDesigner();
        }

        private void InitializeDesigner()
        {
            var root = (Control)Activator.CreateInstance(RootComponentType);
            root.Name = RootComponentType.Name;
            this.DesignerControl = new DesignerControl(root) { Dock = DockStyle.Fill };
            this.DesignerControl.Designer.KeyDown += DesignedForm_KeyDown;
            this.Controls.Add(DesignerControl);
        }

        public void Preview()
        {
            var form = new NewForm();
            form.LayoutXml = this.DesignerControl.Designer.LayoutXML;
            form.ShowDialog();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            (sender as Form).Hide();
        }

        private void DesignedForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                this.Designer.DeleteSelected();
            else if (e.KeyCode == Keys.F5)
                this.Preview();
            else if (e.Control == true && e.KeyCode == Keys.A)
                this.Designer.SelectAll();
            else if (e.Control == true && e.KeyCode == Keys.C)
                this.Designer.CopyControls();
            else if (e.Control == true && e.KeyCode == Keys.V)
                this.Designer.PasteControls();
            else if (e.Control == true && e.KeyCode == Keys.Z)
                this.Designer.Undo();
            else if (e.Control == true && e.KeyCode == Keys.Y)
                this.Designer.Redo();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            this.Designer.KeyDown -= DesignedForm_KeyDown;
            base.OnFormClosed(e);
        }

    }
}
