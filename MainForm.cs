using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraNavBar.ViewInfo;

namespace ERPProject
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MenuManager menuManager=new MenuManager();

            


            menuManager.GetMenu(this.navBarControl1,imageList1);
        }

        
    }
}
