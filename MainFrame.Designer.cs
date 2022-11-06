
namespace LeaveMangementForm
{
    partial class MainFrame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.CurrentTime_tmr = new System.Windows.Forms.Timer(this.components);
            this.SubForm_pnl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logo_btn = new System.Windows.Forms.Button();
            this.SubFormTitle_lbl = new System.Windows.Forms.Label();
            this.CurrentDate_lbl = new System.Windows.Forms.Label();
            this.CurrentTime_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LeaveMg_Menu_btn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentTime_tmr
            // 
            this.CurrentTime_tmr.Tick += new System.EventHandler(this.CurrentTime_tmr_Tick);
            // 
            // SubForm_pnl
            // 
            this.SubForm_pnl.Location = new System.Drawing.Point(241, 134);
            this.SubForm_pnl.Name = "SubForm_pnl";
            this.SubForm_pnl.Size = new System.Drawing.Size(809, 657);
            this.SubForm_pnl.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::LeaveMangementForm.Properties.Resources.UpperMenuBackground;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.Logo_btn);
            this.panel2.Controls.Add(this.SubFormTitle_lbl);
            this.panel2.Controls.Add(this.CurrentDate_lbl);
            this.panel2.Controls.Add(this.CurrentTime_lbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(241, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 132);
            this.panel2.TabIndex = 1;
            // 
            // Logo_btn
            // 
            this.Logo_btn.BackColor = System.Drawing.Color.Transparent;
            this.Logo_btn.BackgroundImage = global::LeaveMangementForm.Properties.Resources.Logo;
            this.Logo_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo_btn.FlatAppearance.BorderSize = 0;
            this.Logo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logo_btn.ForeColor = System.Drawing.Color.Transparent;
            this.Logo_btn.Location = new System.Drawing.Point(666, 0);
            this.Logo_btn.Name = "Logo_btn";
            this.Logo_btn.Size = new System.Drawing.Size(131, 111);
            this.Logo_btn.TabIndex = 3;
            this.Logo_btn.UseVisualStyleBackColor = false;
            // 
            // SubFormTitle_lbl
            // 
            this.SubFormTitle_lbl.AutoSize = true;
            this.SubFormTitle_lbl.BackColor = System.Drawing.Color.Transparent;
            this.SubFormTitle_lbl.ForeColor = System.Drawing.Color.White;
            this.SubFormTitle_lbl.Location = new System.Drawing.Point(20, 114);
            this.SubFormTitle_lbl.Name = "SubFormTitle_lbl";
            this.SubFormTitle_lbl.Size = new System.Drawing.Size(46, 17);
            this.SubFormTitle_lbl.TabIndex = 2;
            this.SubFormTitle_lbl.Text = "label1";
            // 
            // CurrentDate_lbl
            // 
            this.CurrentDate_lbl.AutoSize = true;
            this.CurrentDate_lbl.BackColor = System.Drawing.Color.Transparent;
            this.CurrentDate_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDate_lbl.ForeColor = System.Drawing.Color.White;
            this.CurrentDate_lbl.Location = new System.Drawing.Point(276, 48);
            this.CurrentDate_lbl.Name = "CurrentDate_lbl";
            this.CurrentDate_lbl.Size = new System.Drawing.Size(53, 20);
            this.CurrentDate_lbl.TabIndex = 1;
            this.CurrentDate_lbl.Text = "label1";
            // 
            // CurrentTime_lbl
            // 
            this.CurrentTime_lbl.AutoSize = true;
            this.CurrentTime_lbl.BackColor = System.Drawing.Color.Transparent;
            this.CurrentTime_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTime_lbl.ForeColor = System.Drawing.Color.White;
            this.CurrentTime_lbl.Location = new System.Drawing.Point(322, 9);
            this.CurrentTime_lbl.Name = "CurrentTime_lbl";
            this.CurrentTime_lbl.Size = new System.Drawing.Size(109, 39);
            this.CurrentTime_lbl.TabIndex = 0;
            this.CurrentTime_lbl.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(111)))));
            this.panel1.BackgroundImage = global::LeaveMangementForm.Properties.Resources.Background;
            this.panel1.Controls.Add(this.LeaveMg_Menu_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 711);
            this.panel1.TabIndex = 0;
            // 
            // LeaveMg_Menu_btn
            // 
            this.LeaveMg_Menu_btn.BackColor = System.Drawing.Color.Transparent;
            this.LeaveMg_Menu_btn.BackgroundImage = global::LeaveMangementForm.Properties.Resources.LeaveManagement;
            this.LeaveMg_Menu_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeaveMg_Menu_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeaveMg_Menu_btn.FlatAppearance.BorderSize = 0;
            this.LeaveMg_Menu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeaveMg_Menu_btn.Location = new System.Drawing.Point(21, 337);
            this.LeaveMg_Menu_btn.Name = "LeaveMg_Menu_btn";
            this.LeaveMg_Menu_btn.Size = new System.Drawing.Size(194, 46);
            this.LeaveMg_Menu_btn.TabIndex = 1;
            this.LeaveMg_Menu_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LeaveMg_Menu_btn.UseVisualStyleBackColor = false;
            this.LeaveMg_Menu_btn.Click += new System.EventHandler(this.LeaveMg_Menu_btn_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 711);
            this.Controls.Add(this.SubForm_pnl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrame";
            this.Text = "RECA";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LeaveMg_Menu_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label SubFormTitle_lbl;
        private System.Windows.Forms.Label CurrentDate_lbl;
        private System.Windows.Forms.Label CurrentTime_lbl;
        private System.Windows.Forms.Timer CurrentTime_tmr;
        private System.Windows.Forms.Panel SubForm_pnl;
        private System.Windows.Forms.Button Logo_btn;
    }
}