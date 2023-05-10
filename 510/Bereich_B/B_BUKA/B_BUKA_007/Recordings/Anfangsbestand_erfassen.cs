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

namespace B_BUKA_007.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Anfangsbestand_erfassen recording.
    /// </summary>
    [TestModule("31c818ba-38c1-4f9b-aeca-0894212cc6d3", ModuleType.Recording, 1)]
    public partial class Anfangsbestand_erfassen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUKA_007.B_BUKA_007Repository repository.
        /// </summary>
        public static global::B_BUKA_007.B_BUKA_007Repository repo = global::B_BUKA_007.B_BUKA_007Repository.Instance;

        static Anfangsbestand_erfassen instance = new Anfangsbestand_erfassen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Anfangsbestand_erfassen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Anfangsbestand_erfassen Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBuka.PbOptionenOptionen' at .475;.819.", repo.TblBuka.PbOptionenOptionenInfo, new RecordItemIndex(0));
            repo.TblBuka.PbOptionenOptionen.Click(".475;.819");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BBUKA.AnfangsbestandErfassen' at .356;.409.", repo.BBUKA.AnfangsbestandErfassenInfo, new RecordItemIndex(1));
            repo.BBUKA.AnfangsbestandErfassen.Click(".356;.409");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgAnfang'.", repo.DlgAnfang.SelfInfo, new RecordItemIndex(2));
            Validate.Exists(repo.DlgAnfang.SelfInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Anfangsbestand') on item 'DlgAnfang.TitleBar100AnfangsbestandPerEndeM'.", repo.DlgAnfang.TitleBar100AnfangsbestandPerEndeMInfo, new RecordItemIndex(3));
            Validate.AttributeContains(repo.DlgAnfang.TitleBar100AnfangsbestandPerEndeMInfo, "Text", "Anfangsbestand");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgAnfang.DfJahr' at Center.", repo.DlgAnfang.DfJahrInfo, new RecordItemIndex(4));
            repo.DlgAnfang.DfJahr.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '2019' with focus on 'DlgAnfang.DfJahr'.", repo.DlgAnfang.DfJahrInfo, new RecordItemIndex(5));
            repo.DlgAnfang.DfJahr.PressKeys("2019");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(6));
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '11' with focus on 'DlgAnfang.DfMonat'.", repo.DlgAnfang.DfMonatInfo, new RecordItemIndex(7));
            repo.DlgAnfang.DfMonat.PressKeys("11");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgAnfang.CbAlle' at Center.", repo.DlgAnfang.CbAlleInfo, new RecordItemIndex(8));
            repo.DlgAnfang.CbAlle.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgAnfang.CbSaldoNull' at Center.", repo.DlgAnfang.CbSaldoNullInfo, new RecordItemIndex(9));
            repo.DlgAnfang.CbSaldoNull.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'DlgAnfang.CbAlle'.", repo.DlgAnfang.CbAlleInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.DlgAnfang.CbAlleInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'DlgAnfang.CbSaldoNull'.", repo.DlgAnfang.CbSaldoNullInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.DlgAnfang.CbSaldoNullInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'DlgAnfang.CbAllefirmen'.", repo.DlgAnfang.CbAllefirmenInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.DlgAnfang.CbAllefirmenInfo, "Checked", "False");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgAnfang.PbLaden' at Center.", repo.DlgAnfang.PbLadenInfo, new RecordItemIndex(13));
            repo.DlgAnfang.PbLaden.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
