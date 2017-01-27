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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            if (MainPageSlider.SelectedPage == HomeSliderPage)
            {
                Home.Visible = false;
            }
            else {
                Home.Visible = true;
            }
        }

        private void metroTileItem15_Click(object sender, EventArgs e)
        {
            MainPageSlider.SelectedPage = FastAdditionSliderPage;
        }

        private void metroTileItem16_Click(object sender, EventArgs e)
        {
            MainPageSlider.SelectedPage = AmlakSliderPage;
        }

        private void metroTileItem17_Click(object sender, EventArgs e)
        {
            MainPageSlider.SelectedPage = KhadamatSliderPage;
        }

        private void metroTileItem18_Click(object sender, EventArgs e)
        {
            MainPageSlider.SelectedPage = DaftarCheSliederPage;
        }

        private void RegisterLoginBTN_Click(object sender, EventArgs e)
        {
            MainPageSlider.SelectedPage = HomeSliderPage;
        }

        private void خانه_Click(object sender, EventArgs e)
        {
            MainPageSlider.SelectedPage = HomeSliderPage;
        }
        
    }
}
