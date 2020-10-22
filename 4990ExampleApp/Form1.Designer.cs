namespace _4990ExampleApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.signInPanel = new System.Windows.Forms.Panel();
            this.appPanel = new System.Windows.Forms.Panel();
            this.returnHomeButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.userInfoGrid = new System.Windows.Forms.DataGridView();
            this.goodOrBad = new System.Windows.Forms.RadioButton();
            this.signInPanel.SuspendLayout();
            this.appPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign In";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(228, 121);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.userNameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(228, 154);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // signInPanel
            // 
            this.signInPanel.Controls.Add(this.goodOrBad);
            this.signInPanel.Controls.Add(this.button1);
            this.signInPanel.Controls.Add(this.passwordTextBox);
            this.signInPanel.Controls.Add(this.label3);
            this.signInPanel.Controls.Add(this.userNameTextBox);
            this.signInPanel.Controls.Add(this.label2);
            this.signInPanel.Controls.Add(this.label1);
            this.signInPanel.Location = new System.Drawing.Point(34, 12);
            this.signInPanel.Name = "signInPanel";
            this.signInPanel.Size = new System.Drawing.Size(573, 503);
            this.signInPanel.TabIndex = 2;
            this.signInPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.signInPanel_Paint);
            // 
            // appPanel
            // 
            this.appPanel.Controls.Add(this.returnHomeButton);
            this.appPanel.Controls.Add(this.label6);
            this.appPanel.Controls.Add(this.userInfoGrid);
            this.appPanel.Location = new System.Drawing.Point(37, 12);
            this.appPanel.Name = "appPanel";
            this.appPanel.Size = new System.Drawing.Size(573, 508);
            this.appPanel.TabIndex = 3;
            // 
            // returnHomeButton
            // 
            this.returnHomeButton.Location = new System.Drawing.Point(478, 438);
            this.returnHomeButton.Name = "returnHomeButton";
            this.returnHomeButton.Size = new System.Drawing.Size(75, 23);
            this.returnHomeButton.TabIndex = 2;
            this.returnHomeButton.Text = "Go Home";
            this.returnHomeButton.UseVisualStyleBackColor = true;
            this.returnHomeButton.Click += new System.EventHandler(this.returnHomeButton_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "My Items";
            // 
            // userInfoGrid
            // 
            this.userInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userInfoGrid.Location = new System.Drawing.Point(48, 84);
            this.userInfoGrid.Name = "userInfoGrid";
            this.userInfoGrid.Size = new System.Drawing.Size(505, 291);
            this.userInfoGrid.TabIndex = 1;
            // 
            // goodOrBad
            // 
            this.goodOrBad.AutoSize = true;
            this.goodOrBad.Location = new System.Drawing.Point(398, 48);
            this.goodOrBad.Name = "goodOrBad";
            this.goodOrBad.Size = new System.Drawing.Size(98, 17);
            this.goodOrBad.TabIndex = 6;
            this.goodOrBad.Text = "Input Validation";
            this.goodOrBad.UseVisualStyleBackColor = true;
            this.goodOrBad.CheckedChanged += new System.EventHandler(this.goodOrBad_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 566);
            this.Controls.Add(this.appPanel);
            this.Controls.Add(this.signInPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.signInPanel.ResumeLayout(false);
            this.signInPanel.PerformLayout();
            this.appPanel.ResumeLayout(false);
            this.appPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel signInPanel;
        private System.Windows.Forms.Panel appPanel;
        private System.Windows.Forms.Button returnHomeButton;
        private System.Windows.Forms.DataGridView userInfoGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton goodOrBad;
    }
}

