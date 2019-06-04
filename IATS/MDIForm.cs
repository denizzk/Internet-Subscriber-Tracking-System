using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IATS
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
        }

        private void aboneEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboneEkle = new AboneKayit();
            aboneEkle.MdiParent = this;
            aboneEkle.Show();
            
        }

        private void aboneBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboneler = new AboneList();
            aboneler.MdiParent = this;
            aboneler.Show();
        }

        private void aboneGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboneUpdate = new AboneUpdate();
            aboneUpdate.MdiParent = this;
            aboneUpdate.Show();
        }

        private void aboneSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboneSil = new AboneSil();
            aboneSil.MdiParent = this;
            aboneSil.Show();
        }

        private void paketEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form paketEkle = new PaketEkle();
            paketEkle.MdiParent = this;
            paketEkle.Show();
        }

        private void paketGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form paketUpdate = new PaketUpdate();
            paketUpdate.MdiParent = this;
            paketUpdate.Show();
        }

        private void paketSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form paketSil = new PaketSil();
            paketSil.MdiParent = this;
            paketSil.Show();
        }

        private void toplamFaturaBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form total = new total();
            total.MdiParent = this;
            total.Show();
        }

        private void paketBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form paketList = new PaketList();
            paketList.MdiParent = this;
            paketList.Show();
        }
    }
}
