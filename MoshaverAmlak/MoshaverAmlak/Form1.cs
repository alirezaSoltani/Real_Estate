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
            HomePanel.Location = new Point((this.Width - HomePanel.Width) / 2 + 16 , ((this.Height  - 16) - HomePanel.Height) / 2 + 16);



  
            
        }
        public MainForm()
        {
            InitializeComponent();
            


        }
       

        private void metroTileItem17_Click(object sender, EventArgs e)
        {

        }

        private void stepItem2_Click(object sender, EventArgs e)
        {
            pageSlider1.SelectedPage = pageSliderPage2;
        }
    }
}
