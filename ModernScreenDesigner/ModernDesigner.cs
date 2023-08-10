using ModernDesigner;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace ModernScreenDesigner
{
    public partial class ModernDesigner : Form
    {
        private ToolBoxWindow toolboxWindow;
        private PropertyWindow propertyWindow;
        private ToolStripSeparator toolStripSeparator3;
        private Designer activeDesigner;

        public ModernDesigner()
        {
            InitializeComponent();
            this.toolboxWindow = new ToolBoxWindow();
            this.toolboxWindow.Show(this.m_obDockPanel, DockState.DockLeftAutoHide);

            this.propertyWindow = new PropertyWindow();
            this.propertyWindow.Show(this.m_obDockPanel, DockState.DockRight);
            EnableUndoRedo();   

        }
        private void m_obDockPanel_ActiveDocumentChanged(object sender, EventArgs e)
        {
            if (this.m_obDockPanel.ActiveDocument is DesignerDocument doc)
            {
                this.activeDesigner = doc.Designer;
                this.SelectionChanged(this.activeDesigner.SelectionService, EventArgs.Empty);

                this.toolboxWindow.m_obToolBoxControl.Designer = this.activeDesigner;

                this.propertyWindow.m_obPropertBoxControl.SetComponents(this.activeDesigner.DesignerHost.Container.Components);

                this.EnableUndoRedo();

                this.tbPreview.Enabled = true;
                this.tbSaveForm.Enabled = true;
            }
            else
            {
                this.tbPreview.Enabled = false;
                this.tbSaveForm.Enabled = false;
            }
        }

        private bool DesignEvents_AddingVerb(IComponent primarySelection, DesignerVerb verb)
        {
            return true;
        }
        private void SelectionChanged(object sender, EventArgs e)
        {
            var selectionService = (ISelectionService)sender;
            int selectionCount = selectionService.SelectionCount;

            EnableAlignResize(selectionCount > 1);
            if (selectionCount >= 1)
            {
                this.tbDelete.Enabled = true;
            }
            else
            {
                this.tbDelete.Enabled = false;
            }

            this.propertyWindow.m_obPropertBoxControl.Designer = this.activeDesigner;
            if (selectionCount == 0)
            {
                this.propertyWindow.m_obPropertBoxControl.SetSelectedObjects(this.activeDesigner.DesignedForm);
            }
            else
            {
                var selected = new object[selectionCount];
                selectionService.GetSelectedComponents().CopyTo(selected, 0);
                this.propertyWindow.m_obPropertBoxControl.SetSelectedObjects(selected);
            }
        }
        private void ComponentAdded(object sender, ComponentEventArgs e)
        {
            this.propertyWindow.m_obPropertBoxControl.SetComponents(this.activeDesigner.DesignerHost.Container.Components);

            EnableUndoRedo();
        }
        private void ComponentRemoved(object sender, ComponentEventArgs e)
        {
            this.propertyWindow.m_obPropertBoxControl.SetComponents(this.activeDesigner.DesignerHost.Container.Components);

            EnableUndoRedo();
        }
        private void ComponentChanged(object sender, ComponentChangedEventArgs e)
        {
            EnableUndoRedo();
        }

        private void NewDesignedForm()
        {
            string name = "from " + (this.m_obDockPanel.DocumentsCount + 1);
            var rootType = typeof(NewForm);

            var doc = new DesignerDocument(name, rootType);
            this.activeDesigner = doc.Designer;
            doc.FormClosing += (s, e) =>
            {
                EndDesign(doc.Designer);
            };
            //doc.Designer.DesignEvents.AddingVerb += DesignEvents_AddingVerb;
            doc.Designer.SelectionService.SelectionChanged += SelectionChanged;
            doc.Designer.ComponentChangeService.ComponentAdded += ComponentAdded;
            doc.Designer.ComponentChangeService.ComponentRemoved += ComponentRemoved;
            doc.Designer.ComponentChangeService.ComponentChanged += ComponentChanged;
            doc.Show(m_obDockPanel);
            tbSaveForm.Enabled = true;
        }
        private void OpenDesignedForm()
        {
            var openFileName = new OpenFileDialog();

            openFileName.Filter = "XML text format (*.xml)|*.xml|Proprietary text format (*.*)|*.*";
            openFileName.FilterIndex = 1;
            openFileName.RestoreDirectory = true;

            if (openFileName.ShowDialog() == DialogResult.OK)
            {
                this.NewDesignedForm();

                if (openFileName.FilterIndex == 1)
                {
                    var txtReader = new StreamReader(openFileName.FileName);
                    string layoutString = txtReader.ReadToEnd();
                    txtReader.Close();

                    this.activeDesigner.LayoutXML = layoutString;
                }
                else
                {
                    this.activeDesigner.LoadFromFile(openFileName.FileName);
                }
                tbSaveForm.Enabled = true;
            }
        }
        private void SaveDesignedForm()
        {
            var saveFileName = new SaveFileDialog();
            saveFileName.Filter = "XML Form (*.xml)|*.xml";
            saveFileName.FilterIndex = 1;
            saveFileName.RestoreDirectory = true;

            if (saveFileName.ShowDialog() == DialogResult.OK)
            {
                string test = this.activeDesigner.LayoutXML;

                TextWriter txtWriter = new StreamWriter(saveFileName.FileName);
                txtWriter.Write(test);
                txtWriter.Close();
            }
        }
        private void CheckDesignedForm()
        {
            if (this.activeDesigner.IsDirty == true)
            {
                if (MessageBox.Show("Whether to save the modification of the form?", "Confirmation prompt",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveDesignedForm();
                }
            }
        }
        private void EndDesign(Designer designer)
        {
            if (designer == null) return;

            designer.SelectionService.SelectionChanged -= SelectionChanged;
            designer.ComponentChangeService.ComponentAdded -= ComponentAdded;
            designer.ComponentChangeService.ComponentRemoved -= ComponentRemoved;
            designer.ComponentChangeService.ComponentChanged -= ComponentChanged;
            CheckDesignedForm();
            designer.Active = false;
            designer.DesignContainer = null;
        }

        private void EnableAlignResize(bool enable)
        {

            this.tbAlignBottom.Enabled = enable;
            this.tbAlignMiddle.Enabled = enable;
            this.tbAlignTop.Enabled = enable;
            this.tbAlignCenter.Enabled = enable;
            this.tbAlignLeft.Enabled = enable;
            this.tbAlignRight.Enabled = enable;

            this.tbSameBoth.Enabled = enable;
            this.tbSameWidth.Enabled = enable;
            this.tbSameHeight.Enabled = enable;
        }
        private void EnableUndoRedo()
        {

            tbUndo.Enabled = (this.activeDesigner?.UndoCount > 0);
            tbRedo.Enabled = (this.activeDesigner?.RedoCount > 0);
        }

        #region 菜单事件

      
       
        
        private void tbDelete_Click(object sender, EventArgs e)
        {
            if (this.m_obDockPanel.ActiveDocument is DesignerDocument doc)
            {
                doc.Designer.DeleteSelected();
            }
        }
        private void miAlignTop_Click(object sender, System.EventArgs e)
        {
            this.activeDesigner.Align(AlignType.Top);
        }
        private void miAlignMiddle_Click(object sender, System.EventArgs e)
        {
            this.activeDesigner.Align(AlignType.Middle);
        }
        private void miAlignBottom_Click(object sender, System.EventArgs e)
        {
            this.activeDesigner.Align(AlignType.Bottom);
        }
        private void miAlignLeft_Click(object sender, System.EventArgs e)
        {
            this.activeDesigner.Align(AlignType.Left);
        }
        private void miAlignCenter_Click(object sender, System.EventArgs e)
        {
            this.activeDesigner.Align(AlignType.Center);
        }
        private void miAlignRight_Click(object sender, System.EventArgs e)
        {
            this.activeDesigner.Align(AlignType.Right);
        }

        private void miSameHeight_Click(object sender, System.EventArgs e)
        {
            this.activeDesigner.MakeSameSize(ResizeType.SameHeight);
        }
        private void miSameWidth_Click(object sender, System.EventArgs e)
        {
            this.activeDesigner.MakeSameSize(ResizeType.SameWidth);
        }
        private void miSameBoth_Click(object sender, System.EventArgs e)
        {
            this.activeDesigner.MakeSameSize(ResizeType.SameHeight | ResizeType.SameWidth);
        }
        private void miDeleteSelection_Click(object sender, System.EventArgs e)
        {
            this.activeDesigner.DeleteSelected();
        }

        private void miCopy_Click(object sender, System.EventArgs e)
        {
            this.activeDesigner.CopyControls();
        }
        private void miPaste_Click(object sender, System.EventArgs e)
        {
            this.activeDesigner.PasteControls();
        }

        private void miAbout_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Modern Screen Designer" + Environment.NewLine +
                "Copyright © 2018 IAMRAMKING",
                "About",
                MessageBoxButtons.OK);
        }





        #endregion

        private void tbNewForm_Click(object sender, EventArgs e)
        {
            NewDesignedForm();
        }

        private void tbOpenForm_Click(object sender, EventArgs e)
        {
            OpenDesignedForm();
        }

        private void tbSaveForm_Click(object sender, EventArgs e)
        {
            SaveDesignedForm();
        }

        private void tbPreview_Click_1(object sender, EventArgs e)
        {
            if (this.m_obDockPanel.ActiveDocument is DesignerDocument doc)
            {
                doc.Preview();
            }
        }

        private void tbUndo_Click(object sender, EventArgs e)
        {
            this.activeDesigner.Undo();
        }

        private void tbRedo_Click(object sender, EventArgs e)
        {
            this.activeDesigner.Redo();
        }

        private void tbAlignLeft_Click(object sender, EventArgs e)
        {

        }

        private void tbAlignCenter_Click(object sender, EventArgs e)
        {

        }

        private void tbAlignRight_Click(object sender, EventArgs e)
        {

        }

        private void tbAlignTop_Click(object sender, EventArgs e)
        {

        }

        private void tbAlignMiddle_Click(object sender, EventArgs e)
        {

        }

        private void tbAlignBottom_Click(object sender, EventArgs e)
        {

        }

        private void tbSameWidth_Click(object sender, EventArgs e)
        {

        }

        private void tbSameHeight_Click(object sender, EventArgs e)
        {

        }

        private void tbSameBoth_Click(object sender, EventArgs e)
        {

        }

        
    }
}
