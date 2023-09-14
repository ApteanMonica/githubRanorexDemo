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

namespace B_ERBU_002.Recordings_SQL_Usercode
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SQL_Kontrolle_b_exsa_Belegnr_2200005_2200009_uebergeleitet recording.
    /// </summary>
    [TestModule("d521659b-71f0-4410-9511-ba1f7a7cd427", ModuleType.Recording, 1)]
    public partial class SQL_Kontrolle_b_exsa_Belegnr_2200005_2200009_uebergeleitet : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ERBU_002.B_ERBU_002Repository repository.
        /// </summary>
        public static global::B_ERBU_002.B_ERBU_002Repository repo = global::B_ERBU_002.B_ERBU_002Repository.Instance;

        static SQL_Kontrolle_b_exsa_Belegnr_2200005_2200009_uebergeleitet instance = new SQL_Kontrolle_b_exsa_Belegnr_2200005_2200009_uebergeleitet();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SQL_Kontrolle_b_exsa_Belegnr_2200005_2200009_uebergeleitet()
        {
            SQL_Select_B_EXSA = "select  in default value wird bei copy/paste abgeschnitten";
            DB_File = "C:\\Testdaten\\Allgemein\\UserCode\\datenbank.txt";
            file_selectergebnis_b_exsa_uebergeleitet_aktuell = "C:\\temp\\B_ERBU_002_B_EXSA_uebergeleitet_aktuell.txt";
            file_selectergebnis_b_exsa_uebergeleitet_Referenz = "C:\\Testdaten\\Allgemein\\SQL_Referenz_Files\\B_ERBU_002\\B_ERBU_002_B_EXSA_uebergeleitet_Referenz.txt";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SQL_Kontrolle_b_exsa_Belegnr_2200005_2200009_uebergeleitet Instance
        {
            get { return instance; }
        }

#region Variables

        string _SQL_Select_B_EXSA;

        /// <summary>
        /// Gets or sets the value of variable SQL_Select_B_EXSA.
        /// </summary>
        [TestVariable("47623fb2-1dae-45fb-9ca6-698fab4b1809")]
        public string SQL_Select_B_EXSA
        {
            get { return _SQL_Select_B_EXSA; }
            set { _SQL_Select_B_EXSA = value; }
        }

        string _DB_File;

        /// <summary>
        /// Gets or sets the value of variable DB_File.
        /// </summary>
        [TestVariable("5af44d52-2332-4d06-beae-0e27379d599e")]
        public string DB_File
        {
            get { return _DB_File; }
            set { _DB_File = value; }
        }

        string _file_selectergebnis_b_exsa_uebergeleitet_aktuell;

        /// <summary>
        /// Gets or sets the value of variable file_selectergebnis_b_exsa_uebergeleitet_aktuell.
        /// </summary>
        [TestVariable("fe1598f7-913b-4976-bfa4-28ea6a9cdce3")]
        public string file_selectergebnis_b_exsa_uebergeleitet_aktuell
        {
            get { return _file_selectergebnis_b_exsa_uebergeleitet_aktuell; }
            set { _file_selectergebnis_b_exsa_uebergeleitet_aktuell = value; }
        }

        string _file_selectergebnis_b_exsa_uebergeleitet_Referenz;

        /// <summary>
        /// Gets or sets the value of variable file_selectergebnis_b_exsa_uebergeleitet_Referenz.
        /// </summary>
        [TestVariable("52c82d11-f197-41c8-b47b-d9865e73268f")]
        public string file_selectergebnis_b_exsa_uebergeleitet_Referenz
        {
            get { return _file_selectergebnis_b_exsa_uebergeleitet_Referenz; }
            set { _file_selectergebnis_b_exsa_uebergeleitet_Referenz = value; }
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

            Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.ReadVersion("C:\\Testdaten\\Allgemein\\UserCode\\datenbank.txt", "c:\\temp\\version_b_exsa.txt");
            
            Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.SQLStatement("select\r\nb_exsa.FIRM_NR,\r\nEXSA_KEYPOS,\r\nEXSA_BER_CD6,\r\nEXSA_BEKT_NR6,\r\nEXSA_BER_CD5,\r\nEXSA_BEKT_NR5,\r\nEXSA_BER_CD4,\r\nEXSA_BEKT_NR4,\r\nEXSA_BER_CD1,\r\nEXSA_BEKT_NR1,\r\nEXSA_BER_CD2,\r\nEXSA_BEKT_NR2,\r\nEXSA_BER_CD3,\r\nEXSA_BEKT_NR3,\r\nUST_CD,\r\nEXSA_ART,\r\nEXSA_KTONR,\r\nEXSA_SKONTOKZ,\r\nEXSA_SH,\r\nEXSA_BETRAG,\r\nEXSA_FWBETRAG,\r\nEXSA_MENGE,\r\nEXSA_USTBETRAG,\r\nEXSA_USTFWBETRAG,\r\nEXSA_USTMV,\r\nEXSA_USTSATZ,\r\nEXSA_TEXT1,\r\nEXSA_TEXT2,\r\nEXSA_TEXTCD,\r\nEXSA_BESTELLNR,\r\nEXSA_LIEFSNR,\r\nANLA_NR,\r\nANLA_POS,\r\nKTBE_NR,\r\nPVT_CD,\r\nEXSA_JAHR_BUBE_VON,\r\nEXSA_MON_BUBE_VON,\r\nEXSA_JAHR_BUBE_BIS,\r\nEXSA_MON_BUBE_BIS,\r\nEXSA_FELD1,\r\nEXSA_FELD2,\r\nEXSA_FELD3,\r\nEXSA_FELD4,\r\nEXSA_UID,\r\nEXSA_ARCHIVNR,\r\nEXSA_ARCHIVDOC1,\r\nEXSA_DTLEISTUNG,\r\nEXSA_MENGE2,\r\nEXSA_DTOPFAELL,\r\nEXSA_VNROPAUSGL\r\nfrom b_exsa, b_exop\r\nwhere b_exop.firm_nr = b_exsa.firm_nr\r\nAND b_exop.exop_keybel = b_exsa.exop_keybel\r\nAND b_exop.firm_nr = '100' \r\nAND exop_belegnr BETWEEN '2200005' AND '2200009';", DB_File, "C:\\temp\\B_ERBU_002_B_EXSA_uebergeleitet_aktuell.txt");
            
            Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.FileCompareEqual(file_selectergebnis_b_exsa_uebergeleitet_aktuell, file_selectergebnis_b_exsa_uebergeleitet_Referenz);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
