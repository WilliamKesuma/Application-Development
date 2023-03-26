namespace Take_Home_week_5
{
    partial class Form1
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
            this.LB_PlayerName = new System.Windows.Forms.Label();
            this.LB_PlayerNum = new System.Windows.Forms.Label();
            this.LB_PlayerPos = new System.Windows.Forms.Label();
            this.TB_PlayerName = new System.Windows.Forms.TextBox();
            this.TB_PlayerNum = new System.Windows.Forms.TextBox();
            this.BTN_AddPlayer = new System.Windows.Forms.Button();
            this.BTN_AddTeam = new System.Windows.Forms.Button();
            this.TB_TeamCity = new System.Windows.Forms.TextBox();
            this.TB_TeamCountry = new System.Windows.Forms.TextBox();
            this.TB_TeamName = new System.Windows.Forms.TextBox();
            this.LB_TeamCity = new System.Windows.Forms.Label();
            this.LB_TeamCountry = new System.Windows.Forms.Label();
            this.LB_TeamName = new System.Windows.Forms.Label();
            this.List_Result = new System.Windows.Forms.ListBox();
            this.LB_Choose = new System.Windows.Forms.Label();
            this.CB_Choose_Team = new System.Windows.Forms.ComboBox();
            this.LB_Choose_Country = new System.Windows.Forms.Label();
            this.CB_Choose_Country = new System.Windows.Forms.ComboBox();
            this.BTN_RemovePlayer = new System.Windows.Forms.Button();
            this.CB_PlayerPos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LB_PlayerName
            // 
            this.LB_PlayerName.AutoSize = true;
            this.LB_PlayerName.Location = new System.Drawing.Point(43, 51);
            this.LB_PlayerName.Name = "LB_PlayerName";
            this.LB_PlayerName.Size = new System.Drawing.Size(67, 13);
            this.LB_PlayerName.TabIndex = 1;
            this.LB_PlayerName.Text = "Player Name";
            // 
            // LB_PlayerNum
            // 
            this.LB_PlayerNum.AutoSize = true;
            this.LB_PlayerNum.Location = new System.Drawing.Point(43, 91);
            this.LB_PlayerNum.Name = "LB_PlayerNum";
            this.LB_PlayerNum.Size = new System.Drawing.Size(76, 13);
            this.LB_PlayerNum.TabIndex = 2;
            this.LB_PlayerNum.Text = "Player Number";
            // 
            // LB_PlayerPos
            // 
            this.LB_PlayerPos.AutoSize = true;
            this.LB_PlayerPos.Location = new System.Drawing.Point(43, 129);
            this.LB_PlayerPos.Name = "LB_PlayerPos";
            this.LB_PlayerPos.Size = new System.Drawing.Size(76, 13);
            this.LB_PlayerPos.TabIndex = 3;
            this.LB_PlayerPos.Text = "Player Position";
            // 
            // TB_PlayerName
            // 
            this.TB_PlayerName.Location = new System.Drawing.Point(158, 48);
            this.TB_PlayerName.Name = "TB_PlayerName";
            this.TB_PlayerName.Size = new System.Drawing.Size(100, 20);
            this.TB_PlayerName.TabIndex = 4;
            // 
            // TB_PlayerNum
            // 
            this.TB_PlayerNum.Location = new System.Drawing.Point(158, 88);
            this.TB_PlayerNum.Name = "TB_PlayerNum";
            this.TB_PlayerNum.Size = new System.Drawing.Size(100, 20);
            this.TB_PlayerNum.TabIndex = 5;
            // 
            // BTN_AddPlayer
            // 
            this.BTN_AddPlayer.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_AddPlayer.ForeColor = System.Drawing.Color.White;
            this.BTN_AddPlayer.Location = new System.Drawing.Point(88, 180);
            this.BTN_AddPlayer.Name = "BTN_AddPlayer";
            this.BTN_AddPlayer.Size = new System.Drawing.Size(88, 46);
            this.BTN_AddPlayer.TabIndex = 7;
            this.BTN_AddPlayer.Text = "Add Player";
            this.BTN_AddPlayer.UseVisualStyleBackColor = false;
            this.BTN_AddPlayer.Click += new System.EventHandler(this.BTN_AddPlayer_Click);
            // 
            // BTN_AddTeam
            // 
            this.BTN_AddTeam.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_AddTeam.ForeColor = System.Drawing.Color.White;
            this.BTN_AddTeam.Location = new System.Drawing.Point(334, 180);
            this.BTN_AddTeam.Name = "BTN_AddTeam";
            this.BTN_AddTeam.Size = new System.Drawing.Size(88, 46);
            this.BTN_AddTeam.TabIndex = 15;
            this.BTN_AddTeam.Text = "Add Team";
            this.BTN_AddTeam.UseVisualStyleBackColor = false;
            this.BTN_AddTeam.Click += new System.EventHandler(this.BTN_AddTeam_Click);
            // 
            // TB_TeamCity
            // 
            this.TB_TeamCity.Location = new System.Drawing.Point(403, 123);
            this.TB_TeamCity.Name = "TB_TeamCity";
            this.TB_TeamCity.Size = new System.Drawing.Size(100, 20);
            this.TB_TeamCity.TabIndex = 14;
            // 
            // TB_TeamCountry
            // 
            this.TB_TeamCountry.Location = new System.Drawing.Point(403, 85);
            this.TB_TeamCountry.Name = "TB_TeamCountry";
            this.TB_TeamCountry.Size = new System.Drawing.Size(100, 20);
            this.TB_TeamCountry.TabIndex = 13;
            // 
            // TB_TeamName
            // 
            this.TB_TeamName.Location = new System.Drawing.Point(403, 45);
            this.TB_TeamName.Name = "TB_TeamName";
            this.TB_TeamName.Size = new System.Drawing.Size(100, 20);
            this.TB_TeamName.TabIndex = 12;
            // 
            // LB_TeamCity
            // 
            this.LB_TeamCity.AutoSize = true;
            this.LB_TeamCity.Location = new System.Drawing.Point(288, 126);
            this.LB_TeamCity.Name = "LB_TeamCity";
            this.LB_TeamCity.Size = new System.Drawing.Size(54, 13);
            this.LB_TeamCity.TabIndex = 11;
            this.LB_TeamCity.Text = "Team City";
            // 
            // LB_TeamCountry
            // 
            this.LB_TeamCountry.AutoSize = true;
            this.LB_TeamCountry.Location = new System.Drawing.Point(288, 88);
            this.LB_TeamCountry.Name = "LB_TeamCountry";
            this.LB_TeamCountry.Size = new System.Drawing.Size(73, 13);
            this.LB_TeamCountry.TabIndex = 10;
            this.LB_TeamCountry.Text = "Team Country";
            // 
            // LB_TeamName
            // 
            this.LB_TeamName.AutoSize = true;
            this.LB_TeamName.Location = new System.Drawing.Point(288, 48);
            this.LB_TeamName.Name = "LB_TeamName";
            this.LB_TeamName.Size = new System.Drawing.Size(65, 13);
            this.LB_TeamName.TabIndex = 9;
            this.LB_TeamName.Text = "Team Name";
            // 
            // List_Result
            // 
            this.List_Result.FormattingEnabled = true;
            this.List_Result.Location = new System.Drawing.Point(535, 151);
            this.List_Result.Name = "List_Result";
            this.List_Result.Size = new System.Drawing.Size(213, 212);
            this.List_Result.TabIndex = 18;
            this.List_Result.SelectedValueChanged += new System.EventHandler(this.Selected_player);
            // 
            // LB_Choose
            // 
            this.LB_Choose.AutoSize = true;
            this.LB_Choose.Location = new System.Drawing.Point(532, 95);
            this.LB_Choose.Name = "LB_Choose";
            this.LB_Choose.Size = new System.Drawing.Size(73, 13);
            this.LB_Choose.TabIndex = 21;
            this.LB_Choose.Text = "Choose Team";
            // 
            // CB_Choose_Team
            // 
            this.CB_Choose_Team.FormattingEnabled = true;
            this.CB_Choose_Team.Location = new System.Drawing.Point(627, 92);
            this.CB_Choose_Team.Name = "CB_Choose_Team";
            this.CB_Choose_Team.Size = new System.Drawing.Size(121, 21);
            this.CB_Choose_Team.TabIndex = 22;
            this.CB_Choose_Team.SelectedIndexChanged += new System.EventHandler(this.CB_Choose_Team_SelectedIndexChanged);
            // 
            // LB_Choose_Country
            // 
            this.LB_Choose_Country.AutoSize = true;
            this.LB_Choose_Country.Location = new System.Drawing.Point(532, 55);
            this.LB_Choose_Country.Name = "LB_Choose_Country";
            this.LB_Choose_Country.Size = new System.Drawing.Size(82, 13);
            this.LB_Choose_Country.TabIndex = 25;
            this.LB_Choose_Country.Text = "Choose Country";
            // 
            // CB_Choose_Country
            // 
            this.CB_Choose_Country.FormattingEnabled = true;
            this.CB_Choose_Country.Location = new System.Drawing.Point(627, 51);
            this.CB_Choose_Country.Name = "CB_Choose_Country";
            this.CB_Choose_Country.Size = new System.Drawing.Size(121, 21);
            this.CB_Choose_Country.TabIndex = 24;
            this.CB_Choose_Country.SelectionChangeCommitted += new System.EventHandler(this.Ndakmilihteam);
            // 
            // BTN_RemovePlayer
            // 
            this.BTN_RemovePlayer.BackColor = System.Drawing.Color.Red;
            this.BTN_RemovePlayer.ForeColor = System.Drawing.Color.White;
            this.BTN_RemovePlayer.Location = new System.Drawing.Point(661, 369);
            this.BTN_RemovePlayer.Name = "BTN_RemovePlayer";
            this.BTN_RemovePlayer.Size = new System.Drawing.Size(87, 46);
            this.BTN_RemovePlayer.TabIndex = 8;
            this.BTN_RemovePlayer.Text = "Remove Player";
            this.BTN_RemovePlayer.UseVisualStyleBackColor = false;
            this.BTN_RemovePlayer.Click += new System.EventHandler(this.BTN_RemovePlayer_Click);
            // 
            // CB_PlayerPos
            // 
            this.CB_PlayerPos.FormattingEnabled = true;
            this.CB_PlayerPos.Items.AddRange(new object[] {
            "GK",
            "DF",
            "MF",
            "FW"});
            this.CB_PlayerPos.Location = new System.Drawing.Point(158, 129);
            this.CB_PlayerPos.Name = "CB_PlayerPos";
            this.CB_PlayerPos.Size = new System.Drawing.Size(121, 21);
            this.CB_PlayerPos.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CB_PlayerPos);
            this.Controls.Add(this.LB_Choose_Country);
            this.Controls.Add(this.CB_Choose_Country);
            this.Controls.Add(this.CB_Choose_Team);
            this.Controls.Add(this.LB_Choose);
            this.Controls.Add(this.List_Result);
            this.Controls.Add(this.BTN_AddTeam);
            this.Controls.Add(this.TB_TeamCity);
            this.Controls.Add(this.TB_TeamCountry);
            this.Controls.Add(this.TB_TeamName);
            this.Controls.Add(this.LB_TeamCity);
            this.Controls.Add(this.LB_TeamCountry);
            this.Controls.Add(this.LB_TeamName);
            this.Controls.Add(this.BTN_RemovePlayer);
            this.Controls.Add(this.BTN_AddPlayer);
            this.Controls.Add(this.TB_PlayerNum);
            this.Controls.Add(this.TB_PlayerName);
            this.Controls.Add(this.LB_PlayerPos);
            this.Controls.Add(this.LB_PlayerNum);
            this.Controls.Add(this.LB_PlayerName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LB_PlayerName;
        private System.Windows.Forms.Label LB_PlayerNum;
        private System.Windows.Forms.Label LB_PlayerPos;
        private System.Windows.Forms.TextBox TB_PlayerName;
        private System.Windows.Forms.TextBox TB_PlayerNum;
        private System.Windows.Forms.Button BTN_AddPlayer;
        private System.Windows.Forms.Button BTN_AddTeam;
        private System.Windows.Forms.TextBox TB_TeamCity;
        private System.Windows.Forms.TextBox TB_TeamCountry;
        private System.Windows.Forms.TextBox TB_TeamName;
        private System.Windows.Forms.Label LB_TeamCity;
        private System.Windows.Forms.Label LB_TeamCountry;
        private System.Windows.Forms.Label LB_TeamName;
        private System.Windows.Forms.ListBox List_Result;
        private System.Windows.Forms.Label LB_Choose;
        private System.Windows.Forms.ComboBox CB_Choose_Team;
        private System.Windows.Forms.Label LB_Choose_Country;
        private System.Windows.Forms.ComboBox CB_Choose_Country;
        private System.Windows.Forms.Button BTN_RemovePlayer;
        private System.Windows.Forms.ComboBox CB_PlayerPos;
    }
}

