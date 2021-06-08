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
using System.Threading;
using System.IO;

namespace WinForms
{
    public struct txt
    {
        public int x;
        public int y;
        public int fontsize;
        public string text;
        public int alignement;
    }
    
    public partial class mainWindow : Form
    {
        private string language = "en-EN";

        string fontFamilyDefault = "Arial";

        txt[] txts = new txt[20];
        int txts_n = 0;
        int txts_max_n = 20;
        int selected_txt = -1;
        bool doubleClick = false;

        int pageWidthDefault = 300;
        int pageHeightDefault = 500;
        int spineWidthDefault = 30;

        int pageWidth;
        int pageHeight;
        int spineWidth;

        Color bkgClrDefault = Color.PeachPuff;
        Color frgClrDefault = Color.Black;

        Color bkgClr;
        Color frgClr;

        string textToAdd = "";
        int fontToAdd = 0;
        int alignementToAdd = 0;

        bool movingText = false;
        Point mouseToTextCenter;
        public mainWindow()
        {
            pageWidth = pageWidthDefault;
            pageHeight = pageHeightDefault;
            spineWidth = spineWidthDefault;
            bkgClr = bkgClrDefault;
            frgClr = frgClrDefault;
            System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("en-EN");
            System.Globalization.CultureInfo.CurrentUICulture = new System.Globalization.CultureInfo("en-EN");
            InitializeComponent();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            // draw cover
            // https://docs.microsoft.com/pl-pl/dotnet/api/system.drawing.graphics.drawrectangle?view=net-5.0
            Pen grayPen = new Pen(Color.DarkGray, 3);
            SolidBrush bkgBrush = new SolidBrush(bkgClr);

            Rectangle rect = new Rectangle(pictureBox.Width / 2 - pageWidth - spineWidth / 2, pictureBox.Height / 2 - pageHeight / 2, pageWidth, pageHeight);
            e.Graphics.FillRectangle(bkgBrush, rect);
            e.Graphics.DrawRectangle(grayPen, rect);

            rect.X = pictureBox.Width / 2 - spineWidth / 2;
            rect.Width = spineWidth;
            e.Graphics.FillRectangle(bkgBrush, rect);
            e.Graphics.DrawRectangle(grayPen, rect);

            rect.X += spineWidth;
            rect.Width = pageWidth;
            e.Graphics.FillRectangle(bkgBrush, rect);
            e.Graphics.DrawRectangle(grayPen, rect);

            grayPen.Dispose();
            bkgBrush.Dispose();

            // draw title and author (not on spine)
            int titleFontSize = Math.Min(32, pageHeight / 3);
            Font f_title = new Font(fontFamilyDefault, titleFontSize);
            SizeF titleSize = e.Graphics.MeasureString(textBoxTitle.Text, f_title);
            while ((titleSize.Width + pageWidth / 50 > pageWidth ||
                    titleSize.Height > pageHeight / 3)  &&
                   titleFontSize > 1)
            {
                f_title.Dispose();
                f_title = new Font(fontFamilyDefault, --titleFontSize);
                titleSize = e.Graphics.MeasureString(textBoxTitle.Text, f_title);
            }

            int authorFontSize = Math.Min(24, pageHeight / 6);
            Font f_author = new Font(fontFamilyDefault, authorFontSize);
            SizeF authorSize = e.Graphics.MeasureString(textBoxAuthor.Text, f_author);
            while (authorSize.Width + pageWidth / 50 > pageWidth &&
                   authorFontSize > 1)
            {
                f_author.Dispose();
                f_author = new Font(fontFamilyDefault, --authorFontSize);
                authorSize = e.Graphics.MeasureString(textBoxAuthor.Text, f_author);
            }
            SolidBrush b = new SolidBrush(frgClr);

            Point title_pos = new Point(pictureBox.Width / 2 + spineWidth / 2 + pageWidth / 2 - (int)titleSize.Width / 2,
                                        pictureBox.Height / 2 - pageHeight / 6 - (int)titleSize.Height / 2);
            Point author_pos = new Point(pictureBox.Width / 2 + spineWidth / 2 + pageWidth / 2 - (int)authorSize.Width / 2,
                                         pictureBox.Height / 2 + pageHeight / 6 - f_author.Height / 2);

            if (titleSize.Width + pageWidth / 50 <= pageWidth && titleSize.Height <= pageHeight / 3)
                e.Graphics.DrawString(textBoxTitle.Text, f_title, b, title_pos);
            if (authorSize.Width + pageWidth / 50 <= pageWidth)
                e.Graphics.DrawString(textBoxAuthor.Text, f_author, b, author_pos);

            f_title.Dispose();
            f_author.Dispose();

            // draw title and author on spine
            // http://csharphelper.com/blog/2017/01/easily-draw-rotated-text-on-a-form-in-c/

            string titleCompact = textBoxTitle.Text;
            if (titleCompact.Contains("\n"))
                titleCompact = titleCompact.Replace("\n", " ");
            while (titleCompact.Contains("  "))
                titleCompact = titleCompact.Replace("  ", " ");

            titleFontSize = Math.Min(spineWidth, 32);
            f_title = new Font(fontFamilyDefault, titleFontSize);
            titleSize = e.Graphics.MeasureString(titleCompact, f_title);
            while ((titleSize.Width > pageHeight * 49 / 100 || 
                    titleSize.Height > spineWidth * 4 / 5)  &&
                   titleFontSize > 1)
            {
                f_title.Dispose();
                f_title = new Font(fontFamilyDefault, --titleFontSize);
                titleSize = e.Graphics.MeasureString(titleCompact, f_title);
            }
            
            if (titleSize.Width <= pageHeight * 49 / 100 && titleSize.Height <= spineWidth * 4 / 5)
            {
                Rectangle rot_bounds = new Rectangle(0, 0, (int)Math.Ceiling(titleSize.Width), (int)Math.Ceiling(titleSize.Height));
                e.Graphics.ResetTransform();
                e.Graphics.RotateTransform(-90);
                e.Graphics.TranslateTransform(pictureBox.Width / 2 - (int)titleSize.Height / 2,
                                              pictureBox.Height / 2 + pageHeight / 4 + titleSize.Width / 2,
                                              System.Drawing.Drawing2D.MatrixOrder.Append);
                e.Graphics.DrawString(titleCompact, f_title, b, rot_bounds);
                e.Graphics.ResetTransform();
            }

            string authorCompact = textBoxAuthor.Text;
            while (authorCompact.Contains("  "))
                authorCompact = authorCompact.Replace("  ", " ");

            authorFontSize = Math.Max(spineWidth, 24);
            f_author = new Font(fontFamilyDefault, authorFontSize);
            authorSize = e.Graphics.MeasureString(authorCompact, f_author);
            while ((authorSize.Width > pageHeight * 49 / 100 ||
                    authorSize.Height > spineWidth * 4 / 5) &&
                   titleFontSize > 1)
            {
                f_author.Dispose();
                f_author = new Font(fontFamilyDefault, --authorFontSize);
                authorSize = e.Graphics.MeasureString(authorCompact, f_author);
                e.Graphics.ResetTransform();
            }

            if (authorSize.Width <= pageHeight * 49 / 100 && authorSize.Height <= spineWidth * 4 / 5)
            {
                Rectangle rot_bounds = new Rectangle(0, 0, (int)Math.Ceiling(authorSize.Width), (int)Math.Ceiling(authorSize.Height));
                e.Graphics.ResetTransform();
                e.Graphics.RotateTransform(-90);
                e.Graphics.TranslateTransform(pictureBox.Width / 2 - (int)authorSize.Height / 2,
                                              pictureBox.Height / 2 - pageHeight / 4 + (int)authorSize.Width / 2,
                                              System.Drawing.Drawing2D.MatrixOrder.Append);
                e.Graphics.DrawString(authorCompact, f_author, b, rot_bounds);
                e.Graphics.ResetTransform();
            }


            f_title.Dispose();
            f_author.Dispose();

            // draw additional texts
            for (int i = 0; i < txts_n; i++)
            {
                Font f = new Font(fontFamilyDefault, txts[i].fontsize);
                Point p = new Point();
                SizeF textSize = e.Graphics.MeasureString(txts[i].text, f);
                p.X = txts[i].x + (pictureBox.Width / 2 - pageWidth - spineWidth / 2) - (int)(textSize.Width / 2);
                p.Y = txts[i].y + (pictureBox.Height / 2 - pageHeight / 2) - (int)(textSize.Height / 2);
                if (i == selected_txt)
                {
                    Color selectColor = Color.FromArgb(255 - bkgClr.R, 255 - bkgClr.G, 255 - bkgClr.B);
                    Pen pen_select = new Pen(selectColor);
                    e.Graphics.DrawRectangle(pen_select, p.X, p.Y, (int)textSize.Width, (int)textSize.Height);
                    pen_select.Dispose();
                }
                e.Graphics.DrawString(txts[i].text, f, b, p);
                f.Dispose();
            }

            b.Dispose();
        }

