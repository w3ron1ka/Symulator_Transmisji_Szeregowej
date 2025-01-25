using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Symulator_Transmisji_Szeregowej
{
    public partial class Form1 : Form
    {
        string wpisanyTekst;
        string wpisanyTekstBinarnie;
        string zdekodowanyTekst;

        public Form1()
        {
            InitializeComponent();
            this.pictureBox1.Load("Resources\\russel.png");
        }
        public string convertToASCII(string text)
        {
            StringBuilder binarnieBuilder = new StringBuilder();

            foreach (char znak in text)
            {
                // Zamiana znaku na jego wartosc binarn¹ ASCII
                string binarnieChar = Convert.ToString(znak, 2).PadLeft(8, '0').PadRight(10, '1'); // ASCII na binarny z lewej "0" i z prawej "11" - bity startu i stopu
                binarnieBuilder.Append(binarnieChar).Append(" "); // dodanie spacji dla czytelnosci

            }
            return binarnieBuilder.ToString().Trim(); // usuwa koncowa spacje
        }
        
        private string decodeASCII(string textBinarnie)
        {           
            StringBuilder zdekodowanyBuilder = new StringBuilder();

            // ³añcuch podzielony na 10-bitowe segmenty
            string[] segmenty = textBinarnie.Trim().Split(' ');

            foreach (string segment in segmenty)
            {
                if (segment.Length == 10 && segment.StartsWith("0") && segment.EndsWith("11")) // sprawdza poprawnosc ramki
                {
                    string binaryChar = segment.Substring(1, 7); // wybiera bity danych (1-7) indeksowanie 0-9
                    char decodedChar = (char)Convert.ToInt32(binaryChar, 2); // zamienia bity na znak ASCII
                    zdekodowanyBuilder.Append(decodedChar); // dodaje znak do wyniku
                }
            }
            return zdekodowanyBuilder.ToString();
        }

        private void decode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Dane binarne s¹ puste. Najpierw wykonaj konwersjê do ASCII.");
                return;
            }

            zdekodowanyTekst = decodeASCII(wpisanyTekstBinarnie);

            List<string> slowaCenzuralne = wczytajSlowaCenzuralne("Resources\\cenzura.txt");
            zdekodowanyTekst = cenzurujTekst(zdekodowanyTekst, slowaCenzuralne);

            textBox3.Text = zdekodowanyTekst;           
        }
        private void toAscii_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Dane tekstowe s¹ puste. Najpierw wpisz s³owo.");
                return;
            }
            textBox2.Text = convertToASCII(wpisanyTekst);
            this.wpisanyTekstBinarnie = textBox2.Text.ToString();         
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            wpisanyTekst = textBox1.Text;
        }

        // CENZURA
        private List<string> wczytajSlowaCenzuralne(string sciezkaPliku)
        {
            List<string> slowaCenzuralne = new List<string>();

            if (File.Exists(sciezkaPliku))
            {
                // wczytuje wszystkie s³owa z pliku i dzieli po spacji
                string zawartoscPliku = File.ReadAllText(sciezkaPliku);
                slowaCenzuralne = zawartoscPliku.Split(' ').ToList();
            }
            else
            {
                MessageBox.Show($"Plik {sciezkaPliku} nie istnieje. Cenzura zostanie pominiêta.");
            }

            return slowaCenzuralne;
        }
        private string cenzurujTekst(string tekst, List<string> slowaCenzuralne)
        {
            foreach (string slowo in slowaCenzuralne)
            {
                string gwiazdki = new string('*', slowo.Length);
                tekst = tekst.Replace(slowo, gwiazdki);
            }

            return tekst;
        }
    }
}
