namespace DataBasePart
{
    partial class EventAddingForm
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
            this.EventNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddTimeButton = new System.Windows.Forms.Button();
            this.DateTimeHappens = new System.Windows.Forms.DateTimePicker();
            this.RadioBefore = new System.Windows.Forms.RadioButton();
            this.RadioHappens = new System.Windows.Forms.RadioButton();
            this.BeforeEventMask = new System.Windows.Forms.MaskedTextBox();
            this.AddRemindButton = new System.Windows.Forms.Button();
            this.SaveAndQuitButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.RemoveTimeButton = new System.Windows.Forms.Button();
            this.RadioWithoutRepeat = new System.Windows.Forms.RadioButton();
            this.RadioEveryday = new System.Windows.Forms.RadioButton();
            this.RadioEveryweek = new System.Windows.Forms.RadioButton();
            this.RadioEverymonth = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TimeListView = new System.Windows.Forms.ListView();
            this.EventDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EventRepeat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainBaseInterfaceFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainBaseInterfaceFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EventNameBox
            // 
            this.EventNameBox.Location = new System.Drawing.Point(85, 12);
            this.EventNameBox.Name = "EventNameBox";
            this.EventNameBox.Size = new System.Drawing.Size(438, 20);
            this.EventNameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя события:";
            // 
            // AddTimeButton
            // 
            this.AddTimeButton.Enabled = false;
            this.AddTimeButton.Location = new System.Drawing.Point(262, 65);
            this.AddTimeButton.Name = "AddTimeButton";
            this.AddTimeButton.Size = new System.Drawing.Size(34, 44);
            this.AddTimeButton.TabIndex = 3;
            this.AddTimeButton.Text = ">>";
            this.AddTimeButton.UseVisualStyleBackColor = true;
            this.AddTimeButton.Click += new System.EventHandler(this.AddTimeButton_Click);
            // 
            // DateTimeHappens
            // 
            this.DateTimeHappens.Enabled = false;
            this.DateTimeHappens.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeHappens.Location = new System.Drawing.Point(155, 89);
            this.DateTimeHappens.MinDate = new System.DateTime(2017, 3, 3, 0, 0, 0, 0);
            this.DateTimeHappens.Name = "DateTimeHappens";
            this.DateTimeHappens.Size = new System.Drawing.Size(85, 20);
            this.DateTimeHappens.TabIndex = 5;
            // 
            // RadioBefore
            // 
            this.RadioBefore.AutoSize = true;
            this.RadioBefore.Checked = true;
            this.RadioBefore.Location = new System.Drawing.Point(9, 9);
            this.RadioBefore.Name = "RadioBefore";
            this.RadioBefore.Size = new System.Drawing.Size(135, 17);
            this.RadioBefore.TabIndex = 1;
            this.RadioBefore.TabStop = true;
            this.RadioBefore.Text = "Осталось до события";
            this.RadioBefore.UseVisualStyleBackColor = true;
            // 
            // RadioHappens
            // 
            this.RadioHappens.AutoSize = true;
            this.RadioHappens.Location = new System.Drawing.Point(9, 35);
            this.RadioHappens.Name = "RadioHappens";
            this.RadioHappens.Size = new System.Drawing.Size(140, 17);
            this.RadioHappens.TabIndex = 4;
            this.RadioHappens.TabStop = true;
            this.RadioHappens.Text = "Событие произойдет в";
            this.RadioHappens.UseVisualStyleBackColor = true;
            // 
            // BeforeEventMask
            // 
            this.BeforeEventMask.Location = new System.Drawing.Point(155, 62);
            this.BeforeEventMask.Mask = "99:99:90";
            this.BeforeEventMask.Name = "BeforeEventMask";
            this.BeforeEventMask.Size = new System.Drawing.Size(85, 20);
            this.BeforeEventMask.TabIndex = 2;
            // 
            // AddRemindButton
            // 
            this.AddRemindButton.Location = new System.Drawing.Point(383, 212);
            this.AddRemindButton.Name = "AddRemindButton";
            this.AddRemindButton.Size = new System.Drawing.Size(140, 23);
            this.AddRemindButton.TabIndex = 12;
            this.AddRemindButton.Text = "Добавить напоминание";
            this.AddRemindButton.UseVisualStyleBackColor = true;
            // 
            // SaveAndQuitButton
            // 
            this.SaveAndQuitButton.Location = new System.Drawing.Point(383, 241);
            this.SaveAndQuitButton.Name = "SaveAndQuitButton";
            this.SaveAndQuitButton.Size = new System.Drawing.Size(140, 23);
            this.SaveAndQuitButton.TabIndex = 13;
            this.SaveAndQuitButton.Text = "Сохранить и вернуться";
            this.SaveAndQuitButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(8, 241);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RemoveTimeButton
            // 
            this.RemoveTimeButton.Enabled = false;
            this.RemoveTimeButton.Location = new System.Drawing.Point(262, 157);
            this.RemoveTimeButton.Name = "RemoveTimeButton";
            this.RemoveTimeButton.Size = new System.Drawing.Size(34, 44);
            this.RemoveTimeButton.TabIndex = 11;
            this.RemoveTimeButton.Text = "<<";
            this.RemoveTimeButton.UseVisualStyleBackColor = true;
            this.RemoveTimeButton.Click += new System.EventHandler(this.RemoveTimeButton_Click);
            // 
            // RadioWithoutRepeat
            // 
            this.RadioWithoutRepeat.AutoSize = true;
            this.RadioWithoutRepeat.Checked = true;
            this.RadioWithoutRepeat.Location = new System.Drawing.Point(3, 10);
            this.RadioWithoutRepeat.Name = "RadioWithoutRepeat";
            this.RadioWithoutRepeat.Size = new System.Drawing.Size(106, 17);
            this.RadioWithoutRepeat.TabIndex = 6;
            this.RadioWithoutRepeat.TabStop = true;
            this.RadioWithoutRepeat.Text = "Без повторения";
            this.RadioWithoutRepeat.UseVisualStyleBackColor = true;
            // 
            // RadioEveryday
            // 
            this.RadioEveryday.AutoSize = true;
            this.RadioEveryday.Location = new System.Drawing.Point(3, 34);
            this.RadioEveryday.Name = "RadioEveryday";
            this.RadioEveryday.Size = new System.Drawing.Size(82, 17);
            this.RadioEveryday.TabIndex = 7;
            this.RadioEveryday.Text = "Ежедневно";
            this.RadioEveryday.UseVisualStyleBackColor = true;
            // 
            // RadioEveryweek
            // 
            this.RadioEveryweek.AutoSize = true;
            this.RadioEveryweek.Location = new System.Drawing.Point(3, 58);
            this.RadioEveryweek.Name = "RadioEveryweek";
            this.RadioEveryweek.Size = new System.Drawing.Size(94, 17);
            this.RadioEveryweek.TabIndex = 8;
            this.RadioEveryweek.Text = "Еженедельно";
            this.RadioEveryweek.UseVisualStyleBackColor = true;
            // 
            // RadioEverymonth
            // 
            this.RadioEverymonth.AutoSize = true;
            this.RadioEverymonth.Location = new System.Drawing.Point(3, 82);
            this.RadioEverymonth.Name = "RadioEverymonth";
            this.RadioEverymonth.Size = new System.Drawing.Size(89, 17);
            this.RadioEverymonth.TabIndex = 9;
            this.RadioEverymonth.Text = "Ежемесячно";
            this.RadioEverymonth.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioWithoutRepeat);
            this.groupBox1.Controls.Add(this.RadioEverymonth);
            this.groupBox1.Controls.Add(this.RadioEveryday);
            this.groupBox1.Controls.Add(this.RadioEveryweek);
            this.groupBox1.Location = new System.Drawing.Point(8, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 106);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadioBefore);
            this.groupBox2.Controls.Add(this.RadioHappens);
            this.groupBox2.Location = new System.Drawing.Point(-1, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 55);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // TimeListView
            // 
            this.TimeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EventDate,
            this.EventRepeat});
            this.TimeListView.FullRowSelect = true;
            this.TimeListView.GridLines = true;
            this.TimeListView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TimeListView.Location = new System.Drawing.Point(302, 56);
            this.TimeListView.MultiSelect = false;
            this.TimeListView.Name = "TimeListView";
            this.TimeListView.Size = new System.Drawing.Size(221, 145);
            this.TimeListView.TabIndex = 19;
            this.TimeListView.UseCompatibleStateImageBehavior = false;
            this.TimeListView.View = System.Windows.Forms.View.List;
            // 
            // EventDate
            // 
            this.EventDate.Text = "Дата события";
            // 
            // EventRepeat
            // 
            this.EventRepeat.Text = "Повторение события";
            // 
            // mainBaseInterfaceFormBindingSource
            // 
            this.mainBaseInterfaceFormBindingSource.DataSource = typeof(DataBasePart.MainBaseInterfaceForm);
            // 
            // EventAddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 278);
            this.Controls.Add(this.TimeListView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RemoveTimeButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SaveAndQuitButton);
            this.Controls.Add(this.AddRemindButton);
            this.Controls.Add(this.BeforeEventMask);
            this.Controls.Add(this.DateTimeHappens);
            this.Controls.Add(this.AddTimeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EventNameBox);
            this.Name = "EventAddingForm";
            this.Text = "EventAddingForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainBaseInterfaceFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EventNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddTimeButton;
        private System.Windows.Forms.DateTimePicker DateTimeHappens;
        private System.Windows.Forms.RadioButton RadioBefore;
        private System.Windows.Forms.RadioButton RadioHappens;
        private System.Windows.Forms.MaskedTextBox BeforeEventMask;
        private System.Windows.Forms.Button AddRemindButton;
        private System.Windows.Forms.Button SaveAndQuitButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button RemoveTimeButton;
        private System.Windows.Forms.RadioButton RadioWithoutRepeat;
        private System.Windows.Forms.RadioButton RadioEveryday;
        private System.Windows.Forms.RadioButton RadioEveryweek;
        private System.Windows.Forms.RadioButton RadioEverymonth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView TimeListView;
        private System.Windows.Forms.ColumnHeader EventDate;
        private System.Windows.Forms.ColumnHeader EventRepeat;
        private System.Windows.Forms.BindingSource mainBaseInterfaceFormBindingSource;
    }
}