        private void buttonAddText_Click(object sender, EventArgs e)
        {
            using (textWindow wnd = new textWindow(language))
            {
                DialogResult res = wnd.ShowDialog();
                if (res == DialogResult.OK)
                {
                    textToAdd = wnd.text;
                    fontToAdd = wnd.fontSize;
                    alignementToAdd = wnd.alignement;
                    pictureBox.Cursor = Cursors.Cross;
                }
            }
        }

        private void pictureBox_Resize(object sender, EventArgs e)
        {
            pictureBox.Invalidate();
        }

        private void menuFileNew_Click(object sender, EventArgs e)
        {
            using (newWindow wnd = new newWindow(language, pageWidthDefault, pageHeightDefault, spineWidthDefault))
            {
                DialogResult res = wnd.ShowDialog();
                if (res == DialogResult.OK)
                {
                    pageWidth = wnd.widthValue;
                    pageHeight = wnd.heightValue;
                    spineWidth = wnd.spineWidthValue;
                    textBoxTitle.Text = "";
                    textBoxAuthor.Text = "";
                    txts_n = 0;
                    selected_txt = -1;
                    movingText = false;
                    bkgClr = bkgClrDefault;
                    frgClr = frgClrDefault;
                    pictureBox.Invalidate();
                }
            }
        }

