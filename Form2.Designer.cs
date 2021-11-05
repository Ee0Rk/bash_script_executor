
namespace bash_script_executor
{
    partial class Form2
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
            this.apply_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.font_size_num = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.start_opac_num = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.hid_opac_num = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.prog_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.script_site = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.file_types = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.start_x_num = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.start_y_num = new System.Windows.Forms.NumericUpDown();
            this.ver_lbl = new System.Windows.Forms.Label();
            this.load_conf_btn = new System.Windows.Forms.ToolStripButton();
            this.save_conf_btn = new System.Windows.Forms.ToolStripButton();
            this.reset_btn = new System.Windows.Forms.ToolStripButton();
            this.close_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.font_size_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_opac_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hid_opac_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_x_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_y_num)).BeginInit();
            this.SuspendLayout();
            // 
            // apply_btn
            // 
            this.apply_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.apply_btn.Cursor = System.Windows.Forms.Cursors.Cross;
            this.apply_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.apply_btn.ForeColor = System.Drawing.Color.White;
            this.apply_btn.Location = new System.Drawing.Point(201, 194);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(75, 23);
            this.apply_btn.TabIndex = 0;
            this.apply_btn.Text = "Apply";
            this.apply_btn.UseVisualStyleBackColor = false;
            this.apply_btn.Click += new System.EventHandler(this.apply_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Cross;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.Location = new System.Drawing.Point(120, 194);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 1;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.load_conf_btn,
            this.save_conf_btn,
            this.toolStripSeparator1,
            this.reset_btn,
            this.close_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(296, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.Gray;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // font_size_num
            // 
            this.font_size_num.Location = new System.Drawing.Point(99, 33);
            this.font_size_num.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.font_size_num.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.font_size_num.Name = "font_size_num";
            this.font_size_num.Size = new System.Drawing.Size(41, 20);
            this.font_size_num.TabIndex = 3;
            this.font_size_num.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Font size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Starting opacity";
            // 
            // start_opac_num
            // 
            this.start_opac_num.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.start_opac_num.Location = new System.Drawing.Point(99, 59);
            this.start_opac_num.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.start_opac_num.Name = "start_opac_num";
            this.start_opac_num.Size = new System.Drawing.Size(41, 20);
            this.start_opac_num.TabIndex = 6;
            this.start_opac_num.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hidden Opacity";
            // 
            // hid_opac_num
            // 
            this.hid_opac_num.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.hid_opac_num.Location = new System.Drawing.Point(99, 85);
            this.hid_opac_num.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.hid_opac_num.Name = "hid_opac_num";
            this.hid_opac_num.Size = new System.Drawing.Size(41, 20);
            this.hid_opac_num.TabIndex = 8;
            this.hid_opac_num.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Program name";
            // 
            // prog_name
            // 
            this.prog_name.Location = new System.Drawing.Point(99, 110);
            this.prog_name.Name = "prog_name";
            this.prog_name.Size = new System.Drawing.Size(177, 20);
            this.prog_name.TabIndex = 10;
            this.prog_name.Text = "RobloxPlayerBeta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Scripts site";
            // 
            // script_site
            // 
            this.script_site.Location = new System.Drawing.Point(99, 139);
            this.script_site.Name = "script_site";
            this.script_site.Size = new System.Drawing.Size(177, 20);
            this.script_site.TabIndex = 12;
            this.script_site.Text = "https://rbxscript.com/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "File Types";
            // 
            // file_types
            // 
            this.file_types.Location = new System.Drawing.Point(99, 168);
            this.file_types.Name = "file_types";
            this.file_types.Size = new System.Drawing.Size(177, 20);
            this.file_types.TabIndex = 14;
            this.file_types.Text = "txt files (*.txt)|*.txt|lua files (*.lua)|*.lua";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(146, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Start X";
            // 
            // start_x_num
            // 
            this.start_x_num.Location = new System.Drawing.Point(191, 33);
            this.start_x_num.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.start_x_num.Name = "start_x_num";
            this.start_x_num.Size = new System.Drawing.Size(85, 20);
            this.start_x_num.TabIndex = 16;
            this.start_x_num.Value = new decimal(new int[] {
            830,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(146, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Start Y";
            // 
            // start_y_num
            // 
            this.start_y_num.Location = new System.Drawing.Point(191, 59);
            this.start_y_num.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.start_y_num.Name = "start_y_num";
            this.start_y_num.Size = new System.Drawing.Size(85, 20);
            this.start_y_num.TabIndex = 18;
            this.start_y_num.Value = new decimal(new int[] {
            1060,
            0,
            0,
            0});
            // 
            // ver_lbl
            // 
            this.ver_lbl.AutoSize = true;
            this.ver_lbl.ForeColor = System.Drawing.Color.White;
            this.ver_lbl.Location = new System.Drawing.Point(13, 199);
            this.ver_lbl.Name = "ver_lbl";
            this.ver_lbl.Size = new System.Drawing.Size(60, 13);
            this.ver_lbl.TabIndex = 19;
            this.ver_lbl.Text = "Version 1.2";
            // 
            // load_conf_btn
            // 
            this.load_conf_btn.BackColor = System.Drawing.Color.Gray;
            this.load_conf_btn.Image = global::bash_script_executor.Properties.Resources.file_upload_line;
            this.load_conf_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.load_conf_btn.Name = "load_conf_btn";
            this.load_conf_btn.Size = new System.Drawing.Size(90, 22);
            this.load_conf_btn.Text = "Load config";
            this.load_conf_btn.Click += new System.EventHandler(this.load_conf_btn_Click);
            // 
            // save_conf_btn
            // 
            this.save_conf_btn.BackColor = System.Drawing.Color.Gray;
            this.save_conf_btn.Image = global::bash_script_executor.Properties.Resources.save_3_fill;
            this.save_conf_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save_conf_btn.Name = "save_conf_btn";
            this.save_conf_btn.Size = new System.Drawing.Size(88, 22);
            this.save_conf_btn.Text = "Save config";
            this.save_conf_btn.Click += new System.EventHandler(this.save_conf_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.Gray;
            this.reset_btn.Image = global::bash_script_executor.Properties.Resources.refresh_line;
            this.reset_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(55, 22);
            this.reset_btn.Text = "Reset";
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Gray;
            this.close_btn.Image = global::bash_script_executor.Properties.Resources.close_fill;
            this.close_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(56, 22);
            this.close_btn.Text = "Close";
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(296, 227);
            this.Controls.Add(this.ver_lbl);
            this.Controls.Add(this.start_y_num);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.start_x_num);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.file_types);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.script_site);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prog_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hid_opac_num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.start_opac_num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.font_size_num);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.apply_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.font_size_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_opac_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hid_opac_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_x_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_y_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button apply_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton load_conf_btn;
        private System.Windows.Forms.ToolStripButton save_conf_btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton close_btn;
        private System.Windows.Forms.NumericUpDown font_size_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown start_opac_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown hid_opac_num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox prog_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox script_site;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox file_types;
        private System.Windows.Forms.ToolStripButton reset_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown start_x_num;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown start_y_num;
        private System.Windows.Forms.Label ver_lbl;
    }
}