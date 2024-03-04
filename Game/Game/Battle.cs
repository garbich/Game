using System;
using System.Drawing;
using System.Windows.Forms;

namespace Myspace
{
    public partial class Battle : Form
    {
        private bool part = true;
        public Battle()
        {
            InitializeComponent();
            if (Program.location == 1)
            {
                this.BackgroundImage = Image.FromFile("C:\\Users\\Support\\source\\repos\\Game\\Game\\assets\\Field.jpg");    
            }
            else if (Program.location == 2)
            {
                this.BackgroundImage = Image.FromFile("C:\\Users\\Support\\source\\repos\\Game\\Game\\assets\\City.png");
            }
            else if (Program.location == 3)
            {
                this.BackgroundImage = Image.FromFile("C:\\Users\\Support\\source\\repos\\Game\\Game\\assets\\Mountain.jpg");
            }

            part = true;
            label3.Visible = false;
            Crit.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crit.Visible = false;
            label1.Text = Program.round.ToString();

            chooseBattle();

            Program.round++;

        }



        private void mageBattlesPart1()
        {
            if (Program.choose == 1 && Program.choose2 == 2)
            {
                label3.Visible = true;
                label3.Text = "Attack mage";

                Program.player1Damage = Program.warrior1.Attack(Program.mage1Attack, Attack.Magical);
                Damage.Text = $"Player 1 damage: {Program.player1Damage}";

                criticalForMage(Program.mage1);

                Program.warrior1Health = Program.printHealth(Program.warrior1Health, Program.player1Damage);
                Health.Text = $"Player 2 health: {Program.warrior1Health}";


                if (Program.lose(Program.warrior1Health))
                {
                    MessageBox.Show("Warrior lose");
                    Program.reset();
                    backToStart();
                    return;
                }
            }
            else if (Program.choose == 1 && Program.choose2 == 3)
            {
                label3.Visible = true;
                label3.Text = "Attack mage";

                Program.player1Damage = Program.archer1.Attack(Program.mage1Attack, Attack.Magical);
                Damage.Text = $"Player 1 damage: {Program.player1Damage}";
                criticalForMage(Program.mage1);

                Program.archer1Health = Program.printHealth(Program.archer1Health, Program.player1Damage);
                Health.Text = $"Player 2 health: {Program.archer1Health}";

                if (Program.lose(Program.archer1Health))
                {
                    MessageBox.Show("Archer lose");
                    Program.reset();
                    backToStart();
                    return;
                }
            }
            else if (Program.choose == 1 && Program.choose2 == 1)
            {
                label3.Visible = true;
                label3.Text = "Attack mage 1";

                Program.player1Damage = Program.mage2.Attack(Program.mage1Attack, Attack.Magical);
                Damage.Text = $"Player 1 damage: {Program.player1Damage}";
                criticalForMage(Program.mage1);

                Program.mage2Health = Program.printHealth(Program.mage2Health, Program.player1Damage);
                Health.Text = $"Player 2 health: {Program.mage2Health}";

                if (Program.lose(Program.mage2Health))
                {
                    MessageBox.Show("Mage 2 lose");
                    Program.reset();
                    backToStart();
                    return;
                }
            }
        }
        private void mageBattlesPart2()
        {
            if (Program.choose == 1 && Program.choose2 == 2)
            {
                label3.Text = "Attack warrior";

                Program.player2Damage = Program.mage1.Attack(Program.warrior1Attack, Attack.Physical);
                Damage.Text = $"Player 2 damage: {Program.player2Damage}";
                criticalForWarrior(Program.warrior1);

                Program.mage1Health = Program.printHealth(Program.mage1Health, Program.player2Damage);
                Health.Text = $"Player 1 health: {Program.mage1Health}";


                if (Program.lose(Program.mage1Health))
                {
                    MessageBox.Show("Mage lose");
                    Program.reset();
                    backToStart();
                    return;
                }
            }
            else if (Program.choose == 1 && Program.choose2 == 3)
            {
                label3.Text = "Attack archer";

                Program.player2Damage = Program.mage1.Attack(Program.archer1Attack, Attack.Physical);
                Damage.Text = $"Player 2 damage: {Program.player2Damage}";
                criticalForArcher(Program.archer1);

                Program.mage1Health = Program.printHealth(Program.mage1Health, Program.player2Damage);
                Health.Text = $"Player 1 health: {Program.mage1Health}";


                if (Program.lose(Program.mage1Health))
                {
                    MessageBox.Show("Mage lose");
                    Program.reset();
                    backToStart();
                    return;
                }
            }
            else if (Program.choose == 1 && Program.choose2 == 1)
            {
                label3.Text = "Attack mage 2";

                Program.player2Damage = Program.mage1.Attack(Program.mage2Attack, Attack.Magical);
                Damage.Text = $"Player 2 damage: {Program.player2Damage}";
                criticalForMage(Program.mage2);

                Program.mage1Health = Program.printHealth(Program.mage1Health, Program.player2Damage);
                Health.Text = $"Player 1 health: {Program.mage1Health}";

                if (Program.lose(Program.mage1Health))
                {
                    MessageBox.Show("Mage 1 lose");
                    Program.reset();
                    backToStart();
                    return;
                }
            }
        }

