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

namespace K_AUSW_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Ergebnis_Zeilenuebersicht_pruefen recording.
    /// </summary>
    [TestModule("e4c65876-5b38-4915-875d-76f2bf991e1f", ModuleType.Recording, 1)]
    public partial class Ergebnis_Zeilenuebersicht_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_AUSW_002.K_AUSW_002Repository repository.
        /// </summary>
        public static global::K_AUSW_002.K_AUSW_002Repository repo = global::K_AUSW_002.K_AUSW_002Repository.Instance;

        static Ergebnis_Zeilenuebersicht_pruefen instance = new Ergebnis_Zeilenuebersicht_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Ergebnis_Zeilenuebersicht_pruefen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Ergebnis_Zeilenuebersicht_pruefen Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'-1.000,00\t\t-1.000,00\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t-1.000,00\t\t\t\t-1.000,00\t\t\t\t-1.000,00\t\t\t\t\t\t\t\t\t\t-1.000,00') on item 'TblAnzeige.ChildTableWindow.Row1'.", repo.TblAnzeige.ChildTableWindow.Row1Info, new RecordItemIndex(0));
            Validate.AttributeContains(repo.TblAnzeige.ChildTableWindow.Row1Info, "Text", "-1.000,00\t\t-1.000,00\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t-1.000,00\t\t\t\t-1.000,00\t\t\t\t-1.000,00\t\t\t\t\t\t\t\t\t\t-1.000,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'30\tKST 30') on item 'TblAnzeige.ChildTableWindow.Row2'.", repo.TblAnzeige.ChildTableWindow.Row2Info, new RecordItemIndex(1));
            Validate.AttributeContains(repo.TblAnzeige.ChildTableWindow.Row2Info, "Text", "30\tKST 30");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'454,55\t\t\t\t\t\t454,55\t\t-7,17\t\t\t\t-7,17\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t-1.758,33\t\t-1.310,95\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t-1.310,95\t\t\t\t-1.310,95\t\t\t\t-1.310,95\t\t\t\t\t\t\t\t\t\t-1.310,95') on item 'TblAnzeige.ChildTableWindow.Row2'.", repo.TblAnzeige.ChildTableWindow.Row2Info, new RecordItemIndex(2));
            Validate.AttributeContains(repo.TblAnzeige.ChildTableWindow.Row2Info, "Text", "454,55\t\t\t\t\t\t454,55\t\t-7,17\t\t\t\t-7,17\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t-1.758,33\t\t-1.310,95\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t-1.310,95\t\t\t\t-1.310,95\t\t\t\t-1.310,95\t\t\t\t\t\t\t\t\t\t-1.310,95");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'GESAMT') on item 'TblAnzeige.ChildTableWindow.Row3'.", repo.TblAnzeige.ChildTableWindow.Row3Info, new RecordItemIndex(3));
            Validate.AttributeContains(repo.TblAnzeige.ChildTableWindow.Row3Info, "Text", "GESAMT");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'454,55\t\t\t\t\t\t454,55\t\t-7,17\t\t\t\t-7,17\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t-2.758,33\t\t-2.310,95\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t-2.310,95\t\t\t\t-2.310,95\t\t\t\t-2.310,95\t\t\t\t\t\t\t\t\t\t-2.310,95') on item 'TblAnzeige.ChildTableWindow.Row3'.", repo.TblAnzeige.ChildTableWindow.Row3Info, new RecordItemIndex(4));
            Validate.AttributeContains(repo.TblAnzeige.ChildTableWindow.Row3Info, "Text", "454,55\t\t\t\t\t\t454,55\t\t-7,17\t\t\t\t-7,17\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t-2.758,33\t\t-2.310,95\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t-2.310,95\t\t\t\t-2.310,95\t\t\t\t-2.310,95\t\t\t\t\t\t\t\t\t\t-2.310,95");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}