using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;
using game;
using people;

namespace Reality_Game_Show_Emulator
{
    public partial class frmEmulatorScreen : Form
    {
        public frmEmulatorScreen()
        {
            InitializeComponent();
        }
        // Game that the user is currently doing.
        public game.game current = new game.game();

        //opens up form to create a contestant
        private void add_contestant(){
            contestantForm profile = new contestantForm();
            profile.ShowDialog();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int numberOfContestants;
            try
            {
                numberOfContestants = Convert.ToInt32(Interaction.InputBox("How many contestants are competiting?"));
            }
            catch (FormatException er)
            {
                MessageBox.Show("Type in a whole number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numberOfContestants = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numberOfContestants = 1;
            }

            int i = 0;

            do {
                add_contestant();
                i++;
            } while (i < numberOfContestants);
        }
    }
}
