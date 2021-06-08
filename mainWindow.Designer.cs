
namespace WinForms
{
    partial class mainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelBackgroundColor = new System.Windows.Forms.Label();
            this.labelTextColor = new System.Windows.Forms.Label();
            this.buttonBackgroundColor = new System.Windows.Forms.Button();
            this.buttonTextColor = new System.Windows.Forms.Button();
            this.labelColor = new System.Windows.Forms.Label();
            this.buttonAddText = new System.Windows.Forms.Button();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelAdditText = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingsLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingsLanguageEn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingsLanguagePl = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            resources.ApplyResources(this.splitContainer, "splitContainer");
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            resources.ApplyResources(this.splitContainer.Panel1, "splitContainer.Panel1");
            this.splitContainer.Panel1.Controls.Add(this.pictureBox);
            // 
            // splitContainer.Panel2
            // 
            resources.ApplyResources(this.splitContainer.Panel2, "splitContainer.Panel2");
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutPanel);
            this.splitContainer.Panel2.Controls.Add(this.labelColor);
            this.splitContainer.Panel2.Controls.Add(this.buttonAddText);
            this.splitContainer.Panel2.Controls.Add(this.textBoxAuthor);
            this.splitContainer.Panel2.Controls.Add(this.textBoxTitle);
            this.splitContainer.Panel2.Controls.Add(this.labelAdditText);
            this.splitContainer.Panel2.Controls.Add(this.labelAuthor);
            this.splitContainer.Panel2.Controls.Add(this.labelTitle);
            // 
            // pictureBox
            // 
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            this.pictureBox.Resize += new System.EventHandler(this.pictureBox_Resize);
            // 
            // tableLayoutPanel
            // 
            resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
            this.tableLayoutPanel.Controls.Add(this.labelBackgroundColor, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelTextColor, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonBackgroundColor, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonTextColor, 1, 1);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            // 
            // labelBackgroundColor
            // 
            resources.ApplyResources(this.labelBackgroundColor, "labelBackgroundColor");
            this.labelBackgroundColor.Name = "labelBackgroundColor";
            // 
            // labelTextColor
            // 
            resources.ApplyResources(this.labelTextColor, "labelTextColor");
            this.labelTextColor.Name = "labelTextColor";
            // 
            // buttonBackgroundColor
            // 
            resources.ApplyResources(this.buttonBackgroundColor, "buttonBackgroundColor");
            this.buttonBackgroundColor.Name = "buttonBackgroundColor";
            this.buttonBackgroundColor.UseVisualStyleBackColor = true;
            this.buttonBackgroundColor.Click += new System.EventHandler(this.buttonBackgroundColor_Click);
            // 
            // buttonTextColor
            // 
            resources.ApplyResources(this.buttonTextColor, "buttonTextColor");
            this.buttonTextColor.Name = "buttonTextColor";
            this.buttonTextColor.UseVisualStyleBackColor = true;
            this.buttonTextColor.Click += new System.EventHandler(this.buttonTextColor_Click);
            // 
            // labelColor
            // 
            resources.ApplyResources(this.labelColor, "labelColor");
            this.labelColor.Name = "labelColor";
            // 
            // buttonAddText
            // 
            resources.ApplyResources(this.buttonAddText, "buttonAddText");
            this.buttonAddText.Name = "buttonAddText";
            this.buttonAddText.UseVisualStyleBackColor = true;
            this.buttonAddText.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // textBoxAuthor
            // 
            resources.ApplyResources(this.textBoxAuthor, "textBoxAuthor");
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.TextChanged += new System.EventHandler(this.textBoxAuthor_TextChanged);
            // 
            // textBoxTitle
            // 
            resources.ApplyResources(this.textBoxTitle, "textBoxTitle");
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // labelAdditText
            // 
            resources.ApplyResources(this.labelAdditText, "labelAdditText");
            this.labelAdditText.Name = "labelAdditText";
            // 
            // labelAuthor
            // 
            resources.ApplyResources(this.labelAuthor, "labelAuthor");
            this.labelAuthor.Name = "labelAuthor";
            // 
            // labelTitle
            // 
            resources.ApplyResources(this.labelTitle, "labelTitle");
            this.labelTitle.Name = "labelTitle";
            // 
            // menu
            // 
            resources.ApplyResources(this.menu, "menu");
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuSettings});
            this.menu.Name = "menu";
            // 
            // menuFile
            // 
            resources.ApplyResources(this.menuFile, "menuFile");
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.menuFileSave});
            this.menuFile.Name = "menuFile";
            // 
            // menuFileNew
            // 
            resources.ApplyResources(this.menuFileNew, "menuFileNew");
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // menuFileOpen
            // 
            resources.ApplyResources(this.menuFileOpen, "menuFileOpen");
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFileSave
            // 
            resources.ApplyResources(this.menuFileSave, "menuFileSave");
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // menuSettings
            // 
            resources.ApplyResources(this.menuSettings, "menuSettings");
            this.menuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSettingsLanguage});
            this.menuSettings.Name = "menuSettings";
            // 
            // menuSettingsLanguage
            // 
            resources.ApplyResources(this.menuSettingsLanguage, "menuSettingsLanguage");
            this.menuSettingsLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSettingsLanguageEn,
            this.menuSettingsLanguagePl});
            this.menuSettingsLanguage.Name = "menuSettingsLanguage";
            // 
            // menuSettingsLanguageEn
            // 
            resources.ApplyResources(this.menuSettingsLanguageEn, "menuSettingsLanguageEn");
            this.menuSettingsLanguageEn.Checked = true;
            this.menuSettingsLanguageEn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuSettingsLanguageEn.Name = "menuSettingsLanguageEn";
            this.menuSettingsLanguageEn.Click += new System.EventHandler(this.menuSettingsLanguageEn_Click);
            // 
            // menuSettingsLanguagePl
            // 
            resources.ApplyResources(this.menuSettingsLanguagePl, "menuSettingsLanguagePl");
            this.menuSettingsLanguagePl.Name = "menuSettingsLanguagePl";
            this.menuSettingsLanguagePl.Click += new System.EventHandler(this.menuSettingsLanguagePl_Click);
            // 
            // mainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menu);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menu;
            this.Name = "mainWindow";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mainWindow_KeyUp);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelAdditText;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonAddText;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private System.Windows.Forms.ToolStripMenuItem menuSettingsLanguage;
        private System.Windows.Forms.ToolStripMenuItem menuSettingsLanguageEn;
        private System.Windows.Forms.ToolStripMenuItem menuSettingsLanguagePl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelBackgroundColor;
        private System.Windows.Forms.Label labelTextColor;
        private System.Windows.Forms.Button buttonBackgroundColor;
        private System.Windows.Forms.Button buttonTextColor;
    }
}

