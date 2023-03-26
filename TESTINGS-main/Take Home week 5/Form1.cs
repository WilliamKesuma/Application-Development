using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Take_Home_week_5
{
    public partial class Form1 : Form
    {
        List<Team> teamlist = new List<Team>();
        
        public Form1()
        {
            ManU();
            Chelsea();
            InitializeComponent();
            choosecountry();
        }
        
        string selected_player = "";
        
        private void BTN_AddTeam_Click(object sender, EventArgs e)
        {
            Team team = new Team();
            team.TeamCountry = TB_TeamCountry.Text;
            team.TeamCity = TB_TeamCity.Text;
            team.TeamName = TB_TeamName.Text;
            team.Playerlist2 = new List<Player>();
            teamlist.Add(team);
            choosecountry();

           TB_TeamCountry.Clear();
           TB_TeamCity.Clear();
           TB_TeamName.Clear();
        }

        private void BTN_AddPlayer_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(TB_PlayerName.Text) == false || 
                String.IsNullOrEmpty(TB_PlayerNum.Text) == false || 
                String.IsNullOrEmpty(CB_PlayerPos.SelectedItem.ToString()) == false)
            {
                foreach(Team tim in teamlist) 
                {
                    if(CB_Choose_Team.SelectedItem.ToString() == tim.TeamName)
                    {
                        Player pemain = new Player();
                        pemain.PlayerName = TB_PlayerName.Text;
                        pemain.PlayerNum = TB_PlayerNum.Text;
                        pemain.PlayerPos = CB_PlayerPos.SelectedItem.ToString();
                        tim.Playerlist2.Add(pemain);
                        showplayer();

                        TB_PlayerName.Clear();
                        TB_PlayerNum.Clear();
                        CB_PlayerPos.Text = string.Empty;
                    }
                }
                
            }
        }

        private void showplayer()
        {
            List_Result.Items.Clear();
            foreach(Team tim in teamlist)
            {
                if (CB_Choose_Team.SelectedItem.ToString() == tim.TeamName)
                {
                    foreach (Player player in tim.Playerlist2)
                    {
                        List_Result.Items.Add("(" + player.PlayerNum + ") " + player.PlayerName + ", " + player.PlayerPos);
                    }
                }
            }
        }

        private void choosecountry()
        {
            CB_Choose_Country.Items.Clear();
            foreach (Team tim in teamlist)
            {
                if(CB_Choose_Country.Items.Contains(tim.TeamCountry))
                {
                    
                }
                else
                {
                    CB_Choose_Country.Items.Add(tim.TeamCountry);
                }
            }
        }
        private void showteam()
        {
            
            CB_Choose_Team.Items.Clear();
            foreach (Team tim in teamlist)
            {
                if(tim.TeamCountry == CB_Choose_Country.SelectedItem.ToString())
                {
                    CB_Choose_Team.Items.Add(tim.TeamName);
                }
            }
            
        }

        private void Ndakmilihteam(object sender, EventArgs e)
        {
            showteam();
        }

        private void Selected_player(object sender, EventArgs e)
        {
            selected_player = List_Result.SelectedItem.ToString();
        }

        private void ManU()
        {
            string[] PlayerNama = { "Nathan Bishop", "Jack Butland", "De Gea", "Tom Heaton", " Radek Vítek", "Rhys Bennett", "Diogo Dalot", "Tyler Fredricson", " Phil Jones", "Victor Lindelöf", "Harry Maguire"};
            string[] PlayerNomor = { "30", "31", "1", "22", "50", "66", "20", "80", "4", "2", "5"};
            string[] PlayerPosisi = {"GK", "GK", "GK", "GK", "GK", "DF", "DF", "DF", "DF", "DF", "DF", "DF"};
            Team team2 = new Team();
            team2.TeamCountry = "England";
            team2.TeamCity = "Manchester";
            team2.TeamName = "Manchester United";
            team2.Playerlist = new List<Player>();
            for(int i = 0; i < PlayerNama.Count(); i++) 
            { 
              Player player = new Player();
                player.PlayerName = PlayerNama[i];
                player.PlayerNum = PlayerNomor[i];
                player.PlayerPos = PlayerPosisi[i];
                team2.Playerlist.Add(player);
            }
            teamlist.Add(team2);

        }

        private void Chelsea()
        {
            string[] PlayerNama = { "John", "Jack", "kanye", "Tom", "Radek", "Bennett", "Dalot", "Tyler", "Jones", "Victor", "Harry" };
            string[] PlayerNomor = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "11" };
            string[] PlayerPosisi = { "GK", "GK", "GK", "GK", "GK", "DF", "DF", "DF", "DF", "DF", "DF", "DF" };
            Team team3 = new Team();
            team3.TeamCountry = "England";
            team3.TeamCity = "London";
            team3.TeamName = "Chelsea";
            team3.Playerlist = new List<Player>();
            for (int i = 0; i < PlayerNama.Count(); i++)
            {
                Player player = new Player();
                player.PlayerName = PlayerNama[i];
                player.PlayerNum = PlayerNomor[i];
                player.PlayerPos = PlayerPosisi[i];
                team3.Playerlist.Add(player);
            }
            teamlist.Add(team3);


        }

       
        private void BTN_RemovePlayer_Click(object sender, EventArgs e)
        {
            
            foreach (Team tim in teamlist)
            {
                if(tim.TeamCountry == CB_Choose_Country.SelectedItem.ToString())
                {
                    
                    for (int i = 0; i < tim.Playerlist2.Count; i++)
                    
                    {
                        
                        if ("(" + tim.Playerlist2[i].PlayerNum + ") " + tim.Playerlist2[i].PlayerName + ", " + tim.Playerlist2[i].PlayerPos == selected_player)
                        {
                            tim.Playerlist2.Remove(tim.Playerlist2[i]);
                            showplayer();
                            break;
                        }
                    }
                }
            }
        }

        private void CB_Choose_Team_SelectedIndexChanged(object sender, EventArgs e)
        {
            showplayer();
        }
    }
        
        
}
