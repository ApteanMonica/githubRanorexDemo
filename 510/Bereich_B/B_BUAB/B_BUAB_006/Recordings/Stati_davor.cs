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

namespace B_BUAB_006.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Stati_davor recording.
    /// </summary>
    [TestModule("ca2c56c5-a30d-4d33-bb0b-4261b778b014", ModuleType.Recording, 1)]
    public partial class Stati_davor : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUAB_006.B_BUAB_006Repository repository.
        /// </summary>
        public static global::B_BUAB_006.B_BUAB_006Repository repo = global::B_BUAB_006.B_BUAB_006Repository.Instance;

        static Stati_davor instance = new Stati_davor();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Stati_davor()
        {
            var_Status_lesen = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Stati_davor Instance
        {
            get { return instance; }
        }

#region Variables

        string _var_Status_lesen;

        /// <summary>
        /// Gets or sets the value of variable var_Status_lesen.
        /// </summary>
        [TestVariable("88567e7c-959e-4daf-a86c-866b32c0ad9e")]
        public string var_Status_lesen
        {
            get { return _var_Status_lesen; }
            set { _var_Status_lesen = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblB1.Extras' at Center.", repo.TblB1.ExtrasInfo, new RecordItemIndex(0));
            repo.TblB1.Extras.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BBUAB.BuchungsStati' at Center.", repo.BBUAB.BuchungsStatiInfo, new RecordItemIndex(1));
            repo.BBUAB.BuchungsStati.Click();
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Checked' from item 'DlgOptionenStatus.Copy_of_CbGeloescht' and assigning its value to variable 'var_Status_lesen'.", repo.DlgOptionenStatus.Copy_of_CbGeloeschtInfo, new RecordItemIndex(2));
            var_Status_lesen = repo.DlgOptionenStatus.Copy_of_CbGeloescht.Element.GetAttributeValueText("Checked");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
