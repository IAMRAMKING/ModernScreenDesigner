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
    public partial class ToolBoxWindow : DockContent
    {
        public ToolBoxWindow()
        {
            InitializeComponent();
            InitToolbox();
        }
        private void InitToolbox()
        {
            string groupName = "Public control";
            this.m_obToolBoxControl.AddToolboxItem(typeof(Button), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(CheckBox), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(CheckedListBox), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(ComboBox), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(DateTimePicker), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(Label), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(LinkLabel), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(ListBox), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(ListView), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(MaskedTextBox), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(MonthCalendar), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(NotifyIcon), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(NumericUpDown), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(PictureBox), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(ProgressBar), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(RadioButton), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(RichTextBox), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(TextBox), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(ToolTip), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(TreeView), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(WebBrowser), groupName);

            groupName = "container";
            this.m_obToolBoxControl.AddToolboxItem(typeof(FlowLayoutPanel), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(GroupBox), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(Panel), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(SplitContainer), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(TabControl), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(TableLayoutPanel), groupName);


            groupName = "Menu and toolbar";
            this.m_obToolBoxControl.AddToolboxItem(typeof(ContextMenuStrip), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(MenuStrip), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(StatusStrip), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(ToolStrip), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(ToolStripContainer), groupName);

            groupName = "data";
            this.m_obToolBoxControl.AddToolboxItem(typeof(BindingNavigator), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(BindingSource), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(DataGridView), groupName);

            groupName = "Component";
            this.m_obToolBoxControl.AddToolboxItem(typeof(BackgroundWorker), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(ErrorProvider), groupName);
            this.m_obToolBoxControl.AddToolboxItem(typeof(Timer), groupName);

        }
    }
}
