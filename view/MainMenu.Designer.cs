namespace Banco.view
{
    partial class MainMenu
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
            this.QuitBtn = new System.Windows.Forms.Button();
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.transactionList = new System.Windows.Forms.ListView();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuitBtn
            // 
            this.QuitBtn.Location = new System.Drawing.Point(713, 415);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(75, 23);
            this.QuitBtn.TabIndex = 0;
            this.QuitBtn.Text = "Sair";
            this.QuitBtn.UseVisualStyleBackColor = true;
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLbl.Location = new System.Drawing.Point(259, 50);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(156, 31);
            this.WelcomeLbl.TabIndex = 1;
            this.WelcomeLbl.Text = "Bem vindo, ";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(404, 50);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(94, 31);
            this.NameLbl.TabIndex = 2;
            this.NameLbl.Text = "*User*";
            // 
            // transactionList
            // 
            this.transactionList.HideSelection = false;
            this.transactionList.Location = new System.Drawing.Point(12, 184);
            this.transactionList.Name = "transactionList";
            this.transactionList.Size = new System.Drawing.Size(377, 236);
            this.transactionList.TabIndex = 3;
            this.transactionList.UseCompatibleStateImageBehavior = false;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.BackColor = System.Drawing.SystemColors.Control;
            this.UsernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.Location = new System.Drawing.Point(623, 9);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(118, 25);
            this.UsernameLbl.TabIndex = 4;
            this.UsernameLbl.Text = "*Username*";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.transactionList);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.WelcomeLbl);
            this.Controls.Add(this.QuitBtn);
            this.Name = "MainMenu";
            this.Text = "Banco AL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Label WelcomeLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.ListView transactionList;
        private System.Windows.Forms.Label UsernameLbl;
    }
}