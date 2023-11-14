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

namespace Z_UHR_003.Recording
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Zeile1 recording.
    /// </summary>
    [TestModule("f378f266-288e-4cc8-8dfc-020d5d93aefe", ModuleType.Recording, 1)]
    public partial class Zeile1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_UHR_003.Z_UHR_003Repository repository.
        /// </summary>
        public static global::Z_UHR_003.Z_UHR_003Repository repo = global::Z_UHR_003.Z_UHR_003Repository.Instance;

        static Zeile1 instance = new Zeile1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Zeile1()
        {
            Pers_Nr_2 = "UHR_001_D";
            MA_2 = "Huberta SCHÖNEBERG";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Zeile1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Pers_Nr_2;

        /// <summary>
        /// Gets or sets the value of variable Pers_Nr_2.
        /// </summary>
        [TestVariable("c7b56b29-c32c-4c60-a528-e88ec532ac8f")]
        public string Pers_Nr_2
        {
            get { return _Pers_Nr_2; }
            set { _Pers_Nr_2 = value; }
        }

        string _MA_2;

        /// <summary>
        /// Gets or sets the value of variable MA_2.
        /// </summary>
        [TestVariable("b28349cc-bc91-41c8-9f7c-90c924e95c1a")]
        public string MA_2
        {
            get { return _MA_2; }
            set { _MA_2 = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Pers_Nr_2) on item 'TblAuswertungZeit.Zeile_1.ColMitarbeiterRow1'.", repo.TblAuswertungZeit.Zeile_1.ColMitarbeiterRow1Info, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.TblAuswertungZeit.Zeile_1.ColMitarbeiterRow1Info, "Text", Pers_Nr_2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$MA_2) on item 'TblAuswertungZeit.Zeile_1.ColTextRow1'.", repo.TblAuswertungZeit.Zeile_1.ColTextRow1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.TblAuswertungZeit.Zeile_1.ColTextRow1Info, "Text", MA_2);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
