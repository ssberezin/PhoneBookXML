
namespace PhoneBook
{
    partial class PersonalDataEditForm
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
            System.Windows.Forms.Label birthYearLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label patronimicLabel;
            System.Windows.Forms.Label sexLabel;
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.summaryListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.patronimicTextBox = new System.Windows.Forms.TextBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.birthYearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            birthYearLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            patronimicLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.summaryListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthYearNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // birthYearLabel
            // 
            birthYearLabel.AutoSize = true;
            birthYearLabel.Location = new System.Drawing.Point(6, 96);
            birthYearLabel.Name = "birthYearLabel";
            birthYearLabel.Size = new System.Drawing.Size(101, 17);
            birthYearLabel.TabIndex = 1;
            birthYearLabel.Text = "Год рождения";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(6, 40);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(35, 17);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "Имя";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(6, 12);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(70, 17);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Фамилия";
            // 
            // patronimicLabel
            // 
            patronimicLabel.AutoSize = true;
            patronimicLabel.Location = new System.Drawing.Point(6, 68);
            patronimicLabel.Name = "patronimicLabel";
            patronimicLabel.Size = new System.Drawing.Size(71, 17);
            patronimicLabel.TabIndex = 7;
            patronimicLabel.Text = "Отчество";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(6, 126);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(34, 17);
            sexLabel.TabIndex = 9;
            sexLabel.Text = "Пол";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.summaryListBindingSource, "Pers.FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(115, 37);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(203, 22);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // summaryListBindingSource
            // 
            this.summaryListBindingSource.DataSource = typeof(PhoneBook.Model.CommonClass);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.summaryListBindingSource, "Pers.LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(115, 9);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(203, 22);
            this.lastNameTextBox.TabIndex = 0;
            // 
            // patronimicTextBox
            // 
            this.patronimicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.summaryListBindingSource, "Pers.Patronimic", true));
            this.patronimicTextBox.Location = new System.Drawing.Point(115, 65);
            this.patronimicTextBox.Name = "patronimicTextBox";
            this.patronimicTextBox.Size = new System.Drawing.Size(203, 22);
            this.patronimicTextBox.TabIndex = 2;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(127, 126);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(86, 21);
            this.radioButtonMale.TabIndex = 4;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Мужской";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(219, 128);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(88, 21);
            this.radioButtonFemale.TabIndex = 5;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Женский";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(4, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(184, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 26);
            this.button2.TabIndex = 7;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // birthYearNumericUpDown
            // 
            this.birthYearNumericUpDown.Location = new System.Drawing.Point(115, 94);
            this.birthYearNumericUpDown.Maximum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.birthYearNumericUpDown.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.birthYearNumericUpDown.Name = "birthYearNumericUpDown";
            this.birthYearNumericUpDown.Size = new System.Drawing.Size(75, 22);
            this.birthYearNumericUpDown.TabIndex = 3;
            this.birthYearNumericUpDown.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // PersonalDataEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 189);
            this.Controls.Add(this.birthYearNumericUpDown);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(birthYearLabel);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(patronimicLabel);
            this.Controls.Add(this.patronimicTextBox);
            this.Controls.Add(sexLabel);
            this.Name = "PersonalDataEditForm";
            this.Text = "Персональные данные";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonalDataEditForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.summaryListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthYearNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource summaryListBindingSource;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox patronimicTextBox;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown birthYearNumericUpDown;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}