using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStat_Tracker
{
    public partial class GameStatTracker : Form
    {
        TestingClass tc;
        Color buttonActiveColor = Color.LightBlue;
        Color buttonInactiveColor = Color.Gray;
        Random rand = new Random();

        public GameStatTracker()
        {
            tc = new TestingClass();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToggleButton(AddGame_button, false);
            GamesAvaliableListBox.DataSource = tc.AvaliableGames;
            PlatformListBox.DataSource = tc.AvaliablePlatforms;
            //GamesAddedDataGrid.DataSource = tc.CurrentPlayer.games;
            var source = new BindingSource();
            source.DataSource = tc.CurrentPlayer.games;
            GamesAddedDataGrid.DataSource = source;
            

        }

        public void CheckForLoginEntered()
        {
            if (UsernameEnter_textbox.Text.Length > 0)
                ToggleButton(AddGame_button, true);
            else
                ToggleButton(AddGame_button, false);
        }

        public void ToggleButton(Button button, bool state)
        {
            button.Enabled = state;
            if (state) button.BackColor = buttonActiveColor;
            else button.BackColor = buttonInactiveColor;
        }
        private void UsernameEnter_textbox_TextChanged(object sender, EventArgs e)
        {
            CheckForLoginEntered();
        }

        private void GameStatTracker_Click(object sender, EventArgs e)
        {
            ActiveForm.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

        private void AddGame_button_click(object sender, EventArgs e)
        {
            tc.AddGame(UsernameEnter_textbox.Text,
                        GamesAvaliableListBox.SelectedItem.ToString(),
                        PlatformListBox.SelectedItem.ToString());
            GamesAddedTextBox.Text = tc.PlayerString();
            var source = new BindingSource();
            source.DataSource = tc.CurrentPlayer.games;
            GamesAddedDataGrid.DataSource = source;
        }

        private void GamesAvaliableListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GamesAvaliableListBox_MouseMove(object sender, MouseEventArgs e)
        {
            int index = GamesAvaliableListBox.IndexFromPoint(e.Location);

            if (index != -1 && index < GamesAvaliableListBox.Items.Count)
            {
                if (GamesToolTip.GetToolTip(GamesAvaliableListBox) != tc.GameDescriptions[index])
                {
                    GamesToolTip.SetToolTip(GamesAvaliableListBox, tc.GameDescriptions[index]);
                }
            }
            else
            {
                GamesToolTip.SetToolTip(GamesAvaliableListBox, string.Empty);
            }
        }
    }
}
