namespace DataBasePart
{
    partial class RemindAdding
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
            this.TimersListView = new System.Windows.Forms.ListView();
            this.BackButton = new System.Windows.Forms.Button();
            this.RemindBeforeCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HowToRemindCombo = new System.Windows.Forms.ComboBox();
            this.RemindBeforeRadio = new System.Windows.Forms.RadioButton();
            this.RemindAfterRadio = new System.Windows.Forms.RadioButton();
            this.RemindAfterCombo = new System.Windows.Forms.ComboBox();
            this.RemindInTimeRadio = new System.Windows.Forms.RadioButton();
            this.RemindUntillDateTime = new System.Windows.Forms.DateTimePicker();
            this.AddRemindButton = new System.Windows.Forms.Button();
            this.RemindListBox = new System.Windows.Forms.ListBox();
            this.DeleteRemindButton = new System.Windows.Forms.Button();
            this.SaveAndQuitButton = new System.Windows.Forms.Button();
            this.ComboEventNames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimersListView
            // 
            this.TimersListView.Location = new System.Drawing.Point(12, 12);
            this.TimersListView.MultiSelect = false;
            this.TimersListView.Name = "TimersListView";
            this.TimersListView.Size = new System.Drawing.Size(230, 336);
            this.TimersListView.TabIndex = 0;
            this.TimersListView.UseCompatibleStateImageBehavior = false;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 365);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // RemindBeforeCombo
            // 
            this.RemindBeforeCombo.FormattingEnabled = true;
            this.RemindBeforeCombo.Location = new System.Drawing.Point(386, 39);
            this.RemindBeforeCombo.Name = "RemindBeforeCombo";
            this.RemindBeforeCombo.Size = new System.Drawing.Size(121, 21);
            this.RemindBeforeCombo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Напоминать до:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Формат напоминания:";
            // 
            // HowToRemindCombo
            // 
            this.HowToRemindCombo.FormattingEnabled = true;
            this.HowToRemindCombo.Items.AddRange(new object[] {
            "Звуковое уведомление",
            "Уведомление",
            "Апокалипсис"});
            this.HowToRemindCombo.Location = new System.Drawing.Point(388, 137);
            this.HowToRemindCombo.Name = "HowToRemindCombo";
            this.HowToRemindCombo.Size = new System.Drawing.Size(119, 21);
            this.HowToRemindCombo.TabIndex = 7;
            // 
            // RemindBeforeRadio
            // 
            this.RemindBeforeRadio.AutoSize = true;
            this.RemindBeforeRadio.Checked = true;
            this.RemindBeforeRadio.Location = new System.Drawing.Point(262, 40);
            this.RemindBeforeRadio.Name = "RemindBeforeRadio";
            this.RemindBeforeRadio.Size = new System.Drawing.Size(100, 17);
            this.RemindBeforeRadio.TabIndex = 8;
            this.RemindBeforeRadio.TabStop = true;
            this.RemindBeforeRadio.Text = "Напомнить до:";
            this.RemindBeforeRadio.UseVisualStyleBackColor = true;
            // 
            // RemindAfterRadio
            // 
            this.RemindAfterRadio.AutoSize = true;
            this.RemindAfterRadio.Location = new System.Drawing.Point(262, 67);
            this.RemindAfterRadio.Name = "RemindAfterRadio";
            this.RemindAfterRadio.Size = new System.Drawing.Size(118, 17);
            this.RemindAfterRadio.TabIndex = 9;
            this.RemindAfterRadio.Text = "Напомнить после:";
            this.RemindAfterRadio.UseVisualStyleBackColor = true;
            // 
            // RemindAfterCombo
            // 
            this.RemindAfterCombo.FormattingEnabled = true;
            this.RemindAfterCombo.Location = new System.Drawing.Point(386, 66);
            this.RemindAfterCombo.Name = "RemindAfterCombo";
            this.RemindAfterCombo.Size = new System.Drawing.Size(121, 21);
            this.RemindAfterCombo.TabIndex = 10;
            // 
            // RemindInTimeRadio
            // 
            this.RemindInTimeRadio.AutoSize = true;
            this.RemindInTimeRadio.Location = new System.Drawing.Point(262, 16);
            this.RemindInTimeRadio.Name = "RemindInTimeRadio";
            this.RemindInTimeRadio.Size = new System.Drawing.Size(179, 17);
            this.RemindInTimeRadio.TabIndex = 11;
            this.RemindInTimeRadio.TabStop = true;
            this.RemindInTimeRadio.Text = "Напомнить в момент события";
            this.RemindInTimeRadio.UseVisualStyleBackColor = true;
            // 
            // RemindUntillDateTime
            // 
            this.RemindUntillDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RemindUntillDateTime.Location = new System.Drawing.Point(388, 108);
            this.RemindUntillDateTime.Name = "RemindUntillDateTime";
            this.RemindUntillDateTime.Size = new System.Drawing.Size(119, 20);
            this.RemindUntillDateTime.TabIndex = 12;
            // 
            // AddRemindButton
            // 
            this.AddRemindButton.Location = new System.Drawing.Point(262, 179);
            this.AddRemindButton.Name = "AddRemindButton";
            this.AddRemindButton.Size = new System.Drawing.Size(245, 29);
            this.AddRemindButton.TabIndex = 13;
            this.AddRemindButton.Text = "Добавить напоминание";
            this.AddRemindButton.UseVisualStyleBackColor = true;
            // 
            // RemindListBox
            // 
            this.RemindListBox.FormattingEnabled = true;
            this.RemindListBox.Location = new System.Drawing.Point(262, 214);
            this.RemindListBox.Name = "RemindListBox";
            this.RemindListBox.Size = new System.Drawing.Size(245, 134);
            this.RemindListBox.TabIndex = 14;
            // 
            // DeleteRemindButton
            // 
            this.DeleteRemindButton.Location = new System.Drawing.Point(262, 365);
            this.DeleteRemindButton.Name = "DeleteRemindButton";
            this.DeleteRemindButton.Size = new System.Drawing.Size(245, 22);
            this.DeleteRemindButton.TabIndex = 15;
            this.DeleteRemindButton.Text = "Удалить напоминание";
            this.DeleteRemindButton.UseVisualStyleBackColor = true;
            // 
            // SaveAndQuitButton
            // 
            this.SaveAndQuitButton.Location = new System.Drawing.Point(114, 364);
            this.SaveAndQuitButton.Name = "SaveAndQuitButton";
            this.SaveAndQuitButton.Size = new System.Drawing.Size(128, 23);
            this.SaveAndQuitButton.TabIndex = 16;
            this.SaveAndQuitButton.Text = "Сохранить и выйти";
            this.SaveAndQuitButton.UseVisualStyleBackColor = true;
            // 
            // ComboEventNames
            // 
            this.ComboEventNames.FormattingEnabled = true;
            this.ComboEventNames.Location = new System.Drawing.Point(103, 54);
            this.ComboEventNames.Name = "ComboEventNames";
            this.ComboEventNames.Size = new System.Drawing.Size(257, 21);
            this.ComboEventNames.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите событие:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Принять";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ComboEventNames);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 395);
            this.panel1.TabIndex = 17;
            // 
            // RemindAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 399);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SaveAndQuitButton);
            this.Controls.Add(this.DeleteRemindButton);
            this.Controls.Add(this.RemindListBox);
            this.Controls.Add(this.AddRemindButton);
            this.Controls.Add(this.RemindUntillDateTime);
            this.Controls.Add(this.RemindInTimeRadio);
            this.Controls.Add(this.RemindAfterCombo);
            this.Controls.Add(this.RemindAfterRadio);
            this.Controls.Add(this.RemindBeforeRadio);
            this.Controls.Add(this.HowToRemindCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RemindBeforeCombo);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.TimersListView);
            this.Name = "RemindAdding";
            this.Text = "RemindAdding";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView TimersListView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox RemindBeforeCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox HowToRemindCombo;
        private System.Windows.Forms.RadioButton RemindBeforeRadio;
        private System.Windows.Forms.RadioButton RemindAfterRadio;
        private System.Windows.Forms.ComboBox RemindAfterCombo;
        private System.Windows.Forms.RadioButton RemindInTimeRadio;
        private System.Windows.Forms.DateTimePicker RemindUntillDateTime;
        private System.Windows.Forms.Button AddRemindButton;
        private System.Windows.Forms.ListBox RemindListBox;
        private System.Windows.Forms.Button DeleteRemindButton;
        private System.Windows.Forms.Button SaveAndQuitButton;
        private System.Windows.Forms.ComboBox ComboEventNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}