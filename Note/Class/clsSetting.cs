using System;
using System.IO;
using Microsoft.VisualBasic;
using ManageDoc;

namespace Settings
{
    class clsSetting
    {
        public struct settings
        {
            public string version;
            public string defaultPath;
            public string font;
            public int fontSize;
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
