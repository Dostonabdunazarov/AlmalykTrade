namespace AlmalykTrade
{
    partial class Login
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
            loginTextBox = new TextBox();
            passwordTextbox = new TextBox();
            button1 = new Button();
            label1 = new Label();
            showPasswordCheckbox = new CheckBox();
            SuspendLayout();
            // 
            // loginTextBox
            // 
            loginTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginTextBox.Location = new Point(122, 187);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.PlaceholderText = "Логин";
            loginTextBox.Size = new Size(248, 29);
            loginTextBox.TabIndex = 0;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextbox.Location = new Point(122, 249);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PlaceholderText = "Пароль";
            passwordTextbox.Size = new Size(248, 29);
            passwordTextbox.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(140, 360);
            button1.Name = "button1";
            button1.Size = new Size(204, 40);
            button1.TabIndex = 3;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(202, 73);
            label1.Name = "label1";
            label1.Size = new Size(85, 31);
            label1.TabIndex = 4;
            label1.Text = "ВХОД";
            // 
            // showPasswordCheckbox
            // 
            showPasswordCheckbox.AutoSize = true;
            showPasswordCheckbox.Location = new Point(253, 284);
            showPasswordCheckbox.Name = "showPasswordCheckbox";
            showPasswordCheckbox.Size = new Size(117, 19);
            showPasswordCheckbox.TabIndex = 5;
            showPasswordCheckbox.Text = "показать пароль";
            showPasswordCheckbox.UseVisualStyleBackColor = true;
            showPasswordCheckbox.CheckedChanged += showPasswordCheckbox_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 585);
            Controls.Add(showPasswordCheckbox);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(passwordTextbox);
            Controls.Add(loginTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginTextBox;
        private TextBox passwordTextbox;
        private Button button1;
        private Label label1;
        private CheckBox showPasswordCheckbox;
    }
}