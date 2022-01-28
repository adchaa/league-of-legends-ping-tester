
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;

namespace league_of_legends_ping_tester
{

    public partial class Form1 : Form
    {
        private int[] arrayofpings = new int[60];
        private SeriesCollection ping = new SeriesCollection();
        
        private Thread t;
        private bool clicked_before = false;
        private string currentping = "0";
        public Form1()
        {   

            
            InitializeComponent();
            

        }


        public void graphic_updater()
        {
            Ping p = new Ping();
            PingReply reply;
            int x;
            int max;
            int min;
            while (true)
            {
                Thread.Sleep(993);
                if (euw_radiobutton.Checked)
                {
                    reply = p.Send("riot.de");
                }
                else
                {
                    reply = p.Send("192.64.172.50");
                }

                if (reply.Status == IPStatus.Success)
                {
                    x = Convert.ToInt32(reply.RoundtripTime);
                    
                }
                else
                {
                    x = -100;
                }
                max = int.Parse(textBox_max.Text);
                min = int.Parse(textBox_min.Text);
                if (x > max)
                {
                    textBox_max.Invoke((MethodInvoker)delegate
                    {
                        textBox_max.Text = x.ToString();
                    });

                }
               
                if (x < min)
                {
                    textBox_min.Invoke((MethodInvoker)delegate
                    {
                        textBox_min.Text = x.ToString();
                    });

                }
                textBox_now.Invoke((MethodInvoker)delegate
                {
                    textBox_now.Text = x.ToString();
                });
                ping[0].Values.Add(x);
                ping[0].Values.RemoveAt(0);

            }
        }
        private void startbutton_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            startbutton.Enabled = false;
            button3.Enabled = false;
            euw_radiobutton.Enabled = false;
            na_radiobutton.Enabled = false;
            if (clicked_before)
            {
                t.Resume();
            }
            else
            {
                clicked_before = true;
                t.Start();
            }
       
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t = new Thread(graphic_updater);
            t.IsBackground = true;
            cartesianChart1.Series.Clear();
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis()
            {
                Title = "seconds",
                Labels = new[] {"60", "59" ,"58" , "57", "56", "55", "54", "53", "52", "51", "50", "49", "48", "47", "46", "45", "44", "43", "42", "41", "40", "39", "38" , "37" , "36" , "35" , "34" , "33" , "32" , "31" , "30" , "29" , "28" , "27" , "26" , "25" , "24" , "23" , "22" , "21" , "20" , "19" , "18" , "17" , "16" , "15" , "14" , "13" , "12" , "11" , "10" , "9" , "8" , "7" , "6" , "5" , "4" , "3", "2", "1" }
            });
            
            
            ping.Add(new LineSeries()
            {
                Title = "ping",
                Values = new ChartValues<int>(arrayofpings)
            });
            cartesianChart1.Series = ping;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t.Suspend();
            startbutton.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
            



        }

        private void button3_Click(object sender, EventArgs e)
        {
            clicked_before = false;
            euw_radiobutton.Enabled = true;
            na_radiobutton.Enabled = true;
            t = new Thread(graphic_updater);
            t.IsBackground = true;
            textBox_max.Text = "0";
            textBox_min.Text = "10000";
            textBox_now.Text = "0";
            cartesianChart1.Series.Clear();

            ping.Add(new LineSeries()
            {
                Title = "ping",
                Values = new ChartValues<int>(arrayofpings)
            });
            cartesianChart1.Series = ping;
        }

   

       
    }
}
