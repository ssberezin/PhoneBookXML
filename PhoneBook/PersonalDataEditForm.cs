using PhoneBook.Helps;
using PhoneBook.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class PersonalDataEditForm : Form
    {
        CommonClass NewRecord { get; set; }
        CommonClass SelectedRecord { get; set; }       
        Person PrevNewPerson { get; set; }
        Person PrevSelectPers { get; set; }


        Library lib = new Library();

        //flag for understand is it saved or not
        bool Saved { get; set; }

        public PersonalDataEditForm()
        {            
            InitializeComponent();
        }

        public PersonalDataEditForm(CommonClass newRecord,CommonClass rec)
        {
            NewRecord = newRecord;
            SelectedRecord = rec;
            PrevNewPerson = NewRecord is null ? null : (Person)NewRecord.Pers.Clone();
            PrevSelectPers = SelectedRecord is null ? null : (Person)SelectedRecord.Pers.Clone();

            InitializeComponent();
            if (NewRecord is null)
                DefaultDataLoad(SelectedRecord.Pers);
            else
                DefaultDataLoad(NewRecord.Pers);
        }

        //set default values to forms controls
        private void DefaultDataLoad(Person pers)
        {
            toolTip1.SetToolTip(button2,"Возврат к предыдущему сохраненному состоянию");
            birthYearNumericUpDown.Maximum = DateTime.Now.AddYears(-16).Year;

            lastNameTextBox.Text = pers.LastName;
            firstNameTextBox.Text = pers.FirstName;
            patronimicTextBox.Text = pers.Patronimic;
            birthYearNumericUpDown.Value = pers.BirthYear;
            radioButtonMale.Checked = pers.Sex;
            radioButtonFemale.Checked = !pers.Sex;


        }
        //save process
        private void button1_Click(object sender, EventArgs e)
        {
            if (!lib.CheckValidationPersonalData(firstNameTextBox.Text, lastNameTextBox.Text, patronimicTextBox.Text))
                return;
            SaveChanges();
            Saved = true;
            this.Close();
        }


     
        private void SaveChanges()
        {
            if (SelectedRecord is null)
            {
                //add new data mode
                lib.CopyNewdataToRecord(NewRecord, firstNameTextBox.Text, lastNameTextBox.Text,
                                    patronimicTextBox.Text, (int)birthYearNumericUpDown.Value, radioButtonMale.Checked);
                PrevNewPerson =  (Person)NewRecord.Pers.Clone();
                return;
            }
            //edit mode
            lib.CopyNewdataToRecord(SelectedRecord, firstNameTextBox.Text, lastNameTextBox.Text,
                                    patronimicTextBox.Text, (int)birthYearNumericUpDown.Value, radioButtonMale.Checked);
            PrevSelectPers =(Person)SelectedRecord.Pers.Clone();            
        }

        private void PersonalDataEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Saved)//straight way from SaveChanges and from cancel btn
            {
                e.Cancel = false;
                return;
            }

            //if previous state is the same as current than close the form
            if (!(NewRecord is null))
            {
                lib.CopyNewdataToRecord(NewRecord, firstNameTextBox.Text, lastNameTextBox.Text,
                                    patronimicTextBox.Text, (int)birthYearNumericUpDown.Value, radioButtonMale.Checked);
                if (NewRecord.Pers == PrevNewPerson)
                {
                    e.Cancel = false;
                    return;
                }
               else
                {
                    if (MessageBox.Show("Не были сохранены внесенные изменения. \nСохранить?.\n"
                        , "Сделать выбор", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (!lib.CheckValidationPersonalData(firstNameTextBox.Text, lastNameTextBox.Text, patronimicTextBox.Text))
                        {
                            e.Cancel = true;
                            return;
                        }
                        SaveChanges();
                        e.Cancel = false;
                        return;
                    }
                    else
                        e.Cancel = false;
                }
            }
            else            
            {
                lib.CopyNewdataToRecord(SelectedRecord, firstNameTextBox.Text, lastNameTextBox.Text,
                                   patronimicTextBox.Text, (int)birthYearNumericUpDown.Value, radioButtonMale.Checked);
                if (SelectedRecord.Pers == PrevSelectPers)
                {
                    e.Cancel = false;
                    return;
                }
               else
                {
                    if (MessageBox.Show("Не были сохранены внесенные изменения. \nСохранить?.\n"
                        , "Сделать выбор", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (!lib.CheckValidationPersonalData(firstNameTextBox.Text, lastNameTextBox.Text, patronimicTextBox.Text))
                        {
                            e.Cancel = true;
                            return;
                        }
                        SaveChanges();
                        e.Cancel = false;
                        return;
                    }
                    else
                    {
                        e.Cancel = false;
                        return;
                    }
                }
            }
        }
        //cencel btn
        //if the user pressed the cancel button, it means that all changes will revert to the last state before saving
        private void button2_Click(object sender, EventArgs e)
        {
            if (NewRecord is null)
            {
                lib.CopyNewdataToRecord(SelectedRecord, PrevSelectPers.FirstName, PrevSelectPers.LastName,
                                  PrevSelectPers.Patronimic, (int)birthYearNumericUpDown.Value, PrevSelectPers.Sex);
                Saved = true;                
            }
            else
            {
                lib.CopyNewdataToRecord(NewRecord, PrevNewPerson.FirstName, PrevNewPerson.LastName,
                               PrevNewPerson.Patronimic, (int)birthYearNumericUpDown.Value, PrevNewPerson.Sex);
                Saved = true;                
            } 
            this.Close();
        }
    }
}
