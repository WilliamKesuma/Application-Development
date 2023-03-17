namespace Assignment_Week_4_lagi
{
    partial class MainWindowForm
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
            this.BTN_Submit = new System.Windows.Forms.Button();
            this.CB_AllContentTrue = new System.Windows.Forms.CheckBox();
            this.BTN_OpenNextForm = new System.Windows.Forms.Button();
            this.TB_Artist = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.LB_Artist = new System.Windows.Forms.Label();
            this.LB_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Submit
            // 
            this.BTN_Submit.Location = new System.Drawing.Point(78, 228);
            this.BTN_Submit.Name = "BTN_Submit";
            this.BTN_Submit.Size = new System.Drawing.Size(134, 77);
            this.BTN_Submit.TabIndex = 13;
            this.BTN_Submit.Text = "Submit";
            this.BTN_Submit.UseVisualStyleBackColor = true;
            this.BTN_Submit.Click += new System.EventHandler(this.BTN_Submit_Click);
            // 
            // CB_AllContentTrue
            // 
            this.CB_AllContentTrue.AutoSize = true;
            this.CB_AllContentTrue.Location = new System.Drawing.Point(168, 186);
            this.CB_AllContentTrue.Name = "CB_AllContentTrue";
            this.CB_AllContentTrue.Size = new System.Drawing.Size(197, 17);
            this.CB_AllContentTrue.TabIndex = 12;
            this.CB_AllContentTrue.Text = "All of the content I put above is true!";
            this.CB_AllContentTrue.UseVisualStyleBackColor = true;
            this.CB_AllContentTrue.CheckedChanged += new System.EventHandler(this.CB_AllContentTrue_CheckedChanged);
            // 
            // BTN_OpenNextForm
            // 
            this.BTN_OpenNextForm.Location = new System.Drawing.Point(272, 228);
            this.BTN_OpenNextForm.Name = "BTN_OpenNextForm";
            this.BTN_OpenNextForm.Size = new System.Drawing.Size(148, 77);
            this.BTN_OpenNextForm.TabIndex = 11;
            this.BTN_OpenNextForm.Text = "Open Next Form";
            this.BTN_OpenNextForm.UseVisualStyleBackColor = true;
            this.BTN_OpenNextForm.Click += new System.EventHandler(this.BTN_OpenNextForm_Click);
            // 
            // TB_Artist
            // 
            this.TB_Artist.Location = new System.Drawing.Point(179, 94);
            this.TB_Artist.Name = "TB_Artist";
            this.TB_Artist.Size = new System.Drawing.Size(100, 20);
            this.TB_Artist.TabIndex = 10;
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(179, 59);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(100, 20);
            this.TB_Name.TabIndex = 9;
            // 
            // LB_Artist
            // 
            this.LB_Artist.AutoSize = true;
            this.LB_Artist.Location = new System.Drawing.Point(75, 97);
            this.LB_Artist.Name = "LB_Artist";
            this.LB_Artist.Size = new System.Drawing.Size(91, 13);
            this.LB_Artist.TabIndex = 8;
            this.LB_Artist.Text = "My Favorite Artist:";
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.Location = new System.Drawing.Point(72, 62);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(38, 13);
            this.LB_Name.TabIndex = 7;
            this.LB_Name.Text = "Name:";
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_Submit);
            this.Controls.Add(this.CB_AllContentTrue);
            this.Controls.Add(this.BTN_OpenNextForm);
            this.Controls.Add(this.TB_Artist);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.LB_Artist);
            this.Controls.Add(this.LB_Name);
            this.Name = "MainWindowForm";
            this.Text = "Main Window Form";
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Submit;
        private System.Windows.Forms.CheckBox CB_AllContentTrue;
        private System.Windows.Forms.Button BTN_OpenNextForm;
        private System.Windows.Forms.TextBox TB_Artist;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label LB_Artist;
        private System.Windows.Forms.Label LB_Name;
    }
}