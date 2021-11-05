
namespace bash_script_executor
{
    partial class top
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(top));
            this.execute_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.text_area = new System.Windows.Forms.RichTextBox();
            this.opacity = new System.Windows.Forms.TrackBar();
            this.cur_opacity_lbl = new System.Windows.Forms.Label();
            this.info_lbl = new System.Windows.Forms.Label();
            this.findS_btn = new System.Windows.Forms.Button();
            this.status_lbl = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.hide_btn = new System.Windows.Forms.Button();
            this.setting_btn = new System.Windows.Forms.Button();
            this.attach_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.opacity)).BeginInit();
            this.SuspendLayout();
            // 
            // execute_btn
            // 
            this.execute_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.execute_btn.Cursor = System.Windows.Forms.Cursors.Cross;
            resources.ApplyResources(this.execute_btn, "execute_btn");
            this.execute_btn.ForeColor = System.Drawing.Color.White;
            this.execute_btn.Name = "execute_btn";
            this.execute_btn.UseVisualStyleBackColor = false;
            this.execute_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clear_btn.Cursor = System.Windows.Forms.Cursors.Cross;
            resources.ApplyResources(this.clear_btn, "clear_btn");
            this.clear_btn.ForeColor = System.Drawing.Color.White;
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // text_area
            // 
            this.text_area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.text_area, "text_area");
            this.text_area.ForeColor = System.Drawing.Color.White;
            this.text_area.Name = "text_area";
            // 
            // opacity
            // 
            resources.ApplyResources(this.opacity, "opacity");
            this.opacity.BackColor = System.Drawing.Color.Black;
            this.opacity.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.opacity.LargeChange = 10;
            this.opacity.Maximum = 100;
            this.opacity.Minimum = 20;
            this.opacity.Name = "opacity";
            this.opacity.SmallChange = 10;
            this.opacity.TickFrequency = 10;
            this.opacity.Value = 100;
            this.opacity.Scroll += new System.EventHandler(this.opacity_Scroll);
            // 
            // cur_opacity_lbl
            // 
            resources.ApplyResources(this.cur_opacity_lbl, "cur_opacity_lbl");
            this.cur_opacity_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cur_opacity_lbl.Name = "cur_opacity_lbl";
            // 
            // info_lbl
            // 
            resources.ApplyResources(this.info_lbl, "info_lbl");
            this.info_lbl.ForeColor = System.Drawing.Color.Lime;
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Click += new System.EventHandler(this.info_lbl_Click);
            // 
            // findS_btn
            // 
            this.findS_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.findS_btn.Cursor = System.Windows.Forms.Cursors.Cross;
            resources.ApplyResources(this.findS_btn, "findS_btn");
            this.findS_btn.ForeColor = System.Drawing.Color.White;
            this.findS_btn.Name = "findS_btn";
            this.findS_btn.UseVisualStyleBackColor = false;
            this.findS_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // status_lbl
            // 
            this.status_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.status_lbl.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.status_lbl, "status_lbl");
            this.status_lbl.Name = "status_lbl";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Cross;
            resources.ApplyResources(this.button5, "button5");
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Cross;
            resources.ApplyResources(this.save_btn, "save_btn");
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Name = "save_btn";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // hide_btn
            // 
            this.hide_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hide_btn.Cursor = System.Windows.Forms.Cursors.Cross;
            resources.ApplyResources(this.hide_btn, "hide_btn");
            this.hide_btn.ForeColor = System.Drawing.Color.White;
            this.hide_btn.Name = "hide_btn";
            this.hide_btn.UseVisualStyleBackColor = false;
            this.hide_btn.Click += new System.EventHandler(this.hide_btn_Click);
            // 
            // setting_btn
            // 
            this.setting_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.setting_btn.Cursor = System.Windows.Forms.Cursors.Cross;
            resources.ApplyResources(this.setting_btn, "setting_btn");
            this.setting_btn.ForeColor = System.Drawing.Color.White;
            this.setting_btn.Name = "setting_btn";
            this.setting_btn.UseVisualStyleBackColor = false;
            this.setting_btn.Click += new System.EventHandler(this.setting_btn_Click);
            // 
            // attach_btn
            // 
            this.attach_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.attach_btn.Cursor = System.Windows.Forms.Cursors.Cross;
            resources.ApplyResources(this.attach_btn, "attach_btn");
            this.attach_btn.ForeColor = System.Drawing.Color.White;
            this.attach_btn.Name = "attach_btn";
            this.attach_btn.UseVisualStyleBackColor = false;
            this.attach_btn.Click += new System.EventHandler(this.attach_btn_Click);
            // 
            // top
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.attach_btn);
            this.Controls.Add(this.status_lbl);
            this.Controls.Add(this.setting_btn);
            this.Controls.Add(this.hide_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.findS_btn);
            this.Controls.Add(this.info_lbl);
            this.Controls.Add(this.cur_opacity_lbl);
            this.Controls.Add(this.opacity);
            this.Controls.Add(this.text_area);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.execute_btn);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "top";
            this.ShowIcon = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.top_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button execute_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.RichTextBox text_area;
        private System.Windows.Forms.TrackBar opacity;
        private System.Windows.Forms.Label cur_opacity_lbl;
        private System.Windows.Forms.Label info_lbl;
        private System.Windows.Forms.Button findS_btn;
        private System.Windows.Forms.Label status_lbl;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button hide_btn;
        private System.Windows.Forms.Button setting_btn;
        private System.Windows.Forms.Button attach_btn;
    }
}

