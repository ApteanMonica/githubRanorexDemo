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

namespace Z_REISE_001.Recording_Reiseerfassung
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Erfassung_Reg_Wege recording.
    /// </summary>
    [TestModule("f084283d-1072-425d-8cfa-2017db92a732", ModuleType.Recording, 1)]
    public partial class Erfassung_Reg_Wege : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_REISE_001.Z_REISE_001Repository repository.
        /// </summary>
        public static global::Z_REISE_001.Z_REISE_001Repository repo = global::Z_REISE_001.Z_REISE_001Repository.Instance;

        static Erfassung_Reg_Wege instance = new Erfassung_Reg_Wege();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Erfassung_Reg_Wege()
        {
            Datum_Beginn = "20.05.2022";
            Beginn_Uhrzeit = "06:00";
            Ende_Uhrzeit = "17:00";
            Start_Ort = "Wien";
            Start_Strasse = "Wienerstraße 1";
            Start_PLZ = "1020";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Erfassung_Reg_Wege Instance
        {
            get { return instance; }
        }

#region Variables

        string _Datum_Beginn;

        /// <summary>
        /// Gets or sets the value of variable Datum_Beginn.
        /// </summary>
        [TestVariable("feaf2dab-20f5-4136-af0d-4bf71acb93a3")]
        public string Datum_Beginn
        {
            get { return _Datum_Beginn; }
            set { _Datum_Beginn = value; }
        }

        string _Beginn_Uhrzeit;

        /// <summary>
        /// Gets or sets the value of variable Beginn_Uhrzeit.
        /// </summary>
        [TestVariable("768e5542-c375-44ef-9619-b4e365a69f43")]
        public string Beginn_Uhrzeit
        {
            get { return _Beginn_Uhrzeit; }
            set { _Beginn_Uhrzeit = value; }
        }

        string _Start_Ort;

        /// <summary>
        /// Gets or sets the value of variable Start_Ort.
        /// </summary>
        [TestVariable("d2418338-4d61-4afd-a862-0e308b697854")]
        public string Start_Ort
        {
            get { return _Start_Ort; }
            set { _Start_Ort = value; }
        }

        string _Start_Strasse;

        /// <summary>
        /// Gets or sets the value of variable Start_Strasse.
        /// </summary>
        [TestVariable("c2a79fec-8720-46e8-81de-6275ecbf6852")]
        public string Start_Strasse
        {
            get { return _Start_Strasse; }
            set { _Start_Strasse = value; }
        }

        string _Start_PLZ;

        /// <summary>
        /// Gets or sets the value of variable Start_PLZ.
        /// </summary>
        [TestVariable("fedd8c4b-1864-493a-b8ba-86dce320257d")]
        public string Start_PLZ
        {
            get { return _Start_PLZ; }
            set { _Start_PLZ = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Ende_Uhrzeit.
        /// </summary>
        [TestVariable("8e74f2a8-a182-4d0b-935e-af696e89277b")]
        public string Ende_Uhrzeit
        {
            get { return repo.Ende_Uhrzeit; }
            set { repo.Ende_Uhrzeit = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormRk.Wege' at Center.", repo.FormRk.WegeInfo, new RecordItemIndex(0));
            repo.FormRk.Wege.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleName='Wege') on item 'FormRk.Wege'.", repo.FormRk.WegeInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FormRk.WegeInfo, "AccessibleName", "Wege");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'FormRk.FlexGrid' at Center.", repo.FormRk.FlexGridInfo, new RecordItemIndex(2));
            repo.FormRk.FlexGrid.Click(System.Windows.Forms.MouseButtons.Right);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}{Return}'.", new RecordItemIndex(3));
            Keyboard.Press("{Down}{Return}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Datum_Beginn) on item 'FormRk.FlexGrid1.ColRtagDatumRow1'.", repo.FormRk.FlexGrid1.ColRtagDatumRow1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FormRk.FlexGrid1.ColRtagDatumRow1Info, "Text", Datum_Beginn);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Beginn_Uhrzeit' with focus on 'FormRk.FlexGrid1.ColRwegDtbeginnRow1'.", repo.FormRk.FlexGrid1.ColRwegDtbeginnRow1Info, new RecordItemIndex(5));
            repo.FormRk.FlexGrid1.ColRwegDtbeginnRow1.PressKeys(Beginn_Uhrzeit);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(6));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Ende_Uhrzeit' with focus on 'FormRk.FlexGrid1.ColRwegDtendeRow1'.", repo.FormRk.FlexGrid1.ColRwegDtendeRow1Info, new RecordItemIndex(7));
            repo.FormRk.FlexGrid1.ColRwegDtendeRow1.PressKeys(Ende_Uhrzeit);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(8));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Start_Ort' with focus on 'FormRk.FlexGrid1.ColPlzOrtVonRow1'.", repo.FormRk.FlexGrid1.ColPlzOrtVonRow1Info, new RecordItemIndex(9));
            repo.FormRk.FlexGrid1.ColPlzOrtVonRow1.PressKeys(Start_Ort);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Start_Strasse' with focus on 'FormRk.FlexGrid1.ColRwegStrasseVonRow1'.", repo.FormRk.FlexGrid1.ColRwegStrasseVonRow1Info, new RecordItemIndex(10));
            repo.FormRk.FlexGrid1.ColRwegStrasseVonRow1.PressKeys(Start_Strasse);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Start_PLZ' with focus on 'FormRk.FlexGrid1.ColPlzCdVonRow1'.", repo.FormRk.FlexGrid1.ColPlzCdVonRow1Info, new RecordItemIndex(11));
            repo.FormRk.FlexGrid1.ColPlzCdVonRow1.PressKeys(Start_PLZ);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
