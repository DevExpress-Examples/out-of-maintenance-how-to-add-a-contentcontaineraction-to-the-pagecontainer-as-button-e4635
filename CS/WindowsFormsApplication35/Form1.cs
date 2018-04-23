using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using DevExpress.XtraEditors;

namespace WindowsFormsApplication35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            page1.Buttons.AddAction(ContentContainerAction.Exit);
            
        }

        private void windowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {

            if (e.Document.Caption == "CardView")
                e.Control = CreateNewGrid(new CardView());
            if (e.Document.Caption == "GridView")
                e.Control = CreateNewGrid(new GridView());
            if (e.Document.Caption == "TreeList")
                e.Control = new ListBoxControl() { DataSource = GetData() };
           

        }
        public GridControl CreateNewGrid(BaseView View)
        {
            GridControl grid = new GridControl();
            grid.DataSource = GetData();
            grid.MainView = View;
            return grid;
        }
        public List<Person> GetData()
        {
            List<Person> list = new List<Person>();
            list.Add(new Person() { FirstName = "Alex", LastName = "Hunt", ID = 12321 });
            list.Add(new Person() { FirstName = "James", LastName = "Bond", ID = 87452 });
            list.Add(new Person() { FirstName = "Sam", LastName = "Winchester", ID = 43598 });
            list.Add(new Person() { FirstName = "Din", LastName = "Winchester", ID = 31561 });
            list.Add(new Person() { FirstName = "Derek", LastName = "Morgan", ID = 29873 });
            return list;
        }
    }
}
