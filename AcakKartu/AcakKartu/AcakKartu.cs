using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcakKartu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kartuAwal();
        }

        public int[] kartu()
        {
            int[] kartu = new int[52];
            for (int i = 0; i < 52; i++)
            {
                kartu[i] = i + 1;
            }
            return kartu;
        }

        public void kartuAwal()
        {
            String[] kartuString = Array.ConvertAll(kartu(), k => k.ToString());
            kartu1.Text = kartuString[0];
            kartu2.Text = kartuString[1];
            kartu3.Text = kartuString[2];
            kartu4.Text = kartuString[3];
            kartu5.Text = kartuString[4];
            kartu6.Text = kartuString[5];
            kartu7.Text = kartuString[6];
            kartu8.Text = kartuString[7];
            kartu9.Text = kartuString[8];
            kartu10.Text = kartuString[9];
            kartu11.Text = kartuString[10];
            kartu12.Text = kartuString[11];
            kartu13.Text = kartuString[12];
            kartu14.Text = kartuString[13];
            kartu15.Text = kartuString[14];
            kartu16.Text = kartuString[15];
            kartu17.Text = kartuString[16];
            kartu18.Text = kartuString[17];
            kartu19.Text = kartuString[18];
            kartu20.Text = kartuString[19];
            kartu21.Text = kartuString[20];
            kartu22.Text = kartuString[21];
            kartu23.Text = kartuString[22];
            kartu24.Text = kartuString[23];
            kartu25.Text = kartuString[24];
            kartu26.Text = kartuString[25];
            kartu27.Text = kartuString[26];
            kartu28.Text = kartuString[27];
            kartu29.Text = kartuString[28];
            kartu30.Text = kartuString[29];
            kartu31.Text = kartuString[30];
            kartu32.Text = kartuString[31];
            kartu33.Text = kartuString[32];
            kartu34.Text = kartuString[33];
            kartu35.Text = kartuString[34];
            kartu36.Text = kartuString[35];
            kartu37.Text = kartuString[36];
            kartu38.Text = kartuString[37];
            kartu39.Text = kartuString[38];
            kartu40.Text = kartuString[39];
            kartu41.Text = kartuString[40];
            kartu42.Text = kartuString[41];
            kartu43.Text = kartuString[42];
            kartu44.Text = kartuString[43];
            kartu45.Text = kartuString[44];
            kartu46.Text = kartuString[45];
            kartu47.Text = kartuString[46];
            kartu48.Text = kartuString[47];
            kartu49.Text = kartuString[48];
            kartu50.Text = kartuString[49];
            kartu51.Text = kartuString[50];
            kartu52.Text = kartuString[51];
        }
        
        private void btnAcak_Click(object sender, EventArgs e)
        {
            int[] kartuAcak = kartu().OrderBy(k => Guid.NewGuid()).ToArray();
            String[] kartuString = Array.ConvertAll(kartuAcak, k => k.ToString());
            kartu1.Text = kartuString[0];
            kartu2.Text = kartuString[1];
            kartu3.Text = kartuString[2];
            kartu4.Text = kartuString[3];
            kartu5.Text = kartuString[4];
            kartu6.Text = kartuString[5];
            kartu7.Text = kartuString[6];
            kartu8.Text = kartuString[7];
            kartu9.Text = kartuString[8];
            kartu10.Text = kartuString[9];
            kartu11.Text = kartuString[10];
            kartu12.Text = kartuString[11];
            kartu13.Text = kartuString[12];
            kartu14.Text = kartuString[13];
            kartu15.Text = kartuString[14];
            kartu16.Text = kartuString[15];
            kartu17.Text = kartuString[16];
            kartu18.Text = kartuString[17];
            kartu19.Text = kartuString[18];
            kartu20.Text = kartuString[19];
            kartu21.Text = kartuString[20];
            kartu22.Text = kartuString[21];
            kartu23.Text = kartuString[22];
            kartu24.Text = kartuString[23];
            kartu25.Text = kartuString[24];
            kartu26.Text = kartuString[25];
            kartu27.Text = kartuString[26];
            kartu28.Text = kartuString[27];
            kartu29.Text = kartuString[28];
            kartu30.Text = kartuString[29];
            kartu31.Text = kartuString[30];
            kartu32.Text = kartuString[31];
            kartu33.Text = kartuString[32];
            kartu34.Text = kartuString[33];
            kartu35.Text = kartuString[34];
            kartu36.Text = kartuString[35];
            kartu37.Text = kartuString[36];
            kartu38.Text = kartuString[37];
            kartu39.Text = kartuString[38];
            kartu40.Text = kartuString[39];
            kartu41.Text = kartuString[40];
            kartu42.Text = kartuString[41];
            kartu43.Text = kartuString[42];
            kartu44.Text = kartuString[43];
            kartu45.Text = kartuString[44];
            kartu46.Text = kartuString[45];
            kartu47.Text = kartuString[46];
            kartu48.Text = kartuString[47];
            kartu49.Text = kartuString[48];
            kartu50.Text = kartuString[49];
            kartu51.Text = kartuString[50];
            kartu52.Text = kartuString[51];
        }

        private void btnSembunyikan_Click(object sender, EventArgs e)
        {
            kartu1.Text = "";
            kartu2.Text = "";
            kartu3.Text = "";
            kartu4.Text = "";
            kartu5.Text = "";
            kartu6.Text = "";
            kartu7.Text = "";
            kartu8.Text = "";
            kartu9.Text = "";
            kartu10.Text = "";
            kartu11.Text = "";
            kartu12.Text = "";
            kartu13.Text = "";
            kartu14.Text = "";
            kartu15.Text = "";
            kartu16.Text = "";
            kartu17.Text = "";
            kartu18.Text = "";
            kartu19.Text = "";
            kartu20.Text = "";
            kartu21.Text = "";
            kartu22.Text = "";
            kartu23.Text = "";
            kartu24.Text = "";
            kartu25.Text = "";
            kartu26.Text = "";
            kartu27.Text = "";
            kartu28.Text = "";
            kartu29.Text = "";
            kartu30.Text = "";
            kartu31.Text = "";
            kartu32.Text = "";
            kartu33.Text = "";
            kartu34.Text = "";
            kartu35.Text = "";
            kartu36.Text = "";
            kartu37.Text = "";
            kartu38.Text = "";
            kartu39.Text = "";
            kartu40.Text = "";
            kartu41.Text = "";
            kartu42.Text = "";
            kartu43.Text = "";
            kartu44.Text = "";
            kartu45.Text = "";
            kartu46.Text = "";
            kartu47.Text = "";
            kartu48.Text = "";
            kartu49.Text = "";
            kartu50.Text = "";
            kartu51.Text = "";
            kartu52.Text = "";
        }
    }
}
