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

namespace K_FIBU_001.SQL_Updates_Selects
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SQL_Update_y_par_fibu_sperre_auf_1 recording.
    /// </summary>
    [TestModule("919a529e-274a-4854-ad4a-2d4d2e713e6a", ModuleType.Recording, 1)]
    public partial class SQL_Update_y_par_fibu_sperre_auf_1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_FIBU_001.K_FIBU_001Repository repository.
        /// </summary>
        public static global::K_FIBU_001.K_FIBU_001Repository repo = global::K_FIBU_001.K_FIBU_001Repository.Instance;

        static SQL_Update_y_par_fibu_sperre_auf_1 instance = new SQL_Update_y_par_fibu_sperre_auf_1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SQL_Update_y_par_fibu_sperre_auf_1()
        {
            Update_y_par_Sperre_EIN = "update y_par set par_textk = '1' where par_cd = 'FIBU_SPERRE_100' and par_lfdnr= '0';";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SQL_Update_y_par_fibu_sperre_auf_1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Update_y_par_Sperre_EIN;

        /// <summary>
        /// Gets or sets the value of variable Update_y_par_Sperre_EIN.
        /// </summary>
        [TestVariable("a1f165c5-d815-4042-90b9-ee5bde1c05a3")]
        public string Update_y_par_Sperre_EIN
        {
            get { return _Update_y_par_Sperre_EIN; }
            set { _Update_y_par_Sperre_EIN = value; }
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

            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.SQLStatement(Update_y_par_Sperre_EIN, "");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
