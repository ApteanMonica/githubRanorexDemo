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

namespace N_ANLA_002.Recordings_Anlagenspiegel
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Anlagenspiegel_erstellen recording.
    /// </summary>
    [TestModule("489e95b2-e821-4a80-a3da-e1624b8067d4", ModuleType.Recording, 1)]
    public partial class Anlagenspiegel_erstellen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_ANLA_002.N_ANLA_002Repository repository.
        /// </summary>
        public static global::N_ANLA_002.N_ANLA_002Repository repo = global::N_ANLA_002.N_ANLA_002Repository.Instance;

        static Anlagenspiegel_erstellen instance = new Anlagenspiegel_erstellen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Anlagenspiegel_erstellen()
        {
            GJ = "2022";
            Anlage_A = "N_ANLA_002_01";
            Anlage_G = "N_ANLA_002_07";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Anlagenspiegel_erstellen Instance
        {
            get { return instance; }
        }

#region Variables

        string _GJ;

        /// <summary>
        /// Gets or sets the value of variable GJ.
        /// </summary>
        [TestVariable("6b282b4a-9719-4acc-8427-7477ed869036")]
        public string GJ
        {
            get { return _GJ; }
            set { _GJ = value; }
        }

        string _Anlage_A;

        /// <summary>
        /// Gets or sets the value of variable Anlage_A.
        /// </summary>
        [TestVariable("0e6111b0-b487-49cc-a757-d0197abe9d81")]
        public string Anlage_A
        {
            get { return _Anlage_A; }
            set { _Anlage_A = value; }
        }

        string _Anlage_G;

        /// <summary>
        /// Gets or sets the value of variable Anlage_G.
        /// </summary>
        [TestVariable("1091f330-6c23-4fa4-aa24-0d258f936499")]
        public string Anlage_G
        {
            get { return _Anlage_G; }
            set { _Anlage_G = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$GJ) on item 'FrmSpiegel.DfGjhrBez'.", repo.FrmSpiegel.DfGjhrBezInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FrmSpiegel.DfGjhrBezInfo, "Text", GJ);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Anlage_A' with focus on 'FrmSpiegel.DfAnlaNrVon'.", repo.FrmSpiegel.DfAnlaNrVonInfo, new RecordItemIndex(1));
            repo.FrmSpiegel.DfAnlaNrVon.PressKeys(Anlage_A);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmSpiegel.DfAnlaNrVon'.", repo.FrmSpiegel.DfAnlaNrVonInfo, new RecordItemIndex(2));
            Keyboard.PrepareFocus(repo.FrmSpiegel.DfAnlaNrVon);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Anlage_G' with focus on 'FrmSpiegel.DfAnlaNrBis'.", repo.FrmSpiegel.DfAnlaNrBisInfo, new RecordItemIndex(3));
            repo.FrmSpiegel.DfAnlaNrBis.PressKeys(Anlage_G);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmSpiegel.DfAnlaNrBis'.", repo.FrmSpiegel.DfAnlaNrBisInfo, new RecordItemIndex(4));
            Keyboard.PrepareFocus(repo.FrmSpiegel.DfAnlaNrBis);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmSpiegel.PbBezeichnungTab' at Center.", repo.FrmSpiegel.PbBezeichnungTabInfo, new RecordItemIndex(5));
            repo.FrmSpiegel.PbBezeichnungTab.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMessageBox.AVZAnlagen'", repo.DlgMessageBox.AVZAnlagenInfo, new ActionTimeout(120000), new RecordItemIndex(6));
            repo.DlgMessageBox.AVZAnlagenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Anlagenspiegel erstellen?') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Anlagenspiegel erstellen?");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(8));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TblSpiegel.TitleBar100AVZAnlagenspiegelKomp'", repo.TblSpiegel.TitleBar100AVZAnlagenspiegelKompInfo, new ActionTimeout(120000), new RecordItemIndex(9));
            repo.TblSpiegel.TitleBar100AVZAnlagenspiegelKompInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'[100]  AVZ-Anlagenspiegel - Komprimiert ') on item 'TblSpiegel.TitleBar100AVZAnlagenspiegelKomp'.", repo.TblSpiegel.TitleBar100AVZAnlagenspiegelKompInfo, new RecordItemIndex(10));
            Validate.AttributeContains(repo.TblSpiegel.TitleBar100AVZAnlagenspiegelKompInfo, "Text", "[100]  AVZ-Anlagenspiegel - Komprimiert ");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
