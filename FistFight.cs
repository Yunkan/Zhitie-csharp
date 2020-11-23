using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zhitie
{
    public partial class FistFight : Form
    {
        public int PlEn = 100,//Дыхалка игрока.
                   EnemyEn = 100,//Дыхалка противника.
                   EnemyHP = 100;//ХП противника.

        Random rnd = new Random();

        public int rndPlayerEnDMG,//Урон игрока дыхалке противника.
                   rndEnemyEnDMG,//Урон противника дыхалке игрока.
                   rndPlayerHPDMG,//Урон игрока по ХП противника.
                   rndEnemyHPDMG,//Урон противника по ХП игрока.
                   rndSelfEnDMG,//Затрата дыхалке при ударе.
                   rndNum, rndMoney;

        string[] EnemyName = new string[3] {"Челядь",
                                            "Деревенщина",
                                            "Быдло" };//Имена противника.
        string[] EnemyActions = new string[2] {" бьёт в голову!",
                                               " бьёт в тело!" };//Действия противника.
        string[] LoseInBattle = new string[4] {"Неудачник!\n",
                                               "Слабак!\n",
                                               "Ну, почти победа...\n",
                                               "Ты победил! Шучу...\n"};//Реплики при поражении.

        bool HeadIsDef = false, BodyIsDef = false, CountAttack = false;

        Form1 main = new Form1();

        public FistFight()
        {
            InitializeComponent();

            rndNum = rnd.Next(0, 3);
            enemy.Text = EnemyName[rndNum] + ":";
        }

        private void FistFight_Load(object sender, EventArgs e)
        {
            main.CheckSaves();
        }

        private void EndFight_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        //Удар.
        private void Hit_Click(object sender, EventArgs e)
        {
            HitMenu.Visible = true;
        }

        private void InHead_Click(object sender, EventArgs e)
        {
            rndNum = rnd.Next(1, 101);
            rndPlayerEnDMG = rnd.Next(15, 31);
            rndPlayerHPDMG = rnd.Next(0, 6);
            rndSelfEnDMG = rnd.Next(0, 6);

            //Срез урона, если включена защита.
            if (HeadIsDef)
            {
                rndPlayerEnDMG -= Convert.ToInt32(rndPlayerEnDMG * 0.25);
            }
            if (BodyIsDef)
            {
                rndPlayerEnDMG -= Convert.ToInt32(rndPlayerEnDMG * 0.25);
            }
            if (CountAttack)
            {
                rndPlayerEnDMG -= Convert.ToInt32(rndPlayerEnDMG * 0.25);
            }

            //Попадание.
            if (rndNum <= 50)//Шанс 50%.
            {
                rndNum = rnd.Next(1, 101);

                //Оглушение.
                if (rndNum <= 25)//Шанс 25%.
                {
                    EnemyEn -= rndPlayerEnDMG;
                    EnemyHP -= rndPlayerHPDMG;
                    PlEn -= rndSelfEnDMG;

                    MessageBox.Show("Ты попал в голову и оглушил!\nУрон: " + rndPlayerEnDMG);
                }
                else
                {
                    EnemyEn -= rndPlayerEnDMG;
                    EnemyHP -= rndPlayerHPDMG;
                    PlEn -= rndSelfEnDMG;

                    MessageBox.Show("Ты попал в голову!\nУрон: " + rndPlayerEnDMG);

                    //Контратака.
                    rndNum = rnd.Next(0, 101);

                    if (rndNum <= 25)//Шанс 25%.
                    {
                        rndEnemyEnDMG = rnd.Next(5, 16);
                        rndEnemyHPDMG = rnd.Next(0, 6);

                        EnemyEn -= rndSelfEnDMG;
                        PlEn -= rndEnemyEnDMG;
                        main.PlayerHealth -= rndEnemyHPDMG;

                        MessageBox.Show("Противник контратаковал!\nУрон: " + rndEnemyEnDMG);
                    }
                    EnemyTurn();
                }
            }
            else
            {
                PlEn -= rndSelfEnDMG;

                MessageBox.Show("Промах!");

                EnemyTurn();
            }
        }

        private void InBody_Click(object sender, EventArgs e)
        {
            rndNum = rnd.Next(1, 101);
            rndPlayerEnDMG = rnd.Next(10, 21);
            rndPlayerHPDMG = rnd.Next(0, 6);
            rndSelfEnDMG = rnd.Next(0, 6);

            //Срез урона, если включена защита.
            if (HeadIsDef)
            {
                rndPlayerEnDMG -= Convert.ToInt32(rndPlayerEnDMG * 0.25);
            }
            if (BodyIsDef)
            {
                rndPlayerEnDMG -= Convert.ToInt32(rndPlayerEnDMG * 0.25);
            }
            if (CountAttack)
            {
                rndPlayerEnDMG -= Convert.ToInt32(rndPlayerEnDMG * 0.25);
            }

            //Попадание.
            if (rndNum <= 75)//Шанс 75%.
            {
                EnemyEn -= rndPlayerEnDMG;
                EnemyHP -= rndPlayerHPDMG;
                PlEn -= rndSelfEnDMG;

                MessageBox.Show("Ты попал в тело!\nУрон: " + rndPlayerEnDMG);

                //Контратака.
                rndNum = rnd.Next(0, 101);

                if (rndNum <= 25)//Шанс 25%.
                {
                    rndEnemyEnDMG = rnd.Next(5, 16);
                    rndEnemyHPDMG = rnd.Next(0, 6);

                    EnemyEn -= rndSelfEnDMG;
                    PlEn -= rndEnemyEnDMG;
                    main.PlayerHealth -= rndEnemyHPDMG;

                    MessageBox.Show("Противник контратаковал!\nУрон: " + rndEnemyEnDMG);
                }
                EnemyTurn();
            }
            else
            {
                PlEn -= rndSelfEnDMG;

                MessageBox.Show("Промах!");

                EnemyTurn();
            }
        }

        private void CloseHitMenu_Click(object sender, EventArgs e)
        {
            HitMenu.Visible = false;
        }

        //Удар.

        //Защита.
        private void Defense_Click(object sender, EventArgs e)
        {
            DefenseMenu.Visible = true;
        }

        private void DefHead_Click(object sender, EventArgs e)
        {
            if (HeadIsDef)
            {
                HeadIsDef = false;
                DefHead.ForeColor = SystemColors.ControlText;
            }
            else
            {
                HeadIsDef = true;
                DefHead.ForeColor = SystemColors.HotTrack;
            }
        }

        private void DefBody_Click(object sender, EventArgs e)
        {
            if (BodyIsDef)
            {
                BodyIsDef = false;
                DefBody.ForeColor = SystemColors.ControlText;
            }
            else
            {
                BodyIsDef = true;
                DefBody.ForeColor = SystemColors.HotTrack;
            }
        }

        private void CounterAttack_Click(object sender, EventArgs e)
        {
            if (CountAttack)
            {
                CountAttack = false;
                CounterAttack.ForeColor = SystemColors.ControlText;
            }
            else
            {
                CountAttack = true;
                CounterAttack.ForeColor = SystemColors.HotTrack;
            }
        }

        private void CloseDefenseMenu_Click(object sender, EventArgs e)
        {
            DefenseMenu.Visible = false;
        }

        //Защита.

        //Обновление ХП.
        private void RefreshHP_Tick(object sender, EventArgs e)
        {
            if (PlEn < 0) PlEn = 0;
            if (EnemyEn < 0) EnemyEn = 0;

            PlayerEnergy.Text = PlEn.ToString();
            PlayerHealth.Text = main.PlayerHealth.ToString();
            EnemyEnergy.Text = EnemyEn.ToString();
            EnemyHealth.Text = EnemyHP.ToString();
        }

        //Ход противника.
        private void EnemyTurn()
        {
            if (EnemyEn > 0)
            {
                rndNum = rnd.Next(0, 2);

                //Удар в голову.
                if (EnemyActions[rndNum].Contains("в голову"))
                {
                    rndNum = rnd.Next(0, 101);
                    rndEnemyEnDMG = rnd.Next(15, 31);
                    rndEnemyHPDMG = rnd.Next(0, 6);
                    rndSelfEnDMG = rnd.Next(0, 6);

                    //Попадание.
                    if (rndNum <= 50)//Шанс 50%. 
                    {
                        if (HeadIsDef)//Если игрок защищал голову, удар получается в 20% от силы.
                        {
                            EnemyEn -= rndSelfEnDMG;
                            PlEn -= Convert.ToInt32(rndEnemyEnDMG * 0.8);

                            MessageBox.Show("Ты заблокировал удар в голову!\nДыхалка - " + (rndEnemyEnDMG * 0.8));
                        }
                        else
                        {
                            //Удар без промаха и защиты.
                            EnemyEn -= rndSelfEnDMG;
                            PlEn -= rndEnemyEnDMG;
                            main.PlayerHealth -= rndEnemyHPDMG;

                            MessageBox.Show(enemy.Text.Replace(":", "") + EnemyActions[0] + "\nДыхалка - " + rndEnemyEnDMG + "\nСамочувствие - " + rndEnemyHPDMG);
                        }

                        if (CountAttack)//Контратака.
                        {
                            rndNum = rnd.Next(1, 101);

                            if (rndNum <= 25)//Шанс 25%.
                            {
                                rndPlayerEnDMG = rnd.Next(5, 16);
                                rndPlayerHPDMG = rnd.Next(0, 6);

                                PlEn -= rndSelfEnDMG;
                                EnemyEn -= rndPlayerEnDMG;
                                EnemyHP -= rndPlayerHPDMG;

                                MessageBox.Show("Ты контратаковал!\nУрон: " + rndPlayerEnDMG);
                            }
                        }
                    }
                    else
                    {
                        EnemyEn -= rndSelfEnDMG;
                        MessageBox.Show(enemy.Text.Replace(":", "") + " промахнулся!");//Промах.
                    }
                    CheckResult();
                }
                //Удар в тело.
                else if (EnemyActions[rndNum].Contains("в тело"))
                {
                    rndNum = rnd.Next(0, 101);
                    rndEnemyEnDMG = rnd.Next(10, 21);
                    rndEnemyHPDMG = rnd.Next(0, 6);
                    rndSelfEnDMG = rnd.Next(0, 6);

                    //Попадание.
                    if (rndNum <= 75)//Шанс 75%.
                    {
                        if (BodyIsDef)//если игрок защищал тело, удар получается в пол силы.
                        {
                            EnemyEn -= rndSelfEnDMG;
                            PlEn -= Convert.ToInt32(rndEnemyEnDMG * 0.8);

                            MessageBox.Show("Ты заблокировал удар в тело!\nДыхалка - " + (rndEnemyEnDMG * 0.8));
                        }
                        else
                        {
                            //Удар без промаха и защиты.
                            PlEn -= rndEnemyEnDMG;
                            EnemyEn -= rndSelfEnDMG;
                            main.PlayerHealth -= rndEnemyHPDMG;

                            MessageBox.Show(enemy.Text.Replace(":", "") + EnemyActions[1] + "\nДыхалка - " + rndEnemyEnDMG + "\nСамочувствие - " + rndEnemyHPDMG);
                        }

                        if (CountAttack)//Контратака.
                        {
                            rndNum = rnd.Next(1, 101);

                            if (rndNum <= 25)//Шанс 25%.
                            {
                                rndPlayerEnDMG = rnd.Next(5, 16);
                                rndPlayerHPDMG = rnd.Next(0, 6);

                                PlEn -= rndSelfEnDMG;
                                EnemyEn -= rndPlayerEnDMG;
                                EnemyHP -= rndPlayerHPDMG;

                                MessageBox.Show("Ты контратаковал!\nУрон: " + rndPlayerEnDMG);
                            }
                        }
                    }
                    else
                    {
                        EnemyEn -= rndSelfEnDMG;

                        MessageBox.Show(enemy.Text.Replace(":", "") + " промахнулся!");//Промах.
                    }
                    CheckResult();
                }
            }
            else
                CheckResult();
        }

        //Проверка выйгрыша или проигрыша.
        private void CheckResult()
        {
            if (PlEn <= 0 || main.PlayerHealth <= 0)
            {
                rndNum = rnd.Next(0, 4);

                rndMoney = rnd.Next(5, 11);

                MessageBox.Show(LoseInBattle[rndNum] + "\nДеньги +" + rndMoney);

                Close();
            }
            else if (EnemyEn <= 0)
            {
                rndMoney = rnd.Next(10, 31);

                MessageBox.Show("Ты выйграл!\nДеньги +" + rndMoney);

                Close();
            }
        }
    }
}