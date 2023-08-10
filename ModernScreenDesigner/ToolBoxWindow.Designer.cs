using ModernDesigner;
namespace ModernScreenDesigner
{
    partial class ToolBoxWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_obToolBoxControl = new ToolboxControl();
            this.SuspendLayout();
            // 
            // m_obToolBoxControl
            // 
            this.m_obToolBoxControl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.m_obToolBoxControl.DefaultCategoryText = "conventional";
            this.m_obToolBoxControl.Designer = null;
            this.m_obToolBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_obToolBoxControl.Location = new System.Drawing.Point(0, 0);
            this.m_obToolBoxControl.Name = "m_obToolBoxControl";
            this.m_obToolBoxControl.PointerItemText = "pointer";
            this.m_obToolBoxControl.SelectedCategory = null;
            this.m_obToolBoxControl.SelectedItem = null;
            this.m_obToolBoxControl.Size = new System.Drawing.Size(243, 552);
            this.m_obToolBoxControl.TabIndex = 0;
            // 
            // ToolBoxWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 552);
            this.Controls.Add(this.m_obToolBoxControl);
            this.Name = "ToolBoxWindow";
            this.Text = "ToolBoxWindow";
            this.ResumeLayout(false);

        }

        #endregion

        internal ToolboxControl m_obToolBoxControl;
    }
}