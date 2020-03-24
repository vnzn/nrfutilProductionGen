namespace nrfutilProductionGen
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelApplicationVersion = new System.Windows.Forms.Label();
            this.textBoxApplicationVersion = new System.Windows.Forms.TextBox();
            this.labelHardwareVersion = new System.Windows.Forms.Label();
            this.textBoxHardwareVersion = new System.Windows.Forms.TextBox();
            this.labelSoftDeviceVersion = new System.Windows.Forms.Label();
            this.textBoxSoftDeviceVersion = new System.Windows.Forms.TextBox();
            this.buttonSelectApplicationHexFile = new System.Windows.Forms.Button();
            this.textBoxDeviceFamily = new System.Windows.Forms.TextBox();
            this.labelDeviceFamily = new System.Windows.Forms.Label();
            this.textBoxBootloaderVersion = new System.Windows.Forms.TextBox();
            this.labelBootloaderVersion = new System.Windows.Forms.Label();
            this.labelApplicationHexFilePath = new System.Windows.Forms.Label();
            this.labelBootloaderHexFilePath = new System.Windows.Forms.Label();
            this.buttonSelectBootloaderHexFile = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.openFileDialogApplicationHexFile = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogBootloaderHexFile = new System.Windows.Forms.OpenFileDialog();
            this.textBoxBootloaderSettingVersion = new System.Windows.Forms.TextBox();
            this.labelBootloaderSettingVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelApplicationVersion
            // 
            this.labelApplicationVersion.AutoSize = true;
            this.labelApplicationVersion.Location = new System.Drawing.Point(26, 12);
            this.labelApplicationVersion.Name = "labelApplicationVersion";
            this.labelApplicationVersion.Size = new System.Drawing.Size(113, 12);
            this.labelApplicationVersion.TabIndex = 7;
            this.labelApplicationVersion.Text = "ApplicationVersion";
            // 
            // textBoxApplicationVersion
            // 
            this.textBoxApplicationVersion.Location = new System.Drawing.Point(182, 8);
            this.textBoxApplicationVersion.Name = "textBoxApplicationVersion";
            this.textBoxApplicationVersion.Size = new System.Drawing.Size(41, 21);
            this.textBoxApplicationVersion.TabIndex = 8;
            this.textBoxApplicationVersion.Text = "1";
            // 
            // labelHardwareVersion
            // 
            this.labelHardwareVersion.AutoSize = true;
            this.labelHardwareVersion.Location = new System.Drawing.Point(26, 99);
            this.labelHardwareVersion.Name = "labelHardwareVersion";
            this.labelHardwareVersion.Size = new System.Drawing.Size(95, 12);
            this.labelHardwareVersion.TabIndex = 9;
            this.labelHardwareVersion.Text = "HardwareVersion";
            // 
            // textBoxHardwareVersion
            // 
            this.textBoxHardwareVersion.Location = new System.Drawing.Point(182, 95);
            this.textBoxHardwareVersion.Name = "textBoxHardwareVersion";
            this.textBoxHardwareVersion.Size = new System.Drawing.Size(41, 21);
            this.textBoxHardwareVersion.TabIndex = 10;
            this.textBoxHardwareVersion.Text = "52";
            // 
            // labelSoftDeviceVersion
            // 
            this.labelSoftDeviceVersion.AutoSize = true;
            this.labelSoftDeviceVersion.Location = new System.Drawing.Point(26, 130);
            this.labelSoftDeviceVersion.Name = "labelSoftDeviceVersion";
            this.labelSoftDeviceVersion.Size = new System.Drawing.Size(107, 12);
            this.labelSoftDeviceVersion.TabIndex = 11;
            this.labelSoftDeviceVersion.Text = "SoftDeviceVersion";
            // 
            // textBoxSoftDeviceVersion
            // 
            this.textBoxSoftDeviceVersion.Location = new System.Drawing.Point(182, 126);
            this.textBoxSoftDeviceVersion.Name = "textBoxSoftDeviceVersion";
            this.textBoxSoftDeviceVersion.Size = new System.Drawing.Size(41, 21);
            this.textBoxSoftDeviceVersion.TabIndex = 12;
            this.textBoxSoftDeviceVersion.Text = "0xCB";
            // 
            // buttonSelectApplicationHexFile
            // 
            this.buttonSelectApplicationHexFile.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSelectApplicationHexFile.Location = new System.Drawing.Point(12, 191);
            this.buttonSelectApplicationHexFile.Name = "buttonSelectApplicationHexFile";
            this.buttonSelectApplicationHexFile.Size = new System.Drawing.Size(189, 63);
            this.buttonSelectApplicationHexFile.TabIndex = 13;
            this.buttonSelectApplicationHexFile.Text = "Select Application Hex File";
            this.buttonSelectApplicationHexFile.UseVisualStyleBackColor = true;
            this.buttonSelectApplicationHexFile.Click += new System.EventHandler(this.buttonSelectApplicationHexFile_Click);
            // 
            // textBoxDeviceFamily
            // 
            this.textBoxDeviceFamily.Location = new System.Drawing.Point(182, 68);
            this.textBoxDeviceFamily.Name = "textBoxDeviceFamily";
            this.textBoxDeviceFamily.Size = new System.Drawing.Size(41, 21);
            this.textBoxDeviceFamily.TabIndex = 17;
            this.textBoxDeviceFamily.Text = "NRF52";
            // 
            // labelDeviceFamily
            // 
            this.labelDeviceFamily.AutoSize = true;
            this.labelDeviceFamily.Location = new System.Drawing.Point(26, 72);
            this.labelDeviceFamily.Name = "labelDeviceFamily";
            this.labelDeviceFamily.Size = new System.Drawing.Size(77, 12);
            this.labelDeviceFamily.TabIndex = 16;
            this.labelDeviceFamily.Text = "DeviceFamily";
            // 
            // textBoxBootloaderVersion
            // 
            this.textBoxBootloaderVersion.Location = new System.Drawing.Point(182, 37);
            this.textBoxBootloaderVersion.Name = "textBoxBootloaderVersion";
            this.textBoxBootloaderVersion.Size = new System.Drawing.Size(41, 21);
            this.textBoxBootloaderVersion.TabIndex = 15;
            this.textBoxBootloaderVersion.Text = "1";
            // 
            // labelBootloaderVersion
            // 
            this.labelBootloaderVersion.AutoSize = true;
            this.labelBootloaderVersion.Location = new System.Drawing.Point(26, 41);
            this.labelBootloaderVersion.Name = "labelBootloaderVersion";
            this.labelBootloaderVersion.Size = new System.Drawing.Size(107, 12);
            this.labelBootloaderVersion.TabIndex = 14;
            this.labelBootloaderVersion.Text = "BootloaderVersion";
            // 
            // labelApplicationHexFilePath
            // 
            this.labelApplicationHexFilePath.AutoSize = true;
            this.labelApplicationHexFilePath.Location = new System.Drawing.Point(207, 216);
            this.labelApplicationHexFilePath.Name = "labelApplicationHexFilePath";
            this.labelApplicationHexFilePath.Size = new System.Drawing.Size(17, 12);
            this.labelApplicationHexFilePath.TabIndex = 18;
            this.labelApplicationHexFilePath.Text = "./";
            // 
            // labelBootloaderHexFilePath
            // 
            this.labelBootloaderHexFilePath.AutoSize = true;
            this.labelBootloaderHexFilePath.Location = new System.Drawing.Point(207, 285);
            this.labelBootloaderHexFilePath.Name = "labelBootloaderHexFilePath";
            this.labelBootloaderHexFilePath.Size = new System.Drawing.Size(17, 12);
            this.labelBootloaderHexFilePath.TabIndex = 20;
            this.labelBootloaderHexFilePath.Text = "./";
            // 
            // buttonSelectBootloaderHexFile
            // 
            this.buttonSelectBootloaderHexFile.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSelectBootloaderHexFile.Location = new System.Drawing.Point(12, 260);
            this.buttonSelectBootloaderHexFile.Name = "buttonSelectBootloaderHexFile";
            this.buttonSelectBootloaderHexFile.Size = new System.Drawing.Size(189, 63);
            this.buttonSelectBootloaderHexFile.TabIndex = 19;
            this.buttonSelectBootloaderHexFile.Text = "Select Bootloader Hex File";
            this.buttonSelectBootloaderHexFile.UseVisualStyleBackColor = true;
            this.buttonSelectBootloaderHexFile.Click += new System.EventHandler(this.buttonSelectBootloaderHexFile_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonGenerate.Location = new System.Drawing.Point(12, 329);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(317, 118);
            this.buttonGenerate.TabIndex = 21;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxLog.Location = new System.Drawing.Point(12, 453);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(509, 211);
            this.textBoxLog.TabIndex = 22;
            // 
            // openFileDialogApplicationHexFile
            // 
            this.openFileDialogApplicationHexFile.Filter = "Hex(*.hex)|*.hex";
            this.openFileDialogApplicationHexFile.InitialDirectory = "./";
            this.openFileDialogApplicationHexFile.Title = "Select the Hex File";
            // 
            // openFileDialogBootloaderHexFile
            // 
            this.openFileDialogBootloaderHexFile.Filter = "Hex(*.hex)|*.hex";
            this.openFileDialogBootloaderHexFile.InitialDirectory = "./";
            this.openFileDialogBootloaderHexFile.Title = "Select the Hex File";
            // 
            // textBoxBootloaderSettingVersion
            // 
            this.textBoxBootloaderSettingVersion.Location = new System.Drawing.Point(182, 153);
            this.textBoxBootloaderSettingVersion.Name = "textBoxBootloaderSettingVersion";
            this.textBoxBootloaderSettingVersion.Size = new System.Drawing.Size(41, 21);
            this.textBoxBootloaderSettingVersion.TabIndex = 24;
            this.textBoxBootloaderSettingVersion.Text = "1";
            // 
            // labelBootloaderSettingVersion
            // 
            this.labelBootloaderSettingVersion.AutoSize = true;
            this.labelBootloaderSettingVersion.Location = new System.Drawing.Point(26, 157);
            this.labelBootloaderSettingVersion.Name = "labelBootloaderSettingVersion";
            this.labelBootloaderSettingVersion.Size = new System.Drawing.Size(149, 12);
            this.labelBootloaderSettingVersion.TabIndex = 23;
            this.labelBootloaderSettingVersion.Text = "BootloaderSettingVersion";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 676);
            this.Controls.Add(this.textBoxBootloaderSettingVersion);
            this.Controls.Add(this.labelBootloaderSettingVersion);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.labelBootloaderHexFilePath);
            this.Controls.Add(this.buttonSelectBootloaderHexFile);
            this.Controls.Add(this.labelApplicationHexFilePath);
            this.Controls.Add(this.textBoxDeviceFamily);
            this.Controls.Add(this.labelDeviceFamily);
            this.Controls.Add(this.textBoxBootloaderVersion);
            this.Controls.Add(this.labelBootloaderVersion);
            this.Controls.Add(this.buttonSelectApplicationHexFile);
            this.Controls.Add(this.textBoxSoftDeviceVersion);
            this.Controls.Add(this.labelSoftDeviceVersion);
            this.Controls.Add(this.textBoxHardwareVersion);
            this.Controls.Add(this.labelHardwareVersion);
            this.Controls.Add(this.textBoxApplicationVersion);
            this.Controls.Add(this.labelApplicationVersion);
            this.Name = "FormMain";
            this.Text = "nrfutilProductionGen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelApplicationVersion;
        private System.Windows.Forms.TextBox textBoxApplicationVersion;
        private System.Windows.Forms.Label labelHardwareVersion;
        private System.Windows.Forms.TextBox textBoxHardwareVersion;
        private System.Windows.Forms.Label labelSoftDeviceVersion;
        private System.Windows.Forms.TextBox textBoxSoftDeviceVersion;
        private System.Windows.Forms.Button buttonSelectApplicationHexFile;
        private System.Windows.Forms.TextBox textBoxDeviceFamily;
        private System.Windows.Forms.Label labelDeviceFamily;
        private System.Windows.Forms.TextBox textBoxBootloaderVersion;
        private System.Windows.Forms.Label labelBootloaderVersion;
        private System.Windows.Forms.Label labelApplicationHexFilePath;
        private System.Windows.Forms.Label labelBootloaderHexFilePath;
        private System.Windows.Forms.Button buttonSelectBootloaderHexFile;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.OpenFileDialog openFileDialogApplicationHexFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogBootloaderHexFile;
        private System.Windows.Forms.TextBox textBoxBootloaderSettingVersion;
        private System.Windows.Forms.Label labelBootloaderSettingVersion;
    }
}

