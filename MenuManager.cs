using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraNavBar;
using DevExpress.XtraTreeList;


namespace ERPProject
{
    public class MenuManager
    {
        private ERPDataDataContext context=new ERPDataDataContext();
        private List<Module> menuGroup;
        private int count = 0;
        

        public void GetMenu(NavBarControl navBarControl,ImageList images)
        {
            
            menuGroup = context.Module.Where(m => m.MpParentCode == "0").ToList<Module>();
            if (menuGroup.Count>0)
            {
                foreach (Module module in menuGroup)
                {

                    // 新建NavBarGroup
                    NavBarGroup group=new NavBarGroup();
                    group.Caption = module.MpName;
                    group.GroupClientHeight = 80;
                    group.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;

                    //group.Appearance.Options.UseTextOptions = true;
                    //group.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                    

                    group.Name = module.MpCode;
                    NavBarGroupControlContainer controlContainer=new NavBarGroupControlContainer();
                    controlContainer.Name = module.MpName + module.MpCode;
                    controlContainer.Size = new System.Drawing.Size(140, 175);
                    
                    group.LargeImage = images.Images[count++];
                    

                    #region 创建树
                  //  TreeList treeNode = new TreeList();
                    
                    TreeView treeNode=new TreeView();
                   treeNode.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(treeNode_NodeMouseDoubleClick);
                   // treeNode.TreeListMenuItemClick += new TreeListMenuItemClickEventHandler(treeNode_TreeListMenuItemClick);
                    treeNode.Size = controlContainer.Size;
                   
                    treeNode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
                    treeNode.Location = new System.Drawing.Point(0, 0);
                    treeNode.Name = module.MpCode;
                    treeNode.ImageList = images;
                


                    
                    foreach (Module subModule in context.Module)
                    {
                        if (subModule.MpParentCode == treeNode.Name)
                        {
                            var subsubTreeNode = new TreeNode();
                            subsubTreeNode.Text = subModule.MpName; //目录名  
                            
                            subsubTreeNode.Name = subModule.MpCode; //编号  
                            subsubTreeNode.ToolTipText = subModule.MpParentCode; //获取或设置当鼠标指针悬停于 TreeNode 之上时显示的文本。
                            subsubTreeNode.ImageIndex = count++;
                            treeNode.Nodes.Add(subsubTreeNode);
                            GetSubMenu(subsubTreeNode);
                        } 
                    }

                    #endregion

                    // 添加


                    controlContainer.Controls.Add(treeNode);
                    group.ControlContainer = controlContainer;
                    navBarControl.Controls.Add(controlContainer);
                    navBarControl.Groups.Add(group);

                }
            }
     

        }

        void treeNode_TreeListMenuItemClick(object sender, TreeListMenuItemClickEventArgs e)
        {
            string ls_form;
            ls_form = e.MenuItem.Caption;

            if (String.IsNullOrEmpty(ls_form))
                return;
            //防止一个窗口打开多次
            if (Application.OpenForms[ls_form] != null)
            {
                Application.OpenForms[ls_form].Activate();
                return;
            }

            var frm = new DepartmentForm();
            MainForm main = Application.OpenForms[0] as MainForm;
            frm.Text = ls_form;

            frm.MdiParent = main;

            frm.Show();
        }

        void treeNode_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string ls_form;
            ls_form = e.Node.Text;
            
            if(String.IsNullOrEmpty(ls_form))
                return;
            //防止一个窗口打开多次
            
            if (Application.OpenForms[ls_form] != null)
            {
                Application.OpenForms[ls_form].Activate();
                return;
            }
            
            var frm = new DepartmentForm();
            MainForm main=Application.OpenForms[0] as MainForm;
            frm.Text = ls_form;
            frm.Name = ls_form;
            frm.MdiParent = main;

            frm.Show();

                

        }
        private void GetSubMenu(TreeNode treeNode)
        {

            foreach (Module module in context.Module)
            {
                if (module.MpParentCode==treeNode.Name)
                {
                    var mTreeNode = new TreeNode();
                    mTreeNode.Text = module.MpName;
                    mTreeNode.Name = module.MpCode;
                    mTreeNode.ToolTipText = module.MpParentCode;
                    mTreeNode.ImageIndex = count++;
                    treeNode.Nodes.Add(mTreeNode);
                    GetSubMenu(mTreeNode);
                }
            }

        }

        

    }
}
