namespace SifreÖdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {




        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            string sifre;
            sifre = txtSifre.Text;
            string harfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZXWabcçdefgğhıijklmnoöprsştuüvyzxw";
            string rakamlar = "0123456789";
            string ozelKarakter = "/?*<!>,.;&%$";



            bool harfVar = false;
            bool rakamVar = false;
            bool ozelVar = false;


            int uzunluk = sifre.Length;
            lblDerece.Text = " ";
            if (uzunluk < 6)
            {
                lblDerece.Text = "zayıf";
                lblDerece.BackColor = Color.Red;
            }


            foreach (char sfr in sifre)
            {
                if (harfler.IndexOf(sfr) != -1)
                {

                    harfVar = true;

                }

                if (rakamlar.IndexOf(sfr) != -1)
                {
                    rakamVar = true;
                }

                if (ozelKarakter.IndexOf(sfr) != -1)
                {
                    ozelVar = true;
                }



            }

            if (harfVar == true && rakamVar == true && ozelVar == true)
            {
                lblDerece.Text = "Güçlü";
                lblDerece.BackColor = Color.Green;
            }

            else if (harfVar == true && rakamVar == true || harfVar == true && ozelVar == true || rakamVar == true && ozelVar == true)
            {
                lblDerece.Text = "Orta";
                lblDerece.BackColor = Color.Blue;
            }

            else
            {
                lblDerece.Text = "Zayıf";
                lblDerece.BackColor = Color.Red;
            }

        }
    }
}