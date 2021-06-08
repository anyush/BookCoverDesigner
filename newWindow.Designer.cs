
namespace WinForms
{
    partial class newWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newWindow));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.numUDWidth = new System.Windows.Forms.NumericUpDown();
            this.numUDHeight = new System.Windows.Forms.NumericUpDown();
            this.numUDSpineWidth = new System.Windows.Forms.NumericUpDown();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelSpineWidth = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDSpineWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
            this.tableLayoutPanel.Controls.Add(this.numUDWidth, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.numUDHeight, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.numUDSpineWidth, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelWidth, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelHeight, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelSpineWidth, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.buttonCancel, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.buttonOK, 1, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            // 
            // numUDWidth
            // 
            resources.ApplyResources(this.numUDWidth, "numUDWidth");
            this.numUDWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUDWidth.Name = "numUDWidth";
            this.numUDWidth.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // numUDHeight
            // 
            resources.ApplyResources(this.numUDHeight, "numUDHeight");
            this.numUDHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUDHeight.Name = "numUDHeight";
            this.numUDHeight.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // numUDSpineWidth
            // 
            resources.ApplyResources(this.numUDSpineWidth, "numUDSpineWidth");
            this.numUDSpineWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUDSpineWidth.Name = "numUDSpineWidth";
            this.numUDSpineWidth.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // labelWidth
            // 
            resources.ApplyResources(this.labelWidth, "labelWidth");
            this.labelWidth.Name = "labelWidth";
            // 
            // labelHeight
            // 
            resources.ApplyResources(this.labelHeight, "labelHeight");
            this.labelHeight.Name = "labelHeight";
            // 
            // labelSpineWidth
            // 
            resources.ApplyResources(this.labelSpineWidth, "labelSpineWidth");
            this.labelSpineWidth.Name = "labelSpineWidth";
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            resources.ApplyResources(this.buttonOK, "buttonOK");
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // newWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDSpineWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.NumericUpDown numUDWidth;
        private System.Windows.Forms.NumericUpDown numUDHeight;
        private System.Windows.Forms.NumericUpDown numUDSpineWidth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelSpineWidth;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}