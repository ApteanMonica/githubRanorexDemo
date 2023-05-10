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

namespace Z_UHR_004.Recording
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Kontrolle_Genehmgiung recording.
    /// </summary>
    [TestModule("77c86fad-7901-4c61-befe-1d7092659937", ModuleType.Recording, 1)]
    public partial class Kontrolle_Genehmgiung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_UHR_004.Z_UHR_004Repository repository.
        /// </summary>
        public static global::Z_UHR_004.Z_UHR_004Repository repo = global::Z_UHR_004.Z_UHR_004Repository.Instance;

        static Kontrolle_Genehmgiung instance = new Kontrolle_Genehmgiung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Kontrolle_Genehmgiung()
        {
            Status_0 = "nicht Genehmigt";
            Status_1 = "Genehmigt";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Kontrolle_Genehmgiung Instance
        {
            get { return instance; }
        }

#region Variables

        string _Status_0;

        /// <summary>
        /// Gets or sets the value of variable Status_0.
        /// </summary>
        [TestVariable("36f5beba-c9f3-4416-8d9a-c61d1e969a2e")]
        public string Status_0
        {
            get { return _Status_0; }
            set { _Status_0 = value; }
        }

        string _Status_1;

        /// <summary>
        /// Gets or sets the value of variable Status_1.
        /// </summary>
        [TestVariable("28d577f1-f4f6-46dd-a45a-34ca8582b84b")]
        public string Status_1
        {
            get { return _Status_1; }
            set { _Status_1 = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Status_1) on item 'DlgKorrekturZeiten.Row2.ColUhrGenstatusBezRow2'.", repo.DlgKorrekturZeiten.Row2.ColUhrGenstatusBezRow2Info, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.DlgKorrekturZeiten.Row2.ColUhrGenstatusBezRow2Info, "Text", Status_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='06.02.2023') on item 'DlgKorrekturZeiten.Row3.ColUhrDtbeginnTagRow3'.", repo.DlgKorrekturZeiten.Row3.ColUhrDtbeginnTagRow3Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.DlgKorrekturZeiten.Row3.ColUhrDtbeginnTagRow3Info, "Text", "06.02.2023");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='06.02.2023') on item 'DlgKorrekturZeiten.Row3.ColUhrDtendeTagRow3'.", repo.DlgKorrekturZeiten.Row3.ColUhrDtendeTagRow3Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.DlgKorrekturZeiten.Row3.ColUhrDtendeTagRow3Info, "Text", "06.02.2023");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'DlgKorrekturZeiten.Row3.ColUhrGenstatusRow3'.", repo.DlgKorrekturZeiten.Row3.ColUhrGenstatusRow3Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.DlgKorrekturZeiten.Row3.ColUhrGenstatusRow3Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Status_0) on item 'DlgKorrekturZeiten.ColUhrGenstatusBezRow3'.", repo.DlgKorrekturZeiten.ColUhrGenstatusBezRow3Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.DlgKorrekturZeiten.ColUhrGenstatusBezRow3Info, "Text", Status_0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
