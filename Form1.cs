using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.Diagnostics;


namespace Brendan_support
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Item> deviceList = new List<Item>
            {
                new Item { ip = "1", ADname = "POS 1" },
                new Item { ip = "2", ADname = "POS 2" },
                new Item { ip = "6", ADname = "Kiosk 6" },
                new Item { ip = "7", ADname = "Kiosk 7" },
                new Item { ip = "8", ADname = "Kiosk 8" },
                new Item { ip = "9", ADname = "Kiosk 9" },
                new Item { ip = "12", ADname = "POS 12" },
                new Item { ip = "13", ADname = "POS 13" },
                new Item { ip = "14", ADname = "POS 14" },
                new Item { ip = "15", ADname = "POS 15" },
                new Item { ip = "31", ADname = "KVS 1" },
                new Item { ip = "32", ADname = "KVS 2" },
                new Item { ip = "33", ADname = "KVS 3" },
                new Item { ip = "34", ADname = "KVS 4" },
                new Item { ip = "35", ADname = "KVS 5" },
                new Item { ip = "36", ADname = "KVS 6" },
                new Item { ip = "40", ADname = "EPR 1" },
                new Item { ip = "41", ADname = "EPR 2" },
                new Item { ip = "85", ADname = "RHS" },
                new Item { ip = "25", ADname = "WST" },
            };
            deviceSelectCombo.DisplayMember = "ADname";
            deviceSelectCombo.ValueMember = "ip";
            deviceSelectCombo.DataSource = deviceList;
        }
        private void forceRebootBtn_Click(object sender, EventArgs e)
        {
            var selectedItems = deviceSelectCombo.SelectedItems;
            foreach (var selectedItem in selectedItems)
            {
                string cmdScript = @"C:\Program Files (x86)\McDonalds\OTPSupportSuite\reboot-device-force.bat";
                var item = (Item)selectedItem;
                var value = item.ip;
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "cmd.exe";
                psi.Arguments = string.Format($"/c \"{cmdScript}\" {value}");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(psi);
            }
        }

        private void vncConnectBtn_Click(object sender, EventArgs e)
        {
            var selectedItems = deviceSelectCombo.SelectedItems;
            foreach (var selectedItem in selectedItems)
            {
                string cmdScript = @"C:\Program Files (x86)\McDonalds\OTPSupportSuite\connect.bat";
                var item = (Item)selectedItem;
                var value = item.ip;
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "cmd.exe";
                psi.Arguments = string.Format($"/c \"{cmdScript}\" {value}");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(psi);
            }
        }

        private void exploreConnectBtn_Click(object sender, EventArgs e)
        {
            var selectedItems = deviceSelectCombo.SelectedItems;
            foreach (var selectedItem in selectedItems)
            {
                string cmdScript = @"C:\Program Files (x86)\McDonalds\OTPSupportSuite\connect-explorer.bat";
                var item = (Item)selectedItem;
                var value = item.ip;
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "cmd.exe";
                psi.Arguments = string.Format($"/c \"{cmdScript}\" {value}");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(psi);
            }
        }

        private void rebootBtn_Click(object sender, EventArgs e)
        {
            var selectedItems = deviceSelectCombo.SelectedItems;
            foreach (var selectedItem in selectedItems)
            {
                string cmdScript = @"C:\Program Files (x86)\McDonalds\OTPSupportSuite\reboot-device.bat";
                var item = (Item)selectedItem;
                var value = item.ip;
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "cmd.exe";
                psi.Arguments = string.Format($"/c \"{cmdScript}\" {value}");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(psi);

            }
        }

        private void stopNewposBtn_Click(object sender, EventArgs e)
        {
            var selectedItems = deviceSelectCombo.SelectedItems;
            foreach (var selectedItem in selectedItems)
            {
                string cmdScript = @"C:\Program Files (x86)\McDonalds\OTPSupportSuite\stop-device.bat";
                var item = (Item)selectedItem;
                var value = item.ip;
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "cmd.exe";
                psi.Arguments = string.Format($"/c \"{cmdScript}\" {value}");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(psi);
            }
        }

        private void restartNewposBtn_Click(object sender, EventArgs e)
        {
            var selectedItems = deviceSelectCombo.SelectedItems;
            foreach (var selectedItem in selectedItems)
            {
                string cmdScript = @"C:\Program Files (x86)\McDonalds\OTPSupportSuite\restart-device.bat";
                var item = (Item)selectedItem;
                var value = item.ip;
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "cmd.exe";
                psi.Arguments = string.Format($"/c \"{cmdScript}\" {value}");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(psi);
            }
        }

        private void failoverBtn_Click(object sender, EventArgs e)
        {
            string cmdScript = @"C:\Program Files (x86)\McDonalds\OTPSupportSuite\Execute_Failover.bat";
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = string.Format($"/c \"{cmdScript}\"");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(psi);
        }

        private void primaryBtn_Click(object sender, EventArgs e)
        {
            string cmdScript = @"C:\Program Files (x86)\McDonalds\OTPSupportSuite\Execute_Primary.bat";
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = string.Format($"/c \"{cmdScript}\"");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(psi);
        }
    }
    public class Item
    {
        public string? ip { get; set; }
        public string? ADname { get; set; }
    }
}
