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
    public partial class DataEdit : Form
    {

        CommonClass OriginNewRecord { get; set; }
        CommonClass OriginSelectedRecord { get; set; }
        CommonClass NewRecord { get; set; }
        CommonClass SelectedRecord { get; set; }
        //if user pushes 'cencel' button then NewRecord and SelectedRecord recive previous conditions
        CommonClass PrevNewRecord { get; set; }
        CommonClass PrevSelectedRecord { get; set; }

        Library lib = new Library();

        //flag for understand is it saved or not
        bool Saved { get; set; }

        int SelectedRecIndex { get; set; }

        public BindingList<CommonClass> SecSummaryList  = new BindingList<CommonClass>();

        public DataEdit(BindingList<CommonClass> lst, CommonClass newRecord, CommonClass selectedRecord)
        {
            SecSummaryList = lst;           

            OriginNewRecord = newRecord;
            OriginSelectedRecord = selectedRecord;

            NewRecord = newRecord is null ? null : (CommonClass)newRecord.Clone(); 
            SelectedRecord = selectedRecord is null ? null : (CommonClass)selectedRecord.Clone();

            PrevNewRecord = NewRecord is null ? null : (CommonClass)NewRecord.Clone();
            SelectedRecord = SelectedRecord is null ? null : (CommonClass)SelectedRecord.Clone();

            InitializeComponent();
            if (NewRecord is null)
                DefaultDataLoad(SelectedRecord);
            else
                DefaultDataLoad(NewRecord);
        }

        private void DefaultDataLoad(CommonClass Record)
        {
            toolTip1.SetToolTip(textBox4, "Должно содержать \"@\"");
            textBox1.Text = Record.Pers.ToString();
            textBox2.Text = Record.Adr.ToString();
            textBox3.Text = Record.Phones.ToString();
            textBox4.Text = Record.Email;
        }

        //=====================================Call for edit data operations ========================================

        //call PERSONAL data editting form
        private void EditPersonalDataBtn_Click(object sender, EventArgs e)
        {
            PersonalDataEditForm personalDataEditForm = new PersonalDataEditForm(NewRecord, SelectedRecord);
            personalDataEditForm.ShowDialog();
            if (SelectedRecord is null)
                DefaultDataLoad(NewRecord);
            else
                DefaultDataLoad(SelectedRecord);

        }

        //call ADRESS data editting form
        private void EditAdressBtn_Click(object sender, EventArgs e)
        {
              AdressDataEdittingForm adressDataEditForm = new AdressDataEdittingForm(NewRecord, SelectedRecord);
                adressDataEditForm.ShowDialog();
            if (SelectedRecord is null)
                DefaultDataLoad(NewRecord);
            else
                DefaultDataLoad(SelectedRecord);
        }

        //call PHONES data editting form
        private void EditPhonesBtn_Click(object sender, EventArgs e)
        {            
            PhonesDataEdittingForm phonesDataEditForm = new PhonesDataEdittingForm(NewRecord, SelectedRecord);
            phonesDataEditForm.ShowDialog();
            if (SelectedRecord is null)
                DefaultDataLoad(NewRecord);
            else
                DefaultDataLoad(SelectedRecord);
        }

        //====================================clear fields operations ===============================================

        private void ClearPhonesDataRec(CommonClass rec)
        {
            rec.Phones.MPhoneNum = "";
            rec.Phones.HPhoneNum = "";            
        }

        private void ClearAdrDataRec(CommonClass rec)
        {
            rec.Adr.Street = "";
            rec.Adr.HouseNumber = "";
            rec.Adr.AppNumber = 1;            
        }

        private void ClearPersDataRec(CommonClass rec)
        {
            rec.Pers.FirstName = "";
            rec.Pers.LastName = "";
            rec.Pers.Patronimic = "";
            rec.Pers.BirthYear = 1950;
        }

        //clear personal data
        private void button2_Click(object sender, EventArgs e)
        {
            if (NewRecord is null)            
                ClearPersDataRec(SelectedRecord);                            
            else            
                ClearPersDataRec(NewRecord);                
            
            textBox1.Text = "";

        }
        //clear adress data
        private void ClearAdressBtn_Click(object sender, EventArgs e)
        {
            if (NewRecord is null)
                ClearAdrDataRec(SelectedRecord);
            else
                ClearAdrDataRec(NewRecord);

            textBox2.Text = "";
        }
        //clear phones data
        private void ClearPhonesBtn_Click(object sender, EventArgs e)
        {
            if (NewRecord is null)
                ClearPhonesDataRec(SelectedRecord);
            else
                ClearPhonesDataRec(NewRecord);

            textBox3.Text = "";

        }

       

        
       

        //check for changes before closing
        private void DataEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Saved)//straight way from SaveChanges and from cancel btn
            {
                e.Cancel = false;
                return;
            }

            //if previous state is the same as current than close the form
            if (!(NewRecord is null))
            {
               
                if (NewRecord == OriginNewRecord)
                {
                    e.Cancel = false;
                    return;
                }
                else
                {
                    if (MessageBox.Show("Не были сохранены внесенные изменения. \nСохранить?.\n"
                        , "Сделать выбор", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {                        

                        if (!lib.InputdataEditValidation(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text))
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
              
                if (SelectedRecord == OriginSelectedRecord)
                {
                    e.Cancel = false;
                    return;
                }
                else
                {
                    if (MessageBox.Show("Не были сохранены внесенные изменения. \nСохранить?.\n"
                        , "Сделать выбор", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (!lib.InputdataEditValidation(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text))
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

        private void SaveBtn_Click(object sender, EventArgs e)
        {            
            
            if (!lib.InputdataEditValidation(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text))            
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
                lib.CopyValues(OriginNewRecord, NewRecord);
                OriginNewRecord.Email = textBox4.Text;

                SecSummaryList.Add(OriginNewRecord);

            }
            else
            {
                //edit mode
                OriginSelectedRecord.Email = textBox4.Text;
                lib.CopyValues(OriginSelectedRecord, SelectedRecord);

            }
            lib.FillDataToXML(SecSummaryList);
            Saved = true;
            MessageBox.Show("Есть");

        }

        //cencel  btn
        private void button9_Click(object sender, EventArgs e)
        {
            Saved = true;           
            this.Close();
        }


    }
}
