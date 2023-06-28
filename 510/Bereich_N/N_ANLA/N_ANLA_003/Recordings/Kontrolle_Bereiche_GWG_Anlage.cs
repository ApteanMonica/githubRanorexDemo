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
    ///The Kontrolle_Bereiche_GWG_Anlage recording.
    /// </summary>
    [TestModule("0fbc7708-cc70-4117-9ab3-57195069136c", ModuleType.Recording, 1)]
    public partial class Kontrolle_Bereiche_GWG_Anlage : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_ANLA_003.N_ANLA_003Repository repository.
        /// </summary>
        public static global::N_ANLA_003.N_ANLA_003Repository repo = global::N_ANLA_003.N_ANLA_003Repository.Instance;

        static Kontrolle_Bereiche_GWG_Anlage instance = new Kontrolle_Bereiche_GWG_Anlage();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Kontrolle_Bereiche_GWG_Anlage()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Kontrolle_Bereiche_GWG_Anlage Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='20') on item 'Form100AVZBuchungenZugang.ColBektNr1Row1'.", repo.Form100AVZBuchungenZugang.ColBektNr1Row1Info, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.Form100AVZBuchungenZugang.ColBektNr1Row1Info, "Text", "20");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100,00000000') on item 'Form100AVZBuchungenZugang.ColAnbeProzRow1'.", repo.Form100AVZBuchungenZugang.ColAnbeProzRow1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.Form100AVZBuchungenZugang.ColAnbeProzRow1Info, "Text", "100,00000000");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
