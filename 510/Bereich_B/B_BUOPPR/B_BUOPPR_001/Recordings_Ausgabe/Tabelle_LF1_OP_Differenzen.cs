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

namespace B_BUOPPR_001.Recordings_Ausgabe
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Tabelle_LF1_OP_Differenzen recording.
    /// </summary>
    [TestModule("a8386f9e-ba18-46ab-a050-f9f0db58bc46", ModuleType.Recording, 1)]
    public partial class Tabelle_LF1_OP_Differenzen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUOPPR_001.B_BUOPPR_001Repository repository.
        /// </summary>
        public static global::B_BUOPPR_001.B_BUOPPR_001Repository repo = global::B_BUOPPR_001.B_BUOPPR_001Repository.Instance;

        static Tabelle_LF1_OP_Differenzen instance = new Tabelle_LF1_OP_Differenzen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Tabelle_LF1_OP_Differenzen()
        {
            Tabelle_OP_Diff_1_LF_1 = "";
            Tabelle_OP_Diff_2_LF_1 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Tabelle_LF1_OP_Differenzen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tabelle_OP_Diff_1_LF_1;

        /// <summary>
        /// Gets or sets the value of variable Tabelle_OP_Diff_1_LF_1.
        /// </summary>
        [TestVariable("f15ee1b7-6059-46f9-8a3b-22dcaf147bef")]
        public string Tabelle_OP_Diff_1_LF_1
        {
            get { return _Tabelle_OP_Diff_1_LF_1; }
            set { _Tabelle_OP_Diff_1_LF_1 = value; }
        }

        string _Tabelle_OP_Diff_2_LF_1;

        /// <summary>
        /// Gets or sets the value of variable Tabelle_OP_Diff_2_LF_1.
        /// </summary>
        [TestVariable("399dbf96-121c-4512-bd5f-bbcb31a6c718")]
        public string Tabelle_OP_Diff_2_LF_1
        {
            get { return _Tabelle_OP_Diff_2_LF_1; }
            set { _Tabelle_OP_Diff_2_LF_1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Beleg_OP_Diff_1_LF_1.
        /// </summary>
        [TestVariable("fef3559f-e814-453e-9d53-6b97716d8a18")]
        public string Beleg_OP_Diff_1_LF_1
        {
            get { return repo.Beleg_OP_Diff_1_LF_1; }
            set { repo.Beleg_OP_Diff_1_LF_1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Beleg_OP_Diff_2_LF_1.
        /// </summary>
        [TestVariable("5b64a3cf-8a52-4366-be32-3ee09fa240e2")]
        public string Beleg_OP_Diff_2_LF_1
        {
            get { return repo.Beleg_OP_Diff_2_LF_1; }
            set { repo.Beleg_OP_Diff_2_LF_1 = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'TblDiff.TitleBar100Differenzen'", repo.TblDiff.TitleBar100DifferenzenInfo, new ActionTimeout(60000), new RecordItemIndex(0));
            repo.TblDiff.TitleBar100DifferenzenInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'TblDiff.TitleBar100Differenzen'.", repo.TblDiff.TitleBar100DifferenzenInfo, new RecordItemIndex(1));
            Validate.Exists(repo.TblDiff.TitleBar100DifferenzenInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Tabelle_OP_Diff_1_LF_1) on item 'TblDiff.Row_mit_Beleg_B_BUOPPR_001_9'.", repo.TblDiff.Row_mit_Beleg_B_BUOPPR_001_9Info, new RecordItemIndex(2));
            Validate.AttributeContains(repo.TblDiff.Row_mit_Beleg_B_BUOPPR_001_9Info, "Text", Tabelle_OP_Diff_1_LF_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Tabelle_OP_Diff_2_LF_1) on item 'TblDiff.Row_mit_Beleg_B_BUOPPR_001_10'.", repo.TblDiff.Row_mit_Beleg_B_BUOPPR_001_10Info, new RecordItemIndex(3));
            Validate.AttributeContains(repo.TblDiff.Row_mit_Beleg_B_BUOPPR_001_10Info, "Text", Tabelle_OP_Diff_2_LF_1);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'TblDiff.TitleBar100Differenzen'.", repo.TblDiff.TitleBar100DifferenzenInfo, new RecordItemIndex(4));
            Host.Current.CloseApplication(repo.TblDiff.TitleBar100Differenzen, new Duration(0));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
