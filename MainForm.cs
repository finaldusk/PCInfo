using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using System.IO;

namespace PCInfo
{
    public partial class MainForm : Form
    {

        public string MACAddress { get; set; }  
        public string PCInfo { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string NICCaption;
            MACAddress = getMACInfo(out NICCaption);
            label_MACInfo.Text =  "MAC地址:"+ MACAddress+Environment.NewLine+ NICCaption ;
            PCInfo = GetPCInfo.getJson();
           
        }

        private void button_copyMACAdd_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(MACAddress, true);
            toolStripStatusLabel.Text = "复制MAC地址成功！";            
        }

        private void button_copy2Clipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(PCInfo, true);
            toolStripStatusLabel.Text = "复制计算机硬件信息成功！";
        }

        private string getMACInfo(out string Caption)
        {
            string madAddr = null;
            Caption = "unknown";
            try
            {
                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection moc2 = mc.GetInstances();
                foreach (ManagementObject mo in moc2)
                {
                    if (Convert.ToBoolean(mo["IPEnabled"]) == true)
                    {
                        if (mo["Caption"].ToString().ToLower().Contains("vmware") | mo["Caption"].ToString().ToLower().Contains("virtual") | mo["Caption"].ToString().ToLower().Contains("usb") | mo["Caption"].ToString().ToLower().Contains("wireless"))
                        {

                        }
                        else
                        {
                            madAddr = mo["MACAddress"].ToString();
                            madAddr = madAddr.Replace(':', '-');
                            Caption = mo["Caption"].ToString().Substring(11);
                            break;
                        }
                    }
                    mo.Dispose();
                }
                if (madAddr == null)
                {
                    return "unknown";
                }
                else
                {
                    return madAddr;
                }
            }
            catch (Exception)
            {
                return "unknown";
            }
        }

        private void button_saveInfo_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "JSON文档(*.json)|*.json";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.FileName = "部门+姓名+"+MACAddress;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {                
                File.WriteAllText(saveFileDialog.FileName, PCInfo);
            }
            toolStripStatusLabel.Text = "保存成功！";
        }
    }
}
