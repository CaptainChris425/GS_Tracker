namespace GameStat_Tracker
{
    partial class GameStatTracker
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
            this.UsernameEnter_textbox = new System.Windows.Forms.TextBox();
            this.AddGame_button = new System.Windows.Forms.Button();
            this.Username_textbox = new System.Windows.Forms.TextBox();
            this.Platform_textbox = new System.Windows.Forms.TextBox();
            this.GamesAvaliableListBox = new System.Windows.Forms.ListBox();
            this.GamesAddedTextBox = new System.Windows.Forms.TextBox();
            this.GamesAvaliableTextbox = new System.Windows.Forms.TextBox();
            this.PlatformListBox = new System.Windows.Forms.ListBox();
            this.GamesToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.GamesAddedDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GamesAddedDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameEnter_textbox
            // 
            this.UsernameEnter_textbox.Location = new System.Drawing.Point(12, 41);
            this.UsernameEnter_textbox.Name = "UsernameEnter_textbox";
            this.UsernameEnter_textbox.Size = new System.Drawing.Size(120, 20);
            this.UsernameEnter_textbox.TabIndex = 0;
            this.UsernameEnter_textbox.TextChanged += new System.EventHandler(this.UsernameEnter_textbox_TextChanged);
            // 
            // AddGame_button
            // 
            this.AddGame_button.Location = new System.Drawing.Point(11, 216);
            this.AddGame_button.Name = "AddGame_button";
            this.AddGame_button.Size = new System.Drawing.Size(121, 23);
            this.AddGame_button.TabIndex = 1;
            this.AddGame_button.Text = "Add Game";
            this.AddGame_button.UseVisualStyleBackColor = true;
            this.AddGame_button.Click += new System.EventHandler(this.AddGame_button_click);
            // 
            // Username_textbox
            // 
            this.Username_textbox.BackColor = System.Drawing.SystemColors.Control;
            this.Username_textbox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Username_textbox.Location = new System.Drawing.Point(12, 15);
            this.Username_textbox.Name = "Username_textbox";
            this.Username_textbox.ReadOnly = true;
            this.Username_textbox.Size = new System.Drawing.Size(120, 20);
            this.Username_textbox.TabIndex = 2;
            this.Username_textbox.Text = "Username";
            // 
            // Platform_textbox
            // 
            this.Platform_textbox.BackColor = System.Drawing.SystemColors.Control;
            this.Platform_textbox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Platform_textbox.Location = new System.Drawing.Point(12, 67);
            this.Platform_textbox.Name = "Platform_textbox";
            this.Platform_textbox.ReadOnly = true;
            this.Platform_textbox.Size = new System.Drawing.Size(120, 20);
            this.Platform_textbox.TabIndex = 3;
            this.Platform_textbox.Text = "Platform";
            // 
            // GamesAvaliableListBox
            // 
            this.GamesAvaliableListBox.FormattingEnabled = true;
            this.GamesAvaliableListBox.Location = new System.Drawing.Point(12, 167);
            this.GamesAvaliableListBox.Name = "GamesAvaliableListBox";
            this.GamesAvaliableListBox.Size = new System.Drawing.Size(120, 43);
            this.GamesAvaliableListBox.TabIndex = 5;
            this.GamesAvaliableListBox.SelectedIndexChanged += new System.EventHandler(this.GamesAvaliableListBox_SelectedIndexChanged);
            this.GamesAvaliableListBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GamesAvaliableListBox_MouseMove);
            // 
            // GamesAddedTextBox
            // 
            this.GamesAddedTextBox.AcceptsReturn = true;
            this.GamesAddedTextBox.AcceptsTab = true;
            this.GamesAddedTextBox.Location = new System.Drawing.Point(258, 19);
            this.GamesAddedTextBox.Multiline = true;
            this.GamesAddedTextBox.Name = "GamesAddedTextBox";
            this.GamesAddedTextBox.ReadOnly = true;
            this.GamesAddedTextBox.Size = new System.Drawing.Size(161, 220);
            this.GamesAddedTextBox.TabIndex = 6;
            // 
            // GamesAvaliableTextbox
            // 
            this.GamesAvaliableTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.GamesAvaliableTextbox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.GamesAvaliableTextbox.Location = new System.Drawing.Point(12, 141);
            this.GamesAvaliableTextbox.Name = "GamesAvaliableTextbox";
            this.GamesAvaliableTextbox.ReadOnly = true;
            this.GamesAvaliableTextbox.Size = new System.Drawing.Size(120, 20);
            this.GamesAvaliableTextbox.TabIndex = 7;
            this.GamesAvaliableTextbox.Text = "Games Avaliable";
            // 
            // PlatformListBox
            // 
            this.PlatformListBox.FormattingEnabled = true;
            this.PlatformListBox.Location = new System.Drawing.Point(12, 92);
            this.PlatformListBox.Name = "PlatformListBox";
            this.PlatformListBox.Size = new System.Drawing.Size(120, 43);
            this.PlatformListBox.TabIndex = 8;
            // 
            // GamesAddedDataGrid
            // 
            this.GamesAddedDataGrid.AllowUserToAddRows = false;
            this.GamesAddedDataGrid.AllowUserToDeleteRows = false;
            this.GamesAddedDataGrid.AllowUserToOrderColumns = true;
            this.GamesAddedDataGrid.AllowUserToResizeColumns = false;
            this.GamesAddedDataGrid.AllowUserToResizeRows = false;
            this.GamesAddedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GamesAddedDataGrid.Location = new System.Drawing.Point(12, 260);
            this.GamesAddedDataGrid.Name = "GamesAddedDataGrid";
            this.GamesAddedDataGrid.Size = new System.Drawing.Size(406, 103);
            this.GamesAddedDataGrid.TabIndex = 9;
            // 
            // GameStatTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 376);
            this.Controls.Add(this.GamesAddedDataGrid);
            this.Controls.Add(this.PlatformListBox);
            this.Controls.Add(this.GamesAvaliableTextbox);
            this.Controls.Add(this.GamesAddedTextBox);
            this.Controls.Add(this.GamesAvaliableListBox);
            this.Controls.Add(this.Platform_textbox);
            this.Controls.Add(this.Username_textbox);
            this.Controls.Add(this.AddGame_button);
            this.Controls.Add(this.UsernameEnter_textbox);
            this.Name = "GameStatTracker";
            this.Text = "Game Stat Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.GameStatTracker_Click);
            ((System.ComponentModel.ISupportInitialize)(this.GamesAddedDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameEnter_textbox;
        private System.Windows.Forms.Button AddGame_button;
        private System.Windows.Forms.TextBox Username_textbox;
        private System.Windows.Forms.TextBox Platform_textbox;
        private System.Windows.Forms.ListBox GamesAvaliableListBox;
        private System.Windows.Forms.TextBox GamesAddedTextBox;
        private System.Windows.Forms.TextBox GamesAvaliableTextbox;
        private System.Windows.Forms.ListBox PlatformListBox;
        private System.Windows.Forms.ToolTip GamesToolTip;
        private System.Windows.Forms.DataGridView GamesAddedDataGrid;
    }
}

