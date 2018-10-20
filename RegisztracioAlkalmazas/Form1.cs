using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            betolt.Click += (sender, e) => Megnyitas();
            Hobbihozza.Click += (sender, e) => NewHobbi();
            save.Click += (sender, e) => Mentes();
        }
        private void Megnyitas()
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string tartalom = File.ReadAllText(openFileDialog.FileName);
                string[] open = tartalom.Split(';');
                nevtext.Text = open[0];
                szuldate.Value = Convert.ToDateTime(open[1]);
                if (open[2]=="F")
                {
                    Ferfi.Checked = true;
                    No.Checked = false;
                }
                else
                {
                    Ferfi.Checked = false;
                    No.Checked = true;
                }
                if (!hobbi.Items.Contains(open[3]))
                { 
                    hobbi.Items.Add(open[3]);
                    
                }
                if (open.Length>4)
                {
                    hobbi.Items.Clear();
                    for (int i = 4; i < open.Length-1; i++)
                    {
                        hobbi.Items.Add(open[i]);
                    }
                }
                int index = hobbi.FindString(open[3]);
                hobbi.SetSelected(index, true);

            }
        }
        private void Mentes()
        {
            if (nevtext.Text!="" &&(Ferfi.Checked==true||No.Checked==true)&&hobbi.SelectedItem!=null )
            {
                string tartalom = nevtext.Text + ";" + szuldate.Value + ";";
                if (Ferfi.Checked == true)
                {
                    tartalom += "F;";
                }
                else
                {
                    tartalom += "N;";
                }
                tartalom += hobbi.SelectedItem.ToString()+";";
                List<String> list = new List<String>();

                foreach (String strCol in hobbi.Items)
                {
                    list.Add(strCol);
                }
                foreach (string itm in list)
                {
                    if (itm!="")
                    {
                        tartalom += itm + ";";
                    }
                }
                var eredmeny = saveFileDialog.ShowDialog(this);
                if (eredmeny == DialogResult.OK)
                {
                    string fileNev = saveFileDialog.FileName;

                    File.WriteAllText(fileNev, tartalom);
                }

            }
            else
            {
                MessageBox.Show("Minden Adatott tölts ki!!!");
            }
        }
        private void NewHobbi()
        {
            if (!hobbi.Items.Contains(hobbitext.Text)&&hobbitext.Text!="")
            {
                hobbi.Items.Add(hobbitext.Text);
            }
        }
    }
}
