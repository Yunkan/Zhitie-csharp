namespace Zhitie
{
    partial class TwentyOneGame
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
            this.GetOneCard = new System.Windows.Forms.Button();
            this.EnemySide = new System.Windows.Forms.Panel();
            this.bet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerSide = new System.Windows.Forms.Panel();
            this.pass = new System.Windows.Forms.Button();
            this.AcceptBet = new System.Windows.Forms.Button();
            this.AllIn = new System.Windows.Forms.Button();
            this.EndGame = new System.Windows.Forms.Button();
            this.YourMoney = new System.Windows.Forms.Label();
            this.PlayerScoreText = new System.Windows.Forms.Label();
            this.EnemyScoreText = new System.Windows.Forms.Label();
            this.EnemyFirstCard = new System.Windows.Forms.PictureBox();
            this.EnemyTurn = new System.Windows.Forms.Timer(this.components);
            this.EnemySide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyFirstCard)).BeginInit();
            this.SuspendLayout();
            // 
            // GetOneCard
            // 
            this.GetOneCard.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetOneCard.Location = new System.Drawing.Point(654, 196);
            this.GetOneCard.Name = "GetOneCard";
            this.GetOneCard.Size = new System.Drawing.Size(118, 42);
            this.GetOneCard.TabIndex = 0;
            this.GetOneCard.Text = "Взять карту";
            this.GetOneCard.UseVisualStyleBackColor = true;
            this.GetOneCard.Visible = false;
            this.GetOneCard.Click += new System.EventHandler(this.GetOneCard_Click);
            // 
            // EnemySide
            // 
            this.EnemySide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnemySide.Controls.Add(this.EnemyFirstCard);
            this.EnemySide.Location = new System.Drawing.Point(109, 12);
            this.EnemySide.Name = "EnemySide";
            this.EnemySide.Size = new System.Drawing.Size(585, 114);
            this.EnemySide.TabIndex = 1;
            this.EnemySide.Visible = false;
            // 
            // bet
            // 
            this.bet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bet.Location = new System.Drawing.Point(12, 206);
            this.bet.Name = "bet";
            this.bet.Size = new System.Drawing.Size(115, 23);
            this.bet.TabIndex = 2;
            this.bet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bet_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "На что играешь?";
            // 
            // PlayerSide
            // 
            this.PlayerSide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerSide.Location = new System.Drawing.Point(109, 420);
            this.PlayerSide.Name = "PlayerSide";
            this.PlayerSide.Size = new System.Drawing.Size(585, 114);
            this.PlayerSide.TabIndex = 2;
            this.PlayerSide.Visible = false;
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass.Location = new System.Drawing.Point(654, 259);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(118, 42);
            this.pass.TabIndex = 4;
            this.pass.Text = "Пас";
            this.pass.UseVisualStyleBackColor = true;
            this.pass.Visible = false;
            this.pass.Click += new System.EventHandler(this.pass_Click);
            // 
            // AcceptBet
            // 
            this.AcceptBet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptBet.Location = new System.Drawing.Point(143, 206);
            this.AcceptBet.Name = "AcceptBet";
            this.AcceptBet.Size = new System.Drawing.Size(93, 23);
            this.AcceptBet.TabIndex = 5;
            this.AcceptBet.Text = "Поставить";
            this.AcceptBet.UseVisualStyleBackColor = true;
            this.AcceptBet.Click += new System.EventHandler(this.AcceptBet_Click);
            // 
            // AllIn
            // 
            this.AllIn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllIn.Location = new System.Drawing.Point(12, 245);
            this.AllIn.Name = "AllIn";
            this.AllIn.Size = new System.Drawing.Size(98, 23);
            this.AllIn.TabIndex = 6;
            this.AllIn.Text = "ВА-БАНК!!!!";
            this.AllIn.UseVisualStyleBackColor = true;
            this.AllIn.Click += new System.EventHandler(this.AllIn_Click);
            // 
            // EndGame
            // 
            this.EndGame.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndGame.Location = new System.Drawing.Point(12, 299);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(98, 42);
            this.EndGame.TabIndex = 7;
            this.EndGame.Text = "Уйти";
            this.EndGame.UseVisualStyleBackColor = true;
            this.EndGame.Click += new System.EventHandler(this.EndGame_Click);
            // 
            // YourMoney
            // 
            this.YourMoney.AutoSize = true;
            this.YourMoney.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YourMoney.Location = new System.Drawing.Point(12, 176);
            this.YourMoney.Name = "YourMoney";
            this.YourMoney.Size = new System.Drawing.Size(96, 16);
            this.YourMoney.TabIndex = 8;
            this.YourMoney.Text = "Твои деньги: ";
            // 
            // PlayerScoreText
            // 
            this.PlayerScoreText.AutoSize = true;
            this.PlayerScoreText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerScoreText.Location = new System.Drawing.Point(37, 466);
            this.PlayerScoreText.Name = "PlayerScoreText";
            this.PlayerScoreText.Size = new System.Drawing.Size(38, 19);
            this.PlayerScoreText.TabIndex = 9;
            this.PlayerScoreText.Text = "/21";
            this.PlayerScoreText.Visible = false;
            // 
            // EnemyScoreText
            // 
            this.EnemyScoreText.AutoSize = true;
            this.EnemyScoreText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnemyScoreText.Location = new System.Drawing.Point(37, 61);
            this.EnemyScoreText.Name = "EnemyScoreText";
            this.EnemyScoreText.Size = new System.Drawing.Size(47, 19);
            this.EnemyScoreText.TabIndex = 10;
            this.EnemyScoreText.Text = "?\\21";
            this.EnemyScoreText.Visible = false;
            // 
            // EnemyFirstCard
            // 
            this.EnemyFirstCard.BackColor = System.Drawing.Color.White;
            this.EnemyFirstCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnemyFirstCard.Location = new System.Drawing.Point(3, 3);
            this.EnemyFirstCard.Name = "EnemyFirstCard";
            this.EnemyFirstCard.Size = new System.Drawing.Size(52, 106);
            this.EnemyFirstCard.TabIndex = 0;
            this.EnemyFirstCard.TabStop = false;
            // 
            // EnemyTurn
            // 
            this.EnemyTurn.Enabled = true;
            this.EnemyTurn.Interval = 1000;
            this.EnemyTurn.Tick += new System.EventHandler(this.EnemyTurn_Tick);
            // 
            // TwentyOneGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.EnemyScoreText);
            this.Controls.Add(this.PlayerScoreText);
            this.Controls.Add(this.YourMoney);
            this.Controls.Add(this.EndGame);
            this.Controls.Add(this.AllIn);
            this.Controls.Add(this.AcceptBet);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.PlayerSide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bet);
            this.Controls.Add(this.EnemySide);
            this.Controls.Add(this.GetOneCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TwentyOneGame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра в 21";
            this.Load += new System.EventHandler(this.TwentyOneGame_Load);
            this.EnemySide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EnemyFirstCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetOneCard;
        private System.Windows.Forms.Panel EnemySide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PlayerSide;
        private System.Windows.Forms.Button pass;
        private System.Windows.Forms.Button AcceptBet;
        private System.Windows.Forms.Button AllIn;
        private System.Windows.Forms.Button EndGame;
        public System.Windows.Forms.TextBox bet;
        private System.Windows.Forms.Label YourMoney;
        private System.Windows.Forms.Label PlayerScoreText;
        private System.Windows.Forms.Label EnemyScoreText;
        private System.Windows.Forms.PictureBox EnemyFirstCard;
        private System.Windows.Forms.Timer EnemyTurn;
    }
}