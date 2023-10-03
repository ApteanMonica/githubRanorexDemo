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

namespace K_AUSW_002.Recordings_Bereichskontoabfrage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Bereichskontenabfrage_aufrufen recording.
    /// </summary>
    [TestModule("c49832f8-dd48-4d33-b764-4db855184e97", ModuleType.Recording, 1)]
    public partial class Bereichskontenabfrage_aufrufen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_AUSW_002.K_AUSW_002Repository repository.
        /// </summary>
        public static global::K_AUSW_002.K_AUSW_002Repository repo = global::K_AUSW_002.K_AUSW_002Repository.Instance;

        static Bereichskontenabfrage_aufrufen instance = new Bereichskontenabfrage_aufrufen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Bereichskontenabfrage_aufrufen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Bereichskontenabfrage_aufrufen Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'TblAnzeige.ChildTableWindow.Row2Column0' at Center.", repo.TblAnzeige.ChildTableWindow.Row2Column0Info, new RecordItemIndex(0));
            repo.TblAnzeige.ChildTableWindow.Row2Column0.DoubleClick();
            
            // Set Timeout +2m
            Report.Log(ReportLevel.Info, "Wait", "Set Timeout +2m\r\nWaiting 7m to exist. Associated repository item: 'TblBkAb.TitleBar100Bereichskontenabfrage'", repo.TblBkAb.TitleBar100BereichskontenabfrageInfo, new ActionTimeout(420000), new RecordItemIndex(1));
            repo.TblBkAb.TitleBar100BereichskontenabfrageInfo.WaitForExists(420000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Bereichskontenabfrage') on item 'TblBkAb.TitleBar100Bereichskontenabfrage'.", repo.TblBkAb.TitleBar100BereichskontenabfrageInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.TblBkAb.TitleBar100BereichskontenabfrageInfo, "Text", "Bereichskontenabfrage");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
