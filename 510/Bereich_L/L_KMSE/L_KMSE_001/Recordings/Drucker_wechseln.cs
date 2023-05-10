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

namespace L_KMSE_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Drucker_wechseln recording.
    /// </summary>
    [TestModule("8b6359c6-6488-4270-b466-88e560ecc395", ModuleType.Recording, 1)]
    public partial class Drucker_wechseln : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::L_KMSE_001.L_KMSE_001Repository repository.
        /// </summary>
        public static global::L_KMSE_001.L_KMSE_001Repository repo = global::L_KMSE_001.L_KMSE_001Repository.Instance;

        static Drucker_wechseln instance = new Drucker_wechseln();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Drucker_wechseln()
        {
            Lager = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Drucker_wechseln Instance
        {
            get { return instance; }
        }

#region Variables

        string _Lager;

        /// <summary>
        /// Gets or sets the value of variable Lager.
        /// </summary>
        [TestVariable("4962ff23-defa-4ab4-9043-bab855d45100")]
        public string Lager
        {
            get { return _Lager; }
            set { _Lager = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblKmse.PbShareDruck' at CenterRight.", repo.TblKmse.PbShareDruckInfo, new RecordItemIndex(0));
            repo.TblKmse.PbShareDruck.Click(Location.CenterRight);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'LKMSE.DruckerWechselnKOSchein' at Center.", repo.LKMSE.DruckerWechselnKOScheinInfo, new RecordItemIndex(1));
            repo.LKMSE.DruckerWechselnKOSchein.MoveTo();
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lager) on item 'DlgListBox.CellTmpColS1Row1'.", repo.DlgListBox.CellTmpColS1Row1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.DlgListBox.CellTmpColS1Row1Info, "Text", Lager);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgListBox.PbOk' at Center.", repo.DlgListBox.PbOkInfo, new RecordItemIndex(3));
            repo.DlgListBox.PbOk.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDruckerWechseln.OEffnen' at Center.", repo.DlgDruckerWechseln.OEffnenInfo, new RecordItemIndex(4));
            repo.DlgDruckerWechseln.OEffnen.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.MicrosoftPrintToPDF' at Center.", repo.List1000.MicrosoftPrintToPDFInfo, new RecordItemIndex(5));
            repo.List1000.MicrosoftPrintToPDF.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDruckerWechseln.PbOk' at Center.", repo.DlgDruckerWechseln.PbOkInfo, new RecordItemIndex(6));
            repo.DlgDruckerWechseln.PbOk.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
