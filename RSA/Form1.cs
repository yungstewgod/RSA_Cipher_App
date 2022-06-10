using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Data.SQLite;

namespace RSA
{
    public partial class Form1 : Form
    {

        public int p, q;
        public BigInteger n, fi, e, d;
        string source = @"Data source=C:\Users\Vartotojas\Desktop\Saugumo_3_praktinis\database.db;Version=3;";

        public Form1()
        {
            InitializeComponent();
            UpdateDatabase();
        }

        private void encryptionButton_Click(object sender, EventArgs e)
        {
            p = Convert.ToInt32(textBox_p.Text);
            q = Convert.ToInt32(textBox_q.Text);

            if (IsPrime(p) == true && IsPrime(q) == true)
            {
                Keys();

                textBox_result.Text = Encrypt(textBox_fresh.Text);
            }
            else
                MessageBox.Show("Įvesti skaičiai negali būti pirminiai");

        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            else
            {
                for (BigInteger i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        private void decryptionButton_Click(object sender, EventArgs e)
        {
            textBox_result.Text = Decrypt(textBox_fresh.Text);
        }

        private void chooseFromDatabase_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(source);
            Isvalyti();

            string pasirinko = "";
            pasirinko = comboBox1.SelectedItem.ToString();
            conn.Open();
            string query = "select id from decrypted where data = '" + pasirinko + "'";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                pasirinko = Convert.ToString(reader[0]);
            }
            reader.Close();

            query = "select n, e, text from decrypted where id = '" + pasirinko + "'";
            cmd = new SQLiteCommand(query, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox_n.Text = Convert.ToString(reader[0]);
                textBox_e.Text = Convert.ToString(reader[1]);
                textBox_fresh.Text = Convert.ToString(reader[2]);
            }
            reader.Close();
            conn.Close();
        }

        private void saveToDatabase_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(source);
            string data = DateTime.Now.ToString();
            string query = "insert into decrypted values (NULL, '" + data + "','" + textBox_n.Text +"','" + textBox_e.Text + "','" + textBox_result.Text +"')";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            conn.Open();
            cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Duomenys pridėti į duomenų bazę");
            conn.Close();

            UpdateDatabase();
            Isvalyti();
        }

        private void UpdateDatabase()
        {
            comboBox1.Items.Clear();
            SQLiteConnection conn = new SQLiteConnection(source);
            conn.Open();

            string query = "select data from decrypted";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                comboBox1.Items.Add(Convert.ToString(dr[0]));
            dr.Close();
        }

        private void Isvalyti()
        {
            textBox_n.Clear();
            textBox_fi.Clear();
            textBox_d.Clear();
            textBox_e.Clear();
            textBox_fresh.Clear();
            textBox_p.Clear();
            textBox_q.Clear();
            textBox_result.Clear();
        }

        public string Encrypt(string msg)
        {
            n = Convert.ToInt32(textBox_p.Text) * Convert.ToInt32(textBox_q.Text);
            e = Convert.ToInt32(textBox_e.Text);
            string str = "";
            foreach (char c in msg)
            {
                str += (char)BigInteger.ModPow((int)c, e, n);
            }
            return str;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_n_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_q_TextChanged(object sender, EventArgs e)
        {

        }

        public void DecryptionCalculation(string n, string z)
        {
            Random r = new Random();
            int a = Convert.ToInt32(n);
            int factor = 0;
            int[] mas = new int[4];
            int i = 0;
            for (factor = 1; factor <= a; factor++)
            {
                if (a % factor == 0)
                {
                    mas[i] = factor;
                    i++;
                }
            }
            textBox_p.Text = mas[1].ToString();
            textBox_q.Text = mas[2].ToString();
            p = Convert.ToInt32(textBox_p.Text);
            q = Convert.ToInt32(textBox_q.Text);

            fi = (p - 1) * (q - 1);

            textBox_fi.Text = fi.ToString();

            e = Convert.ToInt32(z);

            List<BigInteger> Possible_d = new List<BigInteger>();
            int amount = 0;
            for (d = p; d < fi; d++)
            {
                if (e * d % fi == 1)
                {
                    Possible_d.Add(d);

                    if (amount == 10)
                    {
                        break;
                    }
                }
            }

            d = Possible_d[r.Next(0, Possible_d.Count)];
            textBox_d.Text = Convert.ToString(d);


        }

        public string Decrypt(string msg)
        {
            DecryptionCalculation(textBox_n.Text, textBox_e.Text);
            string rez = "";

            foreach (char c in msg)
            {
                 rez += (char)BigInteger.ModPow((int)c, d, n);
            }
            return rez;
        }


        public void Keys()
        {
            Random r = new Random();
            List<BigInteger> Possible_e = new List<BigInteger>();

            n = p * q;
            textBox_n.Text = n.ToString();
            fi = (p - 1) * (q - 1);
            textBox_fi.Text = fi.ToString();

            int amount = 0;

            for (e = 2; e < fi; e++)
            {
                if (BigInteger.GreatestCommonDivisor(fi, e) == 1)
                {
                    amount++;
                    Possible_e.Add(e);
                }
                if (amount == 10)
                {
                    break;
                }
            }

            e = Possible_e[r.Next(0, Possible_e.Count)];
            amount = 0;
            List<BigInteger> Possible_d = new List<BigInteger>();

            for (d = p; d < fi; d++)
            {
                if (e * d % fi == 1)
                {
                    Possible_d.Add(d);
                    if (amount == 10)
                    {
                        break;
                    }
                }
            }

            d = Possible_d[r.Next(0, Possible_d.Count)];
            textBox_e.Text = Convert.ToString(e);
            textBox_d.Text = Convert.ToString(d);

        }

    }
}
