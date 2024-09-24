using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSLib;

namespace WSLManager
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Btn_GetWSL_Click(object sender, EventArgs e)
        {
            LSV_Distro.Items.Clear();
            List<WSLData.DistroList> distroList = WSLAPI.getDistro();
            foreach(WSLData.DistroList distro in distroList)
            {
                ListViewItem item = new ListViewItem(distro.Name);
                item.SubItems.Add(distro.State == true ? "Running":"Stopped");
                item.SubItems.Add(distro.WSLVersion.ToString());
                LSV_Distro.Items.Add(item);
            }
            foreach(ColumnHeader column in LSV_Distro.Columns)
            {
                column.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
    }
}
