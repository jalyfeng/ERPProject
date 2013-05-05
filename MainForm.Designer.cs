namespace ERPProject
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barSubItem2,
            this.barSubItem3,
            this.barStaticItem1,
            this.barStaticItem2,
            this.barStaticItem3,
            this.barStaticItem4});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 12;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar2.BarAppearance.Hovered.Image = global::ERPProject.Properties.Resources.Interner呼叫;
            this.bar2.BarAppearance.Hovered.Options.UseFont = true;
            this.bar2.BarAppearance.Hovered.Options.UseImage = true;
            this.bar2.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar2.BarAppearance.Normal.Image = global::ERPProject.Properties.Resources.Interner呼叫;
            this.bar2.BarAppearance.Normal.Options.UseFont = true;
            this.bar2.BarAppearance.Normal.Options.UseImage = true;
            this.bar2.BarAppearance.Pressed.ForeColor = System.Drawing.Color.Red;
            this.bar2.BarAppearance.Pressed.Options.UseForeColor = true;
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "系统";
            this.barSubItem1.Id = 0;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "工具";
            this.barSubItem2.Id = 1;
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "帮助";
            this.barSubItem3.Id = 2;
            this.barSubItem3.Name = "barSubItem3";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem4)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "单位：某某公司";
            this.barStaticItem1.Id = 3;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "                                                          ";
            this.barStaticItem2.Id = 9;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "电话：0755-123456";
            this.barStaticItem3.Id = 10;
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Caption = "经销地：深圳";
            this.barStaticItem4.Id = 11;
            this.barStaticItem4.Name = "barStaticItem4";
            this.barStaticItem4.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(689, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 399);
            this.barDockControlBottom.Size = new System.Drawing.Size(689, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 369);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(689, 30);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 369);
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = null;
            this.navBarControl1.AllowSelectedLink = true;
            this.navBarControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.EachGroupHasSelectedLink = true;
            this.navBarControl1.Location = new System.Drawing.Point(0, 95);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 249;
            this.navBarControl1.OptionsNavPane.ShowOverflowButton = false;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(249, 304);
            this.navBarControl1.TabIndex = 23;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(689, 65);
            this.panelControl1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::ERPProject.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(689, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cross.ico");
            this.imageList1.Images.SetKeyName(1, "Interner呼叫.ico");
            this.imageList1.Images.SetKeyName(2, "Visual.ico");
            this.imageList1.Images.SetKeyName(3, "Web搜索.ico");
            this.imageList1.Images.SetKeyName(4, "Web页.ico");
            this.imageList1.Images.SetKeyName(5, "Web页面.ico");
            this.imageList1.Images.SetKeyName(6, "按钮.ico");
            this.imageList1.Images.SetKeyName(7, "帮助.ico");
            this.imageList1.Images.SetKeyName(8, "帮助文件.ico");
            this.imageList1.Images.SetKeyName(9, "保存.ico");
            this.imageList1.Images.SetKeyName(10, "保存并新建.ico");
            this.imageList1.Images.SetKeyName(11, "背景颜色.ico");
            this.imageList1.Images.SetKeyName(12, "笔.ico");
            this.imageList1.Images.SetKeyName(13, "标志.ico");
            this.imageList1.Images.SetKeyName(14, "表格.ico");
            this.imageList1.Images.SetKeyName(15, "草稿.ico");
            this.imageList1.Images.SetKeyName(16, "查看.ico");
            this.imageList1.Images.SetKeyName(17, "查看2.ico");
            this.imageList1.Images.SetKeyName(18, "查找(新).ico");
            this.imageList1.Images.SetKeyName(19, "查找.ico");
            this.imageList1.Images.SetKeyName(20, "查找下一个.ico");
            this.imageList1.Images.SetKeyName(21, "超链接.ico");
            this.imageList1.Images.SetKeyName(22, "撤销.ico");
            this.imageList1.Images.SetKeyName(23, "传真.ico");
            this.imageList1.Images.SetKeyName(24, "窗格.ico");
            this.imageList1.Images.SetKeyName(25, "错误.ico");
            this.imageList1.Images.SetKeyName(26, "打开.ico");
            this.imageList1.Images.SetKeyName(27, "打印机.ico");
            this.imageList1.Images.SetKeyName(28, "打印机2.ico");
            this.imageList1.Images.SetKeyName(29, "大纲.ico");
            this.imageList1.Images.SetKeyName(30, "单箭头(上).ico");
            this.imageList1.Images.SetKeyName(31, "单箭头(下).ico");
            this.imageList1.Images.SetKeyName(32, "单箭头(右).ico");
            this.imageList1.Images.SetKeyName(33, "单箭头.ico");
            this.imageList1.Images.SetKeyName(34, "单页.ico");
            this.imageList1.Images.SetKeyName(35, "电话.ico");
            this.imageList1.Images.SetKeyName(36, "电子邮件.ico");
            this.imageList1.Images.SetKeyName(37, "动画.ico");
            this.imageList1.Images.SetKeyName(38, "对.ico");
            this.imageList1.Images.SetKeyName(39, "对象.ico");
            this.imageList1.Images.SetKeyName(40, "发布.ico");
            this.imageList1.Images.SetKeyName(41, "发信箱.ico");
            this.imageList1.Images.SetKeyName(42, "返回.ico");
            this.imageList1.Images.SetKeyName(43, "复制.ico");
            this.imageList1.Images.SetKeyName(44, "格式刷.ico");
            this.imageList1.Images.SetKeyName(45, "更新.ico");
            this.imageList1.Images.SetKeyName(46, "更正.ico");
            this.imageList1.Images.SetKeyName(47, "工程.ico");
            this.imageList1.Images.SetKeyName(48, "工具.ico");
            this.imageList1.Images.SetKeyName(49, "公告.ico");
            this.imageList1.Images.SetKeyName(50, "关键字.ico");
            this.imageList1.Images.SetKeyName(51, "管理.ico");
            this.imageList1.Images.SetKeyName(52, "画线.ico");
            this.imageList1.Images.SetKeyName(53, "回复.ico");
            this.imageList1.Images.SetKeyName(54, "绘图.ico");
            this.imageList1.Images.SetKeyName(55, "绘图2.ico");
            this.imageList1.Images.SetKeyName(56, "检查姓名.ico");
            this.imageList1.Images.SetKeyName(57, "检索.ico");
            this.imageList1.Images.SetKeyName(58, "减少页面.ico");
            this.imageList1.Images.SetKeyName(59, "剪切.ico");
            this.imageList1.Images.SetKeyName(60, "结束.ico");
            this.imageList1.Images.SetKeyName(61, "快捷方式.ico");
            this.imageList1.Images.SetKeyName(62, "垃圾桶.ico");
            this.imageList1.Images.SetKeyName(63, "类.ico");
            this.imageList1.Images.SetKeyName(64, "立体.ico");
            this.imageList1.Images.SetKeyName(65, "密匙.ico");
            this.imageList1.Images.SetKeyName(66, "拼音.ico");
            this.imageList1.Images.SetKeyName(67, "权限.ico");
            this.imageList1.Images.SetKeyName(68, "全部保存.ico");
            this.imageList1.Images.SetKeyName(69, "全屏.ico");
            this.imageList1.Images.SetKeyName(70, "删除(新).ico");
            this.imageList1.Images.SetKeyName(71, "闪电.ico");
            this.imageList1.Images.SetKeyName(72, "上一级.ico");
            this.imageList1.Images.SetKeyName(73, "上一级目录.ico");
            this.imageList1.Images.SetKeyName(74, "上一记录.ico");
            this.imageList1.Images.SetKeyName(75, "设置.ico");
            this.imageList1.Images.SetKeyName(76, "声音.ico");
            this.imageList1.Images.SetKeyName(77, "时间.ico");
            this.imageList1.Images.SetKeyName(78, "时钟.ico");
            this.imageList1.Images.SetKeyName(79, "事件部.ico");
            this.imageList1.Images.SetKeyName(80, "收发信.ico");
            this.imageList1.Images.SetKeyName(81, "手.ico");
            this.imageList1.Images.SetKeyName(82, "首记录.ico");
            this.imageList1.Images.SetKeyName(83, "书签.ico");
            this.imageList1.Images.SetKeyName(84, "属性.ico");
            this.imageList1.Images.SetKeyName(85, "数据库.ico");
            this.imageList1.Images.SetKeyName(86, "数据库修复.ico");
            this.imageList1.Images.SetKeyName(87, "刷新.ico");
            this.imageList1.Images.SetKeyName(88, "双箭头(右).ico");
            this.imageList1.Images.SetKeyName(89, "双箭头.ico");
            this.imageList1.Images.SetKeyName(90, "搜索文件夹.ico");
            this.imageList1.Images.SetKeyName(91, "添加组.ico");
            this.imageList1.Images.SetKeyName(92, "填色.ico");
            this.imageList1.Images.SetKeyName(93, "停止(新).ico");
            this.imageList1.Images.SetKeyName(94, "通讯簿.ico");
            this.imageList1.Images.SetKeyName(95, "图片.ico");
            this.imageList1.Images.SetKeyName(96, "图片2.ico");
            this.imageList1.Images.SetKeyName(97, "图形合并.ico");
            this.imageList1.Images.SetKeyName(98, "网页.ico");
            this.imageList1.Images.SetKeyName(99, "网页过渡.ico");
            this.imageList1.Images.SetKeyName(100, "尾记录.ico");
            this.imageList1.Images.SetKeyName(101, "未读.ico");
            this.imageList1.Images.SetKeyName(102, "文件夹.ico");
            this.imageList1.Images.SetKeyName(103, "文章.ico");
            this.imageList1.Images.SetKeyName(104, "文章2.ico");
            this.imageList1.Images.SetKeyName(105, "文字.ico");
            this.imageList1.Images.SetKeyName(106, "问号.ico");
            this.imageList1.Images.SetKeyName(107, "下一记录.ico");
            this.imageList1.Images.SetKeyName(108, "橡皮.ico");
            this.imageList1.Images.SetKeyName(109, "橡皮2.ico");
            this.imageList1.Images.SetKeyName(110, "小子体.ico");
            this.imageList1.Images.SetKeyName(111, "笑脸.ico");
            this.imageList1.Images.SetKeyName(112, "新建.ico");
            this.imageList1.Images.SetKeyName(113, "新建文件夹.ico");
            this.imageList1.Images.SetKeyName(114, "信封.ico");
            this.imageList1.Images.SetKeyName(115, "旋转.ico");
            this.imageList1.Images.SetKeyName(116, "样式.ico");
            this.imageList1.Images.SetKeyName(117, "页搜索.ico");
            this.imageList1.Images.SetKeyName(118, "移至.ico");
            this.imageList1.Images.SetKeyName(119, "阴影.ico");
            this.imageList1.Images.SetKeyName(120, "邮件.ico");
            this.imageList1.Images.SetKeyName(121, "邮件2.ico");
            this.imageList1.Images.SetKeyName(122, "油漆.ico");
            this.imageList1.Images.SetKeyName(123, "语言.ico");
            this.imageList1.Images.SetKeyName(124, "预览.ico");
            this.imageList1.Images.SetKeyName(125, "运行.ico");
            this.imageList1.Images.SetKeyName(126, "粘贴.ico");
            this.imageList1.Images.SetKeyName(127, "展开.ico");
            this.imageList1.Images.SetKeyName(128, "折叠.ico");
            this.imageList1.Images.SetKeyName(129, "正确.ico");
            this.imageList1.Images.SetKeyName(130, "中断.ico");
            this.imageList1.Images.SetKeyName(131, "终止.ico");
            this.imageList1.Images.SetKeyName(132, "重复.ico");
            this.imageList1.Images.SetKeyName(133, "重置.ico");
            this.imageList1.Images.SetKeyName(134, "主页.ico");
            this.imageList1.Images.SetKeyName(135, "转到书签.ico");
            this.imageList1.Images.SetKeyName(136, "转发.ico");
            this.imageList1.Images.SetKeyName(137, "组2.ico");
            this.imageList1.Images.SetKeyName(138, "组件.ico");
            this.imageList1.Images.SetKeyName(139, "组织.ico");
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(689, 426);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "深圳创科技术管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem4;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

