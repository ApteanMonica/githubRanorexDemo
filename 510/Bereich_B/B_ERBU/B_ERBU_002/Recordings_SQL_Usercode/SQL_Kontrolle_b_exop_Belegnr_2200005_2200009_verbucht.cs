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
    ///The SQL_Kontrolle_b_exop_Belegnr_2200005_2200009_verbucht recording.
    /// </summary>
    [TestModule("447cfb37-164f-4ac3-a67d-a7ccbd4b4b37", ModuleType.Recording, 1)]
    public partial class SQL_Kontrolle_b_exop_Belegnr_2200005_2200009_verbucht : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ERBU_002.B_ERBU_002Repository repository.
        /// </summary>
        public static global::B_ERBU_002.B_ERBU_002Repository repo = global::B_ERBU_002.B_ERBU_002Repository.Instance;

        static SQL_Kontrolle_b_exop_Belegnr_2200005_2200009_verbucht instance = new SQL_Kontrolle_b_exop_Belegnr_2200005_2200009_verbucht();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SQL_Kontrolle_b_exop_Belegnr_2200005_2200009_verbucht()
        {
            SQL_Select_B_EXOP = "select  in default value wird bei copy/paste abgeschnitten";
            DB_File = "C:\\Testdaten\\Allgemein\\UserCode\\datenbank.txt";
            file_selectergebnis_b_exop_verbucht_aktuell = "C:\\temp\\B_ERBU_002_B_EXOP_verbucht_aktuell.txt";
            file_selectergebnis_b_exop_verbucht_Referenz = "C:\\Testdaten\\Allgemein\\SQL_Referenz_Files\\B_ERBU_002\\B_ERBU_002_B_EXOP_verbucht_Referenz.txt";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SQL_Kontrolle_b_exop_Belegnr_2200005_2200009_verbucht Instance
        {
            get { return instance; }
        }

#region Variables

        string _SQL_Select_B_EXOP;

        /// <summary>
        /// Gets or sets the value of variable SQL_Select_B_EXOP.
        /// </summary>
        [TestVariable("836117a8-9d53-428b-827b-522efae00dd9")]
        public string SQL_Select_B_EXOP
        {
            get { return _SQL_Select_B_EXOP; }
            set { _SQL_Select_B_EXOP = value; }
        }

        string _DB_File;

        /// <summary>
        /// Gets or sets the value of variable DB_File.
        /// </summary>
        [TestVariable("3fdfcd40-0782-4ed5-b265-16b0b63d19eb")]
        public string DB_File
        {
            get { return _DB_File; }
            set { _DB_File = value; }
        }

        string _file_selectergebnis_b_exop_verbucht_aktuell;

        /// <summary>
        /// Gets or sets the value of variable file_selectergebnis_b_exop_verbucht_aktuell.
        /// </summary>
        [TestVariable("d3d3c7bc-5d1b-469a-9a3f-7fb7b98d40c7")]
        public string file_selectergebnis_b_exop_verbucht_aktuell
        {
            get { return _file_selectergebnis_b_exop_verbucht_aktuell; }
            set { _file_selectergebnis_b_exop_verbucht_aktuell = value; }
        }

        string _file_selectergebnis_b_exop_verbucht_Referenz;

        /// <summary>
        /// Gets or sets the value of variable file_selectergebnis_b_exop_verbucht_Referenz.
        /// </summary>
        [TestVariable("39140b55-00a2-4d54-ada6-851c7f1d7ec2")]
        public string file_selectergebnis_b_exop_verbucht_Referenz
        {
            get { return _file_selectergebnis_b_exop_verbucht_Referenz; }
            set { _file_selectergebnis_b_exop_verbucht_Referenz = value; }
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

            Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.ReadVersion("C:\\Testdaten\\Allgemein\\UserCode\\datenbank.txt", "c:\\temp\\version_b_exop.txt");
            
            Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.SQLStatement("select \r\nFIRM_NR,\r\nADR_NR,\r\nKLDV_NR,\r\nKLBK_NR,\r\nWRG_CD,\r\nKTO_NR,\r\nEXOP_STATUS,\r\nEXOP_ART,\r\nEXOP_KL,\r\nEXOP_JAHR,\r\nEXOP_PERIODE,\r\nEXOP_BELEGNR,\r\nEXOP_DTBELEG,\r\nEXOP_DTFREMDBELEG,\r\nEXOP_NRFREMDBELEG,\r\nEXOP_DTFAELLIG,\r\nEXOP_DTVALUTA,\r\nEXOP_TAGE1,\r\nEXOP_SKONTO1,\r\nEXOP_TAGE2,\r\nEXOP_SKONTO2,\r\nEXOP_TAGENETTO,\r\nEXOP_ZAHLART,\r\nEXOP_BETRAG,\r\nEXOP_FWBETRAG,\r\nEXOP_KURS,\r\nEXOP_RECHBETRAG,\r\nEXOP_ZAHLBETRAG,\r\nEXOP_SKONTOBASIS,\r\nEXOP_TEXT1,\r\nEXOP_TEXT2,\r\nEXOP_UEBERWTEXT,\r\nEXOP_REFBELEGNR,\r\nEXOP_BUSY,\r\nEXOP_MAHNSTUFE,\r\nEXOP_TEXTCD,\r\nEXOP_SELECT1,\r\nEXOP_SELECT2,\r\nEXOP_MAHNSPERRE,\r\nEXOP_ZAHLSPERRE,\r\nEXOP_DTEINHALT,\r\nEXOP_EHPROZ,\r\nEXOP_EHBETRAG,\r\nEXOP_FWEHBETRAG,\r\nEXOP_DTEINHALT2,\r\nEXOP_EHPROZ2,\r\nEXOP_EHBETRAG2,\r\nEXOP_FWEHBETRAG2,\r\nEXOP_BEZUG,\r\nEXOP_BEZUG2,\r\nEXOP_TEILRECHNR,\r\nEXOP_KZFIXTAGE,\r\nEXOP_MONAT1,\r\nEXOP_MONAT2,\r\nEXOP_MONATNETTO,\r\nEXOP_KZDIVERSE,\r\nEXOP_ADRESSE1,\r\nEXOP_ADRESSE2,\r\nEXOP_ADRESSE3,\r\nEXOP_ADRESSE4,\r\nEXOP_ADRESSE5,\r\nLAND_CD,\r\nPLZ_CD,\r\nEXOP_ORT,\r\nSPRA_CD,\r\nANRD_CD,\r\nEXOP_NAME,\r\nEXOP_PERSONEN,\r\nEXOP_KZOK,\r\nEXOP_USEROK,\r\nEXOP_USERHERKUNFT,\r\nEXOP_MATPREIS,\r\nEXOP_UVAJAHR,\r\nEXOP_UVAMONAT,\r\nEXOP_UVATAG,\r\nEXOP_HERKUNFT,\r\nEXOP_SELECT3,\r\nEXOP_SELECT4,\r\nEXOP_ARCHIVDOC1,\r\nUSER_CD,\r\nEXOP_KZEXOPA,\r\nFIRM_NR_RECH,\r\nEXOP_FELD1,\r\nEXOP_FELD2,\r\nEXOP_FELD3,\r\nEXOP_FELD4,\r\nEXOP_USERANLAG,\r\nEXOP_USERAENDG,\r\nEXOP_REFKEYBEL,\r\nEXOP_REFKEYPOS,\r\nEXOP_KZSKONTO,\r\nEXOP_SKBETRAG,\r\nEXOP_FWSKBETRAG,\r\nEXOP_ARCHIVNR,\r\nEXOP_ADR_RECHAD,\r\nEXOP_KLDV_RECHAD,\r\nSAMK_CD,\r\nEXOP_DTLEISTUNG,\r\nEXOP_DTMNSPBIS,\r\nRTK_NR,\r\nEXOP_KZAUSGL,\r\nEXOP_KZSTORNO,\r\nEXOP_STORNOGRUND,\r\nEXOP_KZZINSEN,\r\nEXOP_BELTYP,\r\nEXOP_ZNSBETRAG,\r\nEXOP_FWZNSBETRAG,\r\nMNV_NR,\r\nEXOP_DTZLSPBIS,\r\nZART_CD,\r\nEXOP_KZRECHTSKR,\r\nADR_NR_ZAHLUNG,\r\nKLBK_NR_ZAHLUNG,\r\nEXBK_NR,\r\nEXBP_NR,\r\nEXBO_NR,\r\nEXOP_RTKREF,\r\nRST_CD,\r\nEXOP_FELD01,\r\nEXOP_FELD02,\r\nEXOP_FELD03,\r\nEXOP_FELD04,\r\nEXOP_FELD05,\r\nEXOP_USERVWDG\r\nfrom b_exop where firm_nr = '100' and exop_belegnr BETWEEN '2200005' AND '2200009';", DB_File, "C:\\temp\\B_ERBU_002_B_EXOP_verbucht_aktuell.txt");
            
            Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.FileCompareEqual(file_selectergebnis_b_exop_verbucht_aktuell, file_selectergebnis_b_exop_verbucht_Referenz);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}