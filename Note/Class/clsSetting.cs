using System;
using System.IO;
using Microsoft.VisualBasic;
using ManageDoc;

namespace Settings
{
    class clsSetting
    {
        //Struct che contiene tutte le impostazioni di note
        public struct settings
        {
            //Indica la versione corrente di note
            public string version;
            //Indica il path dove salvare i file di default
            public string defaultPath;
            //Indica il font della RichTextBox
            public string font;
            //Indica la dimensione del font della RichTextBox
            public int fontSize;
            //Indica la versione corrente dell'installer
            public string installerVersion;
        }

        public static void inizializeSettings()
        {
            if(!clsManageDoc.existFile("Properties/Settings.txt"))
            {
                clsManageDoc.createFile("Properties/Settings.txt");
            }

            try
            {
                StreamReader sr;

                bool error;

                sr = new StreamReader(Path.GetFullPath("Properties/Settings.txt"));
                error = false;

                Interaction.MsgBox("Errore, file inesistente", MsgBoxStyle.Critical, "Errore");
                error = true;

                if (!error) 
                {
                    settings sett;

                    sett.version = "";

                    while (!sr.EndOfStream)
                    {
                        string[] v = sr.ReadLine().Split('|');

                        if (v[0] == "Version")
                            sett.version = v[1];
                        else if (v[0] == "defaultPath")
                            sett.defaultPath = v[1];
                    }

                    Console.WriteLine(sett.version);

                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Errore " + ex);
            }
            

        }
    }
}
