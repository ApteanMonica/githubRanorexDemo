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

namespace X_MUSTER_021
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Select_Validate recording.
    /// </summary>
    [TestModule("cc7690f7-41b2-458c-8dab-18cbe2fa347a", ModuleType.Recording, 1)]
    public partial class Select_Validate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the X_MUSTER_021Repository repository.
        /// </summary>
        public static X_MUSTER_021Repository repo = X_MUSTER_021Repository.Instance;

        static Select_Validate instance = new Select_Validate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Select_Validate()
        {
            PAR_TEXTK = "";
            PAR_TEXTK_0 = "0";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Select_Validate Instance
        {
            get { return instance; }
        }

#region Variables

        string _PAR_TEXTK;

        /// <summary>
        /// Gets or sets the value of variable PAR_TEXTK.
        /// </summary>
        [TestVariable("74972e38-3a88-48b3-867a-9383e4a95a0c")]
        public string PAR_TEXTK
        {
            get { return _PAR_TEXTK; }
            set { _PAR_TEXTK = value; }
        }

        string _PAR_TEXTK_0;

        /// <summary>
        /// Gets or sets the value of variable PAR_TEXTK_0.
        /// </summary>
        [TestVariable("9c05e721-4612-4b01-bbdb-ead3bead2d15")]
        public string PAR_TEXTK_0
        {
            get { return _PAR_TEXTK_0; }
            set { _PAR_TEXTK_0 = value; }
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

            //Ranorex.AutomationHelpers.UserCodeCollections.Aptean.SQLStatement("select par_textk from y_par where par_cd = 'FIBU_SPERRE_100' and par_lfdnr= '0';", "$PAR_TEXTK");
            
            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.ValidateVar1Var2("", PAR_TEXTK, PAR_TEXTK_0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
