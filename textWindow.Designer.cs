
namespace WinForms
{
    partial class textWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(textWindow));
            this.labelFont = new System.Windows.Forms.Label();
            this.numUDFont = new System.Windows.Forms.NumericUpDown();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.rButtonAlignRight = new System.Windows.Forms.RadioButton();
            this.rButtonAlignCenter = new System.Windows.Forms.RadioButton();
            this.rButtonAlignLeft = new System.Windows.Forms.RadioButton();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUDFont)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFont
            // 
            resources.ApplyResources(this.labelFont, "labelFont");
            this.labelFont.Name = "labelFont";
            // 
            // numUDFont
            // 
            resources.ApplyResources(this.numUDFont, "numUDFont");
            this.numUDFont.Name = "numUDFont";
            this.numUDFont.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // groupBox
            // 
            resources.ApplyResources(this.groupBox, "groupBox");
            this.groupBox.Controls.Add(this.rButtonAlignRight);
            this.groupBox.Controls.Add(this.rButtonAlignCenter);
            this.groupBox.Controls.Add(this.rButtonAlignLeft);
            this.groupBox.Name = "groupBox";
            this.groupBox.TabStop = false;
            // 
            // rButtonAlignRight
            // 
            resources.ApplyResources(this.rButtonAlignRight, "rButtonAlignRight");
            this.rButtonAlignRight.Name = "rButtonAlignRight";
            this.rButtonAlignRight.UseVisualStyleBackColor = true;
            this.rButtonAlignRight.CheckedChanged += new System.EventHandler(this.rButtonAlignRight_CheckedChanged);
            // 
            // rButtonAlignCenter
            // 
            resources.ApplyResources(this.rButtonAlignCenter, "rButtonAlignCenter");
            this.rButtonAlignCenter.Name = "rButtonAlignCenter";
            this.rButtonAlignCenter.UseVisualStyleBackColor = true;
            this.rButtonAlignCenter.CheckedChanged += new System.EventHandler(this.rButtonAlignCenter_CheckedChanged);
            // 
            // rButtonAlignLeft
            // 
            resources.ApplyResources(this.rButtonAlignLeft, "rButtonAlignLeft");
            this.rButtonAlignLeft.Checked = true;
            this.rButtonAlignLeft.Name = "rButtonAlignLeft";
            this.rButtonAlignLeft.TabStop = true;
            this.rButtonAlignLeft.UseVisualStyleBackColor = true;
            this.rButtonAlignLeft.CheckedChanged += new System.EventHandler(this.rButtonAlignLeft_CheckedChanged);
            // 
            // textBox
            // 
            resources.ApplyResources(this.textBox, "textBox");
            this.textBox.Name = "textBox";
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
            // textWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.numUDFont);
            this.Controls.Add(this.labelFont);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "textWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.numUDFont)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFont;
        private System.Windows.Forms.NumericUpDown numUDFont;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton rButtonAlignRight;
        private System.Windows.Forms.RadioButton rButtonAlignCenter;
        private System.Windows.Forms.RadioButton rButtonAlignLeft;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}