using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fight_club
{
    /// <summary>
    ///  Represents View part of the MVC pattern
    /// </summary>
    public partial class Form1 : Form
    {
        private Color C_NAME = Color.Blue;
        private Color C_PART = Color.MediumAquamarine;
        private Color C_DAMG = Color.Red;
        private Color C_CRIT = Color.DarkOrange;

        Model model;
        Controller controller;
        string name;
        string enemyName;
        bool gameOver = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            if (authForm.ShowDialog(this) != DialogResult.OK)
            {
                Close();
                return;
            }


            enemyName = "Your enemy";
            name = authForm.Name;

            Init();

            gbPlayer.Text = authForm.Name;
            gbEnemy.Text = enemyName;
        }

        public void Log(string message)
        {
            gameLog.AppendText(message);
            gameLog.SelectionStart = gameLog.Text.Length;
            gameLog.ScrollToCaret();
        }

        public void Log(string message, Color color)
        {
            gameLog.SelectionStart = gameLog.TextLength;
            gameLog.SelectionLength = 0;

            gameLog.SelectionColor = color;
            gameLog.AppendText(message);
            gameLog.SelectionColor = gameLog.ForeColor;

            gameLog.SelectionStart = gameLog.Text.Length;
            gameLog.ScrollToCaret();
        }

        void EnableButtons(bool state)
        {
            btnHead.Enabled = state;
            btnTorso.Enabled = state;
            btnLegs.Enabled = state;
        }

        void GameOver()
        {
            EnableButtons(false);
            Log("\n---> Click here to restart <---", C_DAMG);

            gameOver = true;
            gameLog.Cursor = Cursors.Hand;
        }

        /// <summary>
        ///  Subscribing to the events published by the Model
        /// </summary>
        void Init()
        {
            model = new Model(name, enemyName);
            controller = new Controller();
            controller.ModelRef = model;

            model.Player.RaiseBlockEvent += OnBlock;
            model.Enemy.RaiseBlockEvent += OnBlock;
            model.Player.RaiseWoundEvent += OnWound;
            model.Enemy.RaiseWoundEvent += OnWound;
            model.Player.RaiseDeathEvent += OnDeath;
            model.Enemy.RaiseDeathEvent += OnDeath;
            controller.RaiseTurnEvent += OnTurn;

            gameLog.Cursor = Cursors.Default;

            Log("The battle is on. Fight!");
            gbBodyPart.Text = "Body part to attack";
        }

        void Reset()
        {
            Init();

            gameOver = false;
            gameLog.Clear();
            EnableButtons(true);
            UpdatePlayerHealth(100);
            UpdateEnemyHealth(100);
        }

        void UpdatePlayerHealth(int health)
        {
            pbPlayer.Value = health;
            gbPlayerHealth.Text = "Health " + health + "/100";
        }

        void UpdateEnemyHealth(int health)
        {
            pbEnemy.Value = health;
            gbEnemyHealth.Text = "Health " + health + "/100";
        }

        void OnTurn(object sender, TurnEventArgs e)
        {
            Image img = pictureBox1.Image;
            img.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Image = img;

            gbBodyPart.Text = "Body part to " + (e.PlayerTurn ? "attack" : "protect");
        }

        void OnBlock(object sender, PlayerEventArgs e)
        {
            if(e.Damage < 30)
            {
                Log("\n");
                Log(e.Name, C_NAME);
                Log(" blocked incoming hit to their ");
                Log(e.Part.ToString(), C_PART);
            }
            else
            {
                Log("\n");
                Log(e.Name, C_NAME);
                Log(" successfully blocked incoming ");
                Log("critical ", C_CRIT);
                Log(" hit to their ");
                Log(e.Part.ToString(), C_PART);
            }
        }

        void OnWound(object sender, PlayerEventArgs e)
        {
            if (e.Damage < 30)
            {
                Log("\n");
                Log(e.Name, C_NAME);
                Log(" took ");
                Log(e.Damage.ToString(), C_DAMG);
                Log(" damage from incoming hit to their ");
                Log(e.Part.ToString(), C_PART);
            }
            else
            {
                Log("\n");
                Log(e.Name, C_NAME);
                Log(" was ");
                Log("critically ", C_CRIT);
                Log(" hit to their  ");
                Log(e.Part.ToString(), C_PART);
                Log(" for ");
                Log(e.Damage.ToString(), C_DAMG);
                Log(" damage");
            }

            if (enemyName == e.Name)
                UpdateEnemyHealth(e.CurrentHealth);
            else
                UpdatePlayerHealth(e.CurrentHealth);
        }

        void OnDeath(object sender, PlayerEventArgs e)
        {
            Log("\n");
            Log(e.Name, C_NAME);
            Log(" was killed by ");
            Log(e.Damage.ToString(), C_DAMG);
            Log(" damage blow to their ");
            Log(e.Part.ToString(), C_PART);

            if (enemyName == e.Name)
            {
                UpdateEnemyHealth(0);
                Log("\nVICTORY!", C_DAMG);

                Image img = pictureBox1.Image;
                img.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pictureBox1.Image = img;
            }
            else
            {
                UpdatePlayerHealth(0);
                Log("\nYOU DIED...", C_DAMG);
            }
            GameOver();
        }

        private void btnHead_Click(object sender, EventArgs e)
        {
            controller.PlayerTurn(BodyPart.Head);
        }

        private void btnTorso_Click(object sender, EventArgs e)
        {
            controller.PlayerTurn(BodyPart.Torso);
        }

        private void btnLegs_Click(object sender, EventArgs e)
        {
            controller.PlayerTurn(BodyPart.Legs);
        }

        private void gameLog_Click(object sender, EventArgs e)
        {
            if (gameOver)
            {
                Reset();
            }
        }
    }
}
