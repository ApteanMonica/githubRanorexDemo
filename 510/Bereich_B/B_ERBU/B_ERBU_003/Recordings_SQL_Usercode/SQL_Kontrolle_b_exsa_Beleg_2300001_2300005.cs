﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace B_ERBU_003.Recordings_SQL_Usercode
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SQL_Kontrolle_b_exsa_Beleg_2300001_2300005 recording.
    /// </summary>
    [TestModule("e9303fcd-46d1-4e50-a9db-2a6e90421ab4", ModuleType.Recording, 1)]
    public partial class SQL_Kontrolle_b_exsa_Beleg_2300001_2300005 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ERBU_003.B_ERBU_003Repository repository.
        /// </summary>
        public static global::B_ERBU_003.B_ERBU_003Repository repo = global::B_ERBU_003.B_ERBU_003Repository.Instance;

        static SQL_Kontrolle_b_exsa_Beleg_2300001_2300005 instance = new SQL_Kontrolle_b_exsa_Beleg_2300001_2300005();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SQL_Kontrolle_b_exsa_Beleg_2300001_2300005()
        {
            file_selectergebnis_b_exsa_aktuell = "C:\\temp\\B_ERBU_003_B_EXSA_aktuell.txt";
            file_selectergebnis_b_exsa_Referenz = "C:\\Testdaten\\Allgemein\\SQL_Referenz_Files\\B_ERBU_003\\B_ERBU_003_B_EXSA_Referenz.txt";
            SQL_Select_B_EXSA = "select  in default value wird bei copy/paste abgeschnitten";
            Programmversion = "";
            Datenbank = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SQL_Kontrolle_b_exsa_Beleg_2300001_2300005 Instance
        {
            get { return instance; }
        }

#region Variables

        string _file_selectergebnis_b_exsa_aktuell;

        /// <summary>
        /// Gets or sets the value of variable file_selectergebnis_b_exsa_aktuell.
        /// </summary>
        [TestVariable("0601747b-8a78-41b9-8c7e-36a80ebf8472")]
        public string file_selectergebnis_b_exsa_aktuell
        {
            get { return _file_selectergebnis_b_exsa_aktuell; }
            set { _file_selectergebnis_b_exsa_aktuell = value; }
        }

        string _file_selectergebnis_b_exsa_Referenz;

        /// <summary>
        /// Gets or sets the value of variable file_selectergebnis_b_exsa_Referenz.
        /// </summary>
        [TestVariable("fffd72e5-712b-4813-a58b-de17e5d120e1")]
        public string file_selectergebnis_b_exsa_Referenz
        {
            get { return _file_selectergebnis_b_exsa_Referenz; }
            set { _file_selectergebnis_b_exsa_Referenz = value; }
        }

        string _SQL_Select_B_EXSA;

        /// <summary>
        /// Gets or sets the value of variable SQL_Select_B_EXSA.
        /// </summary>
        [TestVariable("544ccf3b-0a2f-4cd7-bbbf-6670327a0c81")]
        public string SQL_Select_B_EXSA
        {
            get { return _SQL_Select_B_EXSA; }
            set { _SQL_Select_B_EXSA = value; }
        }

        string _Programmversion;

        /// <summary>
        /// Gets or sets the value of variable Programmversion.
        /// </summary>
        [TestVariable("8ab74771-a61f-42cd-ac76-95f4ed34d8e2")]
        public string Programmversion
        {
            get { return _Programmversion; }
            set { _Programmversion = value; }
        }

        string _Datenbank;

        /// <summary>
        /// Gets or sets the value of variable Datenbank.
        /// </summary>
        [TestVariable("71c37dad-c76b-47bf-b478-b95e88d76a84")]
        public string Datenbank
        {
            get { return _Datenbank; }
            set { _Datenbank = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            //Ranorex.AutomationHelpers.UserCodeCollections.Aptean.ReadDBVersion();
            
            Programmversion = Ranorex.AutomationHelpers.UserCodeCollections.Aptean.ReadProgrammVersion("RELSP");
            
            Report.Log(ReportLevel.Info, "User", Programmversion, new RecordItemIndex(2));
            
            //Datenbank = Ranorex.AutomationHelpers.UserCodeCollections.Aptean.ReadProgrammVersion("DB");
            
            //Report.Log(ReportLevel.Info, "User", Datenbank, new RecordItemIndex(4));
            
            // aptean.cs ohne Variablen
            try {
                //Report.Log(ReportLevel.Info, "Section", "aptean.cs ohne Variablen", new RecordItemIndex(5));
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            //Ranorex.AutomationHelpers.UserCodeCollections.Aptean.SQLStatement("select\r\nb_exsa.FIRM_NR,\r\nEXSA_KEYPOS,\r\nEXSA_BER_CD6,\r\nEXSA_BEKT_NR6,\r\nEXSA_BER_CD5,\r\nEXSA_BEKT_NR5,\r\nEXSA_BER_CD4,\r\nEXSA_BEKT_NR4,\r\nEXSA_BER_CD1,\r\nEXSA_BEKT_NR1,\r\nEXSA_BER_CD2,\r\nEXSA_BEKT_NR2,\r\nEXSA_BER_CD3,\r\nEXSA_BEKT_NR3,\r\nUST_CD,\r\nEXSA_ART,\r\nEXSA_KTONR,\r\nEXSA_SKONTOKZ,\r\nEXSA_SH,\r\nEXSA_BETRAG,\r\nEXSA_FWBETRAG,\r\nEXSA_MENGE,\r\nEXSA_USTBETRAG,\r\nEXSA_USTFWBETRAG,\r\nEXSA_USTMV,\r\nEXSA_USTSATZ,\r\nEXSA_TEXT1,\r\nEXSA_TEXT2,\r\nEXSA_TEXTCD,\r\nEXSA_BESTELLNR,\r\nEXSA_LIEFSNR,\r\nANLA_NR,\r\nANLA_POS,\r\nKTBE_NR,\r\nPVT_CD,\r\nEXSA_JAHR_BUBE_VON,\r\nEXSA_MON_BUBE_VON,\r\nEXSA_JAHR_BUBE_BIS,\r\nEXSA_MON_BUBE_BIS,\r\nEXSA_FELD1,\r\nEXSA_FELD2,\r\nEXSA_FELD3,\r\nEXSA_FELD4,\r\nEXSA_UID,\r\nEXSA_ARCHIVNR,\r\nEXSA_ARCHIVDOC1,\r\nEXSA_DTLEISTUNG,\r\nEXSA_MENGE2,\r\nEXSA_DTOPFAELL,\r\nEXSA_VNROPAUSGL\r\nfrom b_exsa, b_exop\r\nwhere b_exop.firm_nr = b_exsa.firm_nr\r\nAND b_exop.exop_keybel = b_exsa.exop_keybel\r\nAND b_exop.firm_nr = '100' \r\nAND exop_belegnr BETWEEN '2300001' AND '2300005';", "C:\\temp\\B_ERBU_003_B_EXSA_aktuell.txt");
            
            //Ranorex.AutomationHelpers.UserCodeCollections.Aptean.FileCompareEqualWithoutBreaks("C:\\Testdaten\\Allgemein\\SQL_Referenz_Files\\B_ERBU_003\\B_ERBU_003_B_EXSA_Referenz.txt", "C:\\temp\\B_ERBU_003_B_EXSA_aktuell.txt");
            
            // aptean.cs mit Variablen
            Report.Log(ReportLevel.Info, "Section", "aptean.cs mit Variablen", new RecordItemIndex(8));
            
            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.SQLStatement(SQL_Select_B_EXSA, file_selectergebnis_b_exsa_aktuell);
            
            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.FileCompareEqualWithoutBreaks(file_selectergebnis_b_exsa_Referenz, file_selectergebnis_b_exsa_aktuell);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
