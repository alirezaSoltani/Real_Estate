using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoshaverAmlak
{
    public partial class MainForm : Form
    {
        protected override void OnResize(EventArgs e)
        {
            // Center the panel
            itemPanel1.Location = new Point((this.Width - itemPanel1.Width) / 2 + 16);
            base.OnResize(e);
        }
        public MainForm()
        {
            InitializeComponent();
        }
    }
}