        private void menuSettingsLanguageEn_Click(object sender, EventArgs e)
        {
            menuSettingsLanguageEn.Checked = true;
            menuSettingsLanguagePl.Checked = false;
            language = "en-EN";
            changeLang();
        }

        private void menuSettingsLanguagePl_Click(object sender, EventArgs e)
        {
            menuSettingsLanguageEn.Checked = false;
            menuSettingsLanguagePl.Checked = true;
            language = "pl-PL";
            changeLang();
        }

        private void changeLang()
        {
            int splitDist = splitContainer.SplitterDistance;
            changeLangWorkplace(this);
            changeLangMenu();
            changeLangForm();
            splitContainer.SplitterDistance = splitDist;
        }

        private void changeLangWorkplace(Control c)
        {
            // https://www.dotnetcurry.com/ShowArticle.aspx?ID=174
            int left = c.Left;
            int width = c.Width;
            CultureInfo culture_info = new CultureInfo(language);
            ComponentResourceManager component_resource_manager
                = new ComponentResourceManager(this.GetType());
            component_resource_manager.ApplyResources(
                c, c.Name, culture_info);
            c.Width = width;
            c.Left = left;
            
            foreach (Control ctl in c.Controls)
            {
                changeLangWorkplace(ctl);
            }
        }

        private void changeLangForm()
        {
            int width = this.Width;
            int height = this.Height;
            CultureInfo culture_info = new CultureInfo(language);
            ComponentResourceManager component_resource_manager
                = new ComponentResourceManager(this.GetType());
            component_resource_manager.ApplyResources(
                this, "$this", culture_info);
            this.Width = width;
            this.Height = height;
        }

        private void changeLangMenu()
        {
            CultureInfo culture_info = new CultureInfo(language);
            ComponentResourceManager component_resource_manager
                = new ComponentResourceManager(this.GetType());
            component_resource_manager.ApplyResources(
                menu, menu.Name, culture_info);

            foreach (ToolStripMenuItem opt in menu.Items)
            {
                changeLangDDMenu(opt);
            }
        }

