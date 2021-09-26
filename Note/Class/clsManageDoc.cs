using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ManageDoc
{
    class clsManageDoc
    {
        /*
         * Classe che gestisce i dicumenti, creazione, eliminazione, rinomina, esistenza...
         * TODO:
         */

        public static bool existFile(string path) 
        {
            //Funzione che verifica se il file esiste, non so perchè ho creato un sottoprogramma solo per questo, ma fa niente
            if (File.Exists(path))
                return true;
            else
                return false;
        }

        public static void createFile(string path)
        {
            //Procedura per creare in file in un path specificato
            //In caso di errore mostra una message box contenente il codice dell'errore
            //Per informazioni sul try catch visita il wiki del progetto github
            try
            {
                var file = File.Create(path);
                file.Close();
            }catch(Exception ex)
            {
                Interaction.MsgBox("Impossibile creare il file", MsgBoxStyle.Critical, "Errore");
            }
        }

        public static string chooseFile()
        {
            //Funzione per sciegliere il path di un file specifico solamente .txt, restituisce direttamente la stringa path
            string path = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                }
            }

            return path;
        }

        public static string chooseFolder()
        {
            //Funzione per sciegliere il path della cartella, restituisce direttamente la stringa path
            string path = string.Empty;

            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;

            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }

            return path;
        }
    }
}
