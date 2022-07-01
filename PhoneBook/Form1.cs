using PhoneBook.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.IO;
using PhoneBook.Helps;


namespace PhoneBook
{
    public partial class Form1 : Form
    {
        public BindingList<CommonClass> SummaryList { get; set; } = new BindingList<CommonClass>();
        Random rnd = new Random();
        Library lib = new Library();
        public Form1()
        {
            
            InitializeComponent();            
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
          // FillSummaryList();
           // FillDefaultdDataToXML();
            ReadFromXML();            
            DefaultdataLoad();
        }


        private void DefaultdataLoad()
        {
          

            summaryListDataGridView.Dock = DockStyle.Fill;           
            summaryListDataGridView.AllowUserToAddRows = false;
            summaryListDataGridView.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            summaryListDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;         
            summaryListDataGridView.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }


       //for xml file source filling
        private void FillSummaryList()
        {
            for (int i = 0; i < 50; i++)
            {
                CommonClass tmpCom = new CommonClass();
                if (i % 2 == 0)
                    tmpCom.Pers = lib.GetRndPerson(true, rnd);                
                else
                    tmpCom.Pers = lib.GetRndPerson(false, rnd);
                tmpCom.Adr = lib.GetRndAdress(rnd);
                tmpCom.Phones = lib.GetRndPhoneNumbers(rnd, SummaryList);
                tmpCom.Email = lib.GetEmail(rnd, SummaryList);
                SummaryList.Add(tmpCom);
            }          
        }

        //private void FillDefaultdDataToXML(BindingList<CommonClass> lst)
        //{
        //    XmlSerializer formatter = new XmlSerializer(typeof(BindingList<CommonClass>));          
        //    using (FileStream fs = new FileStream("DB.xml", FileMode.OpenOrCreate))
        //    {
        //        formatter.Serialize(fs, lst);
        //    }            
        //}

        private void ReadFromXML()
        {

            XmlSerializer formatter = new XmlSerializer(typeof(BindingList<CommonClass>));
            using (FileStream fs = new FileStream("DB.xml", FileMode.OpenOrCreate))
            {
                SummaryList.Clear();
                SummaryList = formatter.Deserialize(fs) as BindingList<CommonClass>;
                if (SummaryList!=null)
                    summaryListDataGridView.DataSource = SummaryList;
            }
           
        }

        //Add new data
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ColCount = SummaryList.Count();
            CommonClass rec = new CommonClass { Pers=new Person { FirstName="",LastName="",Patronimic="",BirthYear=1900,Sex=true},
                                                Adr = new Adress { Street="", HouseNumber="", AppNumber=1},
                                                Phones = new PhoneNumbers { MPhoneNum="",HPhoneNum=""},
                                                Email = ""};

            DataEdit DataEditForm = new DataEdit(SummaryList,rec, null);
            DataEditForm.ShowDialog();

            if (ColCount != SummaryList.Count())
            {
                ReadFromXML();
                DefaultdataLoad();
            }
            
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = summaryListDataGridView.CurrentCell.RowIndex;
            DataEdit DataEditForm = new DataEdit(SummaryList, null, SummaryList[index]);
            DataEditForm.ShowDialog();
        }
    }

}
