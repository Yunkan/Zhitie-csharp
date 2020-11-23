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
    public partial class TwentyOneGame : Form
    {

        Form1 main = new Form1();

        bool [] UsedCards = new bool[11] {false, false, false, false, false, false, false, false, false, false, false};

        PictureBox[] Cards = new PictureBox[11];

        Bitmap img;

        Random rnd = new Random();

        public int rndNum, rndMoney;
        int num = 0;//Номер карты.

        int PlayerScore = 0,//Очки игрока.
            EnemyScore = 0;//Очки противника.

        //Координаты карт.
        int PlayerXC = 3,
            EnemyXC = 3;

        //Нажат ли "пас".
        bool PlayerPassed = false,
            EnemyPassed = false;

        //Нажата ли кнопка "уйти".
        public bool GiveUp = false;

        string[] LoseInBattle = new string[4] {"Неудачник!\n",
                                               "Слабак!\n",
                                               "Ну, почти победа...\n",
                                               "Ты победил! Шучу...\n"};//Реплики при поражении.

        public TwentyOneGame()
        {
            InitializeComponent();
        }

        private void TwentyOneGame_Load(object sender, EventArgs e)
        {
            main.CheckSaves();

            YourMoney.Text += main.PlayerMoney.ToString();
        }

        private void bet_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        //Выйти из игры.
        private void EndGame_Click(object sender, EventArgs e)
        {
            GiveUp = true;
            Close();
        }

        //Поставить.
        private void AcceptBet_Click(object sender, EventArgs e)
        {
            if (bet.Text != "" && main.PlayerMoney >= Convert.ToInt32(bet.Text))
            {
                EnemySide.Visible = true;
                PlayerSide.Visible = true;
                GetOneCard.Visible = true;
                pass.Visible = true;
                EnemyFirstCard.Visible = true;
                PlayerScoreText.Visible = true;
                EnemyScoreText.Visible = true;

                bet.ReadOnly = true;
                AllIn.Enabled = false;
                AcceptBet.Enabled = false;

                BeginGame();
            }
            else
                MessageBox.Show("У тебя нет столько денег!");
        }

        //Ва-банк.
        private void AllIn_Click(object sender, EventArgs e)
        {
            bet.Text = main.PlayerMoney.ToString();

            EnemySide.Visible = true;
            PlayerSide.Visible = true;
            GetOneCard.Visible = true;
            pass.Visible = true;
            EnemyFirstCard.Visible = true;
            PlayerScoreText.Visible = true;
            EnemyScoreText.Visible = true;

            bet.ReadOnly = true;
            AllIn.Enabled = false;
            AcceptBet.Enabled = false;

            BeginGame();
        }

        //Взять карту.
        private void GetOneCard_Click(object sender, EventArgs e)
        {
            PlayerCards();
        }

        //Пас.
        private void pass_Click(object sender, EventArgs e)
        {
            GetOneCard.Enabled = false;
            PlayerPassed = true;

            CheckResults();
        }

        //Выдача первых карт.
        private void BeginGame()
        {
            //Первая карта для игрока.
            Cards[num] = new PictureBox();
            Cards[num].Location = new Point(PlayerXC, 3);
            Cards[num].Size = new Size(52, 106);
            Cards[num].BorderStyle = BorderStyle.FixedSingle;
            Cards[num].Image = GiveCards(img);
            PlayerSide.Controls.Add(Cards[num]);

            PlayerScore += rndNum + 1;

            PlayerScoreText.Text = PlayerScore.ToString() + "/21";

            num++;
            PlayerXC += 55;

            //Первая карта для противника.
            Cards[num] = new PictureBox();
            Cards[num].Location = new Point(EnemyXC, 3);
            Cards[num].Size = new Size(52, 106);
            Cards[num].BorderStyle = BorderStyle.FixedSingle;
            Cards[num].Image = GiveCards(img);
            EnemySide.Controls.Add(Cards[num]);

            EnemyScore += rndNum + 1;

            Cards[num].Visible = false;

            num++;
            EnemyXC += 55;
        }

        //Карты для игрока.
        private void PlayerCards()
        {
            if (num < 11)
            {
                Cards[num] = new PictureBox();
                Cards[num].Location = new Point(PlayerXC, 3);
                Cards[num].Size = new Size(52, 106);
                Cards[num].BorderStyle = BorderStyle.FixedSingle;
                Cards[num].Image = GiveCards(img);
                PlayerSide.Controls.Add(Cards[num]);

                PlayerScore += rndNum + 1;

                PlayerScoreText.Text = PlayerScore.ToString() + "/21";

                num++;
                PlayerXC += 55;

                EnemyCards();
            }
        }

        //Карты для противника и его ИИ.
        private void EnemyCards()
        {
            if (num < 11)
            {
                //Если очков больше 21, то закончить.
                if (EnemyScore >= 21)
                {
                    EnemyPassed = true;
                    CheckResults();
                }
                //Если очки <= 21 и >= 17, то закончить
                else if (EnemyScore <= 21 && EnemyScore >= 17)
                {
                    EnemyPassed = true;
                    CheckResults();
                }
                //Если очки игрока > 21, то закончить.
                else if (PlayerScore > 21)
                {
                    EnemyPassed = true;
                    CheckResults();
                }
                //Если мелких карт нет и очков < 15, то бери карту. 
                else if (EnemyScore <= 15 && (!UsedCards[0] || !UsedCards[1] || !UsedCards[2] || !UsedCards[3]) || !UsedCards[4])
                {
                    Cards[num] = new PictureBox();
                    Cards[num].Location = new Point(EnemyXC, 3);
                    Cards[num].Size = new Size(52, 106);
                    Cards[num].BorderStyle = BorderStyle.FixedSingle;
                    Cards[num].Image = GiveCards(img);
                    EnemySide.Controls.Add(Cards[num]);

                    EnemyScore += rndNum + 1;

                    num++;
                    EnemyXC += 55;

                    if (num == 11)
                    {
                        EnemyPassed = true;
                    }

                    CheckResults();
                }
                //Иначе.
                else
                {
                    Cards[num] = new PictureBox();
                    Cards[num].Location = new Point(EnemyXC, 3);
                    Cards[num].Size = new Size(52, 106);
                    Cards[num].BorderStyle = BorderStyle.FixedSingle;
                    Cards[num].Image = GiveCards(img);
                    EnemySide.Controls.Add(Cards[num]);

                    EnemyScore += rndNum + 1;

                    num++;
                    EnemyXC += 55;

                    if (num == 11)
                    {
                        EnemyPassed = true;
                    }

                    CheckResults();
                }
            }
        }

        private void EnemyTurn_Tick(object sender, EventArgs e)
        {
            if (PlayerPassed && !EnemyPassed) EnemyCards();
        }

        //ВЫбор карты и присваивание картинки и очков.
        private Bitmap GiveCards(Bitmap bitmap)
        {
        Again:
            rndNum = rnd.Next(0, 11);

            if (!UsedCards[rndNum])
            {
                switch (rndNum)
                {
                    case 0:
                        {
                            UsedCards[rndNum] = true;
                            return bitmap = Properties.Resources.One;
                        }
                    case 1:
                        {
                            UsedCards[rndNum] = true;
                            return bitmap = Properties.Resources.Two;
                        }
                    case 2:
                        {
                            UsedCards[rndNum] = true;
                            return bitmap = Properties.Resources.Three;
                        }
                    case 3:
                        {
                            UsedCards[rndNum] = true;
                            return bitmap = Properties.Resources.Four;
                        }
                    case 4:
                        {
                            UsedCards[rndNum] = true;
                            return bitmap = Properties.Resources.Five;
                        }
                    case 5:
                        {
                            UsedCards[rndNum] = true;
                            return bitmap = Properties.Resources.Six;
                        }
                    case 6:
                        {
                            UsedCards[rndNum] = true;
                            return bitmap = Properties.Resources.Seven;
                        }
                    case 7:
                        {
                            UsedCards[rndNum] = true;
                            return bitmap = Properties.Resources.Eight;
                        }
                    case 8:
                        {
                            UsedCards[rndNum] = true;
                            return bitmap = Properties.Resources.Nine;
                        }
                    case 9:
                        {
                            UsedCards[rndNum] = true;
                            return bitmap = Properties.Resources.Ten;
                        }
                    case 10:
                        {
                            UsedCards[rndNum] = true;
                            return bitmap = Properties.Resources.Eleven;
                        }
                }
            }
            else
                goto Again;

            return bitmap;
        }

        //Проверка победы.
        private void CheckResults()
        {
            //Если у игрока и противника нажаты "пас".
            if (PlayerPassed && EnemyPassed)
            {
                EnemyScoreText.Text = EnemyScore.ToString() + "/21";

                EnemyFirstCard.Visible = false;
                Cards[1].Visible = true;

                //Ничья.
                if (PlayerScore == EnemyScore)
                {
                    rndMoney = 0;
                    MessageBox.Show("Ничья!");
                    Close();
                }
                //Если очков у игрока больше чем у противника и яу обоих меньше или равно 21, то выйграл игрок. 
                else if (PlayerScore > EnemyScore && PlayerScore <= 21 && EnemyScore <= 21)
                {
                    rndMoney = Convert.ToInt32(Convert.ToInt32(bet.Text) + Convert.ToInt32(bet.Text) * 1.25f);
                    MessageBox.Show("Ты победил!");
                    Close();
                }//Иначе.
                else if (PlayerScore < EnemyScore && PlayerScore <= 21 && EnemyScore <= 21)
                {
                    rndNum = rnd.Next(0, 4);

                    rndMoney = -Convert.ToInt32(bet.Text);
                    MessageBox.Show(LoseInBattle[rndNum]);
                    Close();
                }//Если очки у всех больше 21, но у игрока меньше, то он победил.
                else if (PlayerScore > 21 && EnemyScore > 21 && PlayerScore < EnemyScore)
                {
                    rndMoney = Convert.ToInt32(Convert.ToInt32(bet.Text) + Convert.ToInt32(bet.Text) * 1.25f);
                    MessageBox.Show("Ты победил!");
                    Close();
                }//Иначе.
                else if (PlayerScore > 21 && EnemyScore > 21 && PlayerScore > EnemyScore)
                {
                    rndNum = rnd.Next(0, 4);

                    rndMoney = -Convert.ToInt32(bet.Text);
                    MessageBox.Show(LoseInBattle[rndNum]);
                    Close();
                }//Если у игрока больше 21, а у противника меньше, то игрок проиграл.
                else if (PlayerScore > 21 && PlayerScore > EnemyScore)
                {
                    rndNum = rnd.Next(0, 4);

                    rndMoney = -Convert.ToInt32(bet.Text);
                    MessageBox.Show(LoseInBattle[rndNum]);
                    Close();
                }//Иначе.
                else if (EnemyScore > 21 && PlayerScore < EnemyScore)
                {
                    rndMoney = Convert.ToInt32(Convert.ToInt32(bet.Text) + Convert.ToInt32(bet.Text) * 1.25f);
                    MessageBox.Show("Ты победил!");
                    Close();
                }
            }
        }
    }
}
