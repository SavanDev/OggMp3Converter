namespace OggMp3Converter
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.rndOGG = new System.Windows.Forms.RadioButton();
            this.rndMP3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolLanguage = new System.Windows.Forms.ToolStripDropDownButton();
            this.spanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File to convert";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(15, 25);
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(243, 20);
            this.txtInput.TabIndex = 1;
            // 
            // rndOGG
            // 
            this.rndOGG.AutoSize = true;
            this.rndOGG.Enabled = false;
            this.rndOGG.Location = new System.Drawing.Point(354, 26);
            this.rndOGG.Name = "rndOGG";
            this.rndOGG.Size = new System.Drawing.Size(49, 17);
            this.rndOGG.TabIndex = 3;
            this.rndOGG.TabStop = true;
            this.rndOGG.Text = "OGG";
            this.rndOGG.UseVisualStyleBackColor = true;
            // 
            // rndMP3
            // 
            this.rndMP3.AutoSize = true;
            this.rndMP3.Enabled = false;
            this.rndMP3.Location = new System.Drawing.Point(409, 26);
            this.rndMP3.Name = "rndMP3";
            this.rndMP3.Size = new System.Drawing.Size(47, 17);
            this.rndMP3.TabIndex = 4;
            this.rndMP3.TabStop = true;
            this.rndMP3.Text = "MP3";
            this.rndMP3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ouput folder";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(15, 74);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(243, 20);
            this.txtOutput.TabIndex = 6;
            // 
            // btnConvert
            // 
            this.btnConvert.Image = global::OggMp3Converter.Properties.Resources.media_record;
            this.btnConvert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConvert.Location = new System.Drawing.Point(345, 71);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(111, 23);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert";
            this.btnConvert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Image = global::OggMp3Converter.Properties.Resources.document_open;
            this.btnOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOutput.Location = new System.Drawing.Point(264, 72);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 23);
            this.btnOutput.TabIndex = 7;
            this.btnOutput.Text = "Examine";
            this.btnOutput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnInput
            // 
            this.btnInput.Image = global::OggMp3Converter.Properties.Resources.document_open;
            this.btnInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInput.Location = new System.Drawing.Point(264, 23);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "Examine";
            this.btnInput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 109);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(441, 23);
            this.progressBar.TabIndex = 9;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.toolLanguage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 146);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(468, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(379, 17);
            this.lblStatus.Spring = true;
            this.lblStatus.Text = "Status: IDLE";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolLanguage
            // 
            this.toolLanguage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spanishToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.toolLanguage.Image = global::OggMp3Converter.Properties.Resources.preferences_desktop_font;
            this.toolLanguage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLanguage.Name = "toolLanguage";
            this.toolLanguage.Size = new System.Drawing.Size(74, 20);
            this.toolLanguage.Text = "English";
            // 
            // spanishToolStripMenuItem
            // 
            this.spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
            this.spanishToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spanishToolStripMenuItem.Text = "Spanish";
            this.spanishToolStripMenuItem.Click += new System.EventHandler(this.spanishToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Checked = true;
            this.englishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 168);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rndMP3);
            this.Controls.Add(this.rndOGG);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Audio Converter for HaxeFlixel";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.RadioButton rndOGG;
        private System.Windows.Forms.RadioButton rndMP3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripDropDownButton toolLanguage;
        private System.Windows.Forms.ToolStripMenuItem spanishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
    }
}

