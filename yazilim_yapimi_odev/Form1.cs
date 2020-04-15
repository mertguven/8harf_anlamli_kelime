using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace yazilim_yapimi_odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        tdk_kelimeEntities ent = new tdk_kelimeEntities();//entity framework nesnesi oluşturuluyor
        Random rastgele = new Random();
        ArrayList eleman = new ArrayList();
        char[] dizi = { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };
        string metin = "";
        char[] karakterler = new char[8];
        string[] harfler = new string[8];
        int harfyeri;
        string x;
        int r = 3;//Kombinasyon 3'ten başlayacak örn: 8'in 3'lüsü

        private void rastgeleBtn_Click(object sender, EventArgs e)//Sayıların random atandığı yer
        {
            MessageBox.Show("Bu işlem biraz uzun sürebilir!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            harflerTxt.Text = "";
            for (int i = 0; i < 8; i++) {
                harfyeri = rastgele.Next(0, dizi.Length);
                karakterler[i] = dizi[harfyeri];
                harflerTxt.Text += karakterler[i].ToString();
            }
            OrtakIslem();
        }

        private void kelimeEkleBtn_Click(object sender, EventArgs e)//listbox1'e harflerin olabilecek bütün karmasını yazar
        {
            MessageBox.Show("Bu işlem biraz uzun sürebilir!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            metin = harflerTxt.Text;
            karakterler = metin.ToCharArray();
            for (int i = 0; i < 8; i++)
            {
                harfler[i] = karakterler[i].ToString();
            }
            //8'in 3lü kombinasyonundan başlayarak 8'in 8li kombinasyonuna kadar gidiyor
            OrtakIslem();
        }

        private void veriCekBtn_Click(object sender, EventArgs e)//Entity framework kullanarak veritabanından kelimeleri çeker
        {
            string kelime;
            var liste = from k in ent.kelimeler
                        orderby k.words ascending
                        select new {
                        kelime = k.words
                        };

            dataGridView1.DataSource = liste.ToList();
        }

        private void listeleBtn_Click(object sender, EventArgs e)//Listbox1 ve Datagridviewdaki verileri tek tek karşılaştırır aynı olanları Listbox3'e atar
        {
            listBox3.Items.Clear();
            int listesayisi1 = int.Parse(listBox1.Items.Count.ToString());
            int verilistesayisi = int.Parse(dataGridView1.RowCount.ToString());

            for (int i=0; i < listesayisi1; i++) {
                for (int j=0; j < verilistesayisi; j++) {
                    if (listBox1.Items[i].ToString() == dataGridView1.Rows[j].Cells["kelime"].Value.ToString()) 
                    {
                        string veri = listBox1.Items[i].ToString();
                        int c = veri.Count();
                        switch (c) {
                            case 3:
                                listBox3.Items.Add(dataGridView1.Rows[j].Cells["kelime"].Value.ToString() + ": 3 PUAN");
                                break;
                            case 4:
                                listBox3.Items.Add(dataGridView1.Rows[j].Cells["kelime"].Value.ToString() + ": 4 PUAN");
                                break;
                            case 5:
                                listBox3.Items.Add(dataGridView1.Rows[j].Cells["kelime"].Value.ToString() + ": 5 PUAN");
                                break;
                            case 6:
                                listBox3.Items.Add(dataGridView1.Rows[j].Cells["kelime"].Value.ToString() + ": 7 PUAN");
                                break;
                            case 7:
                                listBox3.Items.Add(dataGridView1.Rows[j].Cells["kelime"].Value.ToString() + ": 9 PUAN");
                                break;
                            case 8:
                                listBox3.Items.Add(dataGridView1.Rows[j].Cells["kelime"].Value.ToString() + ": 11 PUAN");
                                break; 
                        }
                    }
                }
            }
            if (listBox3.Items.Count > 0)
            {
                MessageBox.Show("Anlamlı kelimeler listelendi!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veritabanında anlamlı kelime bulunamadı!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yeniOyunBtn_Click(object sender, EventArgs e)//Her şeyi sıfırlar
        {
            listBox1.Items.Clear();
            listBox3.Items.Clear();
            dataGridView1.DataSource = null;
            harflerTxt.Text = "";
        }

        public void AyniOlanlariSil()
        {
            foreach (string item in listBox1.Items) //listBox1 deki itemları tek tek dolaş ve bunların adına item de.
            {
                if (eleman.Contains(item) == false) //eğer eleman (yani sonsuz dizimiz) elemanları içermiyorsa
                {
                    eleman.Add(item); //sonsuz diziye itemları ekle
                }
            }
            listBox1.Items.Clear(); //listBox'ı temizle
            listBox1.Items.AddRange(eleman.ToArray()); //listBox'a eleman dizinin elemanlarını ekle
        }//listbox1'de oynı olan değerleri siler

        public void OrtakIslem()
        {
            for (int i = 0; i <= 8; i++)
            {
                var kelimeler = Kombinasyon.Combinations(karakterler, r);

                foreach (var item in kelimeler)
                {
                    x = string.Join("", item.ToArray());
                    listBox1.Items.Add(x);
                }
                r++;
            }
            foreach (var p in Permutasyon(harflerTxt.Text))
            {
                listBox1.Items.Add($"{p}");
            }
            AyniOlanlariSil();
        }//Rastgele ve elle eklenen işlemlerde ortak olanları bir yerde topladım

        public static IEnumerable<string> Permutasyon(string source)
        {
            if (source.Length == 1) return new List<string> { source };

            var permutations = from z in source
                               from p in Permutasyon(new String(source.Where(x => x != z).ToArray()))
                               select z + p;
            return permutations;
        }
    }
    public static class Kombinasyon
    {
        public static IEnumerable<IEnumerable<T>> Combinations<T>(this IEnumerable<T> x, int k)
        {
            return k == 0 ? new[] { new T[0] } : x.SelectMany((e, i) => x.Skip(i + 1).Combinations(k - 1).Select(c => (new[] { e }).Concat(c)));
        }
    }
}
