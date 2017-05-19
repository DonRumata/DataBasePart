using ModelMVPDataBasePart;

namespace DataBasePart
{
    partial class MainBaseInterfaceForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddingMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.EventAddMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.RemindAddMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.фильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TabContainer = new System.Windows.Forms.TabControl();
            this.MainViewTab = new System.Windows.Forms.TabPage();
            this.MainViewGrid = new System.Windows.Forms.DataGridView();
            this.EventViewTab = new System.Windows.Forms.TabPage();
            this.EventViewGrid = new System.Windows.Forms.DataGridView();
            this.ReminderViewTab = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TabContainer.SuspendLayout();
            this.MainViewTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainViewGrid)).BeginInit();
            this.EventViewTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.добавитьToolStripMenuItem,
            this.настройкаToolStripMenuItem,
            this.базаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1037, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.добавитьToolStripMenuItem.Text = "Вид";
            // 
            // настройкаToolStripMenuItem
            // 
            this.настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            this.настройкаToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.настройкаToolStripMenuItem.Text = "Настройка";
            // 
            // базаToolStripMenuItem
            // 
            this.базаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddingMenuStrip,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.фильтрToolStripMenuItem});
            this.базаToolStripMenuItem.Name = "базаToolStripMenuItem";
            this.базаToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.базаToolStripMenuItem.Text = "База";
            // 
            // AddingMenuStrip
            // 
            this.AddingMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EventAddMenuStrip,
            this.RemindAddMenuStrip});
            this.AddingMenuStrip.Name = "AddingMenuStrip";
            this.AddingMenuStrip.Size = new System.Drawing.Size(128, 22);
            this.AddingMenuStrip.Text = "Добавить";
            // 
            // EventAddMenuStrip
            // 
            this.EventAddMenuStrip.Name = "EventAddMenuStrip";
            this.EventAddMenuStrip.Size = new System.Drawing.Size(152, 22);
            this.EventAddMenuStrip.Text = "Событие";
            // 
            // RemindAddMenuStrip
            // 
            this.RemindAddMenuStrip.Name = "RemindAddMenuStrip";
            this.RemindAddMenuStrip.Size = new System.Drawing.Size(152, 22);
            this.RemindAddMenuStrip.Text = "Напоминание";
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 6);
            // 
            // фильтрToolStripMenuItem
            // 
            this.фильтрToolStripMenuItem.Name = "фильтрToolStripMenuItem";
            this.фильтрToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.фильтрToolStripMenuItem.Text = "Фильтр";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 405);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Событие";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(328, 87);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(167, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "Фильтр";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(167, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // TabContainer
            // 
            this.TabContainer.Controls.Add(this.MainViewTab);
            this.TabContainer.Controls.Add(this.EventViewTab);
            this.TabContainer.Controls.Add(this.ReminderViewTab);
            this.TabContainer.Location = new System.Drawing.Point(13, 34);
            this.TabContainer.Name = "TabContainer";
            this.TabContainer.SelectedIndex = 0;
            this.TabContainer.Size = new System.Drawing.Size(1012, 365);
            this.TabContainer.TabIndex = 3;
            // 
            // MainViewTab
            // 
            this.MainViewTab.Controls.Add(this.MainViewGrid);
            this.MainViewTab.Location = new System.Drawing.Point(4, 22);
            this.MainViewTab.Name = "MainViewTab";
            this.MainViewTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainViewTab.Size = new System.Drawing.Size(1004, 339);
            this.MainViewTab.TabIndex = 1;
            this.MainViewTab.Text = "Общий вид";
            this.MainViewTab.UseVisualStyleBackColor = true;
            // 
            // MainViewGrid
            // 
            this.MainViewGrid.AllowUserToAddRows = false;
            this.MainViewGrid.AllowUserToDeleteRows = false;
            this.MainViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainViewGrid.Location = new System.Drawing.Point(0, 0);
            this.MainViewGrid.Name = "MainViewGrid";
            this.MainViewGrid.ReadOnly = true;
            this.MainViewGrid.Size = new System.Drawing.Size(948, 336);
            this.MainViewGrid.TabIndex = 0;
            // 
            // EventViewTab
            // 
            this.EventViewTab.Controls.Add(this.EventViewGrid);
            this.EventViewTab.Location = new System.Drawing.Point(4, 22);
            this.EventViewTab.Name = "EventViewTab";
            this.EventViewTab.Padding = new System.Windows.Forms.Padding(3);
            this.EventViewTab.Size = new System.Drawing.Size(1004, 339);
            this.EventViewTab.TabIndex = 2;
            this.EventViewTab.Text = "События";
            this.EventViewTab.UseVisualStyleBackColor = true;
            // 
            // EventViewGrid
            // 
            this.EventViewGrid.AllowUserToAddRows = false;
            this.EventViewGrid.AllowUserToDeleteRows = false;
            this.EventViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventViewGrid.Location = new System.Drawing.Point(7, 7);
            this.EventViewGrid.Name = "EventViewGrid";
            this.EventViewGrid.ReadOnly = true;
            this.EventViewGrid.Size = new System.Drawing.Size(883, 315);
            this.EventViewGrid.TabIndex = 0;
            // 
            // ReminderViewTab
            // 
            this.ReminderViewTab.Location = new System.Drawing.Point(4, 22);
            this.ReminderViewTab.Name = "ReminderViewTab";
            this.ReminderViewTab.Size = new System.Drawing.Size(1004, 339);
            this.ReminderViewTab.TabIndex = 3;
            this.ReminderViewTab.Text = "Напоминания";
            this.ReminderViewTab.UseVisualStyleBackColor = true;
            // 
            // MainBaseInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 550);
            this.Controls.Add(this.TabContainer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainBaseInterfaceForm";
            this.Text = "MainBaseInterfaceForm";
            this.Load += new System.EventHandler(this.MainBaseInterfaceForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TabContainer.ResumeLayout(false);
            this.MainViewTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainViewGrid)).EndInit();
            this.EventViewTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EventViewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem базаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddingMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem фильтрToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem EventAddMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem RemindAddMenuStrip;
        private System.Windows.Forms.TabControl TabContainer;
        private System.Windows.Forms.TabPage MainViewTab;
        private System.Windows.Forms.DataGridView MainViewGrid;
        private System.Windows.Forms.TabPage EventViewTab;
        private System.Windows.Forms.DataGridView EventViewGrid;
        private System.Windows.Forms.TabPage ReminderViewTab;
    }
}