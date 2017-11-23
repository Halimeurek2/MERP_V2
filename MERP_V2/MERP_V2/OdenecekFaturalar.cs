using MySql.Data.MySqlClient;
using System;
using System.Globalization;

namespace MERP_V2
{
    public partial class OdenecekFaturalar : MetroFramework.Forms.MetroForm
    {
        MySqlDataReader myReader;

        public int i, j, index = 0;
        int state = 0;
        Boolean processDone = false;
        Boolean processDone1 = false;

        public float[] month_sumG = new float[12];
        public DateTime[] monthG = new DateTime[12];

        public float[] month_sumNewG = new float[12];
        public DateTime[] monthNewG = new DateTime[12];

        public float[] month_sumK = new float[12];
        public DateTime[] monthK = new DateTime[12];

        public float[] month_sumNewK = new float[12];
        public DateTime[] monthNewK = new DateTime[12];

        public float[] verSip = new float[12];
        public DateTime[] mSip = new DateTime[12];

        public float[] yapOdemeler = new float[12];
        public DateTime[] myOdemeler = new DateTime[12];

        public float[] yapilmisOdemeler = new float[12];
        public DateTime[] myapilmisOdemeler = new DateTime[12];

        public float[] alOdemeler = new float[12];
        public DateTime[] maOdemeler = new DateTime[12];

        public float[] alinmisOdemeler = new float[12];
        public DateTime[] malinmisOdemeler = new DateTime[12];

        public OdenecekFaturalar()
        {
            InitializeComponent();
        }

