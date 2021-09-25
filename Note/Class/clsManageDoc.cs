using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ManageDoc
{
    class clsManageDoc
    {
        public static bool existFile(string path) 
        {
            if (File.Exists(path))
                return true;
            else
                return false;
        }

        public static void createFile(string path)
        {
            try
            {
                var file = File.Create(path);
                file.Close();
            }catch(Exception ex)
            {
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.Critical, "Errore");
            }
        }

        public static string chooseFile()
        {
            string path = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
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
            string path = string.Empty;

            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
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
