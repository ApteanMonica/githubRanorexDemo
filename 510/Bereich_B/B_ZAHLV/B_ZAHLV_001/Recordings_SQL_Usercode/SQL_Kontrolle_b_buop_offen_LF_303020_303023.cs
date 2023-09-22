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
    ///The SQL_Kontrolle_b_buop_offen_LF_303020_303023 recording.
    /// </summary>
    [TestModule("de7e28c1-932f-4774-9acd-61c34fac9c94", ModuleType.Recording, 1)]
    public partial class SQL_Kontrolle_b_buop_offen_LF_303020_303023 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHLV_001.B_ZAHLV_001Repository repository.
        /// </summary>
        public static global::B_ZAHLV_001.B_ZAHLV_001Repository repo = global::B_ZAHLV_001.B_ZAHLV_001Repository.Instance;

        static SQL_Kontrolle_b_buop_offen_LF_303020_303023 instance = new SQL_Kontrolle_b_buop_offen_LF_303020_303023();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SQL_Kontrolle_b_buop_offen_LF_303020_303023()
        {
            SQL_Select_B_BUOP_offen = "select  wir abgeschnitten bei copy/paste in Default value";
            file_selectergebnis_b_buop_offen_aktuell = "C:\\temp\\B_ZAHLV_001_B_BUOP_offen_aktuell.txt";
            file_selectergebnis_b_buop_offen_Referenz = "C:\\Testdaten\\Allgemein\\SQL_Referenz_Files\\B_ZAHLV_001\\B_ZAHLV_001_B_BUOP_offen_Referenz.txt";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SQL_Kontrolle_b_buop_offen_LF_303020_303023 Instance
        {
            get { return instance; }
        }

#region Variables

        string _SQL_Select_B_BUOP_offen;

        /// <summary>
        /// Gets or sets the value of variable SQL_Select_B_BUOP_offen.
        /// </summary>
        [TestVariable("e0bda171-4f7e-4617-82e5-678f51e22485")]
        public string SQL_Select_B_BUOP_offen
        {
            get { return _SQL_Select_B_BUOP_offen; }
            set { _SQL_Select_B_BUOP_offen = value; }
        }

        string _file_selectergebnis_b_buop_offen_aktuell;

        /// <summary>
        /// Gets or sets the value of variable file_selectergebnis_b_buop_offen_aktuell.
        /// </summary>
        [TestVariable("c7aa1087-4741-41a8-a359-5566d37c702d")]
        public string file_selectergebnis_b_buop_offen_aktuell
        {
            get { return _file_selectergebnis_b_buop_offen_aktuell; }
            set { _file_selectergebnis_b_buop_offen_aktuell = value; }
        }

        string _file_selectergebnis_b_buop_offen_Referenz;

        /// <summary>
        /// Gets or sets the value of variable file_selectergebnis_b_buop_offen_Referenz.
        /// </summary>
        [TestVariable("2d2a881c-6b6a-4475-bf25-9790dbb8e260")]
        public string file_selectergebnis_b_buop_offen_Referenz
        {
            get { return _file_selectergebnis_b_buop_offen_Referenz; }
            set { _file_selectergebnis_b_buop_offen_Referenz = value; }
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

            // alte Methoden mit apteanSQL.cs
            try {
                //Report.Log(ReportLevel.Info, "Section", "alte Methoden mit apteanSQL.cs", new RecordItemIndex(0));
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            try {
                //Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.ReadVersion("C:\\Testdaten\\Allgemein\\UserCode\\datenbank.txt", "c:\\temp\\version_b_zahlv_001_b_buop_vor_Verbuchung.txt");
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            try {
                //Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.SQLStatement("select BUSA_USERAENDG,\r\nFIRM_NR,\r\nBUSA_KEYPOS,\r\nWRG_CD,\r\nBANK_NR,\r\nADR_NR,\r\nKLDV_NR,\r\nKLBK_NR,\r\nBUOP_ART,\r\nBUOP_KL,\r\nBUOP_BELEGNR,\r\nBUOP_BELEGPOS,\r\nBUOP_ZAHLART,\r\nBUOP_ZAHLPOS,\r\nBUOP_ZAHLJAHR,\r\nBUOP_ZAHLPERIODE,\r\nBUOP_ZAHLDATUM,\r\nBUOP_ZAHLSTATUS,\r\nBUOP_STORNO,\r\nBUOP_DTFREMDBELEG,\r\nBUOP_NRFREMDBELEG,\r\nBUOP_KULINR,\r\nBUOP_DTFAELLIG,\r\nBUOP_DTVALUTA,\r\nBUOP_DTSKONTO1,\r\nBUOP_DTSKONTO2,\r\nBUOP_TAGEVALUTA,\r\nBUOP_TAGE1,\r\nBUOP_SKONTO1,\r\nBUOP_TAGE2,\r\nBUOP_SKONTO2,\r\nBUOP_TAGENETTO,\r\nBUOP_BETRAG,\r\nBUOP_OFFEN,\r\nBUOP_ABZUEGE,\r\nBUOP_SKONTO,\r\nBUOP_FWBETRAG,\r\nBUOP_FWOFFEN,\r\nBUOP_FWABZUEGE,\r\nBUOP_FWSKONTO,\r\nBUOP_KURSDIFF,\r\nBUOP_RECHBETRAG,\r\nBUOP_FWRECHBETRAG,\r\nBUOP_ZAHLBETRAG,\r\nBUOP_SKONTOBASIS,\r\nBUOP_MAHNSTUFE,\r\nBUOP_MAHNSPERRE,\r\nBUOP_MAHNUNBSKTO,\r\nBUOP_DTMAHN,\r\nBUOP_CD1,\r\nBUOP_CD2,\r\nBUOP_CD3,\r\nBUOP_UEBERWTEXT,\r\nBUOP_SELECT1,\r\nBUOP_SELECT2,\r\nBUOP_ZLVS,\r\nBUOP_ZAHLSTORNO,\r\nBUOP_DTABGLEICH,\r\nBUOP_RECHTYP,\r\nBUOP_KZEINHALT,\r\nBUOP_DTEINHALT,\r\nBUOP_EHPROZ,\r\nBUOP_EHBETRAG,\r\nBUOP_FWEHBETRAG,\r\nBUOP_EHKOBETRAG,\r\nBUOP_FWEHKOBETRAG,\r\nBUOP_DTEINHALT2,\r\nBUOP_EHPROZ2,\r\nBUOP_KZUST,\r\nBUOP_KZUSTUMB,\r\nBUOP_USTBETRAG,\r\nBUOP_FWUSTBETRAG,\r\nBUOP_SKONTOBASISRE,\r\nBUOP_ZAHLSPERRE,\r\nBUOP_BASISBETRAG,\r\nBUOP_BASISSKONTO,\r\nBUOP_BASISABZUEGE,\r\nBUOP_BASISKURSDIFF,\r\nBUOP_MONATNETTO,\r\nBUOP_KZFIXTAGE,\r\nBUOP_MONAT1,\r\nBUOP_MONAT2,\r\nBUOP_SKONTOUNB,\r\nBUOP_FWSKONTOUNB,\r\nBUOP_KZPROVISION,\r\nBUOP_ZAHLJAHR2,\r\nBUOP_ZAHLPERIODE2,\r\nBUOP_SELECT3,\r\nBUOP_SELECT4,\r\nBUOP_ADR_RECHAD,\r\nBUOP_KLDV_RECHAD,\r\nBUOP_DTMNSPBIS,\r\nBUOP_DTMNAENDG,\r\nRTK_NR,\r\nBUOP_DTSALD,\r\nBUOP_KZAUSGL,\r\nBUOP_KZZINSEN,\r\nBUOP_MAHNZINSEN,\r\nADR_NR_ZAHLUNG,\r\nBUOP_BELTYP,\r\nBUOP_DTMNFAELL,\r\nBUOP_DTMNZAHL,\r\nMNV_NR,\r\nKLBK_NR_ZAHLUNG,\r\nBUOP_KZRECHTSKR,\r\nBUOP_ZINSBUCH,\r\nBUOP_ZINSRECH,\r\nBUOP_SALDJAHR,\r\nBUOP_SALDPERIODE,\r\nBUOP_DTIC,\r\nBUOP_ZS_NR,\r\nEXBK_NR,\r\nEXBP_NR,\r\nEXBO_NR,\r\nBUOP_KZPROVISIONSV,\r\nBUOP_KEYBEL_RATE,\r\nBUOP_KEYPOS_RATE,\r\nBUOP_FELD01,\r\nBUOP_FELD02,\r\nBUOP_FELD03,\r\nBUOP_FELD04,\r\nBUOP_FELD05\r\nfrom b_buop\r\nwhere firm_nr = '100' and adr_nr BETWEEN '303020' AND '303023';", "C:\\Testdaten\\Allgemein\\UserCode\\datenbank.txt", "C:\\temp\\B_ZAHLV_001_B_BUOP_offen_aktuell.txt");
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                //Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.FileCompareEqual("C:\\Testdaten\\Allgemein\\SQL_Referenz_Files\\B_ZAHLV_001\\B_ZAHLV_001_B_BUOP_offen_Referenz.txt", "C:\\temp\\B_ZAHLV_001_B_BUOP_offen_aktuell.txt");
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            // neue Methoden mit aptean.cs ohne Variablen
            try {
                Report.Log(ReportLevel.Info, "Section", "neue Methoden mit aptean.cs ohne Variablen", new RecordItemIndex(4));
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Ranorex.AutomationHelpers.UserCodeCollections.Aptean.SQLStatement("select BUSA_USERAENDG,\r\nFIRM_NR,\r\nBUSA_KEYPOS,\r\nWRG_CD,\r\nBANK_NR,\r\nADR_NR,\r\nKLDV_NR,\r\nKLBK_NR,\r\nBUOP_ART,\r\nBUOP_KL,\r\nBUOP_BELEGNR,\r\nBUOP_BELEGPOS,\r\nBUOP_ZAHLART,\r\nBUOP_ZAHLPOS,\r\nBUOP_ZAHLJAHR,\r\nBUOP_ZAHLPERIODE,\r\nBUOP_ZAHLDATUM,\r\nBUOP_ZAHLSTATUS,\r\nBUOP_STORNO,\r\nBUOP_DTFREMDBELEG,\r\nBUOP_NRFREMDBELEG,\r\nBUOP_KULINR,\r\nBUOP_DTFAELLIG,\r\nBUOP_DTVALUTA,\r\nBUOP_DTSKONTO1,\r\nBUOP_DTSKONTO2,\r\nBUOP_TAGEVALUTA,\r\nBUOP_TAGE1,\r\nBUOP_SKONTO1,\r\nBUOP_TAGE2,\r\nBUOP_SKONTO2,\r\nBUOP_TAGENETTO,\r\nBUOP_BETRAG,\r\nBUOP_OFFEN,\r\nBUOP_ABZUEGE,\r\nBUOP_SKONTO,\r\nBUOP_FWBETRAG,\r\nBUOP_FWOFFEN,\r\nBUOP_FWABZUEGE,\r\nBUOP_FWSKONTO,\r\nBUOP_KURSDIFF,\r\nBUOP_RECHBETRAG,\r\nBUOP_FWRECHBETRAG,\r\nBUOP_ZAHLBETRAG,\r\nBUOP_SKONTOBASIS,\r\nBUOP_MAHNSTUFE,\r\nBUOP_MAHNSPERRE,\r\nBUOP_MAHNUNBSKTO,\r\nBUOP_DTMAHN,\r\nBUOP_CD1,\r\nBUOP_CD2,\r\nBUOP_CD3,\r\nBUOP_UEBERWTEXT,\r\nBUOP_SELECT1,\r\nBUOP_SELECT2,\r\nBUOP_ZLVS,\r\nBUOP_ZAHLSTORNO,\r\nBUOP_DTABGLEICH,\r\nBUOP_RECHTYP,\r\nBUOP_KZEINHALT,\r\nBUOP_DTEINHALT,\r\nBUOP_EHPROZ,\r\nBUOP_EHBETRAG,\r\nBUOP_FWEHBETRAG,\r\nBUOP_EHKOBETRAG,\r\nBUOP_FWEHKOBETRAG,\r\nBUOP_DTEINHALT2,\r\nBUOP_EHPROZ2,\r\nBUOP_KZUST,\r\nBUOP_KZUSTUMB,\r\nBUOP_USTBETRAG,\r\nBUOP_FWUSTBETRAG,\r\nBUOP_SKONTOBASISRE,\r\nBUOP_ZAHLSPERRE,\r\nBUOP_BASISBETRAG,\r\nBUOP_BASISSKONTO,\r\nBUOP_BASISABZUEGE,\r\nBUOP_BASISKURSDIFF,\r\nBUOP_MONATNETTO,\r\nBUOP_KZFIXTAGE,\r\nBUOP_MONAT1,\r\nBUOP_MONAT2,\r\nBUOP_SKONTOUNB,\r\nBUOP_FWSKONTOUNB,\r\nBUOP_KZPROVISION,\r\nBUOP_ZAHLJAHR2,\r\nBUOP_ZAHLPERIODE2,\r\nBUOP_SELECT3,\r\nBUOP_SELECT4,\r\nBUOP_ADR_RECHAD,\r\nBUOP_KLDV_RECHAD,\r\nBUOP_DTMNSPBIS,\r\nBUOP_DTMNAENDG,\r\nRTK_NR,\r\nBUOP_DTSALD,\r\nBUOP_KZAUSGL,\r\nBUOP_KZZINSEN,\r\nBUOP_MAHNZINSEN,\r\nADR_NR_ZAHLUNG,\r\nBUOP_BELTYP,\r\nBUOP_DTMNFAELL,\r\nBUOP_DTMNZAHL,\r\nMNV_NR,\r\nKLBK_NR_ZAHLUNG,\r\nBUOP_KZRECHTSKR,\r\nBUOP_ZINSBUCH,\r\nBUOP_ZINSRECH,\r\nBUOP_SALDJAHR,\r\nBUOP_SALDPERIODE,\r\nBUOP_DTIC,\r\nBUOP_ZS_NR,\r\nEXBK_NR,\r\nEXBP_NR,\r\nEXBO_NR,\r\nBUOP_KZPROVISIONSV,\r\nBUOP_KEYBEL_RATE,\r\nBUOP_KEYPOS_RATE,\r\nBUOP_FELD01,\r\nBUOP_FELD02,\r\nBUOP_FELD03,\r\nBUOP_FELD04,\r\nBUOP_FELD05\r\nfrom b_buop\r\nwhere firm_nr = '100' and adr_nr BETWEEN '303020' AND '303023';", "C:\\temp\\B_ZAHLV_001_B_BUOP_offen_aktuell.txt");
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Ranorex.AutomationHelpers.UserCodeCollections.Aptean.FileCompareEqualWithoutBreaks("C:\\Testdaten\\Allgemein\\SQL_Referenz_Files\\B_ZAHLV_001\\B_ZAHLV_001_B_BUOP_offen_Referenz.txt", "C:\\temp\\B_ZAHLV_001_B_BUOP_offen_aktuell.txt");
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            // neue Methoden mit aptean.cs mit Variablen
            try {
                Report.Log(ReportLevel.Info, "Section", "neue Methoden mit aptean.cs mit Variablen", new RecordItemIndex(7));
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            try {
                Ranorex.AutomationHelpers.UserCodeCollections.Aptean.SQLStatement(SQL_Select_B_BUOP_offen, file_selectergebnis_b_buop_offen_aktuell);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            try {
                Ranorex.AutomationHelpers.UserCodeCollections.Aptean.FileCompareEqualWithoutBreaks(file_selectergebnis_b_buop_offen_Referenz, file_selectergebnis_b_buop_offen_aktuell);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