        private void OdenecekFaturalar_Load(object sender, EventArgs e)
        {
            //----------------------------------------------- BAĞLANTI --------------------------------------------------------
            mySqlConnection.Open();
            //-----------------------------------------------------------------------------------------------------------------
            //--------------------------------------- CLEAR ARRAYS AND GRAPHICS -----------------------------------------------
            chart1.Series["Gelen"].Points.Clear();
            chart2.Series["Kesilen"].Points.Clear();

            Array.Clear(monthNewG, 0, 12);
            Array.Clear(month_sumNewG, 0, 12);
            Array.Clear(monthNewK, 0, 12);
            Array.Clear(month_sumNewK, 0, 12);

            Array.Clear(verSip, 0, 12);
            Array.Clear(mSip, 0, 12);
            Array.Clear(yapOdemeler, 0, 12);
            Array.Clear(myOdemeler, 0, 12);
            Array.Clear(alOdemeler, 0, 12);
            Array.Clear(maOdemeler, 0, 12);

            Array.Clear(yapilmisOdemeler, 0, 12);
            Array.Clear(myapilmisOdemeler, 0, 12);
            Array.Clear(alinmisOdemeler, 0, 12);
            Array.Clear(malinmisOdemeler, 0, 12);
            //-----------------------------------------------------------------------------------------------------------------
            //------------------------------------------------- GRAFİKLER -----------------------------------------------------
            for (int index = 0; index < 12; index++)
            {
                if (monthG[index].Year == DateTime.Now.Year)
                {
                    monthNewG[i] = monthG[index];
                    month_sumNewG[i] = month_sumG[index];
                    i++;
                }
            }
            for (int index = 0; index < 12; index++)
            {
                if (monthK[index].Year == DateTime.Now.Year)
                {
                    monthNewK[j] = monthK[index];
                    month_sumNewK[j] = month_sumK[index];
                    j++;
                }
            }
            for (int k = 0; k < i; k++)
            {
                chart1.Series["Gelen"].Points.AddXY(Convert.ToString(DateTime.Now.Year) + "-" + Convert.ToString(monthNewG[k].Month) + ". ay", Convert.ToDecimal(month_sumNewG[k]));
                chart1.Series["Gelen"].Points[k].Label = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(month_sumNewG[k]));
            }
            for (int k = 0; k < j; k++)
            {
                chart2.Series["Kesilen"].Points.AddXY(Convert.ToString(DateTime.Now.Year) + "-" + Convert.ToString(monthNewK[k].Month) + ". ay", Convert.ToDecimal(month_sumNewK[k]));
                chart2.Series["Kesilen"].Points[k].Label = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(month_sumNewK[k]));
            }
            //-----------------------------------------------------------------------------------------------------------------
            //------------------------------------------------- FİRMALAR ------------------------------------------------------
            mySqlCommand.CommandText = "SELECT fatura_firma,sum(fatura_euro) from db_faturalar where fatura_proje_no='" + lbl_proje_no.Text + "' and fatura_tipi='G' group by fatura_firma order by sum(fatura_euro) DESC";
            myReader = mySqlCommand.ExecuteReader();
            while (myReader.Read())
            {
                if (processDone == false)
                {
                    switch (state)
                    {
                        case 0:
                            {
                                lbl_firma1.Text = Convert.ToString(myReader.GetString(0));
                                lbl_tutar1.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(myReader.GetString(1)));
                                state = 1;
                                break;
                            }
                        case 1:
                            {
                                lbl_firma2.Text = Convert.ToString(myReader.GetString(0));
                                lbl_tutar2.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(myReader.GetString(1)));
                                state = 2;
                                break;
                            }
                        case 2:
                            {
                                lbl_firma3.Text = Convert.ToString(myReader.GetString(0));
                                lbl_tutar3.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(myReader.GetString(1)));
                                state = 0;
                                processDone = true;
                                break;
                            }
                    }
                }
            }
            //-----------------------------------------------------------------------------------------------------------------
            //--------------------------------------------- VERİLEN SİPARİŞ ---------------------------------------------------
            try
            {
                mySqlCommand.CommandText = "SELECT siparis_tarihi,sum(siparis_euro) FROM db_siparis_emri where proje_No='" + lbl_proje_no.Text + "' group by date_format(siparis_tarihi, '%m-%Y');";
                myReader = mySqlCommand.ExecuteReader();
                while (myReader.Read())
                {
                    if (Convert.ToDateTime(myReader.GetString(0)).Year == DateTime.Now.Year)
                    {
                        mSip[index] = Convert.ToDateTime(myReader.GetString(0));
                        verSip[mSip[index].Month - 1] = (float)Convert.ToDouble(myReader.GetString(1));
                        index++;
                    }
                }
                myReader.Close();
            }
            catch { myReader.Close(); }
            //-----------------------------------------------------------------------------------------------------------------
            //--------------------------------------------- YAPILAN ÖDEMELER --------------------------------------------------
            try
            {
                index = 0;
                mySqlCommand.CommandText = "SELECT fatura_vade_tarih,sum(fatura_euro) FROM db_faturalar where fatura_durum='ODENMEDI' and fatura_tipi='G' and fatura_proje_no='" + lbl_proje_no.Text + "' group by date_format(fatura_vade_tarih, '%m-%Y');";
                myReader = mySqlCommand.ExecuteReader();
                while (myReader.Read())
                {
                    if (Convert.ToDateTime(myReader.GetString(0)).Year == DateTime.Now.Year)
                    {
                        myOdemeler[index] = Convert.ToDateTime(myReader.GetString(0));
                        yapOdemeler[myOdemeler[index].Month - 1] = (float)Convert.ToDouble(myReader.GetString(1));
                        index++;
                    }
                }
                myReader.Close();
            }
            catch { myReader.Close(); }
            //-----------------------------------------------------------------------------------------------------------------
            //--------------------------------------------- YAPILMIŞ ÖDEMELER -------------------------------------------------
            try
            {
                index = 0;
                mySqlCommand.CommandText = "SELECT fatura_vade_tarih,sum(fatura_euro) FROM db_faturalar where fatura_durum='ODENDI' and fatura_tipi='G' and fatura_proje_no='" + lbl_proje_no.Text + "' group by date_format(fatura_vade_tarih, '%m-%Y');";
                myReader = mySqlCommand.ExecuteReader();
                while (myReader.Read())
                {
                    if (Convert.ToDateTime(myReader.GetString(0)).Year == DateTime.Now.Year)
                    {
                        myapilmisOdemeler[index] = Convert.ToDateTime(myReader.GetString(0));
                        yapilmisOdemeler[myapilmisOdemeler[index].Month - 1] = (float)Convert.ToDouble(myReader.GetString(1));
                        index++;
                    }
                }
                myReader.Close();
            }
            catch { myReader.Close(); }
            //-----------------------------------------------------------------------------------------------------------------
            //----------------------------------------------- ALINAN ÖDEMELER -------------------------------------------------
            try
            {
                index = 0;
                mySqlCommand.CommandText = "SELECT fatura_vade_tarih,sum(fatura_euro) FROM db_faturalar where fatura_durum='ODENMEDI' and fatura_tipi='K' and fatura_proje_no='" + lbl_proje_no.Text + "'group by date_format(fatura_vade_tarih, '%m-%Y');";
                myReader = mySqlCommand.ExecuteReader();
                while (myReader.Read())
                {
                    if (Convert.ToDateTime(myReader.GetString(0)).Year == DateTime.Now.Year)
                    {
                        maOdemeler[index] = Convert.ToDateTime(myReader.GetString(0));
                        alOdemeler[maOdemeler[index].Month - 1] = (float)Convert.ToDouble(myReader.GetString(1));
                        index++;
                    }
                }
                myReader.Close();
            }
            catch { myReader.Close(); }
            //-----------------------------------------------------------------------------------------------------------------
            //---------------------------------------------- ALINMIŞ ÖDEMELER -------------------------------------------------
            try
            {
                index = 0;
                mySqlCommand.CommandText = "SELECT fatura_vade_tarih,sum(fatura_euro) FROM db_faturalar where fatura_durum='ODENDI' and fatura_tipi='K' and fatura_proje_no='" + lbl_proje_no.Text + "'group by date_format(fatura_vade_tarih, '%m-%Y');";
                myReader = mySqlCommand.ExecuteReader();
                while (myReader.Read())
                {
                    if (Convert.ToDateTime(myReader.GetString(0)).Year == DateTime.Now.Year)
                    {
                        malinmisOdemeler[index] = Convert.ToDateTime(myReader.GetString(0));
                        alinmisOdemeler[malinmisOdemeler[index].Month - 1] = (float)Convert.ToDouble(myReader.GetString(1));
                        index++;
                    }
                }
                myReader.Close();
            }
            catch { myReader.Close(); }
            //-----------------------------------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------------------------------
            dgw_maliOzet.Rows.Add();
            dgw_maliOzet.Rows.Add();
            dgw_maliOzet.Rows.Add();
            dgw_maliOzet.Rows.Add();
            dgw_maliOzet.Rows.Add();
            dgw_maliOzet.Rows.Add();
            //-----------------------------------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------------------------------
            //-------------------------------------------------- FILL DGW -----------------------------------------------------
            float kumulatif_tutar = 100;

            for (int i = 0; i < 12; i++)
            {
                try
                {

                    dgw_maliOzet.Rows[0].Cells[i + 1].Value = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(verSip[i]));
                    dgw_maliOzet.Rows[1].Cells[i + 1].Value = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(yapOdemeler[i]));
                    dgw_maliOzet.Rows[2].Cells[i + 1].Value = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(yapilmisOdemeler[i]));
                    dgw_maliOzet.Rows[3].Cells[i + 1].Value = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(alOdemeler[i]));
                    dgw_maliOzet.Rows[4].Cells[i + 1].Value = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(alinmisOdemeler[i]));
                    dgw_maliOzet.Rows[5].Cells[i + 1].Value = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(alinmisOdemeler[i] - yapOdemeler[i] - yapilmisOdemeler[i] + alOdemeler[i]));

                    if (i == 0)
                    {
                        dgw_maliOzet.Rows[6].Cells[i + 1].Value = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(kumulatif_tutar + alinmisOdemeler[i] - yapOdemeler[i] - yapilmisOdemeler[i] + alOdemeler[i]));
                        kumulatif_tutar = kumulatif_tutar + alinmisOdemeler[i] - yapOdemeler[i] - yapilmisOdemeler[i] + alOdemeler[i];
                    }
                    else
                    {
                        dgw_maliOzet.Rows[6].Cells[i + 1].Value = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(kumulatif_tutar + alinmisOdemeler[i] - yapOdemeler[i] - yapilmisOdemeler[i] + alOdemeler[i]));
                        kumulatif_tutar = kumulatif_tutar + alinmisOdemeler[i] - yapOdemeler[i] - yapilmisOdemeler[i] + alOdemeler[i];
                    }


                }
                catch { }
            }

            dgw_maliOzet.Rows[0].Cells[0].Value = Convert.ToString("Verilecek Siparişler");
            dgw_maliOzet.Rows[1].Cells[0].Value = Convert.ToString("Tedarikçilere Yapılacak Ödemeler");
            dgw_maliOzet.Rows[2].Cells[0].Value = Convert.ToString("Tedarikçilere Yapılmış Ödemeler");
            dgw_maliOzet.Rows[3].Cells[0].Value = Convert.ToString("Alınacak Ödemeler");
            dgw_maliOzet.Rows[4].Cells[0].Value = Convert.ToString("Alınmış Ödemeler");
            dgw_maliOzet.Rows[5].Cells[0].Value = Convert.ToString("Aylık Toplam");
            dgw_maliOzet.Rows[6].Cells[0].Value = Convert.ToString("Kümülatif Toplam");
            //-----------------------------------------------------------------------------------------------------------------
            Firmalar();
        }

        public void Firmalar()
        {
            mySqlCommand.CommandText = "SELECT fatura_firma,sum(fatura_euro) from db_faturalar where fatura_cinsi='Elektronik' and fatura_tipi='G' and fatura_proje_no='" + lbl_proje_no.Text + "' group by fatura_firma order by sum(fatura_euro) DESC";
            MySqlDataReader myReader;
            myReader = mySqlCommand.ExecuteReader();
            while (myReader.Read())
            {
                if (processDone1 == false)
                {
                    switch (state)
                    {
                        case 0:
                            {
                                lbl_elfrm1.Text = Convert.ToString(myReader.GetString(0));
                                lbl_el1.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(myReader.GetString(1)));
                                state = 1;
                                break;
                            }
                        case 1:
                            {
                                lbl_elfrm2.Text = Convert.ToString(myReader.GetString(0));
                                lbl_el2.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(myReader.GetString(1)));
                                state = 2;
                                break;
                            }
                        case 2:
                            {
                                lbl_elfrm3.Text = Convert.ToString(myReader.GetString(0));
                                lbl_el3.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(myReader.GetString(1)));
                                state = 0;
                                processDone1 = true;
                                break;
                            }
                    }
                }
            }
            myReader.Close();
            processDone1 = false;

            mySqlCommand.CommandText = "SELECT fatura_firma,sum(fatura_euro) from db_faturalar where fatura_cinsi='Mekanik' and fatura_tipi='G' and fatura_proje_no='" + lbl_proje_no.Text + "' group by fatura_firma order by sum(fatura_euro) DESC";
            myReader = mySqlCommand.ExecuteReader();
            while (myReader.Read())
            {
                if (processDone1 == false)
                {
                    switch (state)
                    {
                        case 0:
                            {
                                lbl_mekfrm1.Text = Convert.ToString(myReader.GetString(0));
                                lbl_mek1.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(myReader.GetString(1)));
                                state = 1;
                                break;
                            }
                        case 1:
                            {
                                lbl_mekfrm2.Text = Convert.ToString(myReader.GetString(0));
                                lbl_mek2.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(myReader.GetString(1)));
                                state = 2;
                                break;
                            }
                        case 2:
                            {
                                lbl_mekfrm3.Text = Convert.ToString(myReader.GetString(0));
                                lbl_mek3.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(myReader.GetString(1)));
                                state = 0;
                                processDone1 = true;
                                break;
                            }
                    }
                }
            }

            myReader.Close();
            processDone1 = false;

            mySqlCommand.CommandText = "SELECT fatura_firma,sum(fatura_euro) from db_faturalar where fatura_cinsi='Genel Giderler' and fatura_tipi='G' and fatura_proje_no='" + lbl_proje_no.Text + "' group by fatura_firma order by sum(fatura_euro) DESC";
            myReader = mySqlCommand.ExecuteReader();
            while (myReader.Read())
            {
                if (processDone1 == false)
                {
                    switch (state)
                    {
                        case 0:
                            {
                                lbl_gnlfrm1.Text = Convert.ToString(myReader.GetString(0));
                                lbl_gnl1.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(myReader.GetString(1)));
                                state = 1;
                                break;
                            }
                        case 1:
                            {
                                lbl_gnlfrm2.Text = Convert.ToString(myReader.GetString(0));
                                lbl_gnl2.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(myReader.GetString(1)));
                                state = 2;
                                break;
                            }
                        case 2:
                            {
                                lbl_gnlfrm3.Text = Convert.ToString(myReader.GetString(0));
                                lbl_gnl3.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(myReader.GetString(1)));
                                state = 0;
                                processDone1 = true;
                                break;
                            }
                    }
                }
            }
            myReader.Close();
            mySqlConnection.Close();
        }
    }
}
