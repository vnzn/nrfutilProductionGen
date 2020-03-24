using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using nrfjprogGUI;

namespace nrfutilProductionGen
{
    public partial class FormMain : Form, CliInterface
    {

        private const String backupDfuApplicationPrefix = "move app_dfu_package.zip app_dfu_package.zip.";
        private const String backupDfuBootloaderPrefix = "move boot_dfu_package.zip boot_dfu_package.zip.";
        private const String backupDfuBootloaderSettingPrefix = "move bootloader_setting.hex bootloader_setting.hex.";
        private const String backupProductionHexPrefix = "move production.hex production.hex.";
        private const String nrfutilCommandPkgGenPefix = "nrfutil pkg generate ";
        private const String nrfutilCommandAppPkgGenSuffix = "app_dfu_package.zip";
        private const String nrfutilCommandBootPkgGenSuffix = "boot_dfu_package.zip";
        
        private const String nrfutilCommandSettingGenPefix = "nrfutil settings generate ";
        private const String nrfutilCommandSettingGenSuffix = "bootloader_setting.hex";
        private const String mergehexCommandStage1 = "mergehex.exe -m s132_nrf52_7.0.1_softdevice.hex [BOOTLOADER] [APPLICATION] -o 3in1.hex&&mergehex.exe -m 3in1.hex bootloader_setting.hex -o production.hex&&del 3in1.hex";
        //private const String mergehexCommandStage2 = "mergehex.exe -m 3in1.hex bootloader_setting.hex -o production.hex";
        //private const String mergehexCommandStage3 = "del 3in1.hex";

