namespace AlmalykTrade
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            reportTab = new TabControl();
            mainTab = new TabPage();
            comingTab = new TabPage();
            expenseTab = new TabPage();
            tabPage2 = new TabPage();
            userTab = new TabPage();
            removeUserButton = new Button();
            addUserButton = new Button();
            panel2 = new Panel();
            usersGrid = new DataGridView();
            reportTab.SuspendLayout();
            userTab.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersGrid).BeginInit();
            SuspendLayout();
            // 
            // reportTab
            // 
            reportTab.Controls.Add(mainTab);
            reportTab.Controls.Add(comingTab);
            reportTab.Controls.Add(expenseTab);
            reportTab.Controls.Add(tabPage2);
            reportTab.Controls.Add(userTab);
            reportTab.Dock = DockStyle.Fill;
            reportTab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            reportTab.Location = new Point(0, 0);
            reportTab.Name = "reportTab";
            reportTab.SelectedIndex = 0;
            reportTab.Size = new Size(1439, 857);
            reportTab.TabIndex = 0;
            // 
            // mainTab
            // 
            mainTab.Location = new Point(4, 30);
            mainTab.Name = "mainTab";
            mainTab.Padding = new Padding(3);
            mainTab.Size = new Size(1431, 823);
            mainTab.TabIndex = 0;
            mainTab.Text = "Главная";
            mainTab.UseVisualStyleBackColor = true;
            // 
            // comingTab
            // 
            comingTab.Location = new Point(4, 30);
            comingTab.Name = "comingTab";
            comingTab.Padding = new Padding(3);
            comingTab.Size = new Size(1431, 823);
            comingTab.TabIndex = 3;
            comingTab.Text = "Приход";
            comingTab.UseVisualStyleBackColor = true;
            // 
            // expenseTab
            // 
            expenseTab.Location = new Point(4, 30);
            expenseTab.Name = "expenseTab";
            expenseTab.Padding = new Padding(3);
            expenseTab.Size = new Size(1431, 823);
            expenseTab.TabIndex = 4;
            expenseTab.Text = "Расход";
            expenseTab.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1431, 823);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Отчеты";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // userTab
            // 
            userTab.Controls.Add(removeUserButton);
            userTab.Controls.Add(addUserButton);
            userTab.Controls.Add(panel2);
            userTab.Location = new Point(4, 30);
            userTab.Name = "userTab";
            userTab.Padding = new Padding(3);
            userTab.Size = new Size(1431, 823);
            userTab.TabIndex = 2;
            userTab.Text = "Пользователи";
            userTab.UseVisualStyleBackColor = true;
            // 
            // removeUserButton
            // 
            removeUserButton.BackColor = Color.DarkSeaGreen;
            removeUserButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            removeUserButton.Location = new Point(1188, 80);
            removeUserButton.Name = "removeUserButton";
            removeUserButton.Size = new Size(237, 55);
            removeUserButton.TabIndex = 2;
            removeUserButton.Text = "Удалить \r\nпользователя";
            removeUserButton.UseVisualStyleBackColor = false;
            // 
            // addUserButton
            // 
            addUserButton.BackColor = Color.DarkSeaGreen;
            addUserButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addUserButton.Location = new Point(1186, 9);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(237, 58);
            addUserButton.TabIndex = 1;
            addUserButton.Text = "Добавить нового \r\nпользователя";
            addUserButton.UseVisualStyleBackColor = false;
            addUserButton.Click += addUserButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(usersGrid);
            panel2.Location = new Point(8, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1172, 815);
            panel2.TabIndex = 0;
            // 
            // usersGrid
            // 
            usersGrid.BackgroundColor = Color.MintCream;
            usersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersGrid.GridColor = Color.LightGreen;
            usersGrid.Location = new Point(-2, 3);
            usersGrid.Name = "usersGrid";
            usersGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            usersGrid.RowTemplate.Height = 25;
            usersGrid.Size = new Size(1171, 817);
            usersGrid.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1439, 857);
            Controls.Add(reportTab);
            Name = "MainForm";
            Text = "Олмалик Савдо";
            FormClosed += MainForm_FormClosed;
            reportTab.ResumeLayout(false);
            userTab.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)usersGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl reportTab;
        private TabPage mainTab;
        private TabPage tabPage2;
        private TabPage userTab;
        private Panel panel2;
        private Button addUserButton;
        private Button removeUserButton;
        private TabPage comingTab;
        private TabPage expenseTab;
        public DataGridView usersGrid;
    }
}
