using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS482E
{
    public partial class Form1 : Form
    {
        private String text = "Gazi Üniversitesi Bilgisayar Mühendisliği Bölümünün vizyonu ulusal ve uluslararası alanda akademik mükemmelliğe ve pratik bilgiye önem vererek en yüksek kalitede lisans ve lisans üstü eğitim veren bir eğitim kurumu olarak tanınmaktır. Gazi Üniversitesi Bilgisayar Mühendisliği Bölümünün vizyonu ulusal ve uluslararası alanda akademik mükemmelliğe ve pratik bilgiye önem vererek en yüksek kalitede lisans ve lisans üstü eğitim veren bir eğitim kurumu.. Gazi Üniversitesi Bilgisayar Mühendisliği Bölümü";
        //This is your LAST CHANCE. After this, there is no turning back. You take the blue pill, the story ends. You wake up and believe whatever you want to believe. You take the red pill and you stay in wonderland, I show you just how deep the rabbit hole goes Remember. All I'm offering you is THE TRUTH : nothing more.
        private String newtext ;
        private int max = 500;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            lblkaraktersayisi.Text = max - textBox1.TextLength + " Karakter Kaldı";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newtext = String.Join("", text.Where(c => !char.IsWhiteSpace(c)));//boşlukları temizledik
            textBox1.Text = text;
            lblkaraktersayisi.Text = max - textBox1.TextLength + " Karakter Kaldı";
            cbdurum.SelectedIndex = 0;
            rbbosluklu.Checked = true;
            rbbosluksuz.Checked = false;
        }

        private void btnanaliz_Click(object sender, EventArgs e)
        {
            if (cbdurum.SelectedIndex == 0 )
            {
                double frekans;
                string analizedilecektext;// = textBox1.Text;
                if (rbbosluklu.Checked)
                {
                    analizedilecektext = textBox1.Text;
                }
                else
                {
                    analizedilecektext = String.Join("", textBox1.Text.Where(c => !char.IsWhiteSpace(c)));//boşlukları temizledik
                }
                var karakter = from c in analizedilecektext
                               group c by c into g
                               let count = g.Count()
                               orderby count descending
                               select new
                               {
                                   Value = g.Key,
                                   Count = count
                               };
                listView1.Items.Clear();
                foreach (var count in karakter)
                {
                    frekans = Convert.ToDouble(count.Count) / analizedilecektext.Length;
                    frekans = Math.Round(frekans, 5);
                    ListViewItem Liste = new ListViewItem();
                    //Liste.Tag = count;
                    Liste.Text = count.Value.ToString();
                    Liste.SubItems.Add(count.Count.ToString());
                    Liste.SubItems.Add((frekans * 100).ToString() + "%");
                    listView1.Items.Add(Liste);
                }
            }
            else if (cbdurum.SelectedIndex == 1)
            {
                double frekans;
                string analizedilecektext = textBox1.Text;
                var karakter = from c in analizedilecektext
                               group c by c into g
                               let count = g.Count()
                               orderby count ascending
                               select new
                               {
                                   Value = g.Key,
                                   Count = count
                               };
                //listView1.Clear();
                foreach (var count in karakter)
                {
                    frekans = Convert.ToDouble(count.Count) / analizedilecektext.Length;
                    frekans = Math.Round(frekans, 5);
                    ListViewItem Liste = new ListViewItem();
                    //Liste.Tag = count;
                    Liste.Text = count.Value.ToString();
                    Liste.SubItems.Add(count.Count.ToString());
                    Liste.SubItems.Add((frekans * 100).ToString() + "%");
                    listView1.Items.Add(Liste);
                }
            }

            else if (cbdurum.SelectedIndex == 2)
            {
                double frekans;
                string analizedilecektext;// = textBox1.Text;
                if (rbbosluklu.Checked)
                {
                    analizedilecektext = textBox1.Text;
                }
                else
                {
                    analizedilecektext = String.Join("", textBox1.Text.Where(c => !char.IsWhiteSpace(c)));//boşlukları temizledik
                }

                
                string[] letters = analizedilecektext.Select(c => c.ToString()).ToArray();
                listView1.Items.Clear();
                for (int i = 0; i < analizedilecektext.Length-1; i++)
                {
                    //Console.WriteLine(CommonCharacters(analizedilecektext.ToLower(), letters[i]+letters[i+1] ));
                    frekans = Convert.ToDouble(CommonCharacters(analizedilecektext.ToLower(), letters[i].ToLower() + letters[i + 1].ToLower())) / analizedilecektext.Length;
                    frekans = Math.Round(frekans, 5);
                    ListViewItem Liste = new ListViewItem();
                    Liste.Text = letters[i].ToLower() + letters[i + 1].ToLower();
                    Liste.SubItems.Add(CommonCharacters(analizedilecektext.ToLower(), letters[i].ToLower() + letters[i + 1].ToLower()).ToString());
                    Liste.SubItems.Add((frekans * 100).ToString() + "%");
                    listView1.Items.Add(Liste);
                }

                  
            }

            else if (cbdurum.SelectedIndex==3)
            {

            }

        }

        public int CommonCharacters(string s1, string s2)
        {
            // bool[] matchedFlag = new bool[s2.Length];
            int i = 0;

            for (int i1 = 0; i1 < s1.Length - 1; i1++)
            {
                for (int i2 = 0; i2 < s2.Length - 1; i2++)
                {
                    if (s1.ToCharArray()[i1] == s2.ToCharArray()[i2] && s1.ToCharArray()[i1 + 1] == s2.ToCharArray()[i2 + 1])
                    {
                        //matchedFlag[i2] = true;
                        //break;
                        i++;
                    }
                }
            }

            return i;
        }
    }
}
