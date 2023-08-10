using ModernDesigner;
namespace ModernScreenDesigner
{
    partial class ModernDesigner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModernDesigner));
            this.m_obpnlToolStrip = new System.Windows.Forms.Panel();
            this.m_obToolStrip = new System.Windows.Forms.ToolStrip();
            this.tbNewForm = new System.Windows.Forms.ToolStripButton();
            this.tbOpenForm = new System.Windows.Forms.ToolStripButton();
            this.tbSaveForm = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbUndo = new System.Windows.Forms.ToolStripButton();
            this.tbRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbDelete = new System.Windows.Forms.ToolStripButton();
            this.tbAlignLeft = new System.Windows.Forms.ToolStripButton();
            this.tbAlignCenter = new System.Windows.Forms.ToolStripButton();
            this.tbAlignRight = new System.Windows.Forms.ToolStripButton();
            this.tbAlignTop = new System.Windows.Forms.ToolStripButton();
            this.tbAlignMiddle = new System.Windows.Forms.ToolStripButton();
            this.tbAlignBottom = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tbSameWidth = new System.Windows.Forms.ToolStripButton();
            this.tbSameHeight = new System.Windows.Forms.ToolStripButton();
            this.tbSameBoth = new System.Windows.Forms.ToolStripButton();
            this.m_obDockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.vS2015LightTheme = new WeifenLuo.WinFormsUI.Docking.VS2015LightTheme();
            this.tbPreview = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.m_obpnlToolStrip.SuspendLayout();
            this.m_obToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_obpnlToolStrip
            // 
            this.m_obpnlToolStrip.Controls.Add(this.m_obToolStrip);
            this.m_obpnlToolStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_obpnlToolStrip.Location = new System.Drawing.Point(0, 0);
            this.m_obpnlToolStrip.Name = "m_obpnlToolStrip";
            this.m_obpnlToolStrip.Size = new System.Drawing.Size(1410, 25);
            this.m_obpnlToolStrip.TabIndex = 0;
            // 
            // m_obToolStrip
            // 
            this.m_obToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_obToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbNewForm,
            this.tbOpenForm,
            this.tbSaveForm,
            this.toolStripSeparator5,
            this.tbPreview,
            this.toolStripSeparator2,
            this.tbUndo,
            this.tbRedo,
            this.toolStripSeparator1,
            this.tbDelete,
            this.tbAlignLeft,
            this.tbAlignCenter,
            this.tbAlignRight,
            this.tbAlignTop,
            this.tbAlignMiddle,
            this.tbAlignBottom,
            this.toolStripSeparator4,
            this.tbSameWidth,
            this.tbSameHeight,
            this.tbSameBoth});
            this.m_obToolStrip.Location = new System.Drawing.Point(0, 0);
            this.m_obToolStrip.Name = "m_obToolStrip";
            this.m_obToolStrip.Size = new System.Drawing.Size(1410, 25);
            this.m_obToolStrip.TabIndex = 8;
            this.m_obToolStrip.Text = "toolStrip1";
            // 
            // tbNewForm
            // 
            this.tbNewForm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbNewForm.Image = ((System.Drawing.Image)(resources.GetObject("tbNewForm.Image")));
            this.tbNewForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbNewForm.Name = "tbNewForm";
            this.tbNewForm.Size = new System.Drawing.Size(23, 22);
            this.tbNewForm.Text = "New Screen";
            this.tbNewForm.ToolTipText = "新建表单 (Ctrl + Ｎ)";
            this.tbNewForm.Click += new System.EventHandler(this.tbNewForm_Click);
            // 
            // tbOpenForm
            // 
            this.tbOpenForm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbOpenForm.Image = ((System.Drawing.Image)(resources.GetObject("tbOpenForm.Image")));
            this.tbOpenForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbOpenForm.Name = "tbOpenForm";
            this.tbOpenForm.Size = new System.Drawing.Size(23, 22);
            this.tbOpenForm.Text = "Open Screen";
            this.tbOpenForm.ToolTipText = "打开文件 (Ctrl + O)";
            this.tbOpenForm.Click += new System.EventHandler(this.tbOpenForm_Click);
            // 
            // tbSaveForm
            // 
            this.tbSaveForm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSaveForm.Enabled = false;
            this.tbSaveForm.Image = ((System.Drawing.Image)(resources.GetObject("tbSaveForm.Image")));
            this.tbSaveForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSaveForm.Name = "tbSaveForm";
            this.tbSaveForm.Size = new System.Drawing.Size(23, 22);
            this.tbSaveForm.Text = "Save Form";
            this.tbSaveForm.ToolTipText = "保存表单 (Ctrl + S)";
            this.tbSaveForm.Click += new System.EventHandler(this.tbSaveForm_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbUndo
            // 
            this.tbUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbUndo.Enabled = false;
            this.tbUndo.Image = ((System.Drawing.Image)(resources.GetObject("tbUndo.Image")));
            this.tbUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbUndo.Name = "tbUndo";
            this.tbUndo.Size = new System.Drawing.Size(23, 22);
            this.tbUndo.Text = "Undo （Ctrl+Z）";
            this.tbUndo.Click += new System.EventHandler(this.tbUndo_Click);
            // 
            // tbRedo
            // 
            this.tbRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbRedo.Enabled = false;
            this.tbRedo.Image = ((System.Drawing.Image)(resources.GetObject("tbRedo.Image")));
            this.tbRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbRedo.Name = "tbRedo";
            this.tbRedo.Size = new System.Drawing.Size(23, 22);
            this.tbRedo.Text = "Redo （Ctrl+Y）";
            this.tbRedo.Click += new System.EventHandler(this.tbRedo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbDelete
            // 
            this.tbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tbDelete.Image")));
            this.tbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Size = new System.Drawing.Size(23, 22);
            this.tbDelete.Text = "Delete";
            // 
            // tbAlignLeft
            // 
            this.tbAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAlignLeft.Enabled = false;
            this.tbAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("tbAlignLeft.Image")));
            this.tbAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAlignLeft.Name = "tbAlignLeft";
            this.tbAlignLeft.Size = new System.Drawing.Size(23, 22);
            this.tbAlignLeft.Text = "Align Left";
            this.tbAlignLeft.Click += new System.EventHandler(this.tbAlignLeft_Click);
            // 
            // tbAlignCenter
            // 
            this.tbAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAlignCenter.Enabled = false;
            this.tbAlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("tbAlignCenter.Image")));
            this.tbAlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAlignCenter.Name = "tbAlignCenter";
            this.tbAlignCenter.Size = new System.Drawing.Size(23, 22);
            this.tbAlignCenter.Text = "Align Center";
            this.tbAlignCenter.Click += new System.EventHandler(this.tbAlignCenter_Click);
            // 
            // tbAlignRight
            // 
            this.tbAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAlignRight.Enabled = false;
            this.tbAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("tbAlignRight.Image")));
            this.tbAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAlignRight.Name = "tbAlignRight";
            this.tbAlignRight.Size = new System.Drawing.Size(23, 22);
            this.tbAlignRight.Text = "Align Right";
            this.tbAlignRight.Click += new System.EventHandler(this.tbAlignRight_Click);
            // 
            // tbAlignTop
            // 
            this.tbAlignTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAlignTop.Enabled = false;
            this.tbAlignTop.Image = ((System.Drawing.Image)(resources.GetObject("tbAlignTop.Image")));
            this.tbAlignTop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAlignTop.Name = "tbAlignTop";
            this.tbAlignTop.Size = new System.Drawing.Size(23, 22);
            this.tbAlignTop.Text = "Align Top";
            this.tbAlignTop.Click += new System.EventHandler(this.tbAlignTop_Click);
            // 
            // tbAlignMiddle
            // 
            this.tbAlignMiddle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAlignMiddle.Enabled = false;
            this.tbAlignMiddle.Image = ((System.Drawing.Image)(resources.GetObject("tbAlignMiddle.Image")));
            this.tbAlignMiddle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAlignMiddle.Name = "tbAlignMiddle";
            this.tbAlignMiddle.Size = new System.Drawing.Size(23, 22);
            this.tbAlignMiddle.Text = "Align Middle";
            this.tbAlignMiddle.Click += new System.EventHandler(this.tbAlignMiddle_Click);
            // 
            // tbAlignBottom
            // 
            this.tbAlignBottom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAlignBottom.Enabled = false;
            this.tbAlignBottom.Image = ((System.Drawing.Image)(resources.GetObject("tbAlignBottom.Image")));
            this.tbAlignBottom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAlignBottom.Name = "tbAlignBottom";
            this.tbAlignBottom.Size = new System.Drawing.Size(23, 22);
            this.tbAlignBottom.Text = "Align Bottom";
            this.tbAlignBottom.Click += new System.EventHandler(this.tbAlignBottom_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tbSameWidth
            // 
            this.tbSameWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSameWidth.Enabled = false;
            this.tbSameWidth.Image = ((System.Drawing.Image)(resources.GetObject("tbSameWidth.Image")));
            this.tbSameWidth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSameWidth.Name = "tbSameWidth";
            this.tbSameWidth.Size = new System.Drawing.Size(23, 22);
            this.tbSameWidth.Text = "Same Width";
            this.tbSameWidth.Click += new System.EventHandler(this.tbSameWidth_Click);
            // 
            // tbSameHeight
            // 
            this.tbSameHeight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSameHeight.Enabled = false;
            this.tbSameHeight.Image = ((System.Drawing.Image)(resources.GetObject("tbSameHeight.Image")));
            this.tbSameHeight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSameHeight.Name = "tbSameHeight";
            this.tbSameHeight.Size = new System.Drawing.Size(23, 22);
            this.tbSameHeight.Text = "Same Height";
            this.tbSameHeight.Click += new System.EventHandler(this.tbSameHeight_Click);
            // 
            // tbSameBoth
            // 
            this.tbSameBoth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSameBoth.Enabled = false;
            this.tbSameBoth.Image = ((System.Drawing.Image)(resources.GetObject("tbSameBoth.Image")));
            this.tbSameBoth.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbSameBoth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSameBoth.Name = "tbSameBoth";
            this.tbSameBoth.Size = new System.Drawing.Size(23, 22);
            this.tbSameBoth.Text = "Same Both";
            this.tbSameBoth.Click += new System.EventHandler(this.tbSameBoth_Click);
            // 
            // m_obDockPanel
            // 
            this.m_obDockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_obDockPanel.DockBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.m_obDockPanel.Location = new System.Drawing.Point(0, 25);
            this.m_obDockPanel.Name = "m_obDockPanel";
            this.m_obDockPanel.Padding = new System.Windows.Forms.Padding(6);
            this.m_obDockPanel.ShowAutoHideContentOnHover = false;
            this.m_obDockPanel.Size = new System.Drawing.Size(1410, 667);
            this.m_obDockPanel.TabIndex = 1;
            this.m_obDockPanel.Theme = this.vS2015LightTheme;
            this.m_obDockPanel.ActiveDocumentChanged += new System.EventHandler(this.m_obDockPanel_ActiveDocumentChanged);
            // 
            // tbPreview
            // 
            this.tbPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbPreview.Image = ((System.Drawing.Image)(resources.GetObject("tbPreview.Image")));
            this.tbPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbPreview.Name = "tbPreview";
            this.tbPreview.Size = new System.Drawing.Size(23, 22);
            this.tbPreview.Text = "Preview";
            this.tbPreview.Click += new System.EventHandler(this.tbPreview_Click_1);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // ModernDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1410, 692);
            this.Controls.Add(this.m_obDockPanel);
            this.Controls.Add(this.m_obpnlToolStrip);
            this.Name = "ModernDesigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModernDesigner";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.m_obpnlToolStrip.ResumeLayout(false);
            this.m_obpnlToolStrip.PerformLayout();
            this.m_obToolStrip.ResumeLayout(false);
            this.m_obToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel m_obpnlToolStrip;
        private System.Windows.Forms.ToolStrip m_obToolStrip;
        private System.Windows.Forms.ToolStripButton tbNewForm;
        private System.Windows.Forms.ToolStripButton tbOpenForm;
        private System.Windows.Forms.ToolStripButton tbSaveForm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbUndo;
        private System.Windows.Forms.ToolStripButton tbRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbAlignLeft;
        private System.Windows.Forms.ToolStripButton tbAlignCenter;
        private System.Windows.Forms.ToolStripButton tbAlignRight;
        private System.Windows.Forms.ToolStripButton tbAlignTop;
        private System.Windows.Forms.ToolStripButton tbAlignMiddle;
        private System.Windows.Forms.ToolStripButton tbAlignBottom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tbSameWidth;
        private System.Windows.Forms.ToolStripButton tbSameHeight;
        private System.Windows.Forms.ToolStripButton tbSameBoth;
        private WeifenLuo.WinFormsUI.Docking.DockPanel m_obDockPanel;
        private WeifenLuo.WinFormsUI.Docking.VS2015LightTheme vS2015LightTheme;
        private System.Windows.Forms.ToolStripButton tbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tbPreview;
    }
}