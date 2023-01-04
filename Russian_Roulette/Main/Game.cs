using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Roulette
{
    public partial class Game : Form
    {
        private int bulletsDefaultCount;
        private int _bullets;
        private int[] bulletSlots;
        private int currentPos = 1;
        private int spinCount;
        private bool suicide;
        public Game(int bullets)
        {
            InitializeComponent();
            _bullets = bullets;
            bulletsDefaultCount = _bullets;
            bulletSlots = LoadRevolver(_bullets);
            if(bulletsDefaultCount != 6)
            {
                bulletsLeftTextBox.Text += $" {_bullets}";
            }
            else
            {
                suicide = true;
                bulletsLeftTextBox.Text += $"Bye!";
            }
            
            PlaySpinAndCockSounds();
        }

        private void shootButton_Click(object sender, EventArgs e)
        {
            if (bulletSlots.Contains(currentPos))
            {
                int shotBulletIndex = Array.IndexOf(bulletSlots, currentPos);
                bulletSlots[shotBulletIndex] = 0;
                bulletSlots = bulletSlots.Where(b => b != 0).ToArray();
                _bullets--;
                if(_bullets == 0 || suicide)
                {
                    PlayShotSound();
                    if(suicide)
                    {
                        MessageBox.Show("Bye!", "Bye!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("You died!", "Nice shot", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    shootButton.Enabled = false;
                    spinButton.Enabled = false;
                    tryAgainButton.Visible = true;
                    newGameButton.Visible = true;
                    if(!suicide)
                    {
                        bulletsLeftTextBox.Text = $"Bullets left: {_bullets}";
                    }
                    else { bulletsLeftTextBox.Text = $"Bullets left: RIP"; }
                    
                }
                else
                {
                    PlayShotSound();
                    MessageBox.Show("You died!", "Nice shot", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bulletsLeftTextBox.Text = $"Bullets left: {_bullets}";
                    CockRevolver();
                }
            }
            else
            {
                PlayEmptyShotSound();
                MessageBox.Show("The gun didn't fire!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                CockRevolver();
            }
            currentPos++;
            if(currentPos > 6)
            {
                currentPos = 1;
            }
        }

        private void spinButton_Click(object sender, EventArgs e) 
        {
            Random rnd = new Random();
            int increment = rnd.Next(1, 7); 
            for (int i = 0; i < bulletSlots.Length; i++)
            {
                int temp = bulletSlots[i];   
                temp += increment; 
                if(temp > 6)
                {
                    temp -= 6;
                }
                bulletSlots[i] = temp;
            }
            PlaySpinAndCockSounds();
            spinCount++;
            currentPos = 1;
            if(spinCount == 2)
            {
                spinButton.Enabled = false;
            }
        }
        private void introButton_Click(object sender, EventArgs e)
        {
            Intro intro = new Intro();
            intro.Show();
            this.Hide();
        }

        private void tryAgainButton_Click(object sender, EventArgs e)
        {
            Game reborn = new Game(bulletsDefaultCount);
            reborn.Show();
            this.Hide();
        }
        private void newGameButton_Click(object sender, EventArgs e)
        {
            Menu settings = new Menu();
            settings.Show();
        }
        private void Game_Load(object sender, EventArgs e)
        {

        }







        //Methods
        private static void CockRevolver()
        {
            using (var soundPlayer = new SoundPlayer(System.IO.Path.Combine(System.Environment.CurrentDirectory, "Sounds", "cock.wav")))
            {
                soundPlayer.Play();
            }
        }
        private static void PlayEmptyShotSound()
        {
            using (var soundPlayer = new SoundPlayer(System.IO.Path.Combine(System.Environment.CurrentDirectory, "Sounds", "empty.wav")))
            {
                soundPlayer.Play();
            }
        }
        private static void PlayShotSound()
        {
            using (var soundPlayer = new SoundPlayer(System.IO.Path.Combine(System.Environment.CurrentDirectory, "Sounds", "shot.wav")))
            {
                soundPlayer.Play();
            }
        }
        private static void PlaySpinAndCockSounds()
        {
            using (var soundPlayer = new SoundPlayer(System.IO.Path.Combine(System.Environment.CurrentDirectory, "Sounds", "spin.wav")))
            {
                soundPlayer.PlaySync();
            }
            using (var soundPlayer = new SoundPlayer(System.IO.Path.Combine(System.Environment.CurrentDirectory, "Sounds", "cock.wav")))
            {
                soundPlayer.PlaySync();
            }
        }

        private int[] LoadRevolver(int _bullets)
        {
            int[] bulletSlots = new int[_bullets]; 
            for (int i = 0; i < _bullets; i++)
            {
                Random rnd = new Random();
                int bulletNum = rnd.Next(1, 7); 

                while (bulletSlots.Contains(bulletNum))
                {
                    rnd = new Random();
                    bulletNum = rnd.Next(1, 7);
                }
                bulletSlots[i] = bulletNum; 
            }
            return bulletSlots;
 
        }

        
    }
}
