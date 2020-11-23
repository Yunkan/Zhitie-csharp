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
    public partial class Adventures : Form
    {
        public List<string> AdventureArray = new List<string>();//Список приключений.

        Random rnd = new Random();
        
        public int rndHungry, rndStamina, rndMoney, rndHealth, rndAdventure;

        Form1 main = new Form1();

        public Adventures()
        {
            InitializeComponent();
        }

        //Закончить приключение.
        private void EndAdventure_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Чтение файла с приключениями и записывание в список.
            using (StreamReader sr = new StreamReader("Adventures.txt", Encoding.Default))
            {
                main.CheckSaves();

                string text = sr.ReadToEnd();

                for (int i = 0; i < text.Length - 1; i++)
                {
                    if (text[i] == '<')
                    {
                        for (int j = i; j < text.Length - 1; j++)
                        {
                            if (text[j] == '/' && text[j + 1] == '>')
                            {
                                AdventureArray.Add(text.Substring(i + 1, j - (i + 1)));
                                break;
                            }
                        }
                    }
                }

                //Выбор рандомного приключения.
                rndAdventure = rnd.Next(0, AdventureArray.ToArray().Length);
                AdventureText.Text = AdventureArray[rndAdventure];

                if (AdventureArray[rndAdventure].Contains("Ты хорошо себя чувствуешь."))
                    rndHealth = 0;
                else if (AdventureArray[rndAdventure].Contains("Ты плохо себя чувствуешь."))
                    rndHealth = -rnd.Next(10, 31);

                if (AdventureArray[rndAdventure].Contains("Ты заработал."))
                    rndMoney = rnd.Next(50, 101);
                else if (AdventureArray[rndAdventure].Contains("Тебя обокрали."))
                    rndMoney = -main.PlayerMoney;

                rndHungry = rnd.Next(35, 58);
                rndStamina = -rnd.Next(35, 58);

                health.Text = rndHealth.ToString();
                hungry.Text = "+" + rndHungry.ToString();
                stamina.Text = rndStamina.ToString();
                money.Text = rndMoney.ToString();
            }
        }
    }
}