        private void warriorBattlesPart1()
        {
            if (Program.choose == 2 && Program.choose2 == 1)
            {
                label3.Visible = true;
                label3.Text = "Attack Warrior";

                Program.player1Damage = Program.mage1.Attack(Program.warrior1Attack, Attack.Physical);
                Damage.Text = $"Player 1 damage: {Program.player1Damage}";
                criticalForWarrior(Program.warrior1);

                Program.mage1Health = Program.printHealth(Program.mage1Health, Program.player1Damage);
                Health.Text = $"Player 2 health: {Program.mage1Health}";


                if (Program.lose(Program.mage1Health))
                {
                    MessageBox.Show("Mage lose");
                    Program.reset();
                    backToStart();
                    return;
                }
            }
            else if (Program.choose == 2 && Program.choose2 == 3)
            {
                label3.Visible = true;
                label3.Text = "Attack warrior";

                Program.player1Damage = Program.archer1.Attack(Program.warrior1Attack, Attack.Physical);
                Damage.Text = $"Player 1 damage: {Program.player1Damage}";
                criticalForWarrior(Program.warrior1);

                Program.archer1Health = Program.printHealth(Program.archer1Health, Program.player1Damage);
                Health.Text = $"Player 2 health: {Program.archer1Health}";

                if (Program.lose(Program.archer1Health))
                {
                    MessageBox.Show("Archer lose");
                    Program.reset();
                    backToStart();
                    return;
                }
            }
            else if (Program.choose == 2 && Program.choose2 == 2)
            {
                label3.Visible = true;
                label3.Text = "Attack warrior 1";

                Program.player1Damage = Program.warrior2.Attack(Program.warrior1Attack, Attack.Physical);
                Damage.Text = $"Player 1 damage: {Program.player1Damage}";
                criticalForWarrior(Program.warrior1);

                Program.warrior2Health = Program.printHealth(Program.warrior2Health, Program.player1Damage);
                Health.Text = $"Player 2 health: {Program.warrior2Health}";

                if (Program.lose(Program.warrior2Health))
                {
                    MessageBox.Show("Warrior 2 lose");
                    Program.reset();
                    backToStart();
                    return;
                }
            }
        }
        private void warriorBattlesPart2()
        {
            if (Program.choose == 2 && Program.choose2 == 1)
            {
                label3.Text = "Attack mage";

                Program.player2Damage = Program.warrior1.Attack(Program.mage1Attack, Attack.Magical);
                Damage.Text = $"Player 2 damage: {Program.player2Damage}";
                criticalForMage(Program.mage1);

                Program.warrior1Health = Program.printHealth(Program.warrior1Health, Program.player2Damage);
                Health.Text = $"Player 1 health: {Program.warrior1Health}";


                if (Program.lose(Program.warrior1Health))
                {
                    MessageBox.Show("Warrior lose");
                    Program.reset();
                    backToStart();
                    return;
                }
            }
            else if (Program.choose == 2 && Program.choose2 == 3)
            {
                label3.Text = "Attack archer";

                Program.player2Damage = Program.warrior1.Attack(Program.archer1Attack, Attack.Physical);
                Damage.Text = $"Player 2 damage: {Program.player2Damage}";
                criticalForArcher(Program.archer1);

                Program.warrior1Health = Program.printHealth(Program.warrior1Health, Program.player2Damage);
                Health.Text = $"Player 1 health: {Program.warrior1Health}";


                if (Program.lose(Program.warrior1Health))
                {
                    MessageBox.Show("Warrior lose");
                    Program.reset();
                    backToStart();
                    return;
                }
            }
            else if (Program.choose == 2 && Program.choose2 == 2)
            {
                label3.Text = "Attack warrior 2";

                Program.player2Damage = Program.warrior2.Attack(Program.warrior2Attack, Attack.Physical);
                Damage.Text = $"Player 2 damage: {Program.player2Damage}";
                criticalForWarrior(Program.warrior2);

                Program.warrior1Health = Program.printHealth(Program.warrior1Health, Program.player2Damage);
                Health.Text = $"Player 1 health: {Program.warrior1Health}";

                if (Program.lose(Program.warrior1Health))
                {
                    MessageBox.Show("Warrior 1 lose");
                    Program.reset();
                    backToStart();
                    return;
                }
            }
        }

