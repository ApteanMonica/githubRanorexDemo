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

namespace B_BUKA_004.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SplittBu_02_erzeugen recording.
    /// </summary>
    [TestModule("c8ba3c35-03c6-4445-9b20-55b6763b7f00", ModuleType.Recording, 1)]
    public partial class SplittBu_02_erzeugen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUKA_004.B_BUKA_004Repository repository.
        /// </summary>
        public static global::B_BUKA_004.B_BUKA_004Repository repo = global::B_BUKA_004.B_BUKA_004Repository.Instance;

        static SplittBu_02_erzeugen instance = new SplittBu_02_erzeugen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SplittBu_02_erzeugen()
        {
            SplittBu_02_Text = "SplittBu_02";
            SplittBu_Konto = "6700";
            KST_10 = "10";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SplittBu_02_erzeugen Instance
        {
            get { return instance; }
        }

#region Variables

        string _SplittBu_02_Text;

        /// <summary>
        /// Gets or sets the value of variable SplittBu_02_Text.
        /// </summary>
        [TestVariable("a3fb735c-e53b-4c0a-8a0e-dc682a9d32f3")]
        public string SplittBu_02_Text
        {
            get { return _SplittBu_02_Text; }
            set { _SplittBu_02_Text = value; }
        }

        string _SplittBu_Konto;

        /// <summary>
        /// Gets or sets the value of variable SplittBu_Konto.
        /// </summary>
        [TestVariable("7086aecc-8cad-4bcd-bc21-261531af89c8")]
        public string SplittBu_Konto
        {
            get { return _SplittBu_Konto; }
            set { _SplittBu_Konto = value; }
        }

        string _KST_10;

        /// <summary>
        /// Gets or sets the value of variable KST_10.
        /// </summary>
        [TestVariable("6696ad0b-e8c6-4fa5-bed3-9676591fe239")]
        public string KST_10
        {
            get { return _KST_10; }
            set { _KST_10 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'TblBuka.FlexGrid1.FlexGrid' at .219;.336.", repo.TblBuka.FlexGrid1.FlexGridInfo, new RecordItemIndex(0));
            repo.TblBuka.FlexGrid1.FlexGrid.Click(System.Windows.Forms.MouseButtons.Right, ".219;.336");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BBUKA.ZeileEinfuegen' at .264;.5.", repo.BBUKA.ZeileEinfuegenInfo, new RecordItemIndex(1));
            repo.BBUKA.ZeileEinfuegen.Click(".264;.5");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '19' with focus on 'TblBuka.FlexGrid1.ColTagRow5'.", repo.TblBuka.FlexGrid1.ColTagRow5Info, new RecordItemIndex(2));
            repo.TblBuka.FlexGrid1.ColTagRow5.PressKeys("19");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(3));
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SplittBu_02_Text' with focus on 'TblBuka.FlexGrid1.ColTextRow5'.", repo.TblBuka.FlexGrid1.ColTextRow5Info, new RecordItemIndex(4));
            repo.TblBuka.FlexGrid1.ColTextRow5.PressKeys(SplittBu_02_Text);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{Tab}'.", new RecordItemIndex(5));
            Keyboard.Press("{Tab}{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '10' with focus on 'TblBuka.FlexGrid1.ColAusgangRow5'.", repo.TblBuka.FlexGrid1.ColAusgangRow5Info, new RecordItemIndex(6));
            repo.TblBuka.FlexGrid1.ColAusgangRow5.PressKeys("10");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBuka.FlexGrid1.ColKtoNrRow5' at Center.", repo.TblBuka.FlexGrid1.ColKtoNrRow5Info, new RecordItemIndex(7));
            repo.TblBuka.FlexGrid1.ColKtoNrRow5.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SplittBu_Konto' with focus on 'TblBuka.FlexGrid1.ColKtoNrRow5'.", repo.TblBuka.FlexGrid1.ColKtoNrRow5Info, new RecordItemIndex(8));
            repo.TblBuka.FlexGrid1.ColKtoNrRow5.PressKeys(SplittBu_Konto);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{Tab}'.", new RecordItemIndex(9));
            Keyboard.Press("{Tab}{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$KST_10' with focus on 'TblBuka.FlexGrid1.ColBektNr1Row5'.", repo.TblBuka.FlexGrid1.ColBektNr1Row5Info, new RecordItemIndex(10));
            repo.TblBuka.FlexGrid1.ColBektNr1Row5.PressKeys(KST_10);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{F12}'.", new RecordItemIndex(11));
            Keyboard.Press("{F12}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='9.890,00') on item 'TblBuka.FlexGrid1.ColSaldoLfdRow5'.", repo.TblBuka.FlexGrid1.ColSaldoLfdRow5Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.TblBuka.FlexGrid1.ColSaldoLfdRow5Info, "Text", "9.890,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$SplittBu_Konto) on item 'TblBuka.FlexGrid1.ColKtoNrRow5'.", repo.TblBuka.FlexGrid1.ColKtoNrRow5Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.TblBuka.FlexGrid1.ColKtoNrRow5Info, "Text", SplittBu_Konto);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$KST_10) on item 'TblBuka.FlexGrid1.ColBektNr1Row5'.", repo.TblBuka.FlexGrid1.ColBektNr1Row5Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.TblBuka.FlexGrid1.ColBektNr1Row5Info, "Text", KST_10);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
