using LoadFileToDb.WinForm.TestUI.ProcessFileSrvRef;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadFileToDb.WinForm.TestUI
{
    public partial class FrmPirncipal : Form
    {
        public FrmPirncipal()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            this.Text = ConfigurationManager.AppSettings["CaptionForm"];
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ucFileToProcess.TxtPathFname.Text = ConfigurationManager.AppSettings["defPathFName"];
        }

        private void tlsStrBtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tlsStrBtnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessFileToDBSrvClient client = new ProcessFileToDBSrvClient();
                string pathFname = ucFileToProcess.TxtPathFname.Text;
                FileInfo fileInfo = new FileInfo(pathFname);
                RemoteFileInfo remoteFileInfo = new RemoteFileInfo();   
                using(FileStream fs = new FileStream(pathFname, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    remoteFileInfo.Filename = Path.GetFileName(pathFname);
                    remoteFileInfo.FileByteStream = fs;
                    remoteFileInfo.Length = fs.Length;
                    client.UploadFile(remoteFileInfo.Filename, remoteFileInfo.Length, remoteFileInfo.FileByteStream);
                }
                MessageBox.Show("Archivo subido correctamente ...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
