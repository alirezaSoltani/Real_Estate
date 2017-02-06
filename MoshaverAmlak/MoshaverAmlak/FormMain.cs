using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoshaverAmlak
{
    public partial class FormMain : Form
    {
        private int noeMelk;
        private bool isNewMalek = false;
        private DataBaseHandler dbh = new DataBaseHandler();
        private Vilayi vilayi = new Vilayi();
        private Apartman apartman = new Apartman();
        private Zamin zamin = new Zamin();
        private Maghaze maghaze = new Maghaze();
        private Malek malek = new Malek();
        private RahnA rA = new RahnA();
        private RahnM rM = new RahnM();
        private RahnV rV = new RahnV();
        private RahnZ rZ = new RahnZ();
        private EjareA eA = new EjareA();
        private EjareM eM = new EjareM();
        private EjareV eV = new EjareV();
        private EjareZ eZ = new EjareZ();
        private ForoshA fA = new ForoshA();
        private ForoshM fM = new ForoshM();
        private ForoshV fV = new ForoshV();
        private ForoshZ fZ = new ForoshZ();
        private PishForoshA pA = new PishForoshA();
        private PishForoshM pM = new PishForoshM();
        private MosharekatA mA = new MosharekatA();
        private MosharekatV mV = new MosharekatV();




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
            MainPageSlider.SelectedPage = RegisterSliderPage;
        }

        //...........................................design button on click...........................................
        private void metroTileItem15_Click(object sender, EventArgs e)
        {
            MainPageSlider.SelectedPage = FastAddETMalekSliderPage;
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
        
        private void stepItem1_Click_2(object sender, EventArgs e)
        {
            FastAddSilderPage.SelectedPage = FastAddETKoliSliderPage;
        }

        private void stepItem2_Click_2(object sender, EventArgs e)
        {
            FastAddSilderPage.SelectedPage = FastAddETMelkSliderPage;
        }

        private void stepItem3_Click_2(object sender, EventArgs e)
        {
            FastAddSilderPage.SelectedPage = FastAddETKhadamatSliderPage;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            MainPageSlider.SelectedPage = HomeSliderPage;
        }



        //...........................................numeric test...........................................
        private void FastAddVilTabagheNumTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void FastAddVilTabagheTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void FastAddVilSalSakhtTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);

        }

        private void FastAddVilOtaghNumTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void FastAddVilVahedHarTabagheTB_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void FastAddApaTabagheNumTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void FastAddApaTabagheTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void FastAddApaSalSakhtTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void FastAddApaOtaghNumTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void FastAddApaVahedHarTabagheTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void FastAddMaghTabagheNumTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void FastAddMaghTabagheTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void FastAddMaghSalSakhtTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void FastAddMaghOtaghNumTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void FastAddMaghVahedHarTabagheTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void FastAddVilNextBTN_Click(object sender, EventArgs e)
        {
            int step = 0;
            int valid = 1;
            if (FastAddVilMantagheTB.Text == "منطقه")
            {
                valid = 0;
                FastAddVilMantagheTB.BackColor = Color.Pink;
            }
            else
            {
                FastAddVilMantagheTB.BackColor = Color.WhiteSmoke;
                step += 16;
            }
            if (FastAddVilKarbariCOMBO.SelectedItem == "") {
                valid = 0;
                FastAddVilKarbariCOMBO.BackColor = Color.Pink;
            }
            else
            {
                FastAddVilMantagheTB.BackColor = Color.WhiteSmoke;
                step += 16;
            }
            if (FastAddVilTabagheNumTB.Text=="تعداد طبقات") {
                valid = 0;
                FastAddVilTabagheNumTB.BackColor = Color.Pink;
            }
            else
            {
                FastAddVilMantagheTB.BackColor = Color.WhiteSmoke;
                step += 16;
            }
            if (FastAddVilTabagheTB.Text == "طبقه") {
                valid = 0;
                FastAddVilTabagheTB.BackColor = Color.Pink;
            }
            else
            {
                FastAddVilMantagheTB.BackColor = Color.WhiteSmoke;
                step += 16;
            }
            if (FastAddVilSalSakhtTB.Text == "سال ساخت") {
                valid = 0;
                FastAddVilSalSakhtTB.BackColor = Color.Pink;
            }
            else
            {
                FastAddVilMantagheTB.BackColor = Color.WhiteSmoke;
                step += 16;
            }
            if (FastAddVilOtaghNumTB.Text == "تعداد اتاق") {
                valid = 0;
                FastAddVilOtaghNumTB.BackColor = Color.Pink;
            }
            else
            {
                FastAddVilMantagheTB.BackColor = Color.WhiteSmoke;
                step += 20;
            }
            FastAddEetelatMelkSI.Value = step;
            if (valid==1) {
                noeMelk = 1;

                Vilayi vilayi = new Vilayi();

                if (FastAddVilAbCB.Checked == true)
                {
                    vilayi.Vilayi_ab = "دارد";
                }
                else
                {
                    vilayi.Vilayi_ab = "ندارد";
                }


                if (FastAddVilBarghCB.Checked == true)
                {
                    vilayi.Vilayi_bargh = "دارد";
                }
                else
                {
                    vilayi.Vilayi_bargh = "ندارد";
                }


                if (FastAddVilGazCB.Checked == true)
                {
                    vilayi.Vilayi_gaz = "دارد";
                }
                else
                {
                    vilayi.Vilayi_gaz = "ندارد";
                }


                if (FastAddVilTelCB.Checked == true)
                {
                    vilayi.Vilayi_tel = "دارد";
                }
                else
                {
                    vilayi.Vilayi_tel = "ندارد";
                }



                if (FastAddVilAsansourCB.Checked == true)
                {
                    vilayi.Vilayi_asansor = "دارد";
                }
                else
                {
                    vilayi.Vilayi_asansor = "ندارد";
                }

                if (FastAddVilTerasCB.Checked == true)
                {
                    vilayi.Vilayi_teras = "دارد";
                }
                else
                {
                    vilayi.Vilayi_teras = "ندارد";
                }


                if (FastAddVilHayatCB.Checked == true)
                {
                    vilayi.Vilayi_hayat = "دارد";
                }
                else
                {
                    vilayi.Vilayi_hayat = "ندارد";
                }

                if (FastAddVilParkingCB.Checked == true)
                {
                    vilayi.Vilayi_parking = "دارد";
                }
                else
                {
                    vilayi.Vilayi_parking = "ندارد";
                }


                if (FastAddVilKabinetCB.Checked == true)
                {
                    vilayi.Vilayi_kabinet = "دارد";
                }
                else
                {
                    vilayi.Vilayi_kabinet = "ندارد";
                }


                if (FastAddVilAnbarCB.Checked == true)
                {
                    vilayi.Vilayi_anbar = "دارد";
                }
                else
                {
                    vilayi.Vilayi_anbar = "ندارد";
                }

                vilayi.Vilayi_mantaghe = FastAddVilMantagheTB.Text;
                vilayi.Vilayi_address = FastAddVilAddressTB.Text;
                vilayi.Vilayi_noeKarbari = FastAddVilKarbariCOMBO.Text;
                vilayi.Vilayi_tedadTabaghat = int.Parse(FastAddVilTabagheNumTB.Text);
                vilayi.Vilayi_tabaghe = int.Parse(FastAddVilTabagheTB.Text);
                vilayi.Vilayi_saleSakht = int.Parse(FastAddVilSalSakhtTB.Text);
                vilayi.Vilayi_tedadOtagh = int.Parse(FastAddVilOtaghNumTB.Text);
                vilayi.Vilayi_tedadVahedTabaghe = int.Parse(FastAddVilVahedHarTabagheTB.Text);
                vilayi.Vilayi_nama = FastAddVilNamaTB.Text;
                vilayi.Vilayi_kafposh = FastAddVilKafpushTB.Text;
                vilayi.Vilayi_tozih = FastAddVilDesTB.Text;
                vilayi.Vilayi_malekncode = FastAddPerCodeTB.Text;
                FastAddSilderPage.SelectedPage = FastAddETKhadamatSliderPage;
            }
        }

        private void FastAddApaNextBTN_Click(object sender, EventArgs e)
        {
            int step=0;
            int valid = 1;
            if (FastAddApaMantagheTB.Text == "منطقه")
            {
                valid = 0;
                FastAddApaMantagheTB.BackColor = Color.Pink;
            }
            else
            {
                FastAddVilMantagheTB.BackColor = Color.WhiteSmoke;
                step += 16;
            }
            if (FastAddApaKarbariCOMBO.SelectedText == "")
            {
                valid = 0;
                FastAddApaKarbariCOMBO.BackColor = Color.Pink;
            }
            else
            {
                FastAddApaKarbariCOMBO.BackColor = Color.WhiteSmoke;
                step += 16;
            }
            if (FastAddApaTabagheNumTB.Text == "تعداد طبقات")
            {
                valid = 0;
                FastAddApaTabagheNumTB.BackColor = Color.Pink;
            }
            else
            {
                FastAddApaTabagheNumTB.BackColor = Color.WhiteSmoke;
                step += 16;
            }
            if (FastAddApaTabagheTB.Text == "طبقه")
            {
                valid = 0;
                FastAddApaTabagheTB.BackColor = Color.Pink;
            }
            else
            {
                FastAddApaTabagheTB.BackColor = Color.WhiteSmoke;
                step += 16;
            }
            if (FastAddApaSalSakhtTB.Text == "سال ساخت")
            {
                valid = 0;
                FastAddApaSalSakhtTB.BackColor = Color.Pink;
            }
            else
            {
                FastAddApaSalSakhtTB.BackColor = Color.WhiteSmoke;
                step += 16;
            }
            if (FastAddApaOtaghNumTB.Text == "تعداد اتاق")
            {
                valid = 0;
                FastAddApaOtaghNumTB.BackColor = Color.Pink;
            }
            else
            {
                FastAddApaOtaghNumTB.BackColor = Color.WhiteSmoke;
                step += 20;
            }
            FastAddEetelatMelkSI.Value = step;
            if (valid == 1)
            {
                noeMelk = 2;

                Apartman apartman = new Apartman();

                if (FastAddApaAbCB.Checked == true)
                {
                    apartman.Apartman_ab = "دارد";
                }
                else
                {
                    apartman.Apartman_ab = "ندارد";
                }


                if (FastAddApaBarghCB.Checked == true)
                {
                    apartman.Apartman_bargh = "دارد";
                }
                else
                {
                    apartman.Apartman_bargh = "ندارد";
                }


                if (FastAddApaGazCB.Checked == true)
                {
                    apartman.Apartman_gaz = "دارد";
                }
                else
                {
                    apartman.Apartman_gaz = "ندارد";
                }


                if (FastAddApaTelCB.Checked == true)
                {
                    apartman.Apartman_tel = "دارد";
                }
                else
                {
                    apartman.Apartman_tel = "ندارد";
                }



                if (FastAddApaAsansourCB.Checked == true)
                {
                    apartman.Apartman_asansor = "دارد";
                }
                else
                {
                    apartman.Apartman_asansor = "ندارد";
                }

                if (FastAddApaTerasCB.Checked == true)
                {
                    apartman.Apartman_teras = "دارد";
                }
                else
                {
                    apartman.Apartman_teras = "ندارد";
                }


                if (FastAddApaHayatCB.Checked == true)
                {
                    apartman.Apartman_hayat = "دارد";
                }
                else
                {
                    apartman.Apartman_hayat = "ندارد";
                }

                if (FastAddApaParkingCB.Checked == true)
                {
                    apartman.Apartman_parking = "دارد";
                }
                else
                {
                    apartman.Apartman_parking = "ندارد";
                }


                if (FastAddApaCabinetCB.Checked == true)
                {
                    apartman.Apartman_kabinet = "دارد";
                }
                else
                {
                    apartman.Apartman_kabinet = "ندارد";
                }


                if (FastAddApaAnbarCB.Checked == true)
                {
                    apartman.Apartman_anbar = "دارد";
                }
                else
                {
                    apartman.Apartman_anbar = "ندارد";
                }

                apartman.Apartman_mantaghe = FastAddApaMantagheTB.Text;
                apartman.Apartman_address = FastAddApaAddressTB.Text;
                apartman.Apartman_noeKarbari = FastAddApaKarbariCOMBO.Text;
                apartman.Apartman_tedadTabaghat = int.Parse(FastAddApaTabagheNumTB.Text);
                apartman.Apartman_tabaghe = int.Parse(FastAddApaTabagheTB.Text);
                apartman.Apartman_saleSakht = int.Parse(FastAddApaSalSakhtTB.Text);
                apartman.Apartman_tedadOtagh = int.Parse(FastAddApaOtaghNumTB.Text);
                apartman.Apartman_tedadVahedTabaghe = int.Parse(FastAddApaVahedHarTabagheTB.Text);
                apartman.Apartman_nama = FastAddApaNamaTB.Text;
                apartman.Apartman_kafposh = FastAddApaKafpushTB.Text;
                apartman.Apartman_tozih = FastAddApaDesTB.Text;
                apartman.Apartman_malekncode = FastAddPerCodeTB.Text;
                FastAddSilderPage.SelectedPage = FastAddETKhadamatSliderPage;
            }
        }

        private void FastAddMaghNextBTN_Click(object sender, EventArgs e)
        {
            int step = 0;
            int valid=1;
            if (FastAddMaghMantagheTB.Text == "منطقه")
            {
                valid = 0;
                FastAddMaghMantagheTB.BackColor = Color.Pink;
            }
            else
            {
                FastAddMaghMantagheTB.BackColor = Color.WhiteSmoke;
                step += 16;
            }
            if (FastAddMaghKarbariCOMBO.SelectedItem == "")
            {
                valid = 0;
                FastAddMaghKarbariCOMBO.BackColor = Color.Pink;
            }
            else
            {
                FastAddMaghKarbariCOMBO.BackColor = Color.WhiteSmoke;
                step += 16;
            }
            if (FastAddMaghTabagheNumTB.Text == "تعداد طبقات")
            {
                valid = 0;
                FastAddMaghTabagheNumTB.BackColor = Color.Pink;
            }
            else
            {
                FastAddMaghTabagheNumTB.BackColor = Color.WhiteSmoke;
                step += 16;
            }
            if (FastAddMaghTabagheTB.Text == "طبقه")
            {
                valid = 0;
                FastAddMaghTabagheTB.BackColor = Color.Pink;
            }
            else
            {
                FastAddMaghTabagheTB.BackColor = Color.WhiteSmoke;
                step += 16;
            }
            if (FastAddMaghSalSakhtTB.Text == "سال ساخت")
            {
                valid = 0;
                FastAddMaghSalSakhtTB.BackColor = Color.Pink;
            }
            else
            {
                FastAddMaghSalSakhtTB.BackColor = Color.WhiteSmoke;
                step += 16;
            }
            if (FastAddMaghOtaghNumTB.Text == "تعداد اتاق")
            {
                valid = 0;
                FastAddMaghOtaghNumTB.BackColor = Color.Pink;
            }
            else
            {
                FastAddMaghOtaghNumTB.BackColor = Color.WhiteSmoke;
                step += 20;
            }
            FastAddEetelatMelkSI.Value = step;
            if (valid == 1)
            {
                noeMelk = 3;

                Maghaze maghaze = new Maghaze();

                if (FastAddMaghAbCB.Checked == true)
                {
                    maghaze.Maghaze_ab = "دارد";
                }
                else
                {
                    maghaze.Maghaze_ab = "ندارد";
                }


                if (FastAddMaghBarghCB.Checked == true)
                {
                    maghaze.Maghaze_bargh = "دارد";
                }
                else
                {
                    maghaze.Maghaze_bargh = "ندارد";
                }


                if (FastAddMaghGazCB.Checked == true)
                {
                    maghaze.Maghaze_gaz = "دارد";
                }
                else
                {
                    maghaze.Maghaze_gaz = "ندارد";
                }


                if (FastAddMaghTelCB.Checked == true)
                {
                    maghaze.Maghaze_tel = "دارد";
                }
                else
                {
                    maghaze.Maghaze_tel = "ندارد";
                }



                if (FastAddMaghAsansourCB.Checked == true)
                {
                    maghaze.Maghaze_asansor = "دارد";
                }
                else
                {
                    maghaze.Maghaze_asansor = "ندارد";
                }

                if (FastAddMaghTerasCB.Checked == true)
                {
                    maghaze.Maghaze_balkon = "دارد";
                }
                else
                {
                    maghaze.Maghaze_balkon = "ندارد";
                }

                if (FastAddMaghParkingCB.Checked == true)
                {
                    maghaze.Maghaze_parking = "دارد";
                }
                else
                {
                    maghaze.Maghaze_parking = "ندارد";
                }




                if (FastAddMaghAnbarCB.Checked == true)
                {
                    maghaze.Maghaze_anbar = "دارد";
                }
                else
                {
                    maghaze.Maghaze_anbar = "ندارد";
                }

                maghaze.Maghaze_mantaghe = FastAddMaghMantagheTB.Text;
                maghaze.Maghaze_address = FastAddMaghAddressTB.Text;
                maghaze.Maghaze_noeKarbari = FastAddMaghKarbariCOMBO.Text;
                maghaze.Maghaze_tedadTabaghat = int.Parse(FastAddMaghTabagheNumTB.Text);
                maghaze.Maghaze_tabaghe = int.Parse(FastAddMaghTabagheTB.Text);
                maghaze.Maghaze_saleSakht = int.Parse(FastAddMaghSalSakhtTB.Text);
                maghaze.Maghaze_tedadVahedTabaghe = int.Parse(FastAddMaghVahedHarTabagheTB.Text);
                maghaze.Maghaze_nama = FastAddMaghNamaTB.Text;
                maghaze.Maghaze_kafposh = FastAddMaghKafpushTB.Text;
                maghaze.Maghaze_tozih = FastAddMaghDesTB.Text;
                maghaze.Maghaze_malekncode = FastAddPerCodeTB.Text;
                FastAddSilderPage.SelectedPage = FastAddETKhadamatSliderPage;
            }
        }

        private void FastAddZamNextBTN_Click(object sender, EventArgs e)
        {
            int step = 0;
            int valid=1;
            if (FastAddZamMantagheTB.Text == "منطقه")
            {
                valid = 0;
                FastAddZamMantagheTB.BackColor = Color.Pink;
            }
            else
            {
                FastAddZamMantagheTB.BackColor = Color.WhiteSmoke;
                step += 50;
            }
            if (FastAddZamKarbariCOMBO.SelectedItem == "")
            {
                valid = 0;
                FastAddZamKarbariCOMBO.BackColor = Color.Pink;
                step += 50;
            }
            else
            {
                FastAddZamKarbariCOMBO.BackColor = Color.WhiteSmoke;
            }
            FastAddEetelatKhadamatSI.Value = step;
            if (valid == 1)
            {
                noeMelk = 4;

                Zamin zamin = new Zamin();

                if (FastAddZamAbCB.Checked == true)
                {
                    zamin.Zamin_ab = "دارد";
                }
                else
                {
                    zamin.Zamin_ab = "ندارد";
                }


                if (FastAddZamBarghCB.Checked == true)
                {
                    zamin.Zamin_bargh = "دارد";
                }
                else
                {
                    zamin.Zamin_bargh = "ندارد";
                }


                if (FastAddZamGazCB.Checked == true)
                {
                    zamin.Zamin_gaz = "دارد";
                }
                else
                {
                    zamin.Zamin_gaz = "ندارد";
                }


                if (FastAddZamTelCB.Checked == true)
                {
                    zamin.Zamin_tel = "دارد";
                }
                else
                {
                    zamin.Zamin_tel = "ندارد";
                }

                zamin.Zamin_address = FastAddZamAddressTB.Text;
                zamin.Zamin_mantaghe = FastAddZamMantagheTB.Text;
                zamin.Zamin_noeKarbari = FastAddZamKarbariCOMBO.Text;
                zamin.Zamin_tozih = FastAddZamDesTB.Text;
                zamin.Zamin_malekncode = FastAddPerCodeTB.Text;
                FastAddSilderPage.SelectedPage = FastAddETKhadamatSliderPage;
            }
        }


        private void FastAddEjareMablaghPishTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (FastAddEjareMablaghPishTB.Text == "" || FastAddEjareMablaghPishTB.Text == "0") return;
                decimal price;
                price = decimal.Parse(FastAddEjareMablaghPishTB.Text, System.Globalization.NumberStyles.Currency);
                FastAddEjareMablaghPishTB.Text = price.ToString("#,#");
                FastAddEjareMablaghPishTB.SelectionStart = FastAddEjareMablaghPishTB.Text.Length;
            }
            catch (Exception) { }
        }

        private void FastAddForushMablaghKolTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (FastAddForushMablaghKolTB.Text == "" || FastAddForushMablaghKolTB.Text == "0") return;
                decimal price;
                price = decimal.Parse(FastAddForushMablaghKolTB.Text, System.Globalization.NumberStyles.Currency);
                FastAddForushMablaghKolTB.Text = price.ToString("#,#");
                FastAddForushMablaghKolTB.SelectionStart = FastAddForushMablaghKolTB.Text.Length;
            }
            catch (Exception) { }
        }

        private void FastAddForushMablaghVamTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (FastAddForushMablaghVamTB.Text == "" || FastAddForushMablaghVamTB.Text == "0") return;
                decimal price;
                price = decimal.Parse(FastAddForushMablaghVamTB.Text, System.Globalization.NumberStyles.Currency);
                FastAddForushMablaghVamTB.Text = price.ToString("#,#");
                FastAddForushMablaghVamTB.SelectionStart = FastAddForushMablaghVamTB.Text.Length;
            }
            catch (Exception) { }
        }

        private void FastAddPishForushPishPardakhtTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (FastAddPishForushPishPardakhtTB.Text == "" || FastAddPishForushPishPardakhtTB.Text == "0") return;
                decimal price;
                price = decimal.Parse(FastAddPishForushPishPardakhtTB.Text, System.Globalization.NumberStyles.Currency);
                FastAddPishForushPishPardakhtTB.Text = price.ToString("#,#");
                FastAddPishForushPishPardakhtTB.SelectionStart = FastAddPishForushPishPardakhtTB.Text.Length;
            }
            catch (Exception) { }
        }

        private void FastAddPishForushMablaghKolTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (FastAddPishForushMablaghKolTB.Text == "" || FastAddPishForushMablaghKolTB.Text == "0") return;
                decimal price;
                price = decimal.Parse(FastAddPishForushMablaghKolTB.Text, System.Globalization.NumberStyles.Currency);
                FastAddPishForushMablaghKolTB.Text = price.ToString("#,#");
                FastAddPishForushMablaghKolTB.SelectionStart = FastAddPishForushMablaghKolTB.Text.Length;
            }
            catch (Exception) { }
        }

        private void FastAddRahnMablaghRahnTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (FastAddRahnMablaghRahnTB.Text == "" || FastAddRahnMablaghRahnTB.Text == "0") return;
                decimal price;
                price = decimal.Parse(FastAddRahnMablaghRahnTB.Text, System.Globalization.NumberStyles.Currency);
                FastAddRahnMablaghRahnTB.Text = price.ToString("#,#");
                FastAddRahnMablaghRahnTB.SelectionStart = FastAddRahnMablaghRahnTB.Text.Length;
            }
            catch (Exception) { }
        }

        private void FastAddEjareMablaghEjareTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (FastAddEjareMablaghEjareTB.Text == "" || FastAddEjareMablaghEjareTB.Text == "0") return;
                decimal price;
                price = decimal.Parse(FastAddEjareMablaghEjareTB.Text, System.Globalization.NumberStyles.Currency);
                FastAddEjareMablaghEjareTB.Text = price.ToString("#,#");
                FastAddEjareMablaghEjareTB.SelectionStart = FastAddEjareMablaghEjareTB.Text.Length;
            }
            catch (Exception) { }
        }

        private void FastAddForushDangNumTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void FastAddPishForushDangNumTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void FastAddMosharekatDangNumTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void FastAddForushMablaghKolTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void FastAddForushMablaghVamTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void FastAddPishForushPishPardakhtTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void FastAddPishForushMablaghKolTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void FastAddRahnMablaghRahnTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void FastAddEjareMablaghPishTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void FastAddEjareMablaghEjareTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void FastAddForushSaveBTN_Click(object sender, EventArgs e)
        {
            int step = 0;
            int valid = 1;
            if (FastAddForushMablaghKolTB.Text == "مبلغ کل")
            {
                valid = 0;
                FastAddForushMablaghKolTB.BackColor = Color.Pink;
            }
            else
            {
                FastAddForushMablaghKolTB.BackColor = Color.WhiteSmoke;
                step += 25;
            }
            if (FastAddForushMablaghVamTB.Text == "مبلغ وام")
            {
                valid = 0;
                FastAddForushMablaghVamTB.BackColor = Color.Pink;
            }
            else
            {
                FastAddForushMablaghVamTB.BackColor = Color.WhiteSmoke;
                step += 25;
            }
            if (FastAddForushSanadKindCOMBO.SelectedItem == "")
            {
                valid = 0;
                FastAddForushSanadKindCOMBO.BackColor = Color.Pink;
                
            }
            else
            {
                FastAddForushSanadKindCOMBO.BackColor = Color.WhiteSmoke;
                step += 25;
            }
            if (FastAddForushDangNumTB.Text == "تعداد دانگ")
            {
                valid = 0;
                FastAddForushDangNumTB.BackColor = Color.Pink;
            }
            else
            {
                FastAddForushDangNumTB.BackColor = Color.WhiteSmoke;
                step += 25;
            }
            FastAddEetelatKhadamatSI.Value = step;
            if (valid == 1)
            {
                //MessageBox.Show("sabte melk ba id : "+kind);
            }
        }

        private void FastAddPishForushSaveBTN_Click(object sender, EventArgs e)
        {
            int step = 0;
            int valid = 1;
            if (FastAddPishForushPishPardakhtTB.Text == "پیش پرداخت")
            {
                valid = 0;
                FastAddPishForushPishPardakhtTB.BackColor = Color.Pink;
            }
            else
            {
                FastAddPishForushPishPardakhtTB.BackColor = Color.WhiteSmoke;
                step += 20;
            }
            if (FastAddPishForushMablaghKolTB.Text == "مبلغ کل")
            {
                valid = 0;
                FastAddPishForushMablaghKolTB.BackColor = Color.Pink;
            }
            else
            {
                FastAddPishForushMablaghKolTB.BackColor = Color.WhiteSmoke;
                step += 25;
            }
            if (FastAddPishForushSandadKindCOMBO.SelectedItem == "")
            {
                valid = 0;
                FastAddPishForushSandadKindCOMBO.BackColor = Color.Pink;
                
            }
            else
            {
                FastAddPishForushSandadKindCOMBO.BackColor = Color.WhiteSmoke;
                step += 20;
            }
            if (FastAddForushDangNumTB.Text == "تعداد دانگ")
            {
                valid = 0;
                FastAddForushDangNumTB.BackColor = Color.Pink;
            }
            else
            {
                FastAddForushDangNumTB.BackColor = Color.WhiteSmoke;
                step += 25;
            }
            FastAddEetelatKhadamatSI.Value = step;
            if (valid == 1)
            {
                //MessageBox.Show("sabte melk ba id : " + kind);
            }
        }
        private void FastAddPerCodeTB_TextChanged(object sender, EventArgs e)
        {
            /////////////// auto fild malek///////////////
            if (FastAddPerCodeTB.Text.Length == 10)
            {
                FastAddPerCodeTB.BackColor = Color.LightGreen;

                Malek malek = new Malek();

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source= 185.159.152.2;" +
                "Initial Catalog=rayanpro_amlak;" +
                "User id=rayanpro_user; " +
                "Password=P@hn1395;";


                SqlCommand sc = new SqlCommand();
                SqlDataReader reader;
                sc.CommandText = "SELECT * FROM tbl_malek WHERE malek_ncode = '" + FastAddPerCodeTB.Text + "'";
                sc.CommandType = CommandType.Text;
                sc.Connection = conn;
                conn.Open();
                reader = sc.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();

                    malek.Malek_ncode = reader["malek_ncode"].ToString();
                    malek.Malek_name = reader["malek_name"].ToString();
                    malek.Malek_mobile = reader["malek_mobile"].ToString();
                    malek.Malek_tel = reader["malek_tel"].ToString();
                    malek.Malek_tozihat = reader["malek_tozihat"].ToString();


                    FastAddPerCodeTB.Text = malek.Malek_ncode;
                    FastAddPerNameTB.Text = malek.Malek_name;
                    FastAddPerMobTB.Text = malek.Malek_mobile;
                    FastAddPerTelTB.Text = malek.Malek_tel;
                    FastAddPerDesTB.Text = malek.Malek_tozihat;

                    ///////////disable feild///////////////////

                    FastAddPerCodeTB.Enabled = false;
                    FastAddPerNameTB.Enabled = false;
                    FastAddPerMobTB.Enabled = false;
                    FastAddPerTelTB.Enabled = false;
                    FastAddPerDesTB.Enabled = false;
                }

                else
                {
                    isNewMalek = true;
                }

            }
        }
        private void FastAddNextBTN_Click(object sender, EventArgs e)
        {
            int valid = 1;
            if (FastAddPerCodeTB.Text == "کد ملی")
            {
                valid = 0;
                FastAddPerCodeTB.BackColor = Color.Pink;
            }
            else {
                FastAddPerCodeTB.BackColor = Color.WhiteSmoke;
            }
            if (FastAddPerNameTB.Text == "نام")
            {
                valid = 0;
                FastAddPerNameTB.BackColor = Color.Pink;
            }
            else
            {
                FastAddPerNameTB.BackColor = Color.WhiteSmoke;
            }
            if (FastAddPerMobTB.Text == "شماره موبایل")
            {
                valid = 0;
                FastAddPerMobTB.BackColor = Color.Pink;
            }
            else
            {
                FastAddPerMobTB.BackColor = Color.WhiteSmoke;
            }
            if (valid == 1) {
                    if (isNewMalek == true)
                    {
                        Malek malek = new Malek();

                        malek.Malek_ncode = FastAddPerCodeTB.Text;
                        malek.Malek_name = FastAddPerNameTB.Text;
                        malek.Malek_mobile = FastAddPerMobTB.Text;
                        malek.Malek_tel = FastAddPerTelTB.Text;
                        malek.Malek_tozihat = FastAddPerDesTB.Text;
                    }
                ////////////end add new malek///////////////
                    FastAddSilderPage.SelectedPage = FastAddETMelkSliderPage;
            }
            /////////////add new malek///////////

        }


    }
}
