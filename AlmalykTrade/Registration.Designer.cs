namespace AlmalykTrade
{
    partial class Registration
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
            registerButton = new Button();
            loginTextBox = new TextBox();
            passwordTextBox = new TextBox();
            rolesCombobox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            showPasswordCheckbox = new CheckBox();
            SuspendLayout();
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.SkyBlue;
            registerButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            registerButton.Location = new Point(165, 422);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(227, 41);
            registerButton.TabIndex = 0;
            registerButton.Text = "Сохранить";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // loginTextBox
            // 
            loginTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginTextBox.Location = new Point(194, 182);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(227, 29);
            loginTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(194, 243);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(227, 29);
            passwordTextBox.TabIndex = 2;
            // 
            // rolesCombobox
            // 
            rolesCombobox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rolesCombobox.FormattingEnabled = true;
            rolesCombobox.Items.AddRange(new object[] { "Админ", "Пользователь" });
            rolesCombobox.Location = new Point(194, 305);
            rolesCombobox.Name = "rolesCombobox";
            rolesCombobox.Size = new Size(227, 29);
            rolesCombobox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(109, 185);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 5;
            label1.Text = "Логин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(101, 246);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 6;
            label2.Text = "Пароль:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(121, 308);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 8;
            label4.Text = "Роль:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(174, 85);
            label3.Name = "label3";
            label3.Size = new Size(204, 31);
            label3.TabIndex = 9;
            label3.Text = "РЕГИСТРАЦИЯ";
            // 
            // showPasswordCheckbox
            // 
            showPasswordCheckbox.AutoSize = true;
            showPasswordCheckbox.Location = new Point(301, 275);
            showPasswordCheckbox.Name = "showPasswordCheckbox";
            showPasswordCheckbox.Size = new Size(117, 19);
            showPasswordCheckbox.TabIndex = 10;
            showPasswordCheckbox.Text = "показать пароль";
            showPasswordCheckbox.UseVisualStyleBackColor = true;
            showPasswordCheckbox.CheckedChanged += showPasswordCheckbox_CheckedChanged;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 593);
            Controls.Add(showPasswordCheckbox);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rolesCombobox);
            Controls.Add(passwordTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(registerButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            FormClosed += Registration_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerButton;
        private TextBox loginTextBox;
        private TextBox passwordTextBox;
        private ComboBox rolesCombobox;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private CheckBox showPasswordCheckbox;
    }
}