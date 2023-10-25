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

namespace B_EXOPV_005.Recordings_B_EXOPV
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Verbuchung_Dialog5_FB03_LF02_neue_Fremdbelegnr recording.
    /// </summary>
    [TestModule("92bc1926-0d17-4312-82a3-826966217121", ModuleType.Recording, 1)]
    public partial class Verbuchung_Dialog5_FB03_LF02_neue_Fremdbelegnr : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_005.B_EXOPV_005Repository repository.
        /// </summary>
        public static global::B_EXOPV_005.B_EXOPV_005Repository repo = global::B_EXOPV_005.B_EXOPV_005Repository.Instance;

        static Verbuchung_Dialog5_FB03_LF02_neue_Fremdbelegnr instance = new Verbuchung_Dialog5_FB03_LF02_neue_Fremdbelegnr();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verbuchung_Dialog5_FB03_LF02_neue_Fremdbelegnr()
        {
            LF_02 = "303202";
            FB03_LF02 = "FB03_B_EXOPV_005";
            FB03_LF02_NEU = "FB03_B_EXOPV_005_NEU";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verbuchung_Dialog5_FB03_LF02_neue_Fremdbelegnr Instance
        {
            get { return instance; }
        }

#region Variables

        string _LF_02;

        /// <summary>
        /// Gets or sets the value of variable LF_02.
        /// </summary>
        [TestVariable("67e34842-001d-42ce-9fbd-bcda35245c10")]
        public string LF_02
        {
            get { return _LF_02; }
            set { _LF_02 = value; }
        }

        string _FB03_LF02;

        /// <summary>
        /// Gets or sets the value of variable FB03_LF02.
        /// </summary>
        [TestVariable("11693dd3-ab3e-42e3-b512-cd8780d00bff")]
        public string FB03_LF02
        {
            get { return _FB03_LF02; }
            set { _FB03_LF02 = value; }
        }

        string _FB03_LF02_NEU;

        /// <summary>
        /// Gets or sets the value of variable FB03_LF02_NEU.
        /// </summary>
        [TestVariable("a294cd94-aa95-4d72-935e-6e23aa63fff2")]
        public string FB03_LF02_NEU
        {
            get { return _FB03_LF02_NEU; }
            set { _FB03_LF02_NEU = value; }
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

            // Meldung5_Fremdbeleg Lieferant 02
            try {
                Report.Log(ReportLevel.Info, "Section", "Meldung5_Fremdbeleg Lieferant 02", new RecordItemIndex(0));
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgFremdbelegnrFehler.TitleBar100FremdbelegNrFehler'.", repo.DlgFremdbelegnrFehler.TitleBar100FremdbelegNrFehlerInfo, new RecordItemIndex(1));
            Validate.Exists(repo.DlgFremdbelegnrFehler.TitleBar100FremdbelegNrFehlerInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_02) on item 'DlgFremdbelegnrFehler.Frame2.DfAdrNr'.", repo.DlgFremdbelegnrFehler.Frame2.DfAdrNrInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.DlgFremdbelegnrFehler.Frame2.DfAdrNrInfo, "Text", LF_02);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Fremdbeleg im selben Jahr schon als OP vorhanden !') on item 'DlgFremdbelegnrFehler.Frame2.Label3'.", repo.DlgFremdbelegnrFehler.Frame2.Label3Info, new RecordItemIndex(3));
            Validate.AttributeContains(repo.DlgFremdbelegnrFehler.Frame2.Label3Info, "Text", "Fremdbeleg im selben Jahr schon als OP vorhanden !");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$FB03_LF02) on item 'DlgFremdbelegnrFehler.Frame2.DfBelegNr'.", repo.DlgFremdbelegnrFehler.Frame2.DfBelegNrInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.DlgFremdbelegnrFehler.Frame2.DfBelegNrInfo, "Text", FB03_LF02);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$FB03_LF02) on item 'DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNr'.", repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNrInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNrInfo, "Text", FB03_LF02);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNr' at Center.", repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNrInfo, new RecordItemIndex(6));
            repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNr.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(7));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNr' at Center.", repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNrInfo, new RecordItemIndex(8));
            repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNr.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(9));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(10));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(11));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$FB03_LF02_NEU' with focus on 'DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNr'.", repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNrInfo, new RecordItemIndex(12));
            repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNr.PressKeys(FB03_LF02_NEU);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(13));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(14));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$FB03_LF02_NEU) on item 'DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNr'.", repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNrInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNrInfo, "Text", FB03_LF02_NEU);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgFremdbelegnrFehler.PbOk' at Center.", repo.DlgFremdbelegnrFehler.PbOkInfo, new RecordItemIndex(16));
            repo.DlgFremdbelegnrFehler.PbOk.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
