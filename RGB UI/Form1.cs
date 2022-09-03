using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace RGB_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader sr1 = new StreamReader(@"RGB Settings\Interval.txt"))
            {
                string chi = sr1.ReadToEnd();
                int x = int.Parse(chi);
                timer1.Interval = x;
                timer2.Interval = x;
                bunifuCustomTextbox1.Text = chi;
            }
            using (StreamReader sr = new StreamReader(@"RGB Settings\Mode.txt"))
            {
                if (sr.ReadToEnd() == "RGB Breath")
                {
                    timer1.Stop();
                    timer2.Start();
                    label2.Text = "1";
                    label5.Text = "Current RGB Mode : RGB Breath";
                }
                else
                {
                    timer2.Stop();
                    timer1.Start();
                    label2.Text = "1";
                    label5.Text = "Current RGB Mode : RGB Cycle";
                }
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            string x = label2.Text;
            if (x == "1")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 0);
                label1.BackColor = Color.FromArgb(0, Color.Transparent);
                button1.BackColor = Color.FromArgb(0, Color.Transparent);
                button2.BackColor = Color.FromArgb(0, Color.Transparent);
                label2.Text = "2";
            }
            if (x == "2")
            {
                panel1.BackColor = Color.FromArgb(255, 10, 0);
                label2.Text = "3";
            }
            if (x == "3")
            {
                panel1.BackColor = Color.FromArgb(255, 20, 0);
                label2.Text = "4";
            }
            if (x == "4")
            {
                panel1.BackColor = Color.FromArgb(255, 30, 0);
                label2.Text = "5";
            }
            if (x == "5")
            {
                panel1.BackColor = Color.FromArgb(255, 40, 0);
                label2.Text = "6";
            }
            if (x == "6")
            {
                panel1.BackColor = Color.FromArgb(255, 50, 0);
                label2.Text = "7";
            }
            if (x == "7")
            {
                panel1.BackColor = Color.FromArgb(255, 60, 0);
                label2.Text = "8";
            }
            if (x == "8")
            {
                panel1.BackColor = Color.FromArgb(255, 70, 0);
                label2.Text = "9";
            }
            if (x == "9")
            {
                panel1.BackColor = Color.FromArgb(255, 80, 0);
                label2.Text = "10";
            }
            if (x == "10")
            {
                panel1.BackColor = Color.FromArgb(255, 90, 0);
                label2.Text = "11";
            }
            if (x == "11")
            {
                panel1.BackColor = Color.FromArgb(255, 100, 0);
                label2.Text = "12";
            }
            if (x == "12")
            {
                panel1.BackColor = Color.FromArgb(255, 110, 0);
                label2.Text = "13";
            }
            if (x == "13")
            {
                panel1.BackColor = Color.FromArgb(255, 120, 0);
                label2.Text = "14";
            }
            if (x == "14")
            {
                panel1.BackColor = Color.FromArgb(255, 130, 0);
                label2.Text = "15";
            }
            if (x == "15")
            {
                panel1.BackColor = Color.FromArgb(255, 140, 0);
                label2.Text = "16";
            }
            if (x == "16")
            {
                panel1.BackColor = Color.FromArgb(255, 150, 0);
                label2.Text = "17";
            }
            if (x == "17")
            {
                panel1.BackColor = Color.FromArgb(255, 160, 0);
                label2.Text = "18";
            }
            if (x == "18")
            {
                panel1.BackColor = Color.FromArgb(255, 170, 0);
                label2.Text = "19";
            }
            if (x == "19")
            {
                panel1.BackColor = Color.FromArgb(255, 180, 0);
                label2.Text = "20";
            }
            if (x == "20")
            {
                panel1.BackColor = Color.FromArgb(255, 190, 0);
                label2.Text = "21";
            }
            if (x == "21")
            {
                panel1.BackColor = Color.FromArgb(255, 200, 0);
                label2.Text = "22";
            }
            if (x == "22")
            {
                panel1.BackColor = Color.FromArgb(255, 210, 0);
                label2.Text = "23";
            }
            if (x == "23")
            {
                panel1.BackColor = Color.FromArgb(255, 220, 0);
                label2.Text = "24";
            }
            if (x == "24")
            {
                panel1.BackColor = Color.FromArgb(255, 230, 0);
                label2.Text = "25";
            }
            if (x == "25")
            {
                panel1.BackColor = Color.FromArgb(255, 240, 0);
                label2.Text = "26";
            }
            if (x == "26")
            {
                panel1.BackColor = Color.FromArgb(255, 250, 0);
                label2.Text = "27";
            }
            if (x == "27")
            {
                panel1.BackColor = Color.FromArgb(255, 255, 0);
                label2.Text = "28";
            }
            if (x == "28")
            {
                panel1.BackColor = Color.FromArgb(250, 255, 0);
                label2.Text = "29";
            }
            if (x == "29")
            {
                panel1.BackColor = Color.FromArgb(240, 255, 0);
                label2.Text = "30";
            }
            if (x == "30")
            {
                panel1.BackColor = Color.FromArgb(230, 255, 0);
                label2.Text = "31";
            }
            if (x == "31")
            {
                panel1.BackColor = Color.FromArgb(220, 255, 0);
                label2.Text = "32";
            }
            if (x == "32")
            {
                panel1.BackColor = Color.FromArgb(210, 255, 0);
                label2.Text = "33";
            }
            if (x == "33")
            {
                panel1.BackColor = Color.FromArgb(200, 255, 0);
                label2.Text = "34";
            }
            if (x == "34")
            {
                panel1.BackColor = Color.FromArgb(190, 255, 0);
                label2.Text = "35";
            }
            if (x == "35")
            {
                panel1.BackColor = Color.FromArgb(180, 255, 0);
                label2.Text = "36";
            }
            if (x == "36")
            {
                panel1.BackColor = Color.FromArgb(170, 255, 0);
                label2.Text = "37";
            }
            if (x == "37")
            {
                panel1.BackColor = Color.FromArgb(160, 255, 0);
                label2.Text = "38";
            }
            if (x == "38")
            {
                panel1.BackColor = Color.FromArgb(150, 255, 0);
                label2.Text = "39";
            }
            if (x == "39")
            {
                panel1.BackColor = Color.FromArgb(140, 255, 0);
                label2.Text = "40";
            }
            if (x == "40")
            {
                panel1.BackColor = Color.FromArgb(130, 255, 0);
                label2.Text = "41";
            }
            if (x == "41")
            {
                panel1.BackColor = Color.FromArgb(120, 255, 0);
                label2.Text = "42";
            }
            if (x == "42")
            {
                panel1.BackColor = Color.FromArgb(110, 255, 0);
                label2.Text = "43";
            }
            if (x == "43")
            {
                panel1.BackColor = Color.FromArgb(100, 255, 0);
                label2.Text = "44";
            }
            if (x == "44")
            {
                panel1.BackColor = Color.FromArgb(90, 255, 0);
                label2.Text = "45";
            }
            if (x == "45")
            {
                panel1.BackColor = Color.FromArgb(80, 255, 0);
                label2.Text = "46";
            }
            if (x == "46")
            {
                panel1.BackColor = Color.FromArgb(70, 255, 0);
                label2.Text = "47";
            }
            if (x == "47")
            {
                panel1.BackColor = Color.FromArgb(60, 255, 0);
                label2.Text = "48";
            }
            if (x == "48")
            {
                panel1.BackColor = Color.FromArgb(50, 255, 0);
                label2.Text = "49";
            }
            if (x == "49")
            {
                panel1.BackColor = Color.FromArgb(40, 255, 0);
                label2.Text = "50";
            }
            if (x == "50")
            {
                panel1.BackColor = Color.FromArgb(30, 255, 0);
                label2.Text = "51";
            }
            if (x == "51")
            {
                panel1.BackColor = Color.FromArgb(20, 255, 0);
                label2.Text = "52";
            }
            if (x == "52")
            {
                panel1.BackColor = Color.FromArgb(10, 255, 0);
                label2.Text = "53";
            }
            if (x == "53")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 0);
                label2.Text = "54";
            }
            if (x == "54")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 10);
                label2.Text = "55";
            }
            if (x == "55")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 20);
                label2.Text = "56";
            }
            if (x == "56")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 30);
                label2.Text = "57";
            }
            if (x == "57")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 40);
                label2.Text = "58";
            }
            if (x == "58")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 50);
                label2.Text = "59";
            }
            if (x == "59")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 60);
                label2.Text = "60";
            }
            if (x == "60")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 70);
                label2.Text = "61";
            }
            if (x == "61")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 80);
                label2.Text = "62";
            }
            if (x == "62")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 90);
                label2.Text = "63";
            }
            if (x == "63")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 100);
                label2.Text = "64";
            }
            if (x == "64")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 110);
                label2.Text = "65";
            }
            if (x == "65")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 120);
                label2.Text = "66";
            }
            if (x == "66")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 130);
                label2.Text = "67";
            }
            if (x == "67")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 140);
                label2.Text = "68";
            }
            if (x == "68")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 150);
                label2.Text = "69";
            }
            if (x == "69")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 160);
                label2.Text = "70";
            }
            if (x == "70")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 170);
                label2.Text = "71";
            }
            if (x == "71")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 180);
                label2.Text = "72";
            }
            if (x == "72")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 190);
                label2.Text = "73";
            }
            if (x == "73")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 200);
                label2.Text = "74";
            }
            if (x == "74")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 210);
                label2.Text = "75";
            }
            if (x == "75")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 220);
                label2.Text = "76";
            }
            if (x == "76")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 230);
                label2.Text = "77";
            }
            if (x == "77")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 240);
                label2.Text = "78";
            }
            if (x == "78")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 250);
                label2.Text = "79";
            }
            if (x == "79")
            {
                panel1.BackColor = Color.FromArgb(0, 255, 255);
                label2.Text = "80";
            }
            if (x == "80")
            {
                panel1.BackColor = Color.FromArgb(0, 250, 255);
                label2.Text = "81";
            }
            if (x == "81")
            {
                panel1.BackColor = Color.FromArgb(0, 240, 255);
                label2.Text = "82";
            }
            if (x == "82")
            {
                panel1.BackColor = Color.FromArgb(0, 230, 255);
                label2.Text = "83";
            }
            if (x == "83")
            {
                panel1.BackColor = Color.FromArgb(0, 220, 255);
                label2.Text = "84";
            }
            if (x == "84")
            {
                panel1.BackColor = Color.FromArgb(0, 210, 255);
                label2.Text = "85";
            }
            if (x == "85")
            {
                panel1.BackColor = Color.FromArgb(0, 200, 255);
                label2.Text = "86";
            }
            if (x == "86")
            {
                panel1.BackColor = Color.FromArgb(0, 190, 255);
                label2.Text = "87";
            }
            if (x == "87")
            {
                panel1.BackColor = Color.FromArgb(0, 180, 255);
                label2.Text = "88";
            }
            if (x == "88")
            {
                panel1.BackColor = Color.FromArgb(0, 170, 255);
                label2.Text = "89";
            }
            if (x == "89")
            {
                panel1.BackColor = Color.FromArgb(0, 160, 255);
                label2.Text = "90";
            }
            if (x == "90")
            {
                panel1.BackColor = Color.FromArgb(0, 150, 255);
                label2.Text = "91";
            }
            if (x == "91")
            {
                panel1.BackColor = Color.FromArgb(0, 140, 255);
                label2.Text = "92";
            }
            if (x == "92")
            {
                panel1.BackColor = Color.FromArgb(0, 130, 255);
                label2.Text = "93";
            }
            if (x == "93")
            {
                panel1.BackColor = Color.FromArgb(0, 120, 255);
                label2.Text = "94";
            }
            if (x == "94")
            {
                panel1.BackColor = Color.FromArgb(0, 110, 255);
                label2.Text = "95";
            }
            if (x == "95")
            {
                panel1.BackColor = Color.FromArgb(0, 100, 255);
                label2.Text = "96";
            }
            if (x == "96")
            {
                panel1.BackColor = Color.FromArgb(0, 90, 255);
                label2.Text = "97";
            }
            if (x == "97")
            {
                panel1.BackColor = Color.FromArgb(0, 80, 255);
                label2.Text = "98";
            }
            if (x == "98")
            {
                panel1.BackColor = Color.FromArgb(0, 70, 255);
                label2.Text = "99";
            }
            if (x == "99")
            {
                panel1.BackColor = Color.FromArgb(0, 60, 255);
                label2.Text = "100";
            }
            if (x == "100")
            {
                panel1.BackColor = Color.FromArgb(0, 50, 255);
                label2.Text = "101";
            }
            if (x == "101")
            {
                panel1.BackColor = Color.FromArgb(0, 40, 255);
                label2.Text = "102";
            }
            if (x == "102")
            {
                panel1.BackColor = Color.FromArgb(0, 30, 255);
                label2.Text = "103";
            }
            if (x == "103")
            {
                panel1.BackColor = Color.FromArgb(0, 20, 255);
                label2.Text = "104";
            }
            if (x == "104")
            {
                panel1.BackColor = Color.FromArgb(0, 10, 255);
                label2.Text = "105";
            }
            if (x == "105")
            {
                panel1.BackColor = Color.FromArgb(0, 0, 255);
                label2.Text = "106";
            }
            if (x == "106")
            {
                panel1.BackColor = Color.FromArgb(10, 0, 255);
                label2.Text = "107";
            }
            if (x == "107")
            {
                panel1.BackColor = Color.FromArgb(20, 0, 255);
                label2.Text = "108";
            }
            if (x == "108")
            {
                panel1.BackColor = Color.FromArgb(30, 0, 255);
                label2.Text = "109";
            }
            if (x == "109")
            {
                panel1.BackColor = Color.FromArgb(40, 0, 255);
                label2.Text = "110";
            }
            if (x == "110")
            {
                panel1.BackColor = Color.FromArgb(50, 0, 255);
                label2.Text = "111";
            }
            if (x == "111")
            {
                panel1.BackColor = Color.FromArgb(60, 0, 255);
                label2.Text = "112";
            }
            if (x == "112")
            {
                panel1.BackColor = Color.FromArgb(70, 0, 255);
                label2.Text = "113";
            }
            if (x == "113")
            {
                panel1.BackColor = Color.FromArgb(80, 0, 255);
                label2.Text = "114";
            }
            if (x == "114")
            {
                panel1.BackColor = Color.FromArgb(90, 0, 255);
                label2.Text = "115";
            }
            if (x == "115")
            {
                panel1.BackColor = Color.FromArgb(100, 0, 255);
                label2.Text = "116";
            }
            if (x == "116")
            {
                panel1.BackColor = Color.FromArgb(110, 0, 255);
                label2.Text = "117";
            }
            if (x == "117")
            {
                panel1.BackColor = Color.FromArgb(120, 0, 255);
                label2.Text = "118";
            }
            if (x == "118")
            {
                panel1.BackColor = Color.FromArgb(130, 0, 255);
                label2.Text = "119";
            }
            if (x == "119")
            {
                panel1.BackColor = Color.FromArgb(140, 0, 255);
                label2.Text = "120";
            }
            if (x == "120")
            {
                panel1.BackColor = Color.FromArgb(150, 0, 255);
                label2.Text = "121";
            }
            if (x == "121")
            {
                panel1.BackColor = Color.FromArgb(160, 0, 255);
                label2.Text = "122";
            }
            if (x == "122")
            {
                panel1.BackColor = Color.FromArgb(170, 0, 255);
                label2.Text = "123";
            }
            if (x == "123")
            {
                panel1.BackColor = Color.FromArgb(180, 0, 255);
                label2.Text = "124";
            }
            if (x == "124")
            {
                panel1.BackColor = Color.FromArgb(190, 0, 255);
                label2.Text = "125";
            }
            if (x == "125")
            {
                panel1.BackColor = Color.FromArgb(200, 0, 255);
                label2.Text = "126";
            }
            if (x == "126")
            {
                panel1.BackColor = Color.FromArgb(210, 0, 255);
                label2.Text = "127";
            }
            if (x == "127")
            {
                panel1.BackColor = Color.FromArgb(220, 0, 255);
                label2.Text = "128";
            }
            if (x == "128")
            {
                panel1.BackColor = Color.FromArgb(230, 0, 255);
                label2.Text = "129";
            }
            if (x == "129")
            {
                panel1.BackColor = Color.FromArgb(240, 0, 255);
                label2.Text = "130";
            }
            if (x == "130")
            {
                panel1.BackColor = Color.FromArgb(250, 0, 255);
                label2.Text = "131";
            }
            if (x == "131")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 255);
                label2.Text = "132";
            }
            if (x == "132")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 250);
                label2.Text = "133";
            }
            if (x == "133")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 240);
                label2.Text = "134";
            }
            if (x == "134")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 230);
                label2.Text = "135";
            }
            if (x == "135")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 220);
                label2.Text = "136";
            }
            if (x == "136")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 210);
                label2.Text = "137";
            }
            if (x == "137")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 200);
                label2.Text = "138";
            }
            if (x == "138")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 190);
                label2.Text = "139";
            }
            if (x == "139")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 180);
                label2.Text = "140";
            }
            if (x == "140")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 170);
                label2.Text = "141";
            }
            if (x == "141")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 160);
                label2.Text = "142";
            }
            if (x == "142")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 150);
                label2.Text = "143";
            }
            if (x == "143")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 140);
                label2.Text = "144";
            }
            if (x == "144")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 130);
                label2.Text = "145";
            }
            if (x == "145")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 120);
                label2.Text = "146";
            }
            if (x == "146")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 110);
                label2.Text = "147";
            }
            if (x == "147")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 100);
                label2.Text = "148";
            }
            if (x == "148")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 90);
                label2.Text = "149";
            }
            if (x == "149")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 80);
                label2.Text = "150";
            }
            if (x == "150")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 70);
                label2.Text = "151";
            }
            if (x == "151")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 60);
                label2.Text = "152";
            }
            if (x == "152")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 50);
                label2.Text = "153";
            }
            if (x == "153")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 40);
                label2.Text = "154";
            }
            if (x == "154")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 30);
                label2.Text = "155";
            }
            if (x == "155")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 20);
                label2.Text = "156";
            }
            if (x == "156")
            {
                panel1.BackColor = Color.FromArgb(255, 0, 10);
                label2.Text = "1";
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (label3.Text == "1")
            {
                Size = new Size(481, 360);
                Thread.Sleep(12);
                Size = new Size(481, 340);
                Thread.Sleep(12);
                Size = new Size(481, 320);
                Thread.Sleep(12);
                Size = new Size(481, 300);
                Thread.Sleep(12);
                Size = new Size(481, 280);
                Thread.Sleep(12);
                Size = new Size(481, 260);
                Thread.Sleep(12);
                Size = new Size(481, 240);
                Thread.Sleep(12);
                Size = new Size(481, 220);
                Thread.Sleep(12);
                Size = new Size(481, 200);
                Thread.Sleep(12);
                Size = new Size(481, 180);
                Thread.Sleep(12);
                Size = new Size(481, 160);
                Thread.Sleep(12);
                Size = new Size(481, 140);
                Thread.Sleep(12);
                Size = new Size(481, 120);
                Thread.Sleep(12);
                Size = new Size(481, 100);
                Thread.Sleep(12);
                Size = new Size(481, 80);
                Thread.Sleep(12);
                Size = new Size(481, 60);
                Thread.Sleep(12);
                Size = new Size(481, 40);
                Thread.Sleep(12);
                Size = new Size(481, 30);
                label3.Text = "2";
            }
            else
            {
                Size = new Size(481, 30);
                Thread.Sleep(12);
                Size = new Size(481, 40);
                Thread.Sleep(12);
                Size = new Size(481, 60);
                Thread.Sleep(12);
                Size = new Size(481, 80);
                Thread.Sleep(12);
                Size = new Size(481, 100);
                Thread.Sleep(12);
                Size = new Size(481, 120);
                Thread.Sleep(12);
                Size = new Size(481, 140);
                Thread.Sleep(12);
                Size = new Size(481, 160);
                Thread.Sleep(12);
                Size = new Size(481, 180);
                Thread.Sleep(12);
                Size = new Size(481, 200);
                Thread.Sleep(12);
                Size = new Size(481, 220);
                Thread.Sleep(12);
                Size = new Size(481, 240);
                Thread.Sleep(12);
                Size = new Size(481, 260);
                Thread.Sleep(12);
                Size = new Size(481, 280);
                Thread.Sleep(12);
                Size = new Size(481, 300);
                Thread.Sleep(12);
                Size = new Size(481, 320);
                Thread.Sleep(12);
                Size = new Size(481, 340);
                Thread.Sleep(12);
                Size = new Size(481, 360);
                label3.Text = "1";
            }
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(bunifuSlider1.Value, bunifuSlider2.Value, bunifuSlider3.Value);
            label6.Text = "Current Breath Colour : " + bunifuSlider1.Value + "," + bunifuSlider2.Value + "," + bunifuSlider3.Value;
        }

        private void bunifuSlider2_ValueChanged(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(bunifuSlider1.Value, bunifuSlider2.Value, bunifuSlider3.Value);
            label6.Text = "Current Breath Colour : " + bunifuSlider1.Value + "," + bunifuSlider2.Value + "," + bunifuSlider3.Value;
        }

        private void bunifuSlider3_ValueChanged(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(bunifuSlider1.Value, bunifuSlider2.Value, bunifuSlider3.Value);
            label6.Text = "Current Breath Colour : " + bunifuSlider1.Value + "," + bunifuSlider2.Value + "," + bunifuSlider3.Value;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "1";
            string interval = bunifuCustomTextbox1.Text;
            File.WriteAllText(@"RGB Settings\Interval.txt", interval);
            if (label5.Text == "Current RGB Mode : RGB Cycle")
            {
                File.WriteAllText(@"RGB Settings\Mode.txt", "RGB Cycle");
            }
            else
            {
                File.WriteAllText(@"RGB Settings\Mode.txt", "RGB Breath");
            }
            string r1 = bunifuSlider1.Value.ToString();
            string g1 = bunifuSlider2.Value.ToString();
            string b1 = bunifuSlider3.Value.ToString();
            File.WriteAllText(@"RGB Settings\RGB Breath\R.txt", r1);
            File.WriteAllText(@"RGB Settings\RGB Breath\G.txt", g1);
            File.WriteAllText(@"RGB Settings\RGB Breath\B.txt", b1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "Current RGB Mode : RGB Cycle";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = "Current RGB Mode : RGB Breath";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"RGB Settings\RGB Breath\R.txt"))
            {
                int r3 = int.Parse(sr.ReadToEnd());
                using (StreamReader sr1 = new StreamReader(@"RGB Settings\RGB Breath\G.txt"))
                {
                    int g3 = int.Parse(sr1.ReadToEnd());
                    using (StreamReader sr11 = new StreamReader(@"RGB Settings\RGB Breath\B.txt"))
                    {
                        int b3 = int.Parse(sr11.ReadToEnd());
                        string x = label2.Text;
                        if (x == "1")
                        {
                            int c = 255;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "2";
                        }
                        if (x == "2")
                        {
                            int c = 250;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "3";
                        }
                        if (x == "3")
                        {
                            int c = 240;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "4";
                        }
                        if (x == "4")
                        {
                            int c = 230;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "5";
                        }
                        if (x == "5")
                        {
                            int c = 220;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "6";
                        }
                        if (x == "6")
                        {
                            int c = 210;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "7";
                        }
                        if (x == "7")
                        {
                            int c = 200;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "8";
                        }
                        if (x == "8")
                        {
                            int c = 190;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "9";
                        }
                        if (x == "9")
                        {
                            int c = 180;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "10";
                        }
                        if (x == "10")
                        {
                            int c = 170;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "11";
                        }
                        if (x == "11")
                        {
                            int c = 160;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "12";
                        }
                        if (x == "12")
                        {
                            int c = 150;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "13";
                        }
                        if (x == "13")
                        {
                            int c = 140;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "14";
                        }
                        if (x == "14")
                        {
                            int c = 130;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "15";
                        }
                        if (x == "15")
                        {
                            int c = 120;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "16";
                        }
                        if (x == "16")
                        {
                            int c = 110;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "17";
                        }
                        if (x == "17")
                        {
                            int c = 100;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "18";
                        }
                        if (x == "18")
                        {
                            int c = 90;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "19";
                        }
                        if (x == "19")
                        {
                            int c = 80;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "20";
                        }
                        if (x == "20")
                        {
                            int c = 70;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "21";
                        }
                        if (x == "21")
                        {
                            int c = 60;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "22";
                        }
                        if (x == "22")
                        {
                            int c = 50;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "23";
                        }
                        if (x == "23")
                        {
                            int c = 40;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "24";
                        }
                        if (x == "24")
                        {
                            int c = 30;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "25";
                        }
                        if (x == "25")
                        {
                            int c = 20;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "26";
                        }
                        if (x == "26")
                        {
                            int c = 10;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "27";
                        }
                        if (x == "27")
                        {
                            int c = 0;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "28";
                        }
                        if (x == "28")
                        {
                            int c = 10;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "29";
                        }
                        if (x == "29")
                        {
                            int c = 20;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "30";
                        }
                        if (x == "30")
                        {
                            int c = 30;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "31";
                        }
                        if (x == "31")
                        {
                            int c = 40;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "32";
                        }
                        if (x == "32")
                        {
                            int c = 40;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "33";
                        }
                        if (x == "33")
                        {
                            int c = 50;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "34";
                        }
                        if (x == "34")
                        {
                            int c = 60;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "35";
                        }
                        if (x == "35")
                        {
                            int c = 70;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "36";
                        }
                        if (x == "36")
                        {
                            int c = 80;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "37";
                        }
                        if (x == "37")
                        {
                            int c = 90;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "38";
                        }
                        if (x == "38")
                        {
                            int c = 100;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "39";
                        }
                        if (x == "39")
                        {
                            int c = 110;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "40";
                        }
                        if (x == "40")
                        {
                            int c = 120;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "41";
                        }
                        if (x == "41")
                        {
                            int c = 130;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "42";
                        }
                        if (x == "42")
                        {
                            int c = 140;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "43";
                        }
                        if (x == "43")
                        {
                            int c = 150;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "44";
                        }
                        if (x == "44")
                        {
                            int c = 160;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "45";
                        }
                        if (x == "45")
                        {
                            int c = 170;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "46";
                        }
                        if (x == "46")
                        {
                            int c = 180;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "47";
                        }
                        if (x == "47")
                        {
                            int c = 190;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "48";
                        }
                        if (x == "48")
                        {
                            int c = 200;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "49";
                        }
                        if (x == "49")
                        {
                            int c = 210;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "50";
                        }
                        if (x == "50")
                        {
                            int c = 220;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "51";
                        }
                        if (x == "51")
                        {
                            int c = 230;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "52";
                        }
                        if (x == "52")
                        {
                            int c = 240;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "53";
                        }
                        if (x == "53")
                        {
                            int c = 250;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "54";
                        }
                        if (x == "54")
                        {
                            int c = 255;
                            panel1.BackColor = Color.FromArgb(c, r3, g3, b3);
                            label1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button1.BackColor = Color.FromArgb(0, r3, g3, b3);
                            button2.BackColor = Color.FromArgb(0, r3, g3, b3);
                            label2.Text = "1";
                        }
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (StreamReader sr1 = new StreamReader(@"RGB Settings\Interval.txt"))
            {
                string chi = sr1.ReadToEnd();
                int x = int.Parse(chi);
                timer1.Interval = x;
                timer2.Interval = x;
                bunifuCustomTextbox1.Text = chi;
            }
            using (StreamReader sr = new StreamReader(@"RGB Settings\Mode.txt"))
            {
                if (sr.ReadToEnd() == "RGB Breath")
                {
                    timer1.Stop();
                    timer2.Start();
                    label2.Text = "1";
                }
                else
                {
                    timer2.Stop();
                    timer1.Start();
                    label2.Text = "1";
                }
            }
        }
    }
}
