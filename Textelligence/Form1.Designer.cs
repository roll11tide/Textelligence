namespace Textelligence
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fieldlabel2 = new System.Windows.Forms.Label();
            this.fieldlabel1 = new System.Windows.Forms.Label();
            this.field1 = new System.Windows.Forms.TextBox();
            this.field2 = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.keyField = new System.Windows.Forms.TextBox();
            this.showPassword = new System.Windows.Forms.Button();
            this.footnote = new System.Windows.Forms.Label();
            this.switchFieldsButton = new System.Windows.Forms.Button();
            this.clearFields = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplashTimer
            // 
            this.SplashTimer.Interval = 2000;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.fieldlabel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fieldlabel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(877, 41);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // fieldlabel2
            // 
            this.fieldlabel2.BackColor = System.Drawing.Color.Transparent;
            this.fieldlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldlabel2.Location = new System.Drawing.Point(441, 0);
            this.fieldlabel2.Name = "fieldlabel2";
            this.fieldlabel2.Size = new System.Drawing.Size(432, 41);
            this.fieldlabel2.TabIndex = 4;
            this.fieldlabel2.Text = "Decrypted";
            this.fieldlabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fieldlabel1
            // 
            this.fieldlabel1.BackColor = System.Drawing.Color.Transparent;
            this.fieldlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldlabel1.Location = new System.Drawing.Point(3, 0);
            this.fieldlabel1.Name = "fieldlabel1";
            this.fieldlabel1.Size = new System.Drawing.Size(432, 41);
            this.fieldlabel1.TabIndex = 3;
            this.fieldlabel1.Text = "Encrypted";
            this.fieldlabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // field1
            // 
            this.field1.Location = new System.Drawing.Point(12, 72);
            this.field1.Multiline = true;
            this.field1.Name = "field1";
            this.field1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.field1.Size = new System.Drawing.Size(423, 321);
            this.field1.TabIndex = 0;
            // 
            // field2
            // 
            this.field2.Location = new System.Drawing.Point(442, 72);
            this.field2.Multiline = true;
            this.field2.Name = "field2";
            this.field2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.field2.Size = new System.Drawing.Size(423, 321);
            this.field2.TabIndex = 1;
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(12, 428);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(853, 53);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Key";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keyField
            // 
            this.keyField.Location = new System.Drawing.Point(101, 399);
            this.keyField.Multiline = true;
            this.keyField.Name = "keyField";
            this.keyField.PasswordChar = '*';
            this.keyField.Size = new System.Drawing.Size(264, 23);
            this.keyField.TabIndex = 2;
            this.keyField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // showPassword
            // 
            this.showPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassword.Location = new System.Drawing.Point(371, 399);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(24, 23);
            this.showPassword.TabIndex = 9;
            this.showPassword.Text = "~";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPassword_MouseDown);
            this.showPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.showPassword_MouseUp);
            // 
            // footnote
            // 
            this.footnote.Location = new System.Drawing.Point(442, 399);
            this.footnote.Name = "footnote";
            this.footnote.Size = new System.Drawing.Size(423, 23);
            this.footnote.TabIndex = 10;
            this.footnote.Text = "© JLWTechnologies - Written by Jesse Wells";
            this.footnote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // switchFieldsButton
            // 
            this.switchFieldsButton.Location = new System.Drawing.Point(401, 399);
            this.switchFieldsButton.Name = "switchFieldsButton";
            this.switchFieldsButton.Size = new System.Drawing.Size(75, 23);
            this.switchFieldsButton.TabIndex = 11;
            this.switchFieldsButton.Text = "<---->";
            this.switchFieldsButton.UseVisualStyleBackColor = true;
            this.switchFieldsButton.Click += new System.EventHandler(this.switchFieldsButton_Click);
            // 
            // clearFields
            // 
            this.clearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearFields.Location = new System.Drawing.Point(482, 399);
            this.clearFields.Name = "clearFields";
            this.clearFields.Size = new System.Drawing.Size(24, 23);
            this.clearFields.TabIndex = 12;
            this.clearFields.Text = "C";
            this.clearFields.UseVisualStyleBackColor = true;
            this.clearFields.Click += new System.EventHandler(this.clearFields_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyOutputToolStripMenuItem,
            this.legendToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // copyOutputToolStripMenuItem
            // 
            this.copyOutputToolStripMenuItem.Name = "copyOutputToolStripMenuItem";
            this.copyOutputToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.copyOutputToolStripMenuItem.Text = "Copy Output";
            this.copyOutputToolStripMenuItem.Click += new System.EventHandler(this.copyOutputToolStripMenuItem_Click);
            // 
            // legendToolStripMenuItem
            // 
            this.legendToolStripMenuItem.Name = "legendToolStripMenuItem";
            this.legendToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.legendToolStripMenuItem.Text = "Legend";
            this.legendToolStripMenuItem.Click += new System.EventHandler(this.legendToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 493);
            this.Controls.Add(this.clearFields);
            this.Controls.Add(this.switchFieldsButton);
            this.Controls.Add(this.footnote);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.keyField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.field2);
            this.Controls.Add(this.field1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Textelligence";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label fieldlabel2;
        private System.Windows.Forms.Label fieldlabel1;
        private System.Windows.Forms.TextBox field1;
        private System.Windows.Forms.TextBox field2;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyField;
        private System.Windows.Forms.Button showPassword;
        private System.Windows.Forms.Label footnote;
        private System.Windows.Forms.Button switchFieldsButton;
        private System.Windows.Forms.Button clearFields;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