        private void archerBattlesPart1()
        {
            if (Program.choose == 3 && Program.choose2 == 1)
            {
                label3.Visible = true;
                label3.Text = "Attack archer";

                Program.player1Damage = Program.mage1.Attack(Program.archer1Attack, Attack.Physical);
                Damage.Text = $"Player 1 damage: {Program.player1Damage}";
                criticalForArcher(Program.archer1);

                Program.mage1Health = Program.printHealth(Program.mage1Health, Program.player1Damage);
                Health.Text = $"Player 2 health: {Program.mage1Health}";

                if (Program.lose(Program.mage1Health))
                {
                    MessageBox.Show("Mage lose");
                    Program.reset();
                    backToStart();
                    return;
                }
            }
            else if (Program.choose == 3 && Program.choose2 == 2)
            {
                label3.Visible = true;
                label3.Text = "Attack archer";

                Program.player1Damage = Program.warrior1.Attack(Program.archer1Attack, Attack.Physical);
                Damage.Text = $"Player 1 damage: {Program.player1Damage}";
                criticalForArcher(Program.archer1);

                Program.warrior1Health = Program.printHealth(Program.warrior1Health, Program.player1Damage);
                Health.Text = $"Player 2 health: {Program.warrior1Health}";


                if (Program.lose(Program.warrior1Health))
                {
                    MessageBox.Show("Warrior lose");
                    Program.reset();
                    backToStart();
                    return;
                }
            }
            else if (Program.choose == 3 && Program.choose2 == 3)
            {
                label3.Visible = true;
                label3.Text = "Attack archer 1";

                Program.player1Damage = Program.archer2.Attack(Program.archer1Attack, Attack.Physical);
                Damage.Text = $"Player 1 damage: {Program.player1Damage}";
                criticalForArcher(Program.archer1);

                Program.archer2Health = Program.printHealth(Program.archer2Health, Program.player1Damage);
                Health.Text = $"Player 2 health: {Program.archer2Health}";

                if (Program.lose(Program.archer2Health))
                {
                    MessageBox.Show("Archer 2 lose");
                    Program.reset();
                    backToStart();
                    return;
                }
            }
        }
        private void archerBattlesPart2()
        {
            if (Program.choose == 3 && Program.choose2 == 1)
            {
                label3.Text = "Attack mage";

                Program.player2Damage = Program.archer1.Attack(Program.mage1Attack, Attack.Magical);
                Damage.Text = $"Player 2 damage: {Program.player2Damage}";
                criticalForMage(Program.mage1);

                Program.archer1Health = Program.printHealth(Program.archer1Health, Program.player2Damage);
                Health.Text = $"Player 1 health: {Program.archer1Health}";

                if (Program.lose(Program.archer1Health))
                {
                    MessageBox.Show("Archer lose");
                    Program.reset();
                    backToStart();
                    return;
                }
            }
            else if (Program.choose == 3 && Program.choose2 == 2)
            {
                label3.Text = "Attack warrior";

                Program.player2Damage = Program.archer1.Attack(Program.warrior1Attack, Attack.Physical);
                Damage.Text = $"Player 2 damage: {Program.player2Damage}";
                criticalForWarrior(Program.warrior1);

                Program.archer1Health = Program.printHealth(Program.archer1Health, Program.player2Damage);
                Health.Text = $"Player 1 health: {Program.archer1Health}";

                if (Program.lose(Program.archer1Health))
                {
                    MessageBox.Show("Archer lose");
                    Program.reset();
                    backToStart();
                    return;
                }
            }
            else if (Program.choose == 3 && Program.choose2 == 3)
            {
                label3.Text = "Attack archer 2";

                Program.player2Damage = Program.archer1.Attack(Program.archer2Attack, Attack.Physical);
                Damage.Text = $"Player 2 damage: {Program.player2Damage}";
                criticalForArcher(Program.archer2);

                Program.archer1Health = Program.printHealth(Program.archer1Health, Program.player2Damage);
                Health.Text = $"Player 1 health: {Program.archer1Health}";

                if (Program.lose(Program.archer1Health))
                {
                    MessageBox.Show("Archer 1 lose");
                    Program.reset();
                    backToStart();
                    return;
                }
            }
        }

        private void chooseBattle()
        {
            if (Program.choose == 1)
            {
                if (part)
                {
                    mageBattlesPart1();
                    part = false;
                }
                else if (!part)
                {
                    mageBattlesPart2();
                    part = true;
                }
            }
            else if (Program.choose == 2)
            {
                if (part)
                {
                    warriorBattlesPart1();
                    part = false;
                }
                else if (!part)
                {
                    warriorBattlesPart2();
                    part = true;
                }
            }
            else if (Program.choose == 3)
            {
                if (part)
                {
                    archerBattlesPart1();
                    part = false;
                }
                else if (!part)
                {
                    archerBattlesPart2();
                    part = true;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            part = true;
            Program.reset();

            Form form = new Menu();

            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }

        private void criticalForMage(Mage mage)
        {
            if (mage.crit)
            {
                Crit.Visible = true;
                Crit.Text = "Attack with critical Damage";
            }
        }

        private void criticalForWarrior(Warrior warrior)
        {
            if (warrior.crit)
            {
                Crit.Visible = true;
                Crit.Text = "Attack with critical Damage";
            }
        }

        private void criticalForArcher(Archer archer)
        {
            if (archer.crit)
            {
                Crit.Visible = true;
                Crit.Text = "Attack with critical Damage";
            }
        }

        private void backToStart()
        {
            Form form = new Menu();
            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }
    }
}
