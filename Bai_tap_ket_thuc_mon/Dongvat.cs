using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Bai_tap_ket_thuc_mon
{
    class Dongvat
    {
        private string Keu;
        private string MauLong;
        public string Tiengkeu
        {
            get { return Keu; }
            set { Keu = value; }
        }
        public Dongvat (string stKeu)
        {
            this.Keu = stKeu;
        }        
        public string Maulong 
        {
            get { return Maulong; }
            set { Maulong = value; }
        }
        public virtual void keu()
        {
            /*if (Tiengkeu.equals("Gaugau"))
                MessageBox.Show("Cho keu: " + this.Tiengkeu);
            else if (Tiengkeu.equals("Meomeo"))
                MessageBox.Show("Meo keu: " + this.Tiengkeu);*/
        }
    }
}
