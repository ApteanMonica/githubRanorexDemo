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
    ///The SQL_Abfrage_Beleg_1001 recording.
    /// </summary>
    [TestModule("9d4f59a9-9ef3-4f29-809b-8ca0da01da29", ModuleType.Recording, 1)]
    public partial class SQL_Abfrage_Beleg_1001 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHLV_001.B_ZAHLV_001Repository repository.
        /// </summary>
        public static global::B_ZAHLV_001.B_ZAHLV_001Repository repo = global::B_ZAHLV_001.B_ZAHLV_001Repository.Instance;

        static SQL_Abfrage_Beleg_1001 instance = new SQL_Abfrage_Beleg_1001();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SQL_Abfrage_Beleg_1001()
        {
            SQL_Select_B_BUSA = "select BUSA_USERAENDG,FIRM_NR,BUSA_KEYPOS,KTO_NR,GKTO_NR,UST_CD,WRG_CD,BUSA_BUSY,ADR_NR,BUSA_STATUS,BUSA_JOURNAL,BUSA_JAHR,BUSA_PERIODE,BUSA_DTBELEG,BUSA_BELEGNR,BUSA_KL,BUSA_SH,BUSA_ART,BUSA_BERKZ,BUSA_SKONTOKZ,BUSA_BETRAG,BUSA_FWBETRAG,BUSA_KURS,BUSA_MENGE,BUSA_USTMV,";
            DB_File = "C:\\Testdaten\\Allgemein\\UserCode\\datenbank.txt";
            file_selectergebnis_b_busa_aktuell = "C:\\temp\\B_ZAHLV_001_B_BUSA_aktuell.txt";
            file_selectergebnis_b_busa_Referenz = "C:\\Testdaten\\Allgemein\\SQL_Referenz_Files\\B_ZAHLV_001\\B_ZAHLV_001_B_BUSA_Referenz.txt";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SQL_Abfrage_Beleg_1001 Instance
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

            //file_selectergebnis_b_busa_aktuell = Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.SQLStatement(SQL_Select_B_BUSA, DB_File, "C:\\temp\\B_ZAHLV_001_B_BUSA_aktuell.txt");
            
            file_selectergebnis_b_busa_aktuell = Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.SQLStatement("Select\r\nBUSA_USERAENDG,FIRM_NR,BUSA_KEYPOS,KTO_NR,GKTO_NR,UST_CD,WRG_CD,BUSA_BUSY,ADR_NR,BUSA_STATUS,BUSA_JOURNAL,BUSA_JAHR,BUSA_PERIODE,BUSA_DTBELEG,BUSA_BELEGNR,BUSA_KL,BUSA_SH,BUSA_ART,BUSA_BERKZ,BUSA_SKONTOKZ,BUSA_BETRAG,BUSA_FWBETRAG,BUSA_KURS,BUSA_MENGE,BUSA_USTMV,\r\nBUSA_USTSATZ,BUSA_USTAUFT,BUSA_USTBETRAG,BUSA_USTFWBETRAG,BUSA_CD1,BUSA_CD2,BUSA_CD3,BUSA_VERARB1,BUSA_VERARB2,BUSA_VERARB3,BUSA_OP,BUSA_NROPAUSGL,BUSA_DTOPAUSGL,BUSA_DTOPFAELL,BUSA_ANZAHLUNG,BUSA_REFART,BUSA_REFBELEGNR,BUSA_REFKEYBEL,BUSA_REFKEYPOS,BUSA_UVAJAHR,BUSA_UVAMONAT,BUSA_UVATAG,BUSA_USTSTATUS,BUSA_TYP,UST_UVACD,BUSA_BEZUG,BUSA_BEZUG2,BUSA_TEXT,BUSA_TEXT2,BUSA_BESTELLNR,BUSA_LIEFSNR,ANLA_NR,ANLA_POS,BUSA_USTAUFTBETRAG,BUSA_NRFREMDBELEG,BUSA_DTFREMDBELEG,BUSA_USERJOURNAL,KTBE_NR,BUSA_USERHERKUNFT,WEOP_BELEGNR,WEOP_STATUS,BUSA_ARCHIVNR,BUSA_UID,BUSA_ARCHIVDOC1,BUSA_DTSTOLOE,BUSA_USERSTOLOE,BUSA_PROGSTOLOE,BUSA_PERI_BUBE_VON,BUSA_PERI_BUBE_BIS,BUSA_FELD1,BUSA_FELD2,BUSA_JAHR_BUBE_VON,BUSA_FELD3,BUSA_JAHR_BUBE_BIS,BUSA_FELD4,PVT_CD,BUSA_HERKUNFT,BUSA_DTHERKUNFT,BUSA_SKBETRAG,BUSA_SKUSTBETRAG,BUSA_SKFWBETRAG,BUSA_SKFWUSTBETRAG,LAND_CD_ONACE,BUSA_SAOPKZEB,BUSA_DTLEISTUNG,BUSA_USEREXOP,BUSA_DTABGLEICH,BUSA_KZSTORNO,BUSA_STORNOGRUND,BUSA_STOKEYBEL,BUSA_STOKEYPOS,BUSA_KZKLEINRG,BUSA_VSECODE,BUSA_VSESUBCODE,BUSA_MENGE2,BUSA_KEYBEL_STORNO,BUSA_KZBN,BUSA_PMTINFID,RST_CD,BUSA_SORT_PK,BUSA_KEYPOS_SKT\r\nfrom b_busa\r\nwhere firm_nr = '100'\r\nand busa_belegnr = '1001';", DB_File, "C:\\temp\\B_ZAHLV_001_B_BUSA_aktuell.txt");
            
            //Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.FileCompareContains(file_selectergebnis_b_busa_Referenz, file_selectergebnis_b_busa_aktuell);
            
            Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.FileCompareContains("C:\\Testdaten\\Allgemein\\SQL_Referenz_Files\\B_ZAHLV_001\\B_ZAHLV_001_B_BUSA_Referenz.txt", "C:\\temp\\B_ZAHLV_001_B_BUSA_aktuell.txt");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
