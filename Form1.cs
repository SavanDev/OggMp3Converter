using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OggMp3Converter
{
    enum Language
    {
        English,
        Spanish
    }

    public partial class Form1 : Form
    {
        private CSAudioConverter.AudioConverter audioConverter;
        private OpenFileDialog openFileDialog;
        private FolderBrowserDialog folderBrowserDialog;
        private Language language = Language.English;

        private string fileName;

        public Form1()
        {
            audioConverter = new CSAudioConverter.AudioConverter();
            openFileDialog = new OpenFileDialog();
            folderBrowserDialog = new FolderBrowserDialog();

            openFileDialog.Title = language == Language.English ? "Select a file to convert" : "Selecciona un archivo a convertir";
            openFileDialog.Filter = "Sound file (*.ogg;*.mp3)|*.ogg;*.mp3|OGG Vorbis (*.ogg)|*.ogg|MP3 file (*.mp3)|*.mp3";

            audioConverter.ConvertProgress += AudioConverter_ConvertProgress;
            audioConverter.ConvertError += AudioConverter_ConvertError;
            audioConverter.ConvertDone += AudioConverter_ConvertDone;
            audioConverter.ConvertStart += AudioConverter_ConvertStart;

            InitializeComponent();
        }

        private void AudioConverter_ConvertStart(object sender, EventArgs e)
        {
            lblStatus.Text = language == Language.English ? "Status: STARTING" : "Estado: INICIANDO";
            progressBar.Value = 0;
            btnConvert.Enabled = false;
            toolLanguage.Enabled = false;
        }

        private void AudioConverter_ConvertDone(object sender, EventArgs e)
        {
            MessageBox.Show(language == Language.English ? "File converted successfully!" : "¡Archivo convertido con éxito!");
            lblStatus.Text = language == Language.English ? "Status: IDLE" : "Estado: INACTIVO";
            btnConvert.Enabled = true;
            toolLanguage.Enabled = true;
        }

        private void AudioConverter_ConvertError(object sender, CSAudioConverter.MessageArgs e)
        {
            MessageBox.Show((language == Language.English ? "An error has occurred:\n" : "Ha ocurrido un error:\n") + e.String);
            lblStatus.Text = language == Language.English ? "Status: ERROR" : "Estado: ERROR";
        }

        private void AudioConverter_ConvertProgress(object sender, CSAudioConverter.PercentArgs e)
        {
            lblStatus.Text = (language == Language.English ? "Status: CONVERTING" : "Estado: CONVIRTIENDO") + $" ({e.Number}%)";
            progressBar.Value = e.Number;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtInput.Text = openFileDialog.FileName;

                if (openFileDialog.FileName.Contains(".ogg"))
                {
                    rndOGG.Checked = true;
                    fileName = openFileDialog.SafeFileName.Replace(".ogg", "");
                }
                else
                {
                    rndMP3.Checked = true;
                    fileName = openFileDialog.SafeFileName.Replace(".mp3", "");
                }
                    
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtOutput.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length > 0 && txtOutput.Text.Length > 0)
            {
                audioConverter.DestinatioFile = txtOutput.Text + "\\" + fileName + (rndOGG.Checked ? ".mp3" : ".ogg");
                audioConverter.Format = rndOGG.Checked ? CSAudioConverter.Format.MP3 : CSAudioConverter.Format.OGG;

                audioConverter.SourceFiles.Clear();
                Options.Core.SourceFile sourceFile = new Options.Core.SourceFile(txtInput.Text);
                audioConverter.SourceFiles.Add(sourceFile);

                audioConverter.Convert();
            }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            language = Language.English;
            label1.Text = "File to convert";
            label2.Text = "Output folder";
            btnInput.Text = btnOutput.Text = "Examine";
            btnConvert.Text = "Convert";
            toolLanguage.Text = "English";
            englishToolStripMenuItem.Checked = true;
            spanishToolStripMenuItem.Checked = false;
            lblStatus.Text = "Status: IDLE";
        }

        private void spanishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            language = Language.Spanish;
            label1.Text = "Archivo a convertir";
            label2.Text = "Carpeta destino";
            btnInput.Text = btnOutput.Text = "Examinar";
            btnConvert.Text = "Convertir";
            toolLanguage.Text = "Spanish";
            englishToolStripMenuItem.Checked = false;
            spanishToolStripMenuItem.Checked = true;
            lblStatus.Text = "Estado: INACTIVO";
        }
    }
}
