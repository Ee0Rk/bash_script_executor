using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace bash_script_executor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //default values
        public string this_opac = "100";
        public string script_sites = "https://rbxscript.com/";
        public string file_type = "txt files (*.txt)|*.txt|lua files (*.lua)|*.lua";
        public string  hide_opac = "80";
        public string prog_names = "RobloxPlayerBeta";
        public string font_size = "10";
        public string version = "1.2";
        public string startx = "10";
        public string starty = "10";

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] text = System.IO.File.ReadAllLines("config.txt");
            font_size_num.Value = Int32.Parse(text[5].Split("=".ToCharArray())[1]);
            start_opac_num.Value = Int32.Parse(text[0].Split("=".ToCharArray())[1]);
            hid_opac_num.Value = Int32.Parse(text[3].Split("=".ToCharArray())[1]);
            prog_name.Text = text[4].Split("=".ToCharArray())[1];
            script_site.Text = text[1].Split("=".ToCharArray())[1];
            file_types.Text = text[2].Split("=".ToCharArray())[1];
            ver_lbl.Text = "Version " + text[6].Split("=".ToCharArray())[1];
        }



        private void apply_btn_Click(object sender, EventArgs e)
        {
            string[] lines =
            {
                "opacity="+start_opac_num.Value.ToString(), "script_site="+script_site.Text, "file_types="+file_types.Text, "hide_opacity="+hid_opac_num.Value.ToString(), "prog_name="+prog_name.Text, "font_size="+font_size_num.Value.ToString(),"version="+version,"startx="+start_x_num.Value.ToString(),"starty="+start_y_num.Value.ToString()
            };
            System.IO.File.WriteAllLines("config.txt", lines);
            this.Close(); // closes the Form2 instance.
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close(); // closes the Form2 instance.
        }

        private void load_conf_btn_Click(object sender, EventArgs e)
        {
            string[] text = System.IO.File.ReadAllLines("config.txt");
            font_size_num.Value = Int32.Parse(text[5].Split("=".ToCharArray())[1]);
            start_opac_num.Value = Int32.Parse(text[0].Split("=".ToCharArray())[1]);
            hid_opac_num.Value = Int32.Parse(text[3].Split("=".ToCharArray())[1]);
            prog_name.Text = text[4].Split("=".ToCharArray())[1];
            script_site.Text = text[1].Split("=".ToCharArray())[1];
            file_types.Text = text[2].Split("=".ToCharArray())[1];
            ver_lbl.Text = "Version: "+text[6].Split("=".ToCharArray())[1];
        }

        private void save_conf_btn_Click(object sender, EventArgs e)
        {
            string[] lines =
            {
                "opacity="+start_opac_num.Value.ToString(), "script_site="+script_site.Text, "file_types="+file_types.Text, "hide_opacity="+hid_opac_num.Value.ToString(), "prog_name="+prog_name.Text, "font_size="+font_size_num.Value.ToString(),"version="+version
            };
            System.IO.File.WriteAllLines("config.txt", lines);

        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            font_size_num.Value = Int32.Parse(font_size);
            start_opac_num.Value = Int32.Parse(this_opac);
            hid_opac_num.Value = Int32.Parse(hide_opac);
            prog_name.Text = prog_names;
            script_site.Text = script_sites;
            file_types.Text = file_type;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close(); // closes the Form2 instance.
        }

        private void color_set_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
