using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ziyunBrowser
{
    public partial class Index : Form
    {
        public WebKit.WebKitBrowser browser = null;
        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            browser = new WebKit.WebKitBrowser();
            browser.Dock = DockStyle.Fill;
            browser.AllowNavigation = true;
            browser.AllowNewWindows = true;
            
            this.ziyunBrowerContent.Controls.Add(browser);
            browser.Navigate("https://www.baidu.com");
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            browser.AllowNavigation = true;
        }
    }
}
