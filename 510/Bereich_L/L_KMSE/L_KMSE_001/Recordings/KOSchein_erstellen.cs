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
    ///The KOSchein_erstellen recording.
    /// </summary>
    [TestModule("c9ba1332-9637-4270-b871-24df5062004c", ModuleType.Recording, 1)]
    public partial class KOSchein_erstellen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::L_KMSE_001.L_KMSE_001Repository repository.
        /// </summary>
        public static global::L_KMSE_001.L_KMSE_001Repository repo = global::L_KMSE_001.L_KMSE_001Repository.Instance;

        static KOSchein_erstellen instance = new KOSchein_erstellen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public KOSchein_erstellen()
        {
            Auftrag = "";
            Lager = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static KOSchein_erstellen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Auftrag;

        /// <summary>
        /// Gets or sets the value of variable Auftrag.
        /// </summary>
        [TestVariable("d946c01c-c565-428f-a37e-cd9ee5a8312a")]
        public string Auftrag
        {
            get { return _Auftrag; }
            set { _Auftrag = value; }
        }

        string _Lager;

        /// <summary>
        /// Gets or sets the value of variable Lager.
        /// </summary>
        [TestVariable("28ccd96a-9004-4920-9554-435da2a6e6a8")]
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Selected='True') on item 'TblKmse.ColAufkNrRow1'.", repo.TblKmse.ColAufkNrRow1Info, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.TblKmse.ColAufkNrRow1Info, "Selected", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue=$Auftrag) on item 'TblKmse.ColAufkNrRow1'.", repo.TblKmse.ColAufkNrRow1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.TblKmse.ColAufkNrRow1Info, "AccessibleValue", Auftrag);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblKmse.PbCommonKsErstellen' at Center.", repo.TblKmse.PbCommonKsErstellenInfo, new RecordItemIndex(2));
            repo.TblKmse.PbCommonKsErstellen.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~'KO([0-9]{2})[\\/]([0-9]{5})$') on item 'TblKmse.ColKmskNrRow1'.", repo.TblKmse.ColKmskNrRow1Info, new RecordItemIndex(3));
            Validate.AttributeRegex(repo.TblKmse.ColKmskNrRow1Info, "Text", new Regex("KO([0-9]{2})[\\/]([0-9]{5})$"));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
