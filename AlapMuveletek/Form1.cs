using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlapMuveletek
{
    public partial class Form1 : Form
    {

        int elso;
        int masodik;
        int eredmeny;
        String muvelet;

        public Form1()
        {
            InitializeComponent();
        }

        private void osztásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muvelet = "osztas";
            Legeneral();
        }

        private void btEllenoriz_Click(object sender, EventArgs e)
        {
            if (tbValasz.Text.Equals(eredmeny.ToString()))
            {
                tbEredmeny.Text = "Jó Megoldás!";
            }
            else
            {
                tbEredmeny.Text = "Rossz Megoldás!";
            }
        }

        private void Legeneral()
        {
            elso = 5;
            masodik = 5;
            if (muvelet.Equals("osztas"))
            {
                eredmeny = elso / masodik;
                tbFeladat.Text = $"{elso}/{masodik}";
            }
            else if(muvelet.Equals("szorzas"))
            {
                eredmeny = elso * masodik;
                tbFeladat.Text = $"{elso}*{masodik}";
            }
            else if (muvelet.Equals("osszeadas"))
            {
                eredmeny = elso + masodik;
                tbFeladat.Text = $"{elso}+{masodik}";
            }
            else if (muvelet.Equals("kivonas"))
            {
                eredmeny = elso - masodik;
                tbFeladat.Text = $"{elso}-{masodik}";
            }
        }


    }
}
