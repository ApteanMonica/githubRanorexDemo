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

namespace AEKOOE_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UEberpruefung_Eingabe_Daten recording.
    /// </summary>
    [TestModule("82c0f73d-58aa-4fd2-8126-0893ee354f55", ModuleType.Recording, 1)]
    public partial class UEberpruefung_Eingabe_Daten : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::AEKOOE_001.AEKOOE_001Repository repository.
        /// </summary>
        public static global::AEKOOE_001.AEKOOE_001Repository repo = global::AEKOOE_001.AEKOOE_001Repository.Instance;

        static UEberpruefung_Eingabe_Daten instance = new UEberpruefung_Eingabe_Daten();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UEberpruefung_Eingabe_Daten()
        {
            berufsunfaehig_ab = "Tagesdatum";
            berufsunfaehig_bis = "Tagesdatum_plus_7";
            SVNR = "1679050956";
            Bankverbindung_1 = "AT351100018481974718";
            Diagnose = "Testdiagnose·zum·Krankengeld";
            Tagesdatum = "";
            Tagesdatum_plus_7_Tage = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UEberpruefung_Eingabe_Daten Instance
        {
            get { return instance; }
        }

#region Variables

        string _berufsunfaehig_ab;

        /// <summary>
        /// Gets or sets the value of variable berufsunfaehig_ab.
        /// </summary>
        [TestVariable("7241be5c-324a-4476-b396-10a9a127205a")]
        public string berufsunfaehig_ab
        {
            get { return _berufsunfaehig_ab; }
            set { _berufsunfaehig_ab = value; }
        }

        string _berufsunfaehig_bis;

        /// <summary>
        /// Gets or sets the value of variable berufsunfaehig_bis.
        /// </summary>
        [TestVariable("192f9cf1-95b8-4982-bbb1-b7a2bd043221")]
        public string berufsunfaehig_bis
        {
            get { return _berufsunfaehig_bis; }
            set { _berufsunfaehig_bis = value; }
        }

        string _SVNR;

        /// <summary>
        /// Gets or sets the value of variable SVNR.
        /// </summary>
        [TestVariable("1d8ba898-de50-4486-8dc5-0094a937de6f")]
        public string SVNR
        {
            get { return _SVNR; }
            set { _SVNR = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Bankverbindung_1.
        /// </summary>
        [TestVariable("0b2959be-f748-494b-ae1e-718a1fdf5041")]
        public string Bankverbindung_1
        {
            get { return repo.Bankverbindung_1; }
            set { repo.Bankverbindung_1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Diagnose.
        /// </summary>
        [TestVariable("37e2007d-e564-4473-bfb5-4dba4d1398fa")]
        public string Diagnose
        {
            get { return repo.Diagnose; }
            set { repo.Diagnose = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("b8bbb522-bf68-47b8-a0b8-8b7ec1181d43")]
        public string Tagesdatum
        {
            get { return repo.Tagesdatum; }
            set { repo.Tagesdatum = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum_plus_7_Tage.
        /// </summary>
        [TestVariable("52dc3457-2ab2-4259-afb7-334fa8620857")]
        public string Tagesdatum_plus_7_Tage
        {
            get { return repo.Tagesdatum_plus_7_Tage; }
            set { repo.Tagesdatum_plus_7_Tage = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$Tagesdatum) on item 'Login.AKAT011RequestFormRow.Text_Zeitraum_Berufsunfaehigkeit_ab'.", repo.Login.AKAT011RequestFormRow.Text_Zeitraum_Berufsunfaehigkeit_abInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.Login.AKAT011RequestFormRow.Text_Zeitraum_Berufsunfaehigkeit_abInfo, "InnerText", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$Tagesdatum_plus_7_Tage) on item 'Login.AKAT011RequestFormRow.Text_Zeitraum_Berufsunfaehigkeit_bis'.", repo.Login.AKAT011RequestFormRow.Text_Zeitraum_Berufsunfaehigkeit_bisInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.Login.AKAT011RequestFormRow.Text_Zeitraum_Berufsunfaehigkeit_bisInfo, "InnerText", Tagesdatum_plus_7_Tage);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value=$SVNR) on item 'Login.AKAT011RequestFormRow.Text_SVNR'.", repo.Login.AKAT011RequestFormRow.Text_SVNRInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.Login.AKAT011RequestFormRow.Text_SVNRInfo, "Value", SVNR);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$SVNR) on item 'Login.AKAT011RequestFormRow.Text_SVNR'.", repo.Login.AKAT011RequestFormRow.Text_SVNRInfo, new RecordItemIndex(3));
            //Validate.AttributeEqual(repo.Login.AKAT011RequestFormRow.Text_SVNRInfo, "InnerText", SVNR);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$Bankverbindung_1) on item 'Login.Auswahl_Bankverbindung'.", repo.Login.Auswahl_BankverbindungInfo, new RecordItemIndex(4));
            //Validate.AttributeEqual(repo.Login.Auswahl_BankverbindungInfo, "InnerText", Bankverbindung_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$Diagnose) on item 'Login.AKAT011RequestFormRow.False_Eingabe_Diagnose'.", repo.Login.AKAT011RequestFormRow.False_Eingabe_DiagnoseInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.Login.AKAT011RequestFormRow.False_Eingabe_DiagnoseInfo, "TagValue", Diagnose);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='ordentlicher Wohnsitz') on item 'Login.AKAT011RequestFormRow.KInput_Aufenthaltsort'.", repo.Login.AKAT011RequestFormRow.KInput_AufenthaltsortInfo, new RecordItemIndex(6));
            //Validate.AttributeEqual(repo.Login.AKAT011RequestFormRow.KInput_AufenthaltsortInfo, "InnerText", "ordentlicher Wohnsitz");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'Login.AKAT011RequestFormRow.Checkbox_Fremdverschulden'.", repo.Login.AKAT011RequestFormRow.Checkbox_FremdverschuldenInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.Login.AKAT011RequestFormRow.Checkbox_FremdverschuldenInfo, "Checked", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
