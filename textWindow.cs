using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WinForms
{
    public partial class textWindow : Form
    {
        private string language;
        public int fontSize;
        public string text;
        public int alignement;
        public textWindow(string lang, int fontSize=16, string init_text="", int alignement=0)
        {
            InitializeComponent();
            numUDFont.Value = fontSize;
            textBox.Text = init_text;
            switch(alignement)
            {
                case 0:
                    rButtonAlignLeft.Checked = true;
                    break;

                case 1:
                    rButtonAlignCenter.Checked = true;
                    break;

                case 2:
                    rButtonAlignRight.Checked = true;
                    break;

                default:
                    throw new ArgumentException("Alignement must be 0, 1 or 2!");
            }
            language = lang;
            changeLang();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            fontSize = (int)numUDFont.Value;
            text = textBox.Text;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void rButtonAlignLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (rButtonAlignLeft.Checked)
            {
                textBox.TextAlign = HorizontalAlignment.Left;
                alignement = 0;
            }
        }

        private void rButtonAlignCenter_CheckedChanged(object sender, EventArgs e)
        {
            if (rButtonAlignCenter.Checked)
            {
                textBox.TextAlign = HorizontalAlignment.Center;
                alignement = 1;
            }
        }

        private void rButtonAlignRight_CheckedChanged(object sender, EventArgs e)
        {
            if (rButtonAlignRight.Checked)
            {
                textBox.TextAlign = HorizontalAlignment.Right;
                alignement = 2;
            }
        }

        private void changeLang()
        {
            changeLangWorkplace(this);
            changeLangForm();
        }

        private void changeLangWorkplace(Control c)
        {
            // https://www.dotnetcurry.com/ShowArticle.aspx?ID=174
            CultureInfo culture_info = new CultureInfo(language);
            ComponentResourceManager component_resource_manager
                = new ComponentResourceManager(this.GetType());
            component_resource_manager.ApplyResources(
                c, c.Name, culture_info);

            foreach (Control ctl in c.Controls)
            {
                changeLangWorkplace(ctl);
            }
        }

        private void changeLangForm()
        {
            CultureInfo culture_info = new CultureInfo(language);
            ComponentResourceManager component_resource_manager
                = new ComponentResourceManager(this.GetType());
            component_resource_manager.ApplyResources(
                this, "$this", culture_info);
        }
    }
}
