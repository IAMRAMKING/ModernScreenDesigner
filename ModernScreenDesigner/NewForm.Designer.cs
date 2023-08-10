using ModernDesigner;
using ModernDesigner.Serialization;
namespace ModernScreenDesigner
{
    partial class NewForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.obDesigner = new Designer();
            this.obDesignerLoader = new DefaultDesignerLoader();
            this.SuspendLayout();
            // 
            // obDesigner
            // 
            this.obDesigner.GridSize = new System.Drawing.Size(8, 8);
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "NewForm";
            this.Size = new System.Drawing.Size(526, 511);
            this.ResumeLayout(false);

        }

        #endregion

        private Designer obDesigner;
        private DefaultDesignerLoader obDesignerLoader;
    }
}
