using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Schema;

namespace WinForms
{
    public struct saveData
    {
        public string author;
        public string title;
        public int spineSize;
        public int height;
        public int width;
        public int BG_b;
        public int BG_g;
        public int BG_r;
        public int TC_b;
        public int TC_g;
        public int TC_r;
        public txt[] texts;
    }
    static class FileSaverOpener
    {
        static public saveData OpenFile(Stream file)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(winforms.CoverType));
            winforms.CoverType cov = (winforms.CoverType) serializer.Deserialize(file);

            saveData data = new saveData();
            data.title = cov.Title;
            data.author = cov.Author;
            data.spineSize = cov.SpineSize;
            data.height = cov.Height;
            data.width = cov.Width;
            data.BG_b = cov.BG.b;
            data.BG_g = cov.BG.g;
            data.BG_r = cov.BG.r;
            data.TC_b = cov.TC.b;
            data.TC_g = cov.TC.g;
            data.TC_r = cov.TC.r;
            if (cov.Text != null)
            {
                data.texts = new txt[cov.Text.Length];
                for (int i = 0; i < cov.Text.Length; i++)
                {
                    data.texts[i].alignement = cov.Text[i].alignement;
                    data.texts[i].x = cov.Text[i].x;
                    data.texts[i].y = cov.Text[i].y;
                    data.texts[i].fontsize = cov.Text[i].size;
                    data.texts[i].text = cov.Text[i].value;
                }
            }
            else
            {
                data.texts = new txt[0];
            }
            return data;
        }

        static public void SaveFile(Stream file, ref saveData data)
        {
            winforms.CoverType cov = new winforms.CoverType();
            cov.Author = data.author;
            cov.Title = data.title;
            cov.SpineSize = data.spineSize;
            cov.Height = data.height;
            cov.Width = data.width;
            cov.BG = new winforms.ColorType();
            cov.BG.b = data.BG_b;
            cov.BG.g = data.BG_g;
            cov.BG.r = data.BG_r;
            cov.TC = new winforms.ColorType();
            cov.TC.b = data.TC_b;
            cov.TC.g = data.TC_g;
            cov.TC.r = data.TC_r;
            cov.Text = new winforms.TextType[data.texts.Length];
            for (int i = 0; i < data.texts.Length; i++)
            {
                cov.Text[i] = new winforms.TextType();
                cov.Text[i].alignement = data.texts[i].alignement;
                cov.Text[i].y = data.texts[i].y;
                cov.Text[i].x = data.texts[i].x;
                cov.Text[i].size = data.texts[i].fontsize;
                cov.Text[i].value = data.texts[i].text;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(winforms.CoverType));
            serializer.Serialize(file, cov);
        }
    }
}