        public FormMain()
        {
            InitializeComponent();
        }
        
        
        private delegate void updateLogDelegate(String log);
        private void updateLog(String log)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new updateLogDelegate(updateLog), new object[] { log });
                }
                else
                {
                    textBoxLog.Text = log;
                }
            }
            catch
            {

            }
        }

        private delegate void updateGenerateButtonDelegate(Boolean isEnabled);
        private void updateGenerateButton(Boolean isEnabled)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new updateGenerateButtonDelegate(updateGenerateButton), new object[] { isEnabled });
                }
                else
                {
                    buttonGenerate.Enabled = isEnabled;
                }
            }
            catch
            {

            }
        }


        private void threadGenerate(object obj)
        {

            List<KeyValuePair<String, String>> kvpListParam = obj as List<KeyValuePair<String, String>>;
            Cli c = new Cli(this);

            String backupTimeStamp = (System.DateTime.UtcNow.ToUniversalTime().Ticks / 10000000).ToString();
            c.Execute(backupDfuApplicationPrefix + backupTimeStamp);
            c.Execute(backupDfuBootloaderPrefix + backupTimeStamp);
            c.Execute(backupDfuBootloaderSettingPrefix + backupTimeStamp);
            c.Execute(backupProductionHexPrefix + backupTimeStamp);

            String applicationFileName = String.Empty;
            
            String bootloaderFileName = String.Empty;

            String cmd = nrfutilCommandPkgGenPefix;
            foreach (KeyValuePair<String, String> kvp in kvpListParam)
            {
                if (kvp.Key == "--application-version")
                {
                    cmd += kvp.Key + " ";
                    cmd += kvp.Value + " ";
                }
                else if (kvp.Key == "--hw-version")
                {
                    cmd += kvp.Key + " ";
                    cmd += kvp.Value + " ";
                }
                else if (kvp.Key == "--sd-req")
                {
                    cmd += kvp.Key + " ";
                    cmd += kvp.Value + " ";
                }
                else if (kvp.Key == "--application")
                {
                    cmd += kvp.Key + " ";
                    cmd += kvp.Value + " ";
                    applicationFileName = kvp.Value;
                }
                else if (kvp.Key == "--key-file")
                {
                    cmd += kvp.Key + " ";
                    cmd += kvp.Value + " ";
                }

            }
            cmd += nrfutilCommandAppPkgGenSuffix;
            c.Execute(cmd);



            cmd = nrfutilCommandPkgGenPefix;
            foreach (KeyValuePair<String, String> kvp in kvpListParam)
            {
                if (kvp.Key == "--bootloader-version")
                {
                    cmd += kvp.Key + " ";
                    cmd += kvp.Value + " ";
                }
                else if (kvp.Key == "--hw-version")
                {
                    cmd += kvp.Key + " ";
                    cmd += kvp.Value + " ";
                }
                else if (kvp.Key == "--sd-req")
                {
                    cmd += kvp.Key + " ";
                    cmd += kvp.Value + " ";
                }
                else if (kvp.Key == "--bootloader")
                {
                    cmd += kvp.Key + " ";
                    cmd += kvp.Value + " ";
                    bootloaderFileName = kvp.Value;
                }
                else if (kvp.Key == "--key-file")
                {
                    cmd += kvp.Key + " ";
                    cmd += kvp.Value + " ";
                }

            }
            cmd += nrfutilCommandBootPkgGenSuffix;
            c.Execute(cmd);


            cmd = nrfutilCommandSettingGenPefix;
            foreach (KeyValuePair<String, String> kvp in kvpListParam)
            {
                
                if (kvp.Key == "--family")
                {
                    cmd += kvp.Key + " ";
                    cmd += kvp.Value + " ";
                }
                else if (kvp.Key == "--application")
                {
                    cmd += kvp.Key + " ";
                    cmd += kvp.Value + " ";
                }
                else if (kvp.Key == "--application-version")
                {
                    cmd += kvp.Key + " ";
                    cmd += kvp.Value + " ";
                }
                else if (kvp.Key == "--bootloader-version")
                {
                    cmd += kvp.Key + " ";
                    cmd += kvp.Value + " ";
                }
                else if (kvp.Key == "--bl-settings-version")
                {
                    cmd += kvp.Key + " ";
                    cmd += kvp.Value + " ";
                }

            }
            cmd += nrfutilCommandSettingGenSuffix;
            c.Execute(cmd);


            if (String.IsNullOrEmpty(applicationFileName) == true || String.IsNullOrEmpty(bootloaderFileName) == true)
            {
                return;
            }
            cmd = mergehexCommandStage1.Replace("[BOOTLOADER]", bootloaderFileName);
            cmd = cmd.Replace("[APPLICATION]", applicationFileName);

            c.Execute(cmd);

            Process proc = new Process();
            proc.StartInfo.FileName = "explorer";
            proc.StartInfo.Arguments = @"/select," + System.Windows.Forms.Application.ExecutablePath;
            proc.Start();
            updateGenerateButton(true);
        }
        private void buttonSelectApplicationHexFile_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialogApplicationHexFile.ShowDialog();
            String selectedFileName = openFileDialogApplicationHexFile.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(selectedFileName))
            {
                labelApplicationHexFilePath.Text = selectedFileName;
            }

        }

        private void buttonSelectBootloaderHexFile_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialogBootloaderHexFile.ShowDialog();
            String selectedFileName = openFileDialogBootloaderHexFile.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(selectedFileName))
            {
                labelBootloaderHexFilePath.Text = selectedFileName;
            }
        }



        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            List<KeyValuePair<String, String>> kvpListParam = new List<KeyValuePair<string, string>>();
            kvpListParam.Clear();
            kvpListParam.Add(new KeyValuePair<string, string>("--application-version", textBoxApplicationVersion.Text));
            kvpListParam.Add(new KeyValuePair<string, string>("--bootloader-version", textBoxBootloaderVersion.Text));
            kvpListParam.Add(new KeyValuePair<string, string>("--bl-settings-version", textBoxBootloaderSettingVersion.Text));
            kvpListParam.Add(new KeyValuePair<string, string>("--family", textBoxDeviceFamily.Text));
            kvpListParam.Add(new KeyValuePair<string, string>("--hw-version", textBoxHardwareVersion.Text));
            kvpListParam.Add(new KeyValuePair<string, string>("--sd-req", textBoxSoftDeviceVersion.Text));
            kvpListParam.Add(new KeyValuePair<string, string>("--application", labelApplicationHexFilePath.Text));
            kvpListParam.Add(new KeyValuePair<string, string>("--bootloader", labelBootloaderHexFilePath.Text));
            kvpListParam.Add(new KeyValuePair<string, string>("--key-file", Application.StartupPath + "\\private.key"));
            foreach (KeyValuePair<String, String> kvp in kvpListParam)
            {

                if (String.IsNullOrEmpty(kvp.Value))
                {
                    MessageBox.Show("Need to Specify the " + kvp.Key);
                    return;
                }
            }


            Thread thread = new Thread(new ParameterizedThreadStart(threadGenerate));
            thread.Start(kvpListParam);

        }

        public void CliInterfaceAnswerReceived(string answer)
        {
            updateLog(answer);
        }

        
    }
}
