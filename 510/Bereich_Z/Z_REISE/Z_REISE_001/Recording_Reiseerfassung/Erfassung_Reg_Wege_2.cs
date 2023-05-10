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
    ///The Erfassung_Reg_Wege_2 recording.
    /// </summary>
    [TestModule("4e93c1ca-c63f-46bd-94e2-079307e50525", ModuleType.Recording, 1)]
    public partial class Erfassung_Reg_Wege_2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_REISE_001.Z_REISE_001Repository repository.
        /// </summary>
        public static global::Z_REISE_001.Z_REISE_001Repository repo = global::Z_REISE_001.Z_REISE_001Repository.Instance;

        static Erfassung_Reg_Wege_2 instance = new Erfassung_Reg_Wege_2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Erfassung_Reg_Wege_2()
        {
            Ziel_Ort = "Graz";
            Ziel_Strasse = "Grazerstr. 12";
            Ziel_PLZ = "8010";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Erfassung_Reg_Wege_2 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Ziel_Ort;

        /// <summary>
        /// Gets or sets the value of variable Ziel_Ort.
        /// </summary>
        [TestVariable("a3cf9840-4d80-4b03-905f-7e65104f5315")]
        public string Ziel_Ort
        {
            get { return _Ziel_Ort; }
            set { _Ziel_Ort = value; }
        }

        string _Ziel_Strasse;

        /// <summary>
        /// Gets or sets the value of variable Ziel_Strasse.
        /// </summary>
        [TestVariable("6558f919-db8b-4074-8fe7-481d174850f0")]
        public string Ziel_Strasse
        {
            get { return _Ziel_Strasse; }
            set { _Ziel_Strasse = value; }
        }

        string _Ziel_PLZ;

        /// <summary>
        /// Gets or sets the value of variable Ziel_PLZ.
        /// </summary>
        [TestVariable("935b7253-a761-4cb0-83fd-b69fc9f2fb2d")]
        public string Ziel_PLZ
        {
            get { return _Ziel_PLZ; }
            set { _Ziel_PLZ = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Ziel_Ort' with focus on 'FormRk.FlexGrid1.ColPlzOrtBisRow1'.", repo.FormRk.FlexGrid1.ColPlzOrtBisRow1Info, new RecordItemIndex(0));
            repo.FormRk.FlexGrid1.ColPlzOrtBisRow1.PressKeys(Ziel_Ort);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Ziel_Strasse' with focus on 'FormRk.FlexGrid1.ColRwegStrasseBisRow1'.", repo.FormRk.FlexGrid1.ColRwegStrasseBisRow1Info, new RecordItemIndex(1));
            repo.FormRk.FlexGrid1.ColRwegStrasseBisRow1.PressKeys(Ziel_Strasse);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Ziel_PLZ' with focus on 'FormRk.FlexGrid1.ColPlzCdBisRow1'.", repo.FormRk.FlexGrid1.ColPlzCdBisRow1Info, new RecordItemIndex(2));
            repo.FormRk.FlexGrid1.ColPlzCdBisRow1.PressKeys(Ziel_PLZ);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1' with focus on 'FormRk.FlexGrid1.ColRkfzCdRow1'.", repo.FormRk.FlexGrid1.ColRkfzCdRow1Info, new RecordItemIndex(3));
            repo.FormRk.FlexGrid1.ColRkfzCdRow1.PressKeys("1");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '5100{Tab}' with focus on 'FormRk.FlexGrid1.ColRwegKmstartRow1'.", repo.FormRk.FlexGrid1.ColRwegKmstartRow1Info, new RecordItemIndex(4));
            repo.FormRk.FlexGrid1.ColRwegKmstartRow1.PressKeys("5100{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '5350{Tab}' with focus on 'FormRk.FlexGrid1.ColRwegKmendeRow1'.", repo.FormRk.FlexGrid1.ColRwegKmendeRow1Info, new RecordItemIndex(5));
            repo.FormRk.FlexGrid1.ColRwegKmendeRow1.PressKeys("5350{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '250{Tab}' with focus on 'FormRk.FlexGrid1.ColRwegKmRow1'.", repo.FormRk.FlexGrid1.ColRwegKmRow1Info, new RecordItemIndex(6));
            repo.FormRk.FlexGrid1.ColRwegKmRow1.PressKeys("250{Tab}");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
