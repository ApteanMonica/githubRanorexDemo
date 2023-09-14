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

namespace B_ZAHLV_001.Recordings_SQL_Usercode
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SQL_Kontrolle_b_busa_Beleg_1001 recording.
    /// </summary>
    [TestModule("9d4f59a9-9ef3-4f29-809b-8ca0da01da29", ModuleType.Recording, 1)]
    public partial class SQL_Kontrolle_b_busa_Beleg_1001 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHLV_001.B_ZAHLV_001Repository repository.
        /// </summary>
        public static global::B_ZAHLV_001.B_ZAHLV_001Repository repo = global::B_ZAHLV_001.B_ZAHLV_001Repository.Instance;

        static SQL_Kontrolle_b_busa_Beleg_1001 instance = new SQL_Kontrolle_b_busa_Beleg_1001();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SQL_Kontrolle_b_busa_Beleg_1001()
        {
            SQL_Select_B_BUSA = "select  in default value wird bei copy/paste abgeschnitten";
            DB_File = "C:\\Testdaten\\Allgemein\\UserCode\\datenbank.txt";
            file_selectergebnis_b_busa_aktuell = "C:\\temp\\B_ZAHLV_001_B_BUSA_aktuell.txt";
            file_selectergebnis_b_busa_Referenz = "C:\\Testdaten\\Allgemein\\SQL_Referenz_Files\\B_ZAHLV_001\\B_ZAHLV_001_B_BUSA_Referenz.txt";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SQL_Kontrolle_b_busa_Beleg_1001 Instance
        {
            get { return instance; }
        }

#region Variables

        string _SQL_Select_B_BUSA;

        /// <summary>
        /// Gets or sets the value of variable SQL_Select_B_BUSA.
        /// </summary>
        [TestVariable("70edba51-7fb8-4239-95ab-25dc436e0ffb")]
        public string SQL_Select_B_BUSA
        {
            get { return _SQL_Select_B_BUSA; }
            set { _SQL_Select_B_BUSA = value; }
        }

        string _DB_File;

        /// <summary>
        /// Gets or sets the value of variable DB_File.
        /// </summary>
        [TestVariable("b2ddc891-35e9-42a4-bb53-685bf4b418bb")]
        public string DB_File
        {
            get { return _DB_File; }
            set { _DB_File = value; }
        }

        string _file_selectergebnis_b_busa_aktuell;

        /// <summary>
        /// Gets or sets the value of variable file_selectergebnis_b_busa_aktuell.
        /// </summary>
        [TestVariable("32df8d2d-a9cb-4e59-ae9f-8d2f302926a7")]
        public string file_selectergebnis_b_busa_aktuell
        {
            get { return _file_selectergebnis_b_busa_aktuell; }
            set { _file_selectergebnis_b_busa_aktuell = value; }
        }

        string _file_selectergebnis_b_busa_Referenz;

        /// <summary>
        /// Gets or sets the value of variable file_selectergebnis_b_busa_Referenz.
        /// </summary>
        [TestVariable("64f5aaec-2205-498c-83d3-79694ec03669")]
        public string file_selectergebnis_b_busa_Referenz
        {
            get { return _file_selectergebnis_b_busa_Referenz; }
            set { _file_selectergebnis_b_busa_Referenz = value; }
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

            Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.ReadVersion("C:\\Testdaten\\Allgemein\\UserCode\\datenbank.txt", "c:\\temp\\version_b_busa.txt");
            
            //file_selectergebnis_b_busa_aktuell = Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.SQLStatement(SQL_Select_B_BUSA, DB_File, "C:\\temp\\B_ZAHLV_001_B_BUSA_aktuell.txt");
            
            Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.SQLStatement("select  \r\nBUSA_USERAENDG,\r\nFIRM_NR,\r\nBUSA_KEYPOS,\r\nKTO_NR,\r\nGKTO_NR,\r\nUST_CD,\r\nWRG_CD,\r\nBUSA_BUSY,\r\nADR_NR,\r\nBUSA_STATUS,\r\nBUSA_JOURNAL,\r\nBUSA_JAHR,\r\nBUSA_PERIODE,\r\nBUSA_DTBELEG,\r\nBUSA_BELEGNR,\r\nBUSA_KL,\r\nBUSA_SH,\r\nBUSA_ART,\r\nBUSA_BERKZ,\r\nBUSA_SKONTOKZ,\r\nBUSA_BETRAG,\r\nBUSA_FWBETRAG,\r\nBUSA_KURS,\r\nBUSA_MENGE,\r\nBUSA_USTMV,\r\nBUSA_USTSATZ,\r\nBUSA_USTAUFT,\r\nBUSA_USTBETRAG,\r\nBUSA_USTFWBETRAG,\r\nBUSA_CD1,\r\nBUSA_CD2,\r\nBUSA_CD3,\r\nBUSA_VERARB1,\r\nBUSA_VERARB2,\r\nBUSA_VERARB3,\r\nBUSA_OP,\r\nBUSA_NROPAUSGL,\r\nBUSA_DTOPAUSGL,\r\nBUSA_DTOPFAELL,\r\nBUSA_ANZAHLUNG,\r\nBUSA_REFART,\r\nBUSA_REFBELEGNR,\r\nBUSA_REFKEYBEL,\r\nBUSA_REFKEYPOS,\r\nBUSA_UVAJAHR,\r\nBUSA_UVAMONAT,\r\nBUSA_UVATAG,\r\nBUSA_USTSTATUS,\r\nBUSA_TYP,\r\nUST_UVACD,\r\nBUSA_BEZUG,\r\nBUSA_BEZUG2,\r\nBUSA_TEXT,\r\nBUSA_TEXT2,\r\nBUSA_BESTELLNR,\r\nBUSA_LIEFSNR,\r\nANLA_NR,\r\nANLA_POS,\r\nBUSA_USTAUFTBETRAG,\r\nBUSA_NRFREMDBELEG,\r\nBUSA_DTFREMDBELEG,\r\nBUSA_USERJOURNAL,\r\nKTBE_NR,\r\nBUSA_USERHERKUNFT,\r\nWEOP_BELEGNR,\r\nWEOP_STATUS,\r\nBUSA_ARCHIVNR,\r\nBUSA_UID,\r\nBUSA_ARCHIVDOC1,\r\nBUSA_DTSTOLOE,\r\nBUSA_USERSTOLOE,\r\nBUSA_PROGSTOLOE,\r\nBUSA_PERI_BUBE_VON,\r\nBUSA_PERI_BUBE_BIS,\r\nBUSA_FELD1,\r\nBUSA_FELD2,\r\nBUSA_JAHR_BUBE_VON,\r\nBUSA_FELD3,\r\nBUSA_JAHR_BUBE_BIS,\r\nBUSA_FELD4,\r\nPVT_CD,\r\nBUSA_HERKUNFT,\r\nBUSA_DTHERKUNFT,\r\nBUSA_SKBETRAG,\r\nBUSA_SKUSTBETRAG,\r\nBUSA_SKFWBETRAG,\r\nBUSA_SKFWUSTBETRAG,\r\nLAND_CD_ONACE,\r\nBUSA_SAOPKZEB,\r\nBUSA_DTLEISTUNG,\r\nBUSA_USEREXOP,\r\nBUSA_DTABGLEICH,\r\nBUSA_KZSTORNO,\r\nBUSA_STORNOGRUND,\r\nBUSA_STOKEYBEL,\r\nBUSA_STOKEYPOS,\r\nBUSA_KZKLEINRG,\r\nBUSA_VSECODE,\r\nBUSA_VSESUBCODE,\r\nBUSA_MENGE2,\r\nBUSA_KEYBEL_STORNO,\r\nBUSA_KZBN,\r\nBUSA_PMTINFID,\r\nRST_CD,\r\nBUSA_SORT_PK,\r\nBUSA_KEYPOS_SKT\r\nfrom b_busa where firm_nr = '100' and busa_belegnr = '1001';", "C:\\Testdaten\\Allgemein\\UserCode\\datenbank.txt", "C:\\temp\\B_ZAHLV_001_B_BUSA_aktuell.txt");
            
            //Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.FileCompareContains(file_selectergebnis_b_busa_Referenz, file_selectergebnis_b_busa_aktuell);
            
            Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.FileCompareContains("C:\\Testdaten\\Allgemein\\SQL_Referenz_Files\\B_ZAHLV_001\\B_ZAHLV_001_B_BUSA_Referenz.txt", "C:\\temp\\B_ZAHLV_001_B_BUSA_aktuell.txt");
            
            Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.FileCompareEqual(file_selectergebnis_b_busa_Referenz, file_selectergebnis_b_busa_aktuell);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
