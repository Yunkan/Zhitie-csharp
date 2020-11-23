using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Zhitie
{
    public partial class Form1 : Form
    {
        public int PlayerHealth = 0;//Здоровье.
        public int PlayerHungry = 0;//Голод.
        public int PlayerStamina = 0;//Усталость.
        public int PlayerMoney = 0;//Деньги.
        public int hour = 0;//Часы.
        public int day = 0;//Дни.
        int AdvCD = 24;//КД приключения.

        string SavePath = "Saves.txt";//Путь к сохранениям.
        string states = "";//Статистика для сохранений.

        Random rnd = new Random();

        int rndHungry, rndStamina, rndHealth, rndNum, rndMoney;//Для рандома статистик.

        string[] NoMoneyReplics = new string[4] {"Нужно больше золота!",
                                                 "Не хватает монет!",
                                                 "Маловато будет!",
                                                 "Лучше подкопить."};//Реплики для нехватки монет.
        string[] CaughtReplics = new string[3] {"Алярм!\nТебя поймали и избили!",
                                                "Тикай с села!\nТы попался и получил по башне.",
                                                "Нас спалили!\nУ тебя начала болеть голова..."};//Реплики при поимке кражи яблок.
        string[] NoTime4Adv = new string[2] {"Куда намылился? Ещё не время.",
                                             "Не время для приключений!",};//Реплики если не время для приключений.

        public Form1()
        {
            InitializeComponent();
            CheckSaves();
        }

        //Открытие окна приключений, начало приключения.
        private void StartAdventure_Click(object sender, EventArgs e)
        {
            if (AdvCD == 0)
            {
                Step();

                Adventures AdventureForm = new Adventures();
                AdventureForm.ShowDialog();

                day++;
                AdvCD = 24;
                PlayerHealth += AdventureForm.rndHealth;
                PlayerHungry -= AdventureForm.rndHungry;
                PlayerStamina += AdventureForm.rndStamina;
                PlayerMoney += AdventureForm.rndMoney;
            }
            else
            {
                rndNum = rnd.Next(0, 2);
                MessageBox.Show(NoTime4Adv[rndNum]);
            }
        }
        
        //Еда.
        private void eating_Click(object sender, EventArgs e)
        {
            FoodMenu.Visible = true;
        }

        private void StealApples_Click(object sender, EventArgs e)
        {
            rndNum = rnd.Next(1, 101);
            rndHealth = rnd.Next(5, 11);
            rndStamina = rnd.Next(10, 21);

            if (rndNum <= 75)//Шанс 75%.
            {
                PlayerHungry += 15;
            }
            else
            {
                rndNum = rnd.Next(0, 3);
                PlayerHealth -= rndHealth;
                PlayerStamina -= rndStamina;
                MessageBox.Show(CaughtReplics[rndNum]);
            }
            Step();
        }

        private void EatBread_Click(object sender, EventArgs e)
        {
            rndNum = rnd.Next(0, 4);

            if (PlayerMoney >= 10)
            {
                PlayerHungry += 25;
                PlayerMoney -= 10;
            }
            else
                MessageBox.Show(NoMoneyReplics[rndNum]);

            Step();
        }

        private void BreadWithSausage_Click(object sender, EventArgs e)
        {
            rndNum = rnd.Next(0, 4);

            if (PlayerMoney >= 15)
            {
                PlayerHungry += 35;
                PlayerMoney -= 15;
            }
            else
                MessageBox.Show(NoMoneyReplics[rndNum]);

            Step();
        }

        private void CloseFoodMenu_Click(object sender, EventArgs e)
        {
            FoodMenu.Visible = false;
        }
        //Еда.

        //Отдых.
        private void sleeping_Click(object sender, EventArgs e)
        {
            SleepMenu.Visible = true;
        }

        private void SleepOnEarth_Click(object sender, EventArgs e)
        {
            rndHungry = rnd.Next(5, 11);

            PlayerStamina += 25;
            PlayerHungry -= rndHungry;
            
            Step();
        }

        private void SleepInPub_Click(object sender, EventArgs e)
        {
            rndHungry = rnd.Next(10, 21);
            rndNum = rnd.Next(0, 4);

            if (PlayerMoney >= 30)
            {
                PlayerStamina += 25;
                PlayerHungry += rndHungry;
                PlayerMoney -= 30; 
            }
            else
                MessageBox.Show(NoMoneyReplics[rndNum]);
            Step();
        }

        private void CloseSleepMenu_Click(object sender, EventArgs e)
        {
            SleepMenu.Visible = false;
        }
        //Отдых.

        //Работа.
        private void working_Click(object sender, EventArgs e)
        {
            WorkMenu.Visible = true;
        }

        private void FistBattle_Click(object sender, EventArgs e)
        {
            FistFight FistFightMenu = new FistFight();
            FistFightMenu.ShowDialog();

            PlayerHealth = Convert.ToInt32(FistFightMenu.PlayerHealth.Text);
            PlayerMoney += FistFightMenu.rndMoney;
            PlayerStamina -= Convert.ToInt32((100 - FistFightMenu.PlEn) * 0.5);
            Step();
        }

        private void charity_Click(object sender, EventArgs e)
        {
            rndMoney = rnd.Next(0, 4);

            MessageBox.Show("Ты получил " + rndMoney + "м.");
            PlayerMoney += rndMoney;

            Step();
        }

        private void TwentyOne_Click(object sender, EventArgs e)
        {
            TwentyOneGame TwOneMenu = new TwentyOneGame();
            TwOneMenu.ShowDialog();

            if (TwOneMenu.GiveUp)
                PlayerMoney -= Convert.ToInt32(TwOneMenu.bet.Text);
            else 
                PlayerMoney += TwOneMenu.rndMoney;

            Step();
        }
        
        private void CloseWorkMenu_Click(object sender, EventArgs e)
        {
            WorkMenu.Visible = false;
        }
        //Работа.

        //Лечение.
        private void heal_Click(object sender, EventArgs e)
        {
            HealMenu.Visible = true;
        }

        private void plantain_Click(object sender, EventArgs e)
        {
            PlayerHealth += 5;
            Step();
        }

        private void bandage_Click(object sender, EventArgs e)
        {
            rndNum = rnd.Next(0, 4);

            if (PlayerMoney >= 10)
            {
                PlayerHealth += 15;
                PlayerMoney -= 10;
            }
            else
                MessageBox.Show(NoMoneyReplics[rndNum]);
            Step();
        }

        private void BandageWithHerbs_Click(object sender, EventArgs e)
        {
            rndNum = rnd.Next(0, 4);

            if (PlayerMoney >= 15)
            {
                PlayerHealth += 30;
                PlayerMoney -= 15;
            }
            else
                MessageBox.Show(NoMoneyReplics[rndNum]);
            Step();
        }

        private void CloseHealMenu_Click(object sender, EventArgs e)
        {
            HealMenu.Visible = false;
        }

        //Лечение.

        //Один ход - один час. Сохранение.
        public void Step()
        {
            hour++;
            AdvCD--;
            rndHungry = rnd.Next(1, 6);
            rndStamina = rnd.Next(1, 6);
            PlayerHungry -= rndHungry;
            PlayerStamina -= rndStamina;

            if (hour == 24)
            {
                hour = 0;
                day++;
            }

            using (StreamWriter swSaves = new StreamWriter(SavePath, false, Encoding.Default))
            {
                swSaves.WriteLine("З " + PlayerHealth + "/");
                swSaves.WriteLine("\nЖ " + PlayerHungry + "/");
                swSaves.WriteLine("\nЭ " + PlayerStamina + "/");
                swSaves.WriteLine("\nМ " + PlayerMoney + "/");
                swSaves.WriteLine("\nЧ " + hour + "/");
                swSaves.WriteLine("\nД " + day + "/");
                swSaves.WriteLine("\nА " + AdvCD + "/");
            }
        }

        //Обновление статистики.
        public void RefreshStates_Tick(object sender, EventArgs e)
        {
            if (PlayerStamina < 0)
            {
                PlayerStamina = 0;
                PlayerHealth -= 5;
            }
            if (PlayerHungry < 0)
            {
                PlayerHungry = 0;
                PlayerHealth -= 5;
            }
            if (PlayerMoney < 0) PlayerMoney = 0;
            if (PlayerHungry > 100) PlayerHungry = 100;
            if (PlayerStamina > 100) PlayerStamina = 100;
            if (PlayerHealth > 100) PlayerHealth = 100;
            if (AdvCD < 0) AdvCD = 0;

            hunger.Text = PlayerHungry.ToString();
            stamina.Text = PlayerStamina.ToString();
            money.Text = PlayerMoney.ToString();
            health.Text = PlayerHealth.ToString();
            clock.Text = hour.ToString() + ":00";
            LiveDay.Text = day.ToString();
            StartAdventure.Text = "Начать приключение(" + AdvCD + ")";
        }

        //Чтение сохранений
        public void CheckSaves()
        {
            using (StreamReader srSaves = new StreamReader(SavePath, Encoding.Default))
            {
                states = srSaves.ReadToEnd();

                for (int i = 0; i < states.Length; i++)
                {
                    //Здоровье.
                    if(states[i] == 'З')
                        for(int j = i; j < states.Length; j++)
                        {
                            if(states[j] == '/')
                            {
                                PlayerHealth = Convert.ToInt32(states.Substring(i + 2, j - (i + 2)));
                                break;
                            }
                        }

                    //Живот набит на.
                    if (states[i] == 'Ж')
                        for (int j = i; j < states.Length; j++)
                        {
                            if (states[j] == '/')
                            {
                                PlayerHungry = Convert.ToInt32(states.Substring(i + 2, j - (i + 2)));
                                break;
                            }
                        }

                    //Энергия.
                    if (states[i] == 'Э')
                        for (int j = i; j < states.Length; j++)
                        {
                            if (states[j] == '/')
                            {
                                PlayerStamina = Convert.ToInt32(states.Substring(i + 2, j - (i + 2)));
                                break;
                            }
                        }

                    //Деньги.
                    if (states[i] == 'М')
                        for (int j = i; j < states.Length; j++)
                        {
                            if (states[j] == '/')
                            {
                                PlayerMoney = Convert.ToInt32(states.Substring(i + 2, j - (i + 2)));
                                break;
                            }
                        }

                    //Часы.
                    if (states[i] == 'Ч')
                        for (int j = i; j < states.Length; j++)
                        {
                            if (states[j] == '/')
                            {
                                hour = Convert.ToInt32(states.Substring(i + 2, j - (i + 2)));
                                break;
                            }
                        }

                    //Дни.
                    if (states[i] == 'Д')
                        for (int j = i; j < states.Length; j++)
                        {
                            if (states[j] == '/')
                            {
                                day = Convert.ToInt32(states.Substring(i + 2, j - (i + 2)));
                                break;
                            }
                        }
                    //КД приключения.
                    if (states[i] == 'А')
                        for (int j = i; j < states.Length; j++)
                        {
                            if (states[j] == '/')
                            {
                                AdvCD = Convert.ToInt32(states.Substring(i + 2, j - (i + 2)));
                                break;
                            }
                        }
                }
            }
        }
        //Чтение сохранений.
    }
}
