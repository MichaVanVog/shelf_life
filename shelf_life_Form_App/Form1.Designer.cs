﻿
namespace shelf_life_Form_App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.thirtyDaysLabel = new System.Windows.Forms.Label();
            this.threeMonthsLabel = new System.Windows.Forms.Label();
            this.oneHundredThirtyFiveDaysLabel = new System.Windows.Forms.Label();
            this.oneHundredFiftyDaysLabel = new System.Windows.Forms.Label();
            this.oneHundredEightyDaysLabel = new System.Windows.Forms.Label();
            this.sixMonthsLabel = new System.Windows.Forms.Label();
            this.searchDaysLabel = new System.Windows.Forms.Label();
            this.FoundDaysLabel = new System.Windows.Forms.Label();
            this.FoundMonthsLabel = new System.Windows.Forms.Label();
            this.ClientsMinimumAgeLabel = new System.Windows.Forms.Label();
            this.BirthdaysLabel = new System.Windows.Forms.Label();
            this.KodexLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ManufactoredDayLabel = new System.Windows.Forms.Label();
            this.DaysFromManufactoringLabel = new System.Windows.Forms.Label();
            this.MonthsFromManufactoringLabel = new System.Windows.Forms.Label();
            this.DaysFromManufactoringTextBox = new System.Windows.Forms.TextBox();
            this.MonthsFromManufactoringTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DateOfManufactureTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(132, 40);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(322, 28);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Часто используемые сроки годности:";
            this.titleLabel.UseCompatibleTextRendering = true;
            // 
            // thirtyDaysLabel
            // 
            this.thirtyDaysLabel.AutoSize = true;
            this.thirtyDaysLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thirtyDaysLabel.Location = new System.Drawing.Point(132, 68);
            this.thirtyDaysLabel.Name = "thirtyDaysLabel";
            this.thirtyDaysLabel.Size = new System.Drawing.Size(75, 23);
            this.thirtyDaysLabel.TabIndex = 2;
            this.thirtyDaysLabel.Text = "90 дней:";
            // 
            // threeMonthsLabel
            // 
            this.threeMonthsLabel.AutoSize = true;
            this.threeMonthsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.threeMonthsLabel.Location = new System.Drawing.Point(131, 91);
            this.threeMonthsLabel.Name = "threeMonthsLabel";
            this.threeMonthsLabel.Size = new System.Drawing.Size(85, 23);
            this.threeMonthsLabel.TabIndex = 3;
            this.threeMonthsLabel.Text = "3 месяца:";
            // 
            // oneHundredThirtyFiveDaysLabel
            // 
            this.oneHundredThirtyFiveDaysLabel.AutoSize = true;
            this.oneHundredThirtyFiveDaysLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oneHundredThirtyFiveDaysLabel.Location = new System.Drawing.Point(131, 137);
            this.oneHundredThirtyFiveDaysLabel.Name = "oneHundredThirtyFiveDaysLabel";
            this.oneHundredThirtyFiveDaysLabel.Size = new System.Drawing.Size(84, 23);
            this.oneHundredThirtyFiveDaysLabel.TabIndex = 4;
            this.oneHundredThirtyFiveDaysLabel.Text = "135 дней:";
            // 
            // oneHundredFiftyDaysLabel
            // 
            this.oneHundredFiftyDaysLabel.AutoSize = true;
            this.oneHundredFiftyDaysLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oneHundredFiftyDaysLabel.Location = new System.Drawing.Point(132, 183);
            this.oneHundredFiftyDaysLabel.Name = "oneHundredFiftyDaysLabel";
            this.oneHundredFiftyDaysLabel.Size = new System.Drawing.Size(84, 23);
            this.oneHundredFiftyDaysLabel.TabIndex = 5;
            this.oneHundredFiftyDaysLabel.Text = "150 дней:";
            // 
            // oneHundredEightyDaysLabel
            // 
            this.oneHundredEightyDaysLabel.AutoSize = true;
            this.oneHundredEightyDaysLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oneHundredEightyDaysLabel.Location = new System.Drawing.Point(132, 229);
            this.oneHundredEightyDaysLabel.Name = "oneHundredEightyDaysLabel";
            this.oneHundredEightyDaysLabel.Size = new System.Drawing.Size(84, 23);
            this.oneHundredEightyDaysLabel.TabIndex = 6;
            this.oneHundredEightyDaysLabel.Text = "180 дней:";
            // 
            // sixMonthsLabel
            // 
            this.sixMonthsLabel.AutoSize = true;
            this.sixMonthsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sixMonthsLabel.Location = new System.Drawing.Point(132, 252);
            this.sixMonthsLabel.Name = "sixMonthsLabel";
            this.sixMonthsLabel.Size = new System.Drawing.Size(94, 23);
            this.sixMonthsLabel.TabIndex = 7;
            this.sixMonthsLabel.Text = "6 месяцев:";
            // 
            // searchDaysLabel
            // 
            this.searchDaysLabel.AutoSize = true;
            this.searchDaysLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchDaysLabel.Location = new System.Drawing.Point(131, 298);
            this.searchDaysLabel.Name = "searchDaysLabel";
            this.searchDaysLabel.Size = new System.Drawing.Size(622, 23);
            this.searchDaysLabel.TabIndex = 8;
            this.searchDaysLabel.Text = "В этом окне можно задать дату производства и получить срок годности:";
            // 
            // FoundDaysLabel
            // 
            this.FoundDaysLabel.AutoSize = true;
            this.FoundDaysLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FoundDaysLabel.Location = new System.Drawing.Point(477, 350);
            this.FoundDaysLabel.Name = "FoundDaysLabel";
            this.FoundDaysLabel.Size = new System.Drawing.Size(0, 23);
            this.FoundDaysLabel.TabIndex = 9;
            // 
            // FoundMonthsLabel
            // 
            this.FoundMonthsLabel.AutoSize = true;
            this.FoundMonthsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FoundMonthsLabel.Location = new System.Drawing.Point(477, 415);
            this.FoundMonthsLabel.Name = "FoundMonthsLabel";
            this.FoundMonthsLabel.Size = new System.Drawing.Size(0, 23);
            this.FoundMonthsLabel.TabIndex = 10;
            // 
            // ClientsMinimumAgeLabel
            // 
            this.ClientsMinimumAgeLabel.AutoSize = true;
            this.ClientsMinimumAgeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClientsMinimumAgeLabel.Location = new System.Drawing.Point(132, 461);
            this.ClientsMinimumAgeLabel.Name = "ClientsMinimumAgeLabel";
            this.ClientsMinimumAgeLabel.Size = new System.Drawing.Size(550, 23);
            this.ClientsMinimumAgeLabel.TabIndex = 11;
            this.ClientsMinimumAgeLabel.Text = "Дата минимально разрешеного возраста для покупки алкоголя:";
            // 
            // BirthdaysLabel
            // 
            this.BirthdaysLabel.AutoSize = true;
            this.BirthdaysLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BirthdaysLabel.Location = new System.Drawing.Point(132, 484);
            this.BirthdaysLabel.Name = "BirthdaysLabel";
            this.BirthdaysLabel.Size = new System.Drawing.Size(132, 23);
            this.BirthdaysLabel.TabIndex = 12;
            this.BirthdaysLabel.Text = "тут будет число";
            // 
            // KodexLabel
            // 
            this.KodexLabel.AutoSize = true;
            this.KodexLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KodexLabel.Location = new System.Drawing.Point(131, 507);
            this.KodexLabel.Name = "KodexLabel";
            this.KodexLabel.Size = new System.Drawing.Size(670, 23);
            this.KodexLabel.TabIndex = 13;
            this.KodexLabel.Text = "Согласно ст. 191 и ст. 192 ГК РФ продажа алкоголя в ДЕНЬ РОЖДЕНИЯ запрещена.";
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.CalculateButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalculateButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CalculateButton.Location = new System.Drawing.Point(131, 397);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(162, 45);
            this.CalculateButton.TabIndex = 14;
            this.CalculateButton.Text = "рассчитать";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ManufactoredDayLabel
            // 
            this.ManufactoredDayLabel.AutoSize = true;
            this.ManufactoredDayLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManufactoredDayLabel.Location = new System.Drawing.Point(132, 321);
            this.ManufactoredDayLabel.Name = "ManufactoredDayLabel";
            this.ManufactoredDayLabel.Size = new System.Drawing.Size(161, 23);
            this.ManufactoredDayLabel.TabIndex = 15;
            this.ManufactoredDayLabel.Text = "Дата производства";
            // 
            // DaysFromManufactoringLabel
            // 
            this.DaysFromManufactoringLabel.AutoSize = true;
            this.DaysFromManufactoringLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DaysFromManufactoringLabel.Location = new System.Drawing.Point(344, 321);
            this.DaysFromManufactoringLabel.Name = "DaysFromManufactoringLabel";
            this.DaysFromManufactoringLabel.Size = new System.Drawing.Size(110, 23);
            this.DaysFromManufactoringLabel.TabIndex = 16;
            this.DaysFromManufactoringLabel.Text = "Дни от даты:";
            // 
            // MonthsFromManufactoringLabel
            // 
            this.MonthsFromManufactoringLabel.AutoSize = true;
            this.MonthsFromManufactoringLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MonthsFromManufactoringLabel.Location = new System.Drawing.Point(330, 386);
            this.MonthsFromManufactoringLabel.Name = "MonthsFromManufactoringLabel";
            this.MonthsFromManufactoringLabel.Size = new System.Drawing.Size(141, 23);
            this.MonthsFromManufactoringLabel.TabIndex = 17;
            this.MonthsFromManufactoringLabel.Text = "Месяцы от даты:";
            // 
            // DaysFromManufactoringTextBox
            // 
            this.DaysFromManufactoringTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DaysFromManufactoringTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.DaysFromManufactoringTextBox.Location = new System.Drawing.Point(344, 347);
            this.DaysFromManufactoringTextBox.Name = "DaysFromManufactoringTextBox";
            this.DaysFromManufactoringTextBox.PlaceholderText = "000";
            this.DaysFromManufactoringTextBox.Size = new System.Drawing.Size(110, 30);
            this.DaysFromManufactoringTextBox.TabIndex = 18;
            this.DaysFromManufactoringTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MonthsFromManufactoringTextBox
            // 
            this.MonthsFromManufactoringTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MonthsFromManufactoringTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.MonthsFromManufactoringTextBox.Location = new System.Drawing.Point(330, 412);
            this.MonthsFromManufactoringTextBox.Name = "MonthsFromManufactoringTextBox";
            this.MonthsFromManufactoringTextBox.PlaceholderText = "00";
            this.MonthsFromManufactoringTextBox.Size = new System.Drawing.Size(141, 30);
            this.MonthsFromManufactoringTextBox.TabIndex = 19;
            this.MonthsFromManufactoringTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(847, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // DateOfManufactureTextBox
            // 
            this.DateOfManufactureTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateOfManufactureTextBox.Location = new System.Drawing.Point(132, 350);
            this.DateOfManufactureTextBox.Mask = "00/00/0000";
            this.DateOfManufactureTextBox.Name = "DateOfManufactureTextBox";
            this.DateOfManufactureTextBox.Size = new System.Drawing.Size(162, 30);
            this.DateOfManufactureTextBox.TabIndex = 21;
            this.DateOfManufactureTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1299, 560);
            this.Controls.Add(this.DateOfManufactureTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MonthsFromManufactoringTextBox);
            this.Controls.Add(this.DaysFromManufactoringTextBox);
            this.Controls.Add(this.MonthsFromManufactoringLabel);
            this.Controls.Add(this.DaysFromManufactoringLabel);
            this.Controls.Add(this.ManufactoredDayLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.KodexLabel);
            this.Controls.Add(this.BirthdaysLabel);
            this.Controls.Add(this.ClientsMinimumAgeLabel);
            this.Controls.Add(this.FoundMonthsLabel);
            this.Controls.Add(this.FoundDaysLabel);
            this.Controls.Add(this.searchDaysLabel);
            this.Controls.Add(this.sixMonthsLabel);
            this.Controls.Add(this.oneHundredEightyDaysLabel);
            this.Controls.Add(this.oneHundredFiftyDaysLabel);
            this.Controls.Add(this.oneHundredThirtyFiveDaysLabel);
            this.Controls.Add(this.threeMonthsLabel);
            this.Controls.Add(this.thirtyDaysLabel);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Пивная Корова";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label thirtyDaysLabel;
        private System.Windows.Forms.Label threeMonthsLabel;
        private System.Windows.Forms.Label oneHundredThirtyFiveDaysLabel;
        private System.Windows.Forms.Label oneHundredFiftyDaysLabel;
        private System.Windows.Forms.Label oneHundredEightyDaysLabel;
        private System.Windows.Forms.Label sixMonthsLabel;
        private System.Windows.Forms.Label searchDaysLabel;
        private System.Windows.Forms.Label FoundDaysLabel;
        private System.Windows.Forms.Label FoundMonthsLabel;
        private System.Windows.Forms.Label ClientsMinimumAgeLabel;
        private System.Windows.Forms.Label BirthdaysLabel;
        private System.Windows.Forms.Label KodexLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label ManufactoredDayLabel;
        private System.Windows.Forms.Label DaysFromManufactoringLabel;
        private System.Windows.Forms.Label MonthsFromManufactoringLabel;
        private System.Windows.Forms.TextBox DaysFromManufactoringTextBox;
        private System.Windows.Forms.TextBox MonthsFromManufactoringTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox DateOfManufactureTextBox;
    }
}

