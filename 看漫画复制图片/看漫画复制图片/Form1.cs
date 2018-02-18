using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 看漫画复制图片
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
       
        {
            button1.Enabled = false;
            Directory.CreateDirectory("kmcopyer");
            string basepath = ".kmcomic/image_down/";
            int index = 0;
            for (int i = 0; i < 100; i++)
            {
                if(Directory.Exists(basepath + i))
                {
                string[] all=Directory.GetFiles(basepath + i);
                foreach (string item in all)
                {
                    string newname = "kmcopyer/" + index.ToString() + ".jpg";
                    while (File.Exists(newname))
                    {
                        ++index;
                        newname = "kmcopyer/" + index.ToString() + ".jpg";
                    }
                    File.Copy(item, newname);
                }

                }
            }
            MessageBox.Show("复制完成");
            button1.Enabled = true;
        }
    }
}
