using System;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;

namespace DocumentManager_TabbedUI {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        void Form1_Load(object sender, EventArgs e) {
            AddDocumentManager();
            for(int i = 0; i < 3; i++) {
                AddChildForm();
            }
        }
        void AddDocumentManager() {
            DocumentManager manager = new DocumentManager();
            manager.MdiParent = this;
            manager.View = new TabbedView();
        }
        int count;
        void AddChildForm() {
            Form childForm = new Form();
            childForm.Text = "Child Form " + (++count).ToString();

            SimpleButton btn = new SimpleButton();
            btn.Text = "Button " + count.ToString();
            btn.Parent = childForm;

            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}