namespace Zhitie
{
    partial class FistFight
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EndFight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.enemy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayerEnergy = new System.Windows.Forms.Label();
            this.EnemyEnergy = new System.Windows.Forms.Label();
            this.Hit = new System.Windows.Forms.Button();
            this.Defense = new System.Windows.Forms.Button();
            this.HitMenu = new System.Windows.Forms.Panel();
            this.InBody = new System.Windows.Forms.Button();
            this.CloseHitMenu = new System.Windows.Forms.Button();
            this.InHead = new System.Windows.Forms.Button();
            this.DefenseMenu = new System.Windows.Forms.Panel();
            this.DefBody = new System.Windows.Forms.Button();
            this.DefHead = new System.Windows.Forms.Button();
            this.CloseDefenseMenu = new System.Windows.Forms.Button();
            this.RefreshHP = new System.Windows.Forms.Timer(this.components);
            this.PlayerHealth = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EnemyHealth = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CounterAttack = new System.Windows.Forms.Button();
            this.HitMenu.SuspendLayout();
            this.DefenseMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // EndFight
            // 
            this.EndFight.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndFight.Location = new System.Drawing.Point(613, 475);
            this.EndFight.Name = "EndFight";
            this.EndFight.Size = new System.Drawing.Size(159, 74);
            this.EndFight.TabIndex = 0;
            this.EndFight.Text = "Сдаться";
            this.EndFight.UseVisualStyleBackColor = true;
            this.EndFight.Click += new System.EventHandler(this.EndFight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ты:";
            // 
            // enemy
            // 
            this.enemy.AutoSize = true;
            this.enemy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemy.Location = new System.Drawing.Point(609, 9);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(69, 19);
            this.enemy.TabIndex = 4;
            this.enemy.Text = "Enemy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дыхалка:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(609, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дыхалка:";
            // 
            // PlayerEnergy
            // 
            this.PlayerEnergy.AutoSize = true;
            this.PlayerEnergy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerEnergy.Location = new System.Drawing.Point(99, 73);
            this.PlayerEnergy.Name = "PlayerEnergy";
            this.PlayerEnergy.Size = new System.Drawing.Size(19, 19);
            this.PlayerEnergy.TabIndex = 8;
            this.PlayerEnergy.Text = "0";
            // 
            // EnemyEnergy
            // 
            this.EnemyEnergy.AutoSize = true;
            this.EnemyEnergy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnemyEnergy.Location = new System.Drawing.Point(696, 73);
            this.EnemyEnergy.Name = "EnemyEnergy";
            this.EnemyEnergy.Size = new System.Drawing.Size(19, 19);
            this.EnemyEnergy.TabIndex = 9;
            this.EnemyEnergy.Text = "0";
            // 
            // Hit
            // 
            this.Hit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hit.Location = new System.Drawing.Point(12, 134);
            this.Hit.Name = "Hit";
            this.Hit.Size = new System.Drawing.Size(120, 31);
            this.Hit.TabIndex = 10;
            this.Hit.Text = "Втащить";
            this.Hit.UseVisualStyleBackColor = true;
            this.Hit.Click += new System.EventHandler(this.Hit_Click);
            // 
            // Defense
            // 
            this.Defense.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Defense.Location = new System.Drawing.Point(12, 189);
            this.Defense.Name = "Defense";
            this.Defense.Size = new System.Drawing.Size(120, 31);
            this.Defense.TabIndex = 11;
            this.Defense.Text = "Защита";
            this.Defense.UseVisualStyleBackColor = true;
            this.Defense.Click += new System.EventHandler(this.Defense_Click);
            // 
            // HitMenu
            // 
            this.HitMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HitMenu.Controls.Add(this.InBody);
            this.HitMenu.Controls.Add(this.CloseHitMenu);
            this.HitMenu.Controls.Add(this.InHead);
            this.HitMenu.Location = new System.Drawing.Point(237, 134);
            this.HitMenu.Name = "HitMenu";
            this.HitMenu.Size = new System.Drawing.Size(287, 144);
            this.HitMenu.TabIndex = 12;
            this.HitMenu.Visible = false;
            // 
            // InBody
            // 
            this.InBody.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InBody.Location = new System.Drawing.Point(125, 3);
            this.InBody.Name = "InBody";
            this.InBody.Size = new System.Drawing.Size(120, 27);
            this.InBody.TabIndex = 16;
            this.InBody.Text = "В тело";
            this.InBody.UseVisualStyleBackColor = true;
            this.InBody.Click += new System.EventHandler(this.InBody_Click);
            // 
            // CloseHitMenu
            // 
            this.CloseHitMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseHitMenu.Location = new System.Drawing.Point(176, 114);
            this.CloseHitMenu.Name = "CloseHitMenu";
            this.CloseHitMenu.Size = new System.Drawing.Size(106, 25);
            this.CloseHitMenu.TabIndex = 15;
            this.CloseHitMenu.Text = "Закрыть";
            this.CloseHitMenu.UseVisualStyleBackColor = true;
            this.CloseHitMenu.Click += new System.EventHandler(this.CloseHitMenu_Click);
            // 
            // InHead
            // 
            this.InHead.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InHead.Location = new System.Drawing.Point(3, 3);
            this.InHead.Name = "InHead";
            this.InHead.Size = new System.Drawing.Size(120, 27);
            this.InHead.TabIndex = 14;
            this.InHead.Text = "В голову";
            this.InHead.UseVisualStyleBackColor = true;
            this.InHead.Click += new System.EventHandler(this.InHead_Click);
            // 
            // DefenseMenu
            // 
            this.DefenseMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DefenseMenu.Controls.Add(this.CounterAttack);
            this.DefenseMenu.Controls.Add(this.DefBody);
            this.DefenseMenu.Controls.Add(this.DefHead);
            this.DefenseMenu.Controls.Add(this.CloseDefenseMenu);
            this.DefenseMenu.Location = new System.Drawing.Point(237, 284);
            this.DefenseMenu.Name = "DefenseMenu";
            this.DefenseMenu.Size = new System.Drawing.Size(287, 144);
            this.DefenseMenu.TabIndex = 13;
            this.DefenseMenu.Visible = false;
            // 
            // DefBody
            // 
            this.DefBody.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DefBody.Location = new System.Drawing.Point(125, 3);
            this.DefBody.Name = "DefBody";
            this.DefBody.Size = new System.Drawing.Size(120, 27);
            this.DefBody.TabIndex = 18;
            this.DefBody.Text = "Тело";
            this.DefBody.UseVisualStyleBackColor = true;
            this.DefBody.Click += new System.EventHandler(this.DefBody_Click);
            // 
            // DefHead
            // 
            this.DefHead.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DefHead.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DefHead.Location = new System.Drawing.Point(3, 3);
            this.DefHead.Name = "DefHead";
            this.DefHead.Size = new System.Drawing.Size(120, 27);
            this.DefHead.TabIndex = 17;
            this.DefHead.Text = "Голову";
            this.DefHead.UseVisualStyleBackColor = true;
            this.DefHead.Click += new System.EventHandler(this.DefHead_Click);
            // 
            // CloseDefenseMenu
            // 
            this.CloseDefenseMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseDefenseMenu.Location = new System.Drawing.Point(176, 114);
            this.CloseDefenseMenu.Name = "CloseDefenseMenu";
            this.CloseDefenseMenu.Size = new System.Drawing.Size(106, 25);
            this.CloseDefenseMenu.TabIndex = 14;
            this.CloseDefenseMenu.Text = "Закрыть";
            this.CloseDefenseMenu.UseVisualStyleBackColor = true;
            this.CloseDefenseMenu.Click += new System.EventHandler(this.CloseDefenseMenu_Click);
            // 
            // RefreshHP
            // 
            this.RefreshHP.Enabled = true;
            this.RefreshHP.Interval = 25;
            this.RefreshHP.Tick += new System.EventHandler(this.RefreshHP_Tick);
            // 
            // PlayerHealth
            // 
            this.PlayerHealth.AutoSize = true;
            this.PlayerHealth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerHealth.Location = new System.Drawing.Point(141, 39);
            this.PlayerHealth.Name = "PlayerHealth";
            this.PlayerHealth.Size = new System.Drawing.Size(19, 19);
            this.PlayerHealth.TabIndex = 15;
            this.PlayerHealth.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Самочувствие:";
            // 
            // EnemyHealth
            // 
            this.EnemyHealth.AutoSize = true;
            this.EnemyHealth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnemyHealth.Location = new System.Drawing.Point(742, 39);
            this.EnemyHealth.Name = "EnemyHealth";
            this.EnemyHealth.Size = new System.Drawing.Size(19, 19);
            this.EnemyHealth.TabIndex = 17;
            this.EnemyHealth.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(609, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Самочувствие:";
            // 
            // CounterAttack
            // 
            this.CounterAttack.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CounterAttack.Location = new System.Drawing.Point(3, 36);
            this.CounterAttack.Name = "CounterAttack";
            this.CounterAttack.Size = new System.Drawing.Size(120, 27);
            this.CounterAttack.TabIndex = 19;
            this.CounterAttack.Text = "Контратака";
            this.CounterAttack.UseVisualStyleBackColor = true;
            this.CounterAttack.Click += new System.EventHandler(this.CounterAttack_Click);
            // 
            // FistFight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.EnemyHealth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PlayerHealth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DefenseMenu);
            this.Controls.Add(this.HitMenu);
            this.Controls.Add(this.Defense);
            this.Controls.Add(this.Hit);
            this.Controls.Add(this.EnemyEnergy);
            this.Controls.Add(this.PlayerEnergy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndFight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FistFight";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кулачный бой";
            this.Load += new System.EventHandler(this.FistFight_Load);
            this.HitMenu.ResumeLayout(false);
            this.DefenseMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EndFight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label enemy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PlayerEnergy;
        private System.Windows.Forms.Label EnemyEnergy;
        private System.Windows.Forms.Button Hit;
        private System.Windows.Forms.Button Defense;
        private System.Windows.Forms.Panel HitMenu;
        private System.Windows.Forms.Panel DefenseMenu;
        private System.Windows.Forms.Timer RefreshHP;
        private System.Windows.Forms.Button InHead;
        private System.Windows.Forms.Button CloseHitMenu;
        private System.Windows.Forms.Button CloseDefenseMenu;
        private System.Windows.Forms.Button InBody;
        private System.Windows.Forms.Button DefBody;
        private System.Windows.Forms.Button DefHead;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label EnemyHealth;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label PlayerHealth;
        private System.Windows.Forms.Button CounterAttack;
    }
}