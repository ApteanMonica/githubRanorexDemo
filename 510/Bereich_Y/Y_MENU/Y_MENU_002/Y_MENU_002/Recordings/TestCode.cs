/*
 * Created by Ranorex
 * User: Laloski
 * Date: 01.12.2022
 * Time: 10:57
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace Y_MENU_002.Recordings
{
    /// <summary>
    /// Description of TestCode.
    /// </summary>
    [TestModule("F1CFD8E3-7F02-4CEC-920C-C4378CF79C05", ModuleType.UserCode, 1)]
    public class TestCode : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TestCode()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
        }
    }
}
