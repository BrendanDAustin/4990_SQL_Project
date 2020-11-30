namespace _4990ExampleApp
//amespace _4990ExampleApp
//amespace _4990ExampleApp
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
            this.signIn = new System.Windows.Forms.Button();
            this.signInPanel = new System.Windows.Forms.Panel();
            this.techniqueSelectionGroup = new System.Windows.Forms.GroupBox();
            this.storedProcedure = new System.Windows.Forms.RadioButton();
            this.inputValidation = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.appPanel = new System.Windows.Forms.Panel();
            this.returnHomeButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.userInfoGrid = new System.Windows.Forms.DataGridView();
            this.newAccountPanel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.newSsn = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.newLastName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.newFirstName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.returnToMainFromNewAccount = new System.Windows.Forms.Button();
            this.newAccountPasswordConfirm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.createAccount = new System.Windows.Forms.Button();
            this.newAccountPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newAccountName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.noValidationCheckbox = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.queryDisplayLabel = new System.Windows.Forms.Label();
            this.showQuery = new System.Windows.Forms.CheckBox();
            this.signInPanel.SuspendLayout();
            this.techniqueSelectionGroup.SuspendLayout();
            this.appPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoGrid)).BeginInit();
            this.newAccountPanel.SuspendLayout();
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
            // signIn
            // 
            this.signIn.Location = new System.Drawing.Point(264, 233);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(75, 23);
            this.signIn.TabIndex = 5;
            this.signIn.Text = "Sign In";
            this.signIn.UseVisualStyleBackColor = true;
            this.signIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // signInPanel
            // 
            this.signInPanel.Controls.Add(this.showQuery);
            this.signInPanel.Controls.Add(this.queryDisplayLabel);
            this.signInPanel.Controls.Add(this.label14);
            this.signInPanel.Controls.Add(this.techniqueSelectionGroup);
            this.signInPanel.Controls.Add(this.label9);
            this.signInPanel.Controls.Add(this.button3);
            this.signInPanel.Controls.Add(this.signIn);
            this.signInPanel.Controls.Add(this.passwordTextBox);
            this.signInPanel.Controls.Add(this.label3);
            this.signInPanel.Controls.Add(this.userNameTextBox);
            this.signInPanel.Controls.Add(this.label2);
            this.signInPanel.Controls.Add(this.label1);
            this.signInPanel.Location = new System.Drawing.Point(45, 41);
            this.signInPanel.Name = "signInPanel";
            this.signInPanel.Size = new System.Drawing.Size(573, 503);
            this.signInPanel.TabIndex = 2;
            this.signInPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.signInPanel_Paint);
            // 
            // techniqueSelectionGroup
            // 
            this.techniqueSelectionGroup.Controls.Add(this.noValidationCheckbox);
            this.techniqueSelectionGroup.Controls.Add(this.storedProcedure);
            this.techniqueSelectionGroup.Controls.Add(this.inputValidation);
            this.techniqueSelectionGroup.Location = new System.Drawing.Point(370, 27);
            this.techniqueSelectionGroup.Name = "techniqueSelectionGroup";
            this.techniqueSelectionGroup.Size = new System.Drawing.Size(171, 99);
            this.techniqueSelectionGroup.TabIndex = 9;
            this.techniqueSelectionGroup.TabStop = false;
            this.techniqueSelectionGroup.Text = "Secure Programming Technique";
            this.techniqueSelectionGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // storedProcedure
            // 
            this.storedProcedure.AutoSize = true;
            this.storedProcedure.Location = new System.Drawing.Point(0, 76);
            this.storedProcedure.Name = "storedProcedure";
            this.storedProcedure.Size = new System.Drawing.Size(162, 17);
            this.storedProcedure.TabIndex = 7;
            this.storedProcedure.Text = "DB Driver Stored Procedures";
            this.storedProcedure.UseVisualStyleBackColor = true;
            this.storedProcedure.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // inputValidation
            // 
            this.inputValidation.AutoSize = true;
            this.inputValidation.Location = new System.Drawing.Point(0, 53);
            this.inputValidation.Name = "inputValidation";
            this.inputValidation.Size = new System.Drawing.Size(98, 17);
            this.inputValidation.TabIndex = 6;
            this.inputValidation.Text = "Input Validation";
            this.inputValidation.UseVisualStyleBackColor = true;
            this.inputValidation.CheckedChanged += new System.EventHandler(this.goodOrBad_CheckedChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "New User? - ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(264, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Create New Account";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // appPanel
            // 
            this.appPanel.Controls.Add(this.returnHomeButton);
            this.appPanel.Controls.Add(this.label6);
            this.appPanel.Controls.Add(this.userInfoGrid);
            this.appPanel.Location = new System.Drawing.Point(669, 41);
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
            // newAccountPanel
            // 
            this.newAccountPanel.Controls.Add(this.label13);
            this.newAccountPanel.Controls.Add(this.newSsn);
            this.newAccountPanel.Controls.Add(this.label10);
            this.newAccountPanel.Controls.Add(this.newLastName);
            this.newAccountPanel.Controls.Add(this.label11);
            this.newAccountPanel.Controls.Add(this.newFirstName);
            this.newAccountPanel.Controls.Add(this.label12);
            this.newAccountPanel.Controls.Add(this.returnToMainFromNewAccount);
            this.newAccountPanel.Controls.Add(this.newAccountPasswordConfirm);
            this.newAccountPanel.Controls.Add(this.label8);
            this.newAccountPanel.Controls.Add(this.createAccount);
            this.newAccountPanel.Controls.Add(this.newAccountPassword);
            this.newAccountPanel.Controls.Add(this.label4);
            this.newAccountPanel.Controls.Add(this.newAccountName);
            this.newAccountPanel.Controls.Add(this.label5);
            this.newAccountPanel.Controls.Add(this.label7);
            this.newAccountPanel.Location = new System.Drawing.Point(1315, 41);
            this.newAccountPanel.Name = "newAccountPanel";
            this.newAccountPanel.Size = new System.Drawing.Size(573, 503);
            this.newAccountPanel.TabIndex = 4;
            this.newAccountPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.newAccountPanel_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(331, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(211, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "<- Seriously. Don\'t put your actual ssn here.";
            // 
            // newSsn
            // 
            this.newSsn.Location = new System.Drawing.Point(225, 173);
            this.newSsn.Mask = "000-00-0000";
            this.newSsn.Name = "newSsn";
            this.newSsn.Size = new System.Drawing.Size(100, 20);
            this.newSsn.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "(FAKE) Social Security Number:";
            // 
            // newLastName
            // 
            this.newLastName.Location = new System.Drawing.Point(225, 139);
            this.newLastName.Name = "newLastName";
            this.newLastName.Size = new System.Drawing.Size(100, 20);
            this.newLastName.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(117, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Last Name";
            // 
            // newFirstName
            // 
            this.newFirstName.Location = new System.Drawing.Point(225, 106);
            this.newFirstName.Name = "newFirstName";
            this.newFirstName.Size = new System.Drawing.Size(100, 20);
            this.newFirstName.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(117, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "First Name";
            // 
            // returnToMainFromNewAccount
            // 
            this.returnToMainFromNewAccount.Location = new System.Drawing.Point(424, 312);
            this.returnToMainFromNewAccount.Name = "returnToMainFromNewAccount";
            this.returnToMainFromNewAccount.Size = new System.Drawing.Size(75, 23);
            this.returnToMainFromNewAccount.TabIndex = 25;
            this.returnToMainFromNewAccount.Text = "Main Page";
            this.returnToMainFromNewAccount.UseVisualStyleBackColor = true;
            this.returnToMainFromNewAccount.Click += new System.EventHandler(this.returnToMainFromNewAccount_Click_1);
            // 
            // newAccountPasswordConfirm
            // 
            this.newAccountPasswordConfirm.Location = new System.Drawing.Point(225, 266);
            this.newAccountPasswordConfirm.Name = "newAccountPasswordConfirm";
            this.newAccountPasswordConfirm.Size = new System.Drawing.Size(100, 20);
            this.newAccountPasswordConfirm.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Confirm Password:";
            // 
            // createAccount
            // 
            this.createAccount.Location = new System.Drawing.Point(250, 312);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(75, 23);
            this.createAccount.TabIndex = 22;
            this.createAccount.Text = "Create!";
            this.createAccount.UseVisualStyleBackColor = true;
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // newAccountPassword
            // 
            this.newAccountPassword.Location = new System.Drawing.Point(225, 232);
            this.newAccountPassword.Name = "newAccountPassword";
            this.newAccountPassword.Size = new System.Drawing.Size(100, 20);
            this.newAccountPassword.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Password:";
            // 
            // newAccountName
            // 
            this.newAccountName.Location = new System.Drawing.Point(225, 199);
            this.newAccountName.Name = "newAccountName";
            this.newAccountName.Size = new System.Drawing.Size(100, 20);
            this.newAccountName.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "User Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(184, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Create New Account";
            // 
            // noValidationCheckbox
            // 
            this.noValidationCheckbox.AutoSize = true;
            this.noValidationCheckbox.Checked = true;
            this.noValidationCheckbox.Location = new System.Drawing.Point(0, 33);
            this.noValidationCheckbox.Name = "noValidationCheckbox";
            this.noValidationCheckbox.Size = new System.Drawing.Size(51, 17);
            this.noValidationCheckbox.TabIndex = 8;
            this.noValidationCheckbox.TabStop = true;
            this.noValidationCheckbox.Text = "None";
            this.noValidationCheckbox.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 438);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Constructed Query:";
            // 
            // queryDisplayLabel
            // 
            this.queryDisplayLabel.AutoSize = true;
            this.queryDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryDisplayLabel.Location = new System.Drawing.Point(3, 461);
            this.queryDisplayLabel.Name = "queryDisplayLabel";
            this.queryDisplayLabel.Size = new System.Drawing.Size(0, 13);
            this.queryDisplayLabel.TabIndex = 12;
            // 
            // showQuery
            // 
            this.showQuery.AutoSize = true;
            this.showQuery.Location = new System.Drawing.Point(6, 418);
            this.showQuery.Name = "showQuery";
            this.showQuery.Size = new System.Drawing.Size(187, 17);
            this.showQuery.TabIndex = 13;
            this.showQuery.Text = "Show Constructed SQL Command";
            this.showQuery.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1989, 576);
            this.Controls.Add(this.newAccountPanel);
            this.Controls.Add(this.appPanel);
            this.Controls.Add(this.signInPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.signInPanel.ResumeLayout(false);
            this.signInPanel.PerformLayout();
            this.techniqueSelectionGroup.ResumeLayout(false);
            this.techniqueSelectionGroup.PerformLayout();
            this.appPanel.ResumeLayout(false);
            this.appPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoGrid)).EndInit();
            this.newAccountPanel.ResumeLayout(false);
            this.newAccountPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button signIn;
        private System.Windows.Forms.Panel signInPanel;
        private System.Windows.Forms.Panel appPanel;
        private System.Windows.Forms.Button returnHomeButton;
        private System.Windows.Forms.DataGridView userInfoGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton inputValidation;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Panel newAccountPanel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox newSsn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox newLastName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox newFirstName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button returnToMainFromNewAccount;
        private System.Windows.Forms.TextBox newAccountPasswordConfirm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button createAccount;
        private System.Windows.Forms.TextBox newAccountPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newAccountName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox techniqueSelectionGroup;
        private System.Windows.Forms.RadioButton storedProcedure;
        private System.Windows.Forms.RadioButton noValidationCheckbox;
        private System.Windows.Forms.Label queryDisplayLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox showQuery;
    }
}

