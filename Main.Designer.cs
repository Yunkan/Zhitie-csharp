namespace Zhitie
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StartAdventure = new System.Windows.Forms.Button();
            this.hunger = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.stamina = new System.Windows.Forms.Label();
            this.eating = new System.Windows.Forms.Button();
            this.sleeping = new System.Windows.Forms.Button();
            this.working = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.health = new System.Windows.Forms.Label();
            this.FoodMenu = new System.Windows.Forms.Panel();
            this.BreadWithSausage = new System.Windows.Forms.Button();
            this.StealApples = new System.Windows.Forms.Button();
            this.EatBread = new System.Windows.Forms.Button();
            this.CloseFoodMenu = new System.Windows.Forms.Button();
            this.RefreshStates = new System.Windows.Forms.Timer(this.components);
            this.SleepMenu = new System.Windows.Forms.Panel();
            this.SleepOnEarth = new System.Windows.Forms.Button();
            this.SleepInPub = new System.Windows.Forms.Button();
            this.CloseSleepMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LiveDay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Label();
            this.WorkMenu = new System.Windows.Forms.Panel();
            this.TwentyOne = new System.Windows.Forms.Button();
            this.charity = new System.Windows.Forms.Button();
            this.FistFight = new System.Windows.Forms.Button();
            this.CloseWorkMenu = new System.Windows.Forms.Button();
            this.heal = new System.Windows.Forms.Button();
            this.HealMenu = new System.Windows.Forms.Panel();
            this.plantain = new System.Windows.Forms.Button();
            this.bandage = new System.Windows.Forms.Button();
            this.BandageWithHerbs = new System.Windows.Forms.Button();
            this.CloseHealMenu = new System.Windows.Forms.Button();
            this.FoodMenu.SuspendLayout();
            this.SleepMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.WorkMenu.SuspendLayout();
            this.HealMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartAdventure
            // 
            this.StartAdventure.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartAdventure.Location = new System.Drawing.Point(12, 12);
            this.StartAdventure.Name = "StartAdventure";
            this.StartAdventure.Size = new System.Drawing.Size(138, 81);
            this.StartAdventure.TabIndex = 0;
            this.StartAdventure.Text = "Начать приключение";
            this.StartAdventure.UseVisualStyleBackColor = true;
            this.StartAdventure.Click += new System.EventHandler(this.StartAdventure_Click);
            // 
            // hunger
            // 
            this.hunger.AutoSize = true;
            this.hunger.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hunger.Location = new System.Drawing.Point(125, 129);
            this.hunger.Name = "hunger";
            this.hunger.Size = new System.Drawing.Size(16, 16);
            this.hunger.TabIndex = 1;
            this.hunger.Text = "0";
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.money.Location = new System.Drawing.Point(70, 186);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(16, 16);
            this.money.TabIndex = 2;
            this.money.Text = "0";
            // 
            // stamina
            // 
            this.stamina.AutoSize = true;
            this.stamina.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stamina.Location = new System.Drawing.Point(74, 156);
            this.stamina.Name = "stamina";
            this.stamina.Size = new System.Drawing.Size(16, 16);
            this.stamina.TabIndex = 3;
            this.stamina.Text = "0";
            // 
            // eating
            // 
            this.eating.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eating.Location = new System.Drawing.Point(15, 221);
            this.eating.Name = "eating";
            this.eating.Size = new System.Drawing.Size(81, 23);
            this.eating.TabIndex = 4;
            this.eating.Text = "Кушац";
            this.eating.UseVisualStyleBackColor = true;
            this.eating.Click += new System.EventHandler(this.eating_Click);
            // 
            // sleeping
            // 
            this.sleeping.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sleeping.Location = new System.Drawing.Point(15, 263);
            this.sleeping.Name = "sleeping";
            this.sleeping.Size = new System.Drawing.Size(81, 23);
            this.sleeping.TabIndex = 5;
            this.sleeping.Text = "Спатки";
            this.sleeping.UseVisualStyleBackColor = true;
            this.sleeping.Click += new System.EventHandler(this.sleeping_Click);
            // 
            // working
            // 
            this.working.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.working.Location = new System.Drawing.Point(15, 306);
            this.working.Name = "working";
            this.working.Size = new System.Drawing.Size(81, 23);
            this.working.TabIndex = 6;
            this.working.Text = "Вкалывать";
            this.working.UseVisualStyleBackColor = true;
            this.working.Click += new System.EventHandler(this.working_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Живот набит на:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Энергия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Деньги:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Самочувствие:";
            // 
            // health
            // 
            this.health.AutoSize = true;
            this.health.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.health.Location = new System.Drawing.Point(114, 106);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(16, 16);
            this.health.TabIndex = 11;
            this.health.Text = "0";
            // 
            // FoodMenu
            // 
            this.FoodMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FoodMenu.Controls.Add(this.BreadWithSausage);
            this.FoodMenu.Controls.Add(this.StealApples);
            this.FoodMenu.Controls.Add(this.EatBread);
            this.FoodMenu.Controls.Add(this.CloseFoodMenu);
            this.FoodMenu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FoodMenu.Location = new System.Drawing.Point(459, 393);
            this.FoodMenu.Name = "FoodMenu";
            this.FoodMenu.Size = new System.Drawing.Size(316, 156);
            this.FoodMenu.TabIndex = 12;
            this.FoodMenu.Visible = false;
            // 
            // BreadWithSausage
            // 
            this.BreadWithSausage.Location = new System.Drawing.Point(3, 32);
            this.BreadWithSausage.Name = "BreadWithSausage";
            this.BreadWithSausage.Size = new System.Drawing.Size(177, 23);
            this.BreadWithSausage.TabIndex = 3;
            this.BreadWithSausage.Tag = "";
            this.BreadWithSausage.Text = "Хлеб с колбасой (+35) 15м.";
            this.BreadWithSausage.UseVisualStyleBackColor = true;
            this.BreadWithSausage.Click += new System.EventHandler(this.BreadWithSausage_Click);
            // 
            // StealApples
            // 
            this.StealApples.Location = new System.Drawing.Point(3, 3);
            this.StealApples.Name = "StealApples";
            this.StealApples.Size = new System.Drawing.Size(151, 23);
            this.StealApples.TabIndex = 0;
            this.StealApples.Tag = "";
            this.StealApples.Text = "Украсть яблоки (+15)";
            this.StealApples.UseVisualStyleBackColor = true;
            this.StealApples.Click += new System.EventHandler(this.StealApples_Click);
            // 
            // EatBread
            // 
            this.EatBread.Location = new System.Drawing.Point(159, 3);
            this.EatBread.Name = "EatBread";
            this.EatBread.Size = new System.Drawing.Size(116, 23);
            this.EatBread.TabIndex = 1;
            this.EatBread.Tag = "";
            this.EatBread.Text = "Хлеб (+25) 10м.";
            this.EatBread.UseVisualStyleBackColor = true;
            this.EatBread.Click += new System.EventHandler(this.EatBread_Click);
            // 
            // CloseFoodMenu
            // 
            this.CloseFoodMenu.Location = new System.Drawing.Point(224, 128);
            this.CloseFoodMenu.Name = "CloseFoodMenu";
            this.CloseFoodMenu.Size = new System.Drawing.Size(87, 23);
            this.CloseFoodMenu.TabIndex = 2;
            this.CloseFoodMenu.Tag = "";
            this.CloseFoodMenu.Text = "Закрыть";
            this.CloseFoodMenu.UseVisualStyleBackColor = true;
            this.CloseFoodMenu.Click += new System.EventHandler(this.CloseFoodMenu_Click);
            // 
            // RefreshStates
            // 
            this.RefreshStates.Enabled = true;
            this.RefreshStates.Interval = 25;
            this.RefreshStates.Tick += new System.EventHandler(this.RefreshStates_Tick);
            // 
            // SleepMenu
            // 
            this.SleepMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SleepMenu.Controls.Add(this.SleepOnEarth);
            this.SleepMenu.Controls.Add(this.SleepInPub);
            this.SleepMenu.Controls.Add(this.CloseSleepMenu);
            this.SleepMenu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SleepMenu.Location = new System.Drawing.Point(141, 393);
            this.SleepMenu.Name = "SleepMenu";
            this.SleepMenu.Size = new System.Drawing.Size(316, 156);
            this.SleepMenu.TabIndex = 13;
            this.SleepMenu.Visible = false;
            // 
            // SleepOnEarth
            // 
            this.SleepOnEarth.Location = new System.Drawing.Point(3, 3);
            this.SleepOnEarth.Name = "SleepOnEarth";
            this.SleepOnEarth.Size = new System.Drawing.Size(153, 23);
            this.SleepOnEarth.TabIndex = 0;
            this.SleepOnEarth.Tag = "";
            this.SleepOnEarth.Text = "Спать на земле (+25)";
            this.SleepOnEarth.UseVisualStyleBackColor = true;
            this.SleepOnEarth.Click += new System.EventHandler(this.SleepOnEarth_Click);
            // 
            // SleepInPub
            // 
            this.SleepInPub.Location = new System.Drawing.Point(3, 32);
            this.SleepInPub.Name = "SleepInPub";
            this.SleepInPub.Size = new System.Drawing.Size(235, 23);
            this.SleepInPub.TabIndex = 1;
            this.SleepInPub.Tag = "";
            this.SleepInPub.Text = "Переночевать в таверне (+50) 30м.";
            this.SleepInPub.UseVisualStyleBackColor = true;
            this.SleepInPub.Click += new System.EventHandler(this.SleepInPub_Click);
            // 
            // CloseSleepMenu
            // 
            this.CloseSleepMenu.Location = new System.Drawing.Point(224, 128);
            this.CloseSleepMenu.Name = "CloseSleepMenu";
            this.CloseSleepMenu.Size = new System.Drawing.Size(87, 23);
            this.CloseSleepMenu.TabIndex = 2;
            this.CloseSleepMenu.Tag = "";
            this.CloseSleepMenu.Text = "Закрыть";
            this.CloseSleepMenu.UseVisualStyleBackColor = true;
            this.CloseSleepMenu.Click += new System.EventHandler(this.CloseSleepMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LiveDay);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.clock);
            this.panel1.Location = new System.Drawing.Point(644, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 55);
            this.panel1.TabIndex = 14;
            // 
            // LiveDay
            // 
            this.LiveDay.AutoSize = true;
            this.LiveDay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LiveDay.Location = new System.Drawing.Point(74, 22);
            this.LiveDay.Name = "LiveDay";
            this.LiveDay.Size = new System.Drawing.Size(16, 16);
            this.LiveDay.TabIndex = 4;
            this.LiveDay.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(63, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "День:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Время:";
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clock.Location = new System.Drawing.Point(8, 22);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(45, 16);
            this.clock.TabIndex = 2;
            this.clock.Text = "00:00";
            // 
            // WorkMenu
            // 
            this.WorkMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WorkMenu.Controls.Add(this.TwentyOne);
            this.WorkMenu.Controls.Add(this.charity);
            this.WorkMenu.Controls.Add(this.FistFight);
            this.WorkMenu.Controls.Add(this.CloseWorkMenu);
            this.WorkMenu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkMenu.Location = new System.Drawing.Point(459, 228);
            this.WorkMenu.Name = "WorkMenu";
            this.WorkMenu.Size = new System.Drawing.Size(316, 163);
            this.WorkMenu.TabIndex = 15;
            this.WorkMenu.Visible = false;
            // 
            // TwentyOne
            // 
            this.TwentyOne.Location = new System.Drawing.Point(3, 32);
            this.TwentyOne.Name = "TwentyOne";
            this.TwentyOne.Size = new System.Drawing.Size(101, 23);
            this.TwentyOne.TabIndex = 3;
            this.TwentyOne.Text = "Сыграть в 21";
            this.TwentyOne.UseVisualStyleBackColor = true;
            this.TwentyOne.Click += new System.EventHandler(this.TwentyOne_Click);
            // 
            // charity
            // 
            this.charity.Location = new System.Drawing.Point(3, 3);
            this.charity.Name = "charity";
            this.charity.Size = new System.Drawing.Size(131, 23);
            this.charity.TabIndex = 2;
            this.charity.Text = "Просить милостыни";
            this.charity.UseVisualStyleBackColor = true;
            this.charity.Click += new System.EventHandler(this.charity_Click);
            // 
            // FistFight
            // 
            this.FistFight.Location = new System.Drawing.Point(140, 3);
            this.FistFight.Name = "FistFight";
            this.FistFight.Size = new System.Drawing.Size(101, 23);
            this.FistFight.TabIndex = 0;
            this.FistFight.Text = "Кулачный бой";
            this.FistFight.UseVisualStyleBackColor = true;
            this.FistFight.Click += new System.EventHandler(this.FistBattle_Click);
            // 
            // CloseWorkMenu
            // 
            this.CloseWorkMenu.Location = new System.Drawing.Point(210, 135);
            this.CloseWorkMenu.Name = "CloseWorkMenu";
            this.CloseWorkMenu.Size = new System.Drawing.Size(101, 23);
            this.CloseWorkMenu.TabIndex = 1;
            this.CloseWorkMenu.Text = "Закрыть";
            this.CloseWorkMenu.UseVisualStyleBackColor = true;
            this.CloseWorkMenu.Click += new System.EventHandler(this.CloseWorkMenu_Click);
            // 
            // heal
            // 
            this.heal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heal.Location = new System.Drawing.Point(15, 344);
            this.heal.Name = "heal";
            this.heal.Size = new System.Drawing.Size(81, 23);
            this.heal.TabIndex = 16;
            this.heal.Text = "Вавки";
            this.heal.UseVisualStyleBackColor = true;
            this.heal.Click += new System.EventHandler(this.heal_Click);
            // 
            // HealMenu
            // 
            this.HealMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HealMenu.Controls.Add(this.plantain);
            this.HealMenu.Controls.Add(this.bandage);
            this.HealMenu.Controls.Add(this.BandageWithHerbs);
            this.HealMenu.Controls.Add(this.CloseHealMenu);
            this.HealMenu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HealMenu.Location = new System.Drawing.Point(141, 228);
            this.HealMenu.Name = "HealMenu";
            this.HealMenu.Size = new System.Drawing.Size(316, 163);
            this.HealMenu.TabIndex = 16;
            this.HealMenu.Visible = false;
            // 
            // plantain
            // 
            this.plantain.Location = new System.Drawing.Point(3, 3);
            this.plantain.Name = "plantain";
            this.plantain.Size = new System.Drawing.Size(136, 23);
            this.plantain.TabIndex = 0;
            this.plantain.Text = "Подорожник (+5)";
            this.plantain.UseVisualStyleBackColor = true;
            this.plantain.Click += new System.EventHandler(this.plantain_Click);
            // 
            // bandage
            // 
            this.bandage.Location = new System.Drawing.Point(145, 3);
            this.bandage.Name = "bandage";
            this.bandage.Size = new System.Drawing.Size(120, 23);
            this.bandage.TabIndex = 1;
            this.bandage.Text = "Бинты (+15) 10м.";
            this.bandage.UseVisualStyleBackColor = true;
            this.bandage.Click += new System.EventHandler(this.bandage_Click);
            // 
            // BandageWithHerbs
            // 
            this.BandageWithHerbs.Location = new System.Drawing.Point(3, 32);
            this.BandageWithHerbs.Name = "BandageWithHerbs";
            this.BandageWithHerbs.Size = new System.Drawing.Size(174, 23);
            this.BandageWithHerbs.TabIndex = 2;
            this.BandageWithHerbs.Text = "Бинты с травами(+30) 15м.";
            this.BandageWithHerbs.UseVisualStyleBackColor = true;
            this.BandageWithHerbs.Click += new System.EventHandler(this.BandageWithHerbs_Click);
            // 
            // CloseHealMenu
            // 
            this.CloseHealMenu.Location = new System.Drawing.Point(210, 135);
            this.CloseHealMenu.Name = "CloseHealMenu";
            this.CloseHealMenu.Size = new System.Drawing.Size(101, 23);
            this.CloseHealMenu.TabIndex = 3;
            this.CloseHealMenu.Text = "Закрыть";
            this.CloseHealMenu.UseVisualStyleBackColor = true;
            this.CloseHealMenu.Click += new System.EventHandler(this.CloseHealMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.heal);
            this.Controls.Add(this.WorkMenu);
            this.Controls.Add(this.HealMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.health);
            this.Controls.Add(this.working);
            this.Controls.Add(this.sleeping);
            this.Controls.Add(this.eating);
            this.Controls.Add(this.stamina);
            this.Controls.Add(this.money);
            this.Controls.Add(this.hunger);
            this.Controls.Add(this.StartAdventure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FoodMenu);
            this.Controls.Add(this.SleepMenu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Житие";
            this.FoodMenu.ResumeLayout(false);
            this.SleepMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.WorkMenu.ResumeLayout(false);
            this.HealMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartAdventure;
        public System.Windows.Forms.Label money;
        private System.Windows.Forms.Button eating;
        private System.Windows.Forms.Button sleeping;
        private System.Windows.Forms.Button working;
        private System.Windows.Forms.Panel FoodMenu;
        private System.Windows.Forms.Button StealApples;
        private System.Windows.Forms.Button EatBread;
        private System.Windows.Forms.Timer RefreshStates;
        private System.Windows.Forms.Button CloseFoodMenu;
        private System.Windows.Forms.Panel SleepMenu;
        private System.Windows.Forms.Button SleepOnEarth;
        private System.Windows.Forms.Button SleepInPub;
        private System.Windows.Forms.Button CloseSleepMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LiveDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel WorkMenu;
        private System.Windows.Forms.Button FistFight;
        private System.Windows.Forms.Button CloseWorkMenu;
        private System.Windows.Forms.Button heal;
        private System.Windows.Forms.Panel HealMenu;
        private System.Windows.Forms.Button plantain;
        private System.Windows.Forms.Button bandage;
        private System.Windows.Forms.Button BandageWithHerbs;
        private System.Windows.Forms.Button CloseHealMenu;
        public System.Windows.Forms.Label hunger;
        public System.Windows.Forms.Label stamina;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label health;
        private System.Windows.Forms.Button charity;
        private System.Windows.Forms.Button BreadWithSausage;
        private System.Windows.Forms.Button TwentyOne;
    }
}

