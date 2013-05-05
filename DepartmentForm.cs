using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace ERPProject
{
    public partial class DepartmentForm : DevExpress.XtraEditors.XtraForm
    {
        public DepartmentForm()
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
        }
    }
}
