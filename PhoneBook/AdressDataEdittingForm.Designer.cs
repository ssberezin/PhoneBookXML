
namespace PhoneBook
{
    partial class AdressDataEdittingForm
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
            System.Windows.Forms.Label appNumberLabel;
            System.Windows.Forms.Label houseNumberLabel;
            System.Windows.Forms.Label streetLabel;
            this.houseNumberTextBox = new System.Windows.Forms.TextBox();
            this.summaryListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CencelBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.appNumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            appNumberLabel = new System.Windows.Forms.Label();
            houseNumberLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.summaryListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appNumNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // appNumberLabel
            // 
            appNumberLabel.AutoSize = true;
            appNumberLabel.Location = new System.Drawing.Point(11, 65);
            appNumberLabel.Name = "appNumberLabel";
            appNumberLabel.Size = new System.Drawing.Size(89, 17);
            appNumberLabel.TabIndex = 1;
            appNumberLabel.Text = "№ квартиры";
            // 
            // houseNumberLabel
            // 
            houseNumberLabel.AutoSize = true;
            houseNumberLabel.Location = new System.Drawing.Point(11, 37);
            houseNumberLabel.Name = "houseNumberLabel";
            houseNumberLabel.Size = new System.Drawing.Size(59, 17);
            houseNumberLabel.TabIndex = 3;
            houseNumberLabel.Text = "№ дома";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(11, 9);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(49, 17);
            streetLabel.TabIndex = 5;
            streetLabel.Text = "Улица";
            // 
            // houseNumberTextBox
            // 
            this.houseNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.summaryListBindingSource, "Adr.HouseNumber", true));
            this.houseNumberTextBox.Location = new System.Drawing.Point(124, 34);
            this.houseNumberTextBox.Name = "houseNumberTextBox";
            this.houseNumberTextBox.Size = new System.Drawing.Size(274, 22);
            this.houseNumberTextBox.TabIndex = 1;
            // 
            // summaryListBindingSource
            // 
            this.summaryListBindingSource.DataSource = typeof(PhoneBook.Model.CommonClass);
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.summaryListBindingSource, "Adr.Street", true));
            this.streetTextBox.Location = new System.Drawing.Point(124, 6);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(274, 22);
            this.streetTextBox.TabIndex = 0;
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(12, 100);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(177, 23);
            this.OkBtn.TabIndex = 3;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CencelBtn
            // 
            this.CencelBtn.Location = new System.Drawing.Point(223, 100);
            this.CencelBtn.Name = "CencelBtn";
            this.CencelBtn.Size = new System.Drawing.Size(175, 23);
            this.CencelBtn.TabIndex = 4;
            this.CencelBtn.Text = "Отмена";
            this.CencelBtn.UseVisualStyleBackColor = true;
            this.CencelBtn.Click += new System.EventHandler(this.CencelBtn_Click);
            // 
            // appNumNumericUpDown
            // 
            this.appNumNumericUpDown.Location = new System.Drawing.Point(124, 63);
            this.appNumNumericUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.appNumNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.appNumNumericUpDown.Name = "appNumNumericUpDown";
            this.appNumNumericUpDown.Size = new System.Drawing.Size(75, 22);
            this.appNumNumericUpDown.TabIndex = 2;
            this.appNumNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AdressDataEdittingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 134);
            this.Controls.Add(this.appNumNumericUpDown);
            this.Controls.Add(this.CencelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(appNumberLabel);
            this.Controls.Add(houseNumberLabel);
            this.Controls.Add(this.houseNumberTextBox);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Name = "AdressDataEdittingForm";
            this.Text = "Редактирование адресных данных";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdressDataEdittingForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.summaryListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appNumNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource summaryListBindingSource;
        private System.Windows.Forms.TextBox houseNumberTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CencelBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown appNumNumericUpDown;
    }
}