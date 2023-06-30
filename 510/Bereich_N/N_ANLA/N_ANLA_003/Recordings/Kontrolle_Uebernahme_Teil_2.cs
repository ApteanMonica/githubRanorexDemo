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

namespace N_ANLA_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Kontrolle_Uebernahme_Teil_2 recording.
    /// </summary>
    [TestModule("6d3899ff-8fe8-428e-b208-563fc9bfd3ec", ModuleType.Recording, 1)]
    public partial class Kontrolle_Uebernahme_Teil_2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_ANLA_003.N_ANLA_003Repository repository.
        /// </summary>
        public static global::N_ANLA_003.N_ANLA_003Repository repo = global::N_ANLA_003.N_ANLA_003Repository.Instance;

        static Kontrolle_Uebernahme_Teil_2 instance = new Kontrolle_Uebernahme_Teil_2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Kontrolle_Uebernahme_Teil_2()
        {
            Frist_stille_Reserve = "7,00";
            Frist_IFB = "4,00";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Kontrolle_Uebernahme_Teil_2 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Frist_stille_Reserve;

        /// <summary>
        /// Gets or sets the value of variable Frist_stille_Reserve.
        /// </summary>
        [TestVariable("726164ec-a9b8-4719-bace-2d912c3f73a2")]
        public string Frist_stille_Reserve
        {
            get { return _Frist_stille_Reserve; }
            set { _Frist_stille_Reserve = value; }
        }

        string _Frist_IFB;

        /// <summary>
        /// Gets or sets the value of variable Frist_IFB.
        /// </summary>
        [TestVariable("1280136d-f1d4-4926-93ed-09746eaac0bb")]
        public string Frist_IFB
        {
            get { return _Frist_IFB; }
            set { _Frist_IFB = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Frist_stille_Reserve) on item 'DlgZugang.TpWerte.DfAnlaStrfrist'.", repo.DlgZugang.TpWerte.DfAnlaStrfristInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.DlgZugang.TpWerte.DfAnlaStrfristInfo, "Text", Frist_stille_Reserve);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Frist_IFB) on item 'DlgZugang.TpWerte.DfAnlaIfbfrist'.", repo.DlgZugang.TpWerte.DfAnlaIfbfristInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.DlgZugang.TpWerte.DfAnlaIfbfristInfo, "Text", Frist_IFB);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0660') on item 'DlgZugang.TpWerte.TextAfA'.", repo.DlgZugang.TpWerte.TextAfAInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.DlgZugang.TpWerte.TextAfAInfo, "Text", "0660");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'DlgZugang.TpWerte.DfKtoNrAfaindirekt'.", repo.DlgZugang.TpWerte.DfKtoNrAfaindirektInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.DlgZugang.TpWerte.DfKtoNrAfaindirektInfo, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'DlgZugang.TpWerte.CbAnlaKeinekalkzins'.", repo.DlgZugang.TpWerte.CbAnlaKeinekalkzinsInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.DlgZugang.TpWerte.CbAnlaKeinekalkzinsInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'DlgZugang.TpWerte.CbKeineAHK'.", repo.DlgZugang.TpWerte.CbKeineAHKInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.DlgZugang.TpWerte.CbKeineAHKInfo, "Checked", "False");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Linear, monatlich') on item 'DlgZugang.TpWerte.CmbAnla1AfaBez'.", repo.DlgZugang.TpWerte.CmbAnla1AfaBezInfo, new RecordItemIndex(6));
            Validate.AttributeContains(repo.DlgZugang.TpWerte.CmbAnla1AfaBezInfo, "Text", "Linear, monatlich");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'DlgZugang.TpWerte.CbAnlaKzafaber1'.", repo.DlgZugang.TpWerte.CbAnlaKzafaber1Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.DlgZugang.TpWerte.CbAnlaKzafaber1Info, "Checked", "False");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'DlgZugang.TpWerte.CbAnlaKzafaber91'.", repo.DlgZugang.TpWerte.CbAnlaKzafaber91Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.DlgZugang.TpWerte.CbAnlaKzafaber91Info, "Checked", "False");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form100AVZBuchungenZugang.PbSpeichern' at Center.", repo.Form100AVZBuchungenZugang.PbSpeichernInfo, new RecordItemIndex(9));
            repo.Form100AVZBuchungenZugang.PbSpeichern.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press.", new RecordItemIndex(10));
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
