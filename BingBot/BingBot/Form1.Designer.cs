namespace BingBot
{
    partial class Frm_Bot
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
            this.Web_Bing = new System.Windows.Forms.WebBrowser();
            this.Prg_Main = new System.Windows.Forms.ProgressBar();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Tmr_Run = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Web_Bing
            // 
            this.Web_Bing.Location = new System.Drawing.Point(12, 41);
            this.Web_Bing.MinimumSize = new System.Drawing.Size(20, 20);
            this.Web_Bing.Name = "Web_Bing";
            this.Web_Bing.ScriptErrorsSuppressed = true;
            this.Web_Bing.Size = new System.Drawing.Size(1160, 333);
            this.Web_Bing.TabIndex = 0;
            // 
            // Prg_Main
            // 
            this.Prg_Main.Location = new System.Drawing.Point(12, 12);
            this.Prg_Main.Maximum = 53;
            this.Prg_Main.Name = "Prg_Main";
            this.Prg_Main.Size = new System.Drawing.Size(1160, 23);
            this.Prg_Main.TabIndex = 1;
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(12, 380);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(1160, 49);
            this.Btn_Start.TabIndex = 2;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Tmr_Run
            // 
            this.Tmr_Run.Interval = 5000;
            this.Tmr_Run.Tick += new System.EventHandler(this.Tmr_Run_Tick);
            // 
            // Frm_Bot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 441);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.Prg_Main);
            this.Controls.Add(this.Web_Bing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Bot";
            this.Text = "Bing Bot";
            this.Load += new System.EventHandler(this.Frm_Bot_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser Web_Bing;
        private System.Windows.Forms.ProgressBar Prg_Main;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Timer Tmr_Run;
    }
}

