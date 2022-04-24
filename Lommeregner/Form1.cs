using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lommeregner
{
    public partial class Form1 : Form
    {
        string foorste_tal = "";            // En string variabel der gemmer det første tal man sætter ind
        string anden_tal = "";              // En string variabel der gemmer det andet tal man sætter ind
        char funktioner;                    // En Char variabel med navnet funktioner
        double relsutat = 0.0;              // En double variabel som gemmer relsutatet
        string Srelsutat;                   // en string variavel når der sker en fejl
        string bruger_input = "";           // En string variabel som gemmer brugerns input
        double DoFoorstetal;                // en double variabel som gammer foorstetal som et komma tal
        double DoAndettal;                  // en double variabel som gammer foorstetal som et komma tal
        string fejl = "Fejl!";              // en string variabel der indeholder verdien "Fejl!" til at skrivve når man har fået en fejl
        


        public Form1()
        {
            InitializeComponent();
        }

        private void nul_knap_Click(object sender, EventArgs e) // Hvis man trukker på 0 knappen
        {
            tekst_Box.Text = "";            // Sætter text boxen til ingenting
            bruger_input += "0";            // tilføjer 0 til variabel bruger_input
            tekst_Box.Text += bruger_input; // Udskriver brugerns input
        }

        private void knap_1_Click(object sender, EventArgs e)
        {
            tekst_Box.Text = "";            // Sætter text boxen til ingenting
            bruger_input += "1";            // tilføjer 1 til variabel bruger_input
            tekst_Box.Text += bruger_input; // Udskriver brugerns input
        }

        private void Knap_2_Click(object sender, EventArgs e)
        {
            tekst_Box.Text = "";            // Sætter text boxen til ingenting
            bruger_input += "2";            // tilføjer 2 til variabel bruger_input
            tekst_Box.Text += bruger_input; // Udskriver brugerns input
        }

        private void Knap_3_Click(object sender, EventArgs e)
        {
            tekst_Box.Text = "";            // Sætter text boxen til ingenting
            bruger_input += "3";            // tilføjer 3 til variabel bruger_input
            tekst_Box.Text += bruger_input; // Udskriver brugerns input
        } 

        private void Knap_4_Click(object sender, EventArgs e)
        {
            tekst_Box.Text = "";            // Sætter text boxen til ingenting
            bruger_input += "4";            // tilføjer 4 til variabel bruger_input
            tekst_Box.Text += bruger_input; // Udskriver brugerns input
        }

        private void Knap_5_Click(object sender, EventArgs e)
        {
            tekst_Box.Text = "";            // Sætter text boxen til ingenting
            bruger_input += "5";            // tilføjer 5 til variabel bruger_input
            tekst_Box.Text += bruger_input; // Udskriver brugerns input
        }

        private void Knap_6_Click(object sender, EventArgs e)
        {
            tekst_Box.Text = "";            // Sætter text boxen til ingenting
            bruger_input += "6";            // tilføjer 6 til variabel bruger_input
            tekst_Box.Text += bruger_input; // Udskriver brugerns input
        }

        private void Knap_7_Click(object sender, EventArgs e)
        {
            tekst_Box.Text = "";            // Sætter text boxen til ingenting
            bruger_input += "7";            // tilføjer 7 til variabel bruger_input
            tekst_Box.Text += bruger_input; // Udskriver brugerns input
        }

        private void Knap_8_Click(object sender, EventArgs e)
        {
            tekst_Box.Text = "";            // Sætter text boxen til ingenting
            bruger_input += "8";            // tilføjer 8 til variabel bruger_input
            tekst_Box.Text += bruger_input; // Udskriver brugerns input
        }

        private void Knap_9_Click(object sender, EventArgs e)
        {
            tekst_Box.Text = "";            // Sætter text boxen til ingenting
            bruger_input += "9";            // tilføjer 9 til variabel bruger_input
            tekst_Box.Text += bruger_input; // Udskriver brugerns input
        }

        private void biner_Click(object sender, EventArgs e)
        {
            int n;                          // laver en int variabel med navent n
            string bin = "";                // laver en sting variabel med navnet bin og laver den til ingen ting

            int.TryParse(bruger_input, out n);  // laver bruger input til int og putputter vadien til n

            for (; n != 0; n = n / 2)       // for hvær tal i n så devider med 2 og når det kommer et nul så break ud
            {
                bin = n % 2 + bin;          // sæt variablen bin til n som divider og ser efter om der er rest og hvis der er så sæt lav 1 hvis ikke så et 0
            }

            tekst_Box.Text = bin;           // udskriver bin til skermen 
            bin = "";                       // laver bin til ingen ting
            n = 0;                          // sætter n til 0

        }
        private void HEX_Knap_Click(object sender, EventArgs e)
        {
            int n;                          // laver en int variabel med navent n
            int.TryParse(bruger_input, out n);  // laver bruger input til int og putputter vadien til n
            string hexValue = n.ToString("X2"); // laver en string variabel med navet hexValue og til giver den vadien n som bliver convatert til hec

            tekst_Box.Text = hexValue;      // udskriver vadien af hexValue til skermen
            n = 0;                          // sætter n til 0
            hexValue = "";                  // sætter hexValue til ingen ting
        }


        private void Komma_Knap_Click(object sender, EventArgs e)
        {
            tekst_Box.Text = "";            // Sætter text boxen til ingenting
            bruger_input += ".";            // tilføjer komma til variabel bruger_input
            tekst_Box.Text += bruger_input; // Udskriver brugerns input

            var s = bruger_input;           // laver en var variabel med navnet s som bliver tilgivet vadien bruger input
            var ch = '.';                   // laver en var variabel med navet ch som bliver tilgivet vadien "."
            if (s.IndexOf(ch) != s.LastIndexOf(ch)) // hvis der er 2 pumtuner så gør det her
            {
                tekst_Box.Text = fejl;      // udskriver fejl variablen med vadien "FEJL!"
                bruger_input = "";          // sætter bruger input til ingen ting
            }       
        }

        private void Plus_knap_Click(object sender, EventArgs e)
        {
            foorste_tal = bruger_input;     // gemmer det første tal som man skriver ind
            bruger_input = "";              // sætter bruger input til ingen ting
            funktioner = '+';               // når man kliker på pluds så gemmer den et pluds tegn i vriaben funtioner
            Console.WriteLine(foorste_tal); // udskriver variablen foorste_tal til consollen 
        }

        private void Minus_knap_Click(object sender, EventArgs e)
        {
            foorste_tal = bruger_input;     // gemmer det første tal som man skriver ind
            bruger_input = "";              // sætter bruger input til ingen ting
            funktioner = '-';               // når man kliker på minus så gemmer den et minus tegn i vriaben funtioner
            Console.WriteLine(foorste_tal); // udskriver variablen foorste_tal til consollen 
        }

        private void Gange_knap_Click(object sender, EventArgs e)
        {
            foorste_tal = bruger_input;     // gemmer det første tal som man skriver ind
            bruger_input = "";              // sætter bruger input til ingen ting
            funktioner = '*';               // når man kliker på gange så gemmer den et gange tegn i vriaben funtioner
            Console.WriteLine(foorste_tal); // udskriver variablen foorste_tal til consollen 
        }

        private void Divider_knap_Click(object sender, EventArgs e)
        {
            foorste_tal = bruger_input;     // gemmer det første tal som man skriver ind
            bruger_input = "";              // sætter bruger input til ingen ting
            funktioner = '/';               // når man kliker på divider så gemmer den et divider tegn i vriaben funtioner
            Console.WriteLine(foorste_tal); // udskriver variablen foorste_tal til consollen 
        }

        private void Opianden_knap_Click(object sender, EventArgs e)
        {
            double.TryParse(bruger_input, out DoFoorstetal);    // laver bruger inpu om til en doubel
            bruger_input = "";                                  // sætter bruger input til ingen ting
            relsutat = DoFoorstetal * DoFoorstetal;             // lægger variabelen DoFoorstetal ganget med sig selv 

            tekst_Box.Text = relsutat.ToString();               // udskriver relsutatet til skermen
            bruger_input = relsutat.ToString();                 // sæter bruger input til relsutatet
        }
        

        private void Iligmed_knap_Click(object sender, EventArgs e)
        {
            anden_tal = bruger_input;   // tilgiver andet tal vardien bruger_input
            
            double.TryParse(foorste_tal, out DoFoorstetal);     //laver foorste tal om til en doubel og til givervadien til DoFoorstetal
            double.TryParse(anden_tal, out DoAndettal);          //laver andet tal om til en doubel og til givervadien til DoAndettal

            if (funktioner == '+')          // hvis variablen funktioner er pluds så gør det her
            {
                relsutat = DoFoorstetal + DoAndettal;   // pludser de 2 tal sammen og gemmer det i variablen relsutat
            }
            else if (funktioner == '-')     // hvis variablen funktioner er pluds så gør det her
            {
                relsutat = DoFoorstetal - DoAndettal;   // minus de 2 tal sammen og gemmer det i variablen relsutat
            }
            else if (funktioner == '*')     // hvis variablen funktioner er pluds så gør det her
            {
                relsutat = DoFoorstetal * DoAndettal;   // ganger de 2 tal sammen og gemmer det i variablen relsutat
            }
            else if (funktioner == '/')     // hvis variablen funktioner er pluds så gør det her
            {
                if (DoFoorstetal == 0 || DoAndettal == 0)   // hvis en af de 2 taller er 0
                {
                    Srelsutat = fejl;       // sætter Srelsutat til fejl
                }
                else                                        // ellers
                {
                    relsutat = DoFoorstetal / DoAndettal; // devider med de 2 tal og sæt relsutatet
                }
            }

            if (Srelsutat == fejl)          // hvis Srelsutat er fejl så gør det her
            {
                tekst_Box.Text = Srelsutat;                 // så udskrev variblen fejl
            }   
            else                            // ellers
            {
                tekst_Box.Text = relsutat.ToString();       // udskiv relsutatet
            }

            //sætter foorste_t, anden_tal, relsutat og bruger_input til ingen ting
            relsutat = 0.0;
            foorste_tal = "";           
            anden_tal = "";
            bruger_input = "";

        }

        private void Ce_Knap_Click(object sender, EventArgs e)
        { 
            tekst_Box.Text = "";    // sætter variablen til ingen ting   
            tekst_Box.Text = "0";   // sætter variablen til ingen ting 
            bruger_input = "";      // sætter variablen til ingen ting         
            foorste_tal = "";       // sætter variablen til ingen ting     
            anden_tal = "";         // sætter variablen til ingen ting 
            funktioner = ' ';       // sætter variablen til ingen ting 
            DoFoorstetal = 0.0;     // sætter variablen til ingen ting  
            DoAndettal = 0.0;       // sætter variablen til ingen ting 
            relsutat = 0.0;         // sætter variablen til ingen ting 
        }

        private void tekst_Box_Click(object sender, EventArgs e)
        { 

        }

        
    }
}