        private void changeLangDDMenu(ToolStripMenuItem it)
        {
            CultureInfo culture_info = new CultureInfo(language);
            ComponentResourceManager component_resource_manager
                = new ComponentResourceManager(this.GetType());
            component_resource_manager.ApplyResources(
                it, it.Name, culture_info);


            foreach (ToolStripMenuItem opt in it.DropDownItems)
            {
                changeLangDDMenu(opt);
            }
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            pictureBox.Invalidate();
        }

        private void textBoxAuthor_TextChanged(object sender, EventArgs e)
        {
            pictureBox.Invalidate();
        }

        private void buttonBackgroundColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    bkgClr = dlg.Color;
                    pictureBox.Invalidate();
                }
            }
        }

        private void buttonTextColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    frgClr = dlg.Color;
                    pictureBox.Invalidate();
                }
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (pictureBox.Cursor == Cursors.Cross)
                    {
                        if (txts_n == txts_max_n)
                        {
                            txt[] b = new txt[txts_max_n * 2];
                            for (int i = 0; i < txts_n; i++)
                                b[i] = txts[i];
                            txts_max_n *= 2;
                            txts = b;
                        }

                        txt new_txt = new txt();
                        Point p = pictureBox.PointToClient(Control.MousePosition);
                        new_txt.x = p.X - (pictureBox.Width / 2 - (pageWidth + spineWidth / 2));
                        new_txt.y = p.Y - (pictureBox.Height / 2 - pageHeight / 2);
                        new_txt.text = textToAdd;
                        new_txt.fontsize = fontToAdd;
                        new_txt.alignement = alignementToAdd;
                        txts[txts_n++] = new_txt;
                        pictureBox.Cursor = Cursors.Default;
                        pictureBox.Invalidate();
                    }
                    if (e.Clicks >= 2)
                        doubleClick = true;
                    else
                        doubleClick = false;
                    break;

                case MouseButtons.Middle:
                    if (selected_txt > -1)
                    {
                        movingText = true;
                        Point mousePos = pictureBox.PointToClient(Control.MousePosition);
                        mouseToTextCenter.X = txts[selected_txt].x - mousePos.X;
                        mouseToTextCenter.Y = txts[selected_txt].y - mousePos.Y;
                    }
                    break;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (movingText)
            {
                Point mousePos = pictureBox.PointToClient(Control.MousePosition);
                txts[selected_txt].x = mousePos.X + mouseToTextCenter.X;
                txts[selected_txt].y = mousePos.Y + mouseToTextCenter.Y;
                pictureBox.Invalidate();
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (doubleClick)
                    {
                        Graphics grl = pictureBox.CreateGraphics();
                        for (int i = 0; i < txts_n; i++)
                        {
                            Font f = new Font(fontFamilyDefault, txts[i].fontsize);
                            SizeF textSize = grl.MeasureString(txts[i].text, f);
                            int x = txts[i].x + (pictureBox.Width / 2 - pageWidth - spineWidth / 2) - (int)(textSize.Width / 2);
                            int y = txts[i].y + (pictureBox.Height / 2 - pageHeight / 2) - (int)(textSize.Height / 2);
                            Point mousePos = pictureBox.PointToClient(Control.MousePosition);
                            if (x <= mousePos.X && x + textSize.Width >= mousePos.X &&
                                y <= mousePos.Y && y + textSize.Height >= mousePos.Y)
                            {
                                using (textWindow wnd = new textWindow(language, txts[i].fontsize, txts[i].text, txts[i].alignement))
                                {
                                    DialogResult res = wnd.ShowDialog();
                                    if (res == DialogResult.OK)
                                    {
                                        txts[i].fontsize = wnd.fontSize;
                                        txts[i].text = wnd.text;
                                        txts[i].alignement = wnd.alignement;
                                        pictureBox.Invalidate();
                                    }
                                }
                                break;
                            }
                        }
                        grl.Dispose();
                    }
                    break;

                case MouseButtons.Middle:
                    movingText = false;
                    break;

                case MouseButtons.Right:
                    Graphics gr = pictureBox.CreateGraphics();
                    bool founded = false;
                    for (int i = 0; i < txts_n; i++)
                    {
                        Font f = new Font(fontFamilyDefault, txts[i].fontsize);
                        SizeF textSize = gr.MeasureString(txts[i].text, f);
                        int x = txts[i].x + (pictureBox.Width / 2 - pageWidth - spineWidth / 2) - (int)(textSize.Width / 2);
                        int y = txts[i].y + (pictureBox.Height / 2 - pageHeight / 2) - (int)(textSize.Height / 2);
                        Point mousePos = pictureBox.PointToClient(Control.MousePosition);
                        if (x <= mousePos.X && x + textSize.Width >= mousePos.X &&
                            y <= mousePos.Y && y + textSize.Height >= mousePos.Y)
                        {
                            selected_txt = i;
                            pictureBox.Invalidate();
                            founded = true;
                            break;
                        }
                    }
                    if (!founded)
                    {
                        selected_txt = -1;
                        pictureBox.Invalidate();
                    }
                    gr.Dispose();
                    break;
            }
        }

        private void menuFileSave_Click(object sender, EventArgs e)
        {
            // https://docs.microsoft.com/pl-pl/dotnet/api/system.windows.forms.savefiledialog?view=net-5.0
            Stream file;
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "XML files (*.xml)|*.xml";
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if ((file = dlg.OpenFile()) != null)
                {
                    saveData data = new saveData();
                    data.title = textBoxTitle.Text;
                    data.author = textBoxAuthor.Text;
                    data.spineSize = spineWidth;
                    data.height = pageHeight;
                    data.width = pageWidth;
                    data.BG_b = bkgClr.B;
                    data.BG_g = bkgClr.G;
                    data.BG_r = bkgClr.R;
                    data.TC_b = frgClr.B;
                    data.TC_g = frgClr.G;
                    data.TC_r = frgClr.R;
                    data.texts = new txt[txts_n];
                    for (int i = 0; i < txts_n; i++)
                    {
                        data.texts[i].alignement = txts[i].alignement;
                        data.texts[i].x = txts[i].x;
                        data.texts[i].y = txts[i].y;
                        data.texts[i].fontsize = txts[i].fontsize;
                        data.texts[i].text = txts[i].text;
                    }
                    FileSaverOpener.SaveFile(file, ref data);
                    file.Close();
                }
            }
        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            Stream file;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "XML files (*.xml)|*.xml";
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if ((file = dlg.OpenFile()) != null)
                {
                    saveData data = new saveData();
                    try
                    {
                        data = FileSaverOpener.OpenFile(file);
                    }
                    catch (InvalidOperationException)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBoxIcon icon = MessageBoxIcon.Error;
                        if (language == "pl-PL")
                            MessageBox.Show("Wybrany plik został uszkodzony!", "BŁĄD", buttons, icon);
                        else
                            MessageBox.Show("The selected file has been corrupted!", "ERROR", buttons, icon);
                        return;
                    }
                    

                    textBoxTitle.Text = data.title;
                    textBoxAuthor.Text = data.author;
                    spineWidth = data.spineSize;
                    pageHeight = data.height;
                    pageWidth = data.width;
                    bkgClr = Color.FromArgb(data.BG_r, data.BG_g, data.BG_b);
                    frgClr = Color.FromArgb(data.TC_r, data.TC_g, data.TC_b);
                    txts_n = data.texts.Length;
                    txts_max_n = Math.Max(data.texts.Length, 1);
                    for (int i = 0; i < txts_n; i++)
                    {
                        txts[i].alignement = data.texts[i].alignement;
                        txts[i].x = data.texts[i].x;
                        txts[i].y = data.texts[i].y;
                        txts[i].fontsize = data.texts[i].fontsize;
                        txts[i].text = data.texts[i].text;
                    }
                    file.Close();
                    pictureBox.Invalidate();
                }
            }
        }

        private void mainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && selected_txt != -1)
            {
                for (int i = selected_txt; i < txts_n - 1; i++)
                    txts[i] = txts[i + 1];
                txts_n -= 1;
                selected_txt = -1;
                pictureBox.Invalidate();
            }
        }
    }
}
