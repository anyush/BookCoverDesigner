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
    public partial class newWindow : Form
    {
        private string language;
        public int widthValue;
        public int heightValue;
        public int spineWidthValue;
        public newWindow(string lang, int width, int height, int spineWidth)
        {
            InitializeComponent();
            language = lang;
            changeLang();
            numUDWidth.Value = width;
            numUDHeight.Value = height;
            numUDSpineWidth.Value = spineWidth;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.widthValue = (int)numUDWidth.Value;
            this.heightValue = (int)numUDHeight.Value;
            this.spineWidthValue = (int)numUDSpineWidth.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
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
