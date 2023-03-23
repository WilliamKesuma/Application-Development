using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Take_Home_week_5
{
    public partial class Form1 : Form
    {
        List<Team> teamlist = new List<Team>();
        
        public Form1()
        {
            Team team2 = new Team();
            InitializeComponent();
            team2.TeamCountry = "USA";
            team2.TeamCity = "New York";
            team2.TeamName = "Yankees";
            teamlist.Add(team2);
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
            foreach (var tim in teamlist)
            {
                if(CB_Choose_Country.Items.Contains(tim.TeamCountry))
                {
                    CB_Choose_Country.Items[0] = tim.TeamCountry;
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
                            
                        }
                    }
                }
            }

            
        
        }
        
        private void Selected_player(object sender, EventArgs e)
        {
            selected_player = List_Result.SelectedItem.ToString();
            label_debug.Text = selected_player;
        }
    }
}
