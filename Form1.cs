using System;
using System.Drawing;
using System.Windows.Forms;
using WeAreDevs_API;
using System.Diagnostics;
using System.Windows;

namespace bash_script_executor
{
    public partial class top : Form
    {
        public bool attached = false;

        public string sFileName = "";

        public bool hidden = false;
        public Point position;
        public Point btn_position;

        public string scr_site = "https://rbxscript.com/";
        public string file_types = "txt files (*.txt)|*.txt|lua files (*.lua)|*.lua";
        public string hide_opac = "80";
        public string prog_name = "RobloxPlayerBeta";
        public string font_size = "10";
        public string version = "1.2";
        public string startx = "10";
        public string starty = "10";

        public top()
        {
            InitializeComponent();
        }

        ExploitAPI api = new ExploitAPI();

        private void button2_Click(object sender, EventArgs e)
        {
            if (attached != true)
            {
                Process[] processes = Process.GetProcessesByName(prog_name);
                if (processes.Length != 0) {
                    string text = text_area.Text;
                    this.api.SendLuaScript(text);
                    status_lbl.ForeColor = System.Drawing.Color.Green;
                    status_lbl.Text = "Status: Running";
                    attached = true;
                }
                else
                {
                    status_lbl.ForeColor = System.Drawing.Color.Red;
                    status_lbl.Text = "Status: Failed";
                    attached = false;
                }
            }
            else
            {
                Process[] processes = Process.GetProcessesByName(prog_name);
                if (processes.Length != 0)
                {
                    string text = text_area.Text;
                    this.api.SendLuaScript(text);
                    status_lbl.ForeColor = System.Drawing.Color.Green;
                    status_lbl.Text = "Status: Running";
                    attached = true;
                }
                else
                {
                    status_lbl.ForeColor = System.Drawing.Color.Red;
                    status_lbl.Text = "Status: Failed";
                    attached = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            text_area.Text = "--Paste Lua script here!";
        }

        private void opacity_Scroll(object sender, EventArgs e)
        {
            cur_opacity_lbl.Text = opacity.Value.ToString() + "%";
            this.Opacity = ((double)(opacity.Value) / 100.0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(scr_site);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = file_types;
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                string lines = System.IO.File.ReadAllText(sFileName);
                text_area.Text = lines;
                this.Text = "Bash's script executor v" + version + " ~" + sFileName;
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = file_types;
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                System.IO.File.WriteAllText(sFileName,text_area.Text);
            }
        }

        private void hide_btn_Click(object sender, EventArgs e)
        {
            if (hidden != true)
            {
                position = this.Location;
                btn_position = hide_btn.Location;
                hide_btn.Location = new Point(0,0);
                hide_btn.Text = "↑Show↑";
                int locx = Screen.FromControl(this).Bounds.Width - 75;
                int locy = Screen.FromControl(this).Bounds.Height - 23;
                this.Location = new Point(locx, locy);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Opacity = ((double)(Int32.Parse(hide_opac)) / 100.0);
                status_lbl.Location = new Point(9, 50);
                hidden = true;
                MessageBox.Show("The window has been moved to the bottom right!");
            }
            else 
            {
                this.Location = position;
                hide_btn.Location = btn_position;
                hide_btn.Text = "↓Hide↓";
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                this.Opacity = ((double)(opacity.Value) / 100.0);
                status_lbl.Location = new Point(9, 0);
                hidden = false;
            }
        }

        private void setting_btn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.FormClosed += F2_FormClosed;
            f2.Show();
        }

        private void top_Load(object sender, EventArgs e)
        {
            string[] text = System.IO.File.ReadAllLines("config.txt");
            this.Opacity = ((double)(Int32.Parse(text[0].Split("=".ToCharArray())[1])) / 100.0);
            opacity.Value = Int32.Parse(text[0].Split("=".ToCharArray())[1]);
            cur_opacity_lbl.Text = text[0].Split("=".ToCharArray())[1] + "%";
            scr_site = text[1].Split("=".ToCharArray())[1];
            file_types = text[2].Split("=".ToCharArray())[1];
            hide_opac = text[3].Split("=".ToCharArray())[1];
            prog_name = text[4].Split("=".ToCharArray())[1];
            font_size = text[5].Split("=".ToCharArray())[1];
            text_area.Font = new Font(text_area.Font.FontFamily, Int32.Parse(text[5].Split("=".ToCharArray())[1]));
            version = text[6].Split("=".ToCharArray())[1];
            startx = text[7].Split("=".ToCharArray())[1];
            starty = text[8].Split("=".ToCharArray())[1];
            int locx = Screen.FromControl(this).Bounds.Width - Int32.Parse(startx);
            int locy = Screen.FromControl(this).Bounds.Height - Int32.Parse(starty);
            this.Location = new Point(locx, locy);
            this.Text = "Bash's script executor v" + version + " ~" + sFileName;
        }
        private void F2_FormClosed(object sender, FormClosedEventArgs e)
        {
            string[] text = System.IO.File.ReadAllLines("config.txt");
            this.Opacity = ((double)(Int32.Parse(text[0].Split("=".ToCharArray())[1])) / 100.0);
            opacity.Value = Int32.Parse(text[0].Split("=".ToCharArray())[1]);
            cur_opacity_lbl.Text = text[0].Split("=".ToCharArray())[1] + "%";
            scr_site = text[1].Split("=".ToCharArray())[1];
            file_types = text[2].Split("=".ToCharArray())[1];
            hide_opac = text[3].Split("=".ToCharArray())[1];
            prog_name = text[4].Split("=".ToCharArray())[1];
            font_size = text[5].Split("=".ToCharArray())[1];
            text_area.Font = new Font(text_area.Font.FontFamily, Int32.Parse(text[5].Split("=".ToCharArray())[1]));
            version = text[6].Split("=".ToCharArray())[1];
            startx = text[7].Split("=".ToCharArray())[1];
            starty = text[8].Split("=".ToCharArray())[1];
            int locx = Screen.FromControl(this).Bounds.Width - Int32.Parse(startx);
            int locy = Screen.FromControl(this).Bounds.Height - Int32.Parse(starty);
            this.Location = new Point(locx, locy);
            this.Text = "Bash's script executor v" + version + " ~" + sFileName;
        }

        private void info_lbl_Click(object sender, EventArgs e)
        {
        }

        private void attach_btn_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName(prog_name);
            if (processes.Length != 0)
            {
                if (attached != true)
                {
                    status_lbl.ForeColor = System.Drawing.Color.Yellow;
                    status_lbl.Text = "Status: Injecting";
                    api.LaunchExploit();
                    status_lbl.ForeColor = System.Drawing.Color.Orange;
                    status_lbl.Text = "Status: Injected";
                }
                else
                {
                    MessageBox.Show("Dll already injected");
                }
            }
            else
            {
                status_lbl.ForeColor = System.Drawing.Color.Red;
                status_lbl.Text = "Status: Failed";
                attached = false;
            }
            
        }
    }
}
