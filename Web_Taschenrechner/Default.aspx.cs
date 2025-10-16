using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Web_Taschenrechner
{
    public partial class _Default : Page
    {
        /// <summary>
        /// Konstruktor der Page "Default"
        /// Methode wird aufgerufen wenn die Page geladen wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        string rechenzeichen = string.Empty;    //Variable um das Rechenzeichen zu merken
        bool rechenzeichenActive = false;       //Variable um zu merken, ob ein Rechenzeichen gedrückt wurde
        bool gleichzeichenActive = false;       //Variable um zu merken, ob das Gleichzeichen gedrückt wurde
        int zahl = 0;                           //Variable um sich die Zahl zu merken, die vor dem Rechenzeichen gedrückt wurde


        /// <summary>
        /// Methode wird aufgerufen wenn der Benutzer auf einen Button der Zahlen klickt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnNumber_Click(object sender, EventArgs e)
        {
            int geklickteZahl = Convert.ToInt32((sender as Button).Text);    //Hol dir die Zahl
            int display = Convert.ToInt32(txtDisplay.Text);

            //Ist eine Null im Bildschirm?
            if (display == 0)
            {
                if (geklickteZahl != 0)
                {
                    display = geklickteZahl;
                }
                else
                {
                    return;
                }
            }
            else if (rechenzeichenActive || gleichzeichenActive)
            {
                display = geklickteZahl;

                gleichzeichenActive = false;    
                rechenzeichenActive = false;
            }
            else
            {
                display += geklickteZahl;
            }

            txtDisplay.Text = display.ToString();
        }     

        /// <summary>
        /// Methode wird aufgerufen wenn der Benutzer ein Komma setzen will
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnKomma_Click(object sender, EventArgs e)
        {
            //Wenn das Display mindestens eine Zahl enthält und noch kein Komma, dann printe Komma
            if (!txtDisplay.Text.Contains(".") && txtDisplay.Text.Count() >= 1) 
            {
                txtDisplay.Text += ".";
            }
        }

        /// <summary>
        /// Methode wird aufgerufen wenn der Benutzer ein Rechenzeichen (+ - * /) klickt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnRechenzeichen_Click(object sender, EventArgs e)
        {
            string geklicktesRechenzeichen = (sender as Button).Text;    //Hol dir die Zahl

            //Hat er eben ein Rechenzeichen geklickt
            if (! rechenzeichenActive)
            {
                //Wenn noch kein Rechenzeichen geklickt wurde, dann merk dir dir zahl im DIsplay
                zahl = Convert.ToInt32(txtDisplay.Text);
            }

            //Merk dir das Rechenzeichen und stell variable auf true
            rechenzeichen = geklicktesRechenzeichen;
            labRechenzeichen.Text = rechenzeichen;
        }

        /// <summary>
        /// Methode wird aufgerufen wenn der Benutzer die aktuelle Rechnung verwerfen will
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnClear_Click(object sender, EventArgs e)
        {
            //Setze Werte zurück
            rechenzeichenActive = false;
            gleichzeichenActive = false;
            rechenzeichen = string.Empty;
            zahl = 0;

            //schreib 0 ins display
            txtDisplay.Text = zahl.ToString();
        }
        
        /// <summary>
        /// Methode wird aufgerufen wenn der Benutzer ausrechnen will
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnGleich_Click(object sender, EventArgs e)
        {

        }
    }
}