using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Threading;
using System.Runtime.InteropServices; //para las DllImport("user32.dll")
using System.IO;

namespace Lenovo_G485_bateria_check
{
    public partial class Form1 : Form
    {
       
        public int lbl_bat_estado;
        public int voltaje_bat;
        public int voltaje;
        public int f;
        public int count = 0;
        public int count1 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                bateria();
                Thread.Sleep(2000);
                if (File.Exists(@"log_ok\bat_cargando.txt")&& (File.Exists(@"log_ok\bat_descargando.txt")))
                {
                    File.Delete(@"log_ok\bat_cargando.txt");
                     File.Delete(@"log_ok\bat_descargando.txt");

                }
                           
                 
        }
       
        private void check_carga_bateria()
        {
            voltaje_bat = Convert.ToInt32(lbl_bat.Text);
            voltaje = Convert.ToInt32(lbl_bat_actualiza.Text);
            //int voltaje = Convert.ToInt32(lbl_bat.Text);
            if (voltaje > (voltaje_bat ))
            {
                lbl_carga_bat.Text = "Chequeando";
            }
            if ((voltaje  + 20) < (voltaje_bat))
            { lbl_carga_bat.Text = "OK";
            timer_carga.Enabled = false;
            timer_car.Enabled = false;
            }

        }
        private void check_descarga_bateria()
        {
            voltaje_bat = Convert.ToInt32(lbl_bat.Text);
            voltaje = Convert.ToInt32(lbl_bat_actualiza.Text);
            //int voltaje = Convert.ToInt32(lbl_bat.Text);
            if (voltaje < (voltaje_bat))
            {
                lbl_descarga_bat.Text = "Chequeando";
            }
            if ((voltaje - 20 ) > (voltaje_bat))
            { lbl_descarga_bat.Text = "OK";
            //timer_descarga.Enabled = false;
                timer_des.Enabled = false;
            //MessageBox.Show("conecte el cargador");
            }
            if (lbl_bat_status.Text == "2")
            {
                timer_carga.Enabled = true;

                check_carga_bateria();
            }

        }
        public void bateria_voltaje()
        {
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Battery");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    lbl_bat_actualiza.Text = queryObj["DesignVoltage"].ToString();
                    voltaje = Convert.ToInt32(lbl_bat_actualiza.Text);
                    //lbl_bat_actualiza.Text = voltaje.ToString();

                }
            }
            catch (ManagementException e)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + e.Message);
            }
        }
        public void bateria()
        {
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Battery");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    lbl_level_bat.Text = queryObj["EstimatedChargeRemaining"].ToString();
                    lbl_bat.Text = queryObj["DesignVoltage"].ToString();
                    lbl_bat_status.Text = queryObj["BatteryStatus"].ToString();
                    f = Convert.ToInt32(lbl_level_bat.Text);

                    //MessageBox.Show(f.ToString());
                    string bat_1 = (@"..\..\Resources\bat_1.png");
                    string bat_2 = (@"..\..\Resources\bat_2.png");
                    string bat_3 = (@"..\..\Resources\bat_3.png");
                    string bat_4 = (@"..\..\Resources\bat_4.png");
                    string bat_5 = (@"..\..\Resources\bat_5.png");
                    string bat_6 = (@"..\..\Resources\bat_6.png");
                    string bat_7 = (@"..\..\Resources\bat_7.png");
                    string bat_8 = (@"..\..\Resources\bat_8.png");
                    string bat_9 = (@"..\..\Resources\bat_9.png");
                    string bat_10 = (@"..\..\Resources\bat_10.png");
                    string bat_11 = (@"..\..\Resources\bat_11.png");
                    string bat_12 = @"..\..\Resources\bat_12.png";

                    
                    if (f <= 5)
                    { pic_bat.Load(bat_1);}
                    if ((f >= 6) && (f <= 12))
                    { pic_bat.Load(bat_2);  }
                    if ((f >= 13) && (f <= 20))
                    { pic_bat.Load(bat_3); }
                    if ((f >= 21) && (f <= 30))
                    { pic_bat.Load(bat_4); }
                    if ((f >= 31) && (f <= 40))
                    { pic_bat.Load(bat_5); }
                    if ((f >= 41) && (f <= 50))
                    { pic_bat.Load(bat_6); }
                    if ((f >= 51) && (f <= 60))
                    { pic_bat.Load(bat_7); }
                    if ((f >= 61) && (f <= 67))
                    { pic_bat.Load(bat_8); }
                    if ((f >= 68) && (f <= 75))
                    { pic_bat.Load(bat_9); }
                    if ((f >= 76) && (f <= 85))
                    { pic_bat.Load(bat_10); }
                    if ((f >= 86) && (f <= 94))
                    { pic_bat.Load(bat_11);  }
                    if ((f >= 95) && (f <= 100))
                    { pic_bat.Load(bat_12);  }

                }
            }
            catch (ManagementException e)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + e.Message);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            check_descarga_bateria();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check_carga_bateria();
        }

        private void timer_bateria_Tick(object sender, EventArgs e)
        {
            bateria();
           
        }

        private void timer_carga_Tick(object sender, EventArgs e)
        {
            if (lbl_bat_status.Text == "2")
            {

                bateria();
                bateria_voltaje();
                
                timer_carga.Stop();
                timer_car.Enabled = true;



            }
        }

        private void timer_descarga_Tick(object sender, EventArgs e)
        {
            if (lbl_bat_status.Text == "1")
            {

                bateria_voltaje();
                
                timer_descarga.Stop();


            }
        }

        private void timer_des_Tick(object sender, EventArgs e)
        {
            check_descarga_bateria();
        }

        private void timer_car_Tick(object sender, EventArgs e)
        {
            check_carga_bateria();
        }

        private void timer_check_Tick(object sender, EventArgs e)
        {
            if ((lbl_descarga_bat.Text == "OK") && (lbl_carga_bat.Text == "OK"))
            {
                TextWriter unidad = new StreamWriter(@"log_ok\bat_ok.txt");
                unidad.Close();
            }
        }

        private void timer_reporta_estado_Tick(object sender, EventArgs e)
        {
            if (lbl_bat_status.Text == "1")
            {
                
                TextWriter descargando = new StreamWriter(@"log_ok\bat_descargando.txt");
                descargando.Close();

               
            }
            else
            {
                if (lbl_bat_status.Text == "2")
                {
                   
                    TextWriter cargando = new StreamWriter(@"log_ok\bat_cargando.txt");
                    cargando.Close();

                  
                }
            }
        }

        private void t_uno_Tick(object sender, EventArgs e)
        {
            if (lbl_bat_status.Text == "1")
            {
                
                TextWriter descargando = new StreamWriter(@"log_ok\bat_descargando.txt");
                descargando.Close();
                lbl_descarga_bat.Text = "OK";
                t_uno.Enabled = false;
                /*
                     
                timer_descarga.Enabled = true;
                check_descarga_bateria();*/
            }
        }

        private void t_dos_Tick(object sender, EventArgs e)
        {
             
                    if (lbl_bat_status.Text == "2")
                    {
                      
                        TextWriter cargando = new StreamWriter(@"log_ok\bat_cargando.txt");
                        cargando.Close();
                        lbl_carga_bat.Text = "OK";
                        t_dos.Enabled = false;
                    /*
                        timer_carga.Enabled = true;
                        check_descarga_bateria();
                     */ 
                    }
                
        }

       
    }
}
