using ModernDesigner;
namespace ModernScreenDesigner
{
    partial class PropertyWindow
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
            this.m_obPropertBoxControl = new PropertyboxControl();
            this.SuspendLayout();
            // 
            // m_obPropertBoxControl
            // 
            this.m_obPropertBoxControl.Designer = null;
            this.m_obPropertBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_obPropertBoxControl.Location = new System.Drawing.Point(0, 0);
            this.m_obPropertBoxControl.Name = "m_obPropertBoxControl";
            this.m_obPropertBoxControl.ShowEventTab = false;
            this.m_obPropertBoxControl.Size = new System.Drawing.Size(248, 589);
            this.m_obPropertBoxControl.TabIndex = 0;
            // 
            // PropertyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 589);
            this.Controls.Add(this.m_obPropertBoxControl);
            this.Name = "PropertyWindow";
            this.Text = "PropertyWindow";
            this.ResumeLayout(false);

        }

        #endregion

        internal PropertyboxControl m_obPropertBoxControl;
    }
}