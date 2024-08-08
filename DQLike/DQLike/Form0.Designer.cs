namespace DQLike
{
    partial class Form0
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.userControl21 = new UserControl2("Herbe médicinale", 5);
            this.userControl22 = new UserControl2("Arme", 50);
            this.userControl23 = new UserControl2("Armure", 50);
            this.labelTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Jouer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marché :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mercenaire du jour :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pièces d\'or :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "payer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(104, 65);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(142, 95);
            this.userControl21.TabIndex = 6;
            // 
            // userControl22
            // 
            this.userControl22.Location = new System.Drawing.Point(252, 65);
            this.userControl22.Name = "userControl22";
            this.userControl22.Size = new System.Drawing.Size(142, 95);
            this.userControl22.TabIndex = 7;
            // 
            // userControl23
            // 
            this.userControl23.Location = new System.Drawing.Point(400, 65);
            this.userControl23.Name = "userControl23";
            this.userControl23.Size = new System.Drawing.Size(142, 95);
            this.userControl23.TabIndex = 8;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(30, 184);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(39, 15);
            this.labelTotal.TabIndex = 9;
            this.labelTotal.Text = "TOTAL";
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.userControl23);
            this.Controls.Add(this.userControl22);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form0";
            this.Text = "Form0";
            this.Load += new System.EventHandler(this.Form0_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private UserControl2 userControl21;
        private UserControl2 userControl22;
        private UserControl2 userControl23;
        private Label labelTotal;
    }
}