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

namespace N_LISTEN_BULI_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Einschraenkung_Daten recording.
    /// </summary>
    [TestModule("80fb7873-1a2b-40ac-8742-3f8511c54a79", ModuleType.Recording, 1)]
    public partial class Einschraenkung_Daten : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_LISTEN_BULI_002.N_LISTEN_BULI_002Repository repository.
        /// </summary>
        public static global::N_LISTEN_BULI_002.N_LISTEN_BULI_002Repository repo = global::N_LISTEN_BULI_002.N_LISTEN_BULI_002Repository.Instance;

        static Einschraenkung_Daten instance = new Einschraenkung_Daten();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Einschraenkung_Daten()
        {
            GJ = "2022";
            Monat_von = "01.07.2022";
            Monat_bis = "31.07.2022";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Einschraenkung_Daten Instance
        {
            get { return instance; }
        }

#region Variables

        string _GJ;

        /// <summary>
        /// Gets or sets the value of variable GJ.
        /// </summary>
        [TestVariable("61bc8db5-7208-4cc6-a928-8e532a5a6e6e")]
        public string GJ
        {
            get { return _GJ; }
            set { _GJ = value; }
        }

        string _Monat_von;

        /// <summary>
        /// Gets or sets the value of variable Monat_von.
        /// </summary>
        [TestVariable("4f6abe4f-98ba-4c4c-8c58-4079496e838b")]
        public string Monat_von
        {
            get { return _Monat_von; }
            set { _Monat_von = value; }
        }

        string _Monat_bis;

        /// <summary>
        /// Gets or sets the value of variable Monat_bis.
        /// </summary>
        [TestVariable("428a1aa8-493e-4f43-a40a-0a62f3ba230a")]
        public string Monat_bis
        {
            get { return _Monat_bis; }
            set { _Monat_bis = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$GJ) on item 'FrmBuchungsliste.Geschaeftsjahr'.", repo.FrmBuchungsliste.GeschaeftsjahrInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FrmBuchungsliste.GeschaeftsjahrInfo, "Text", GJ);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmBuchungsliste.TextVon' at Center.", repo.FrmBuchungsliste.TextVonInfo, new RecordItemIndex(1));
            repo.FrmBuchungsliste.TextVon.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press with focus on 'FrmBuchungsliste.TextVon'.", repo.FrmBuchungsliste.TextVonInfo, new RecordItemIndex(2));
            Keyboard.PrepareFocus(repo.FrmBuchungsliste.TextVon);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Monat_von' with focus on 'FrmBuchungsliste.TextVon'.", repo.FrmBuchungsliste.TextVonInfo, new RecordItemIndex(3));
            repo.FrmBuchungsliste.TextVon.PressKeys(Monat_von);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmBuchungsliste.TextVon'.", repo.FrmBuchungsliste.TextVonInfo, new RecordItemIndex(4));
            Keyboard.PrepareFocus(repo.FrmBuchungsliste.TextVon);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmBuchungsliste.TextBis' at Center.", repo.FrmBuchungsliste.TextBisInfo, new RecordItemIndex(5));
            repo.FrmBuchungsliste.TextBis.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press with focus on 'FrmBuchungsliste.TextBis'.", repo.FrmBuchungsliste.TextBisInfo, new RecordItemIndex(6));
            Keyboard.PrepareFocus(repo.FrmBuchungsliste.TextBis);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Monat_bis' with focus on 'FrmBuchungsliste.TextBis'.", repo.FrmBuchungsliste.TextBisInfo, new RecordItemIndex(7));
            repo.FrmBuchungsliste.TextBis.PressKeys(Monat_bis);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmBuchungsliste.TextBis'.", repo.FrmBuchungsliste.TextBisInfo, new RecordItemIndex(8));
            Keyboard.PrepareFocus(repo.FrmBuchungsliste.TextBis);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
