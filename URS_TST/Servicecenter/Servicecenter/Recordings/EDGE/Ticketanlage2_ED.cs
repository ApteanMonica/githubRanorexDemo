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

namespace Servicecenter.Recordings.EDGE
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Ticketanlage2_ED recording.
    /// </summary>
    [TestModule("f33b1f53-1907-430b-b6a5-fff342b8b7f5", ModuleType.Recording, 1)]
    public partial class Ticketanlage2_ED : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Servicecenter.ServicecenterRepository repository.
        /// </summary>
        public static global::Servicecenter.ServicecenterRepository repo = global::Servicecenter.ServicecenterRepository.Instance;

        static Ticketanlage2_ED instance = new Ticketanlage2_ED();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Ticketanlage2_ED()
        {
            Titel = "Das ist ein Test!";
            Text = "TEST TEST TEST TEST TEST";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Ticketanlage2_ED Instance
        {
            get { return instance; }
        }

#region Variables

        string _Titel;

        /// <summary>
        /// Gets or sets the value of variable Titel.
        /// </summary>
        [TestVariable("29945df3-2f06-4a41-b850-5b07a3eb8519")]
        public string Titel
        {
            get { return _Titel; }
            set { _Titel = value; }
        }

        string _Text;

        /// <summary>
        /// Gets or sets the value of variable Text.
        /// </summary>
        [TestVariable("be1dad77-8723-4661-b10e-39cce95f8d5b")]
        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Windows.Fehler_Edge.Titel_ED' at Center.", repo.Windows.Fehler_Edge.Titel_EDInfo, new RecordItemIndex(0));
            repo.Windows.Fehler_Edge.Titel_ED.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Titel' with focus on 'Windows.Fehler_Edge.Titel_ED'.", repo.Windows.Fehler_Edge.Titel_EDInfo, new RecordItemIndex(1));
            repo.Windows.Fehler_Edge.Titel_ED.PressKeys(Titel);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Titel) on item 'Windows.Fehler_Edge.Titel_Text'.", repo.Windows.Fehler_Edge.Titel_TextInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.Windows.Fehler_Edge.Titel_TextInfo, "Text", Titel);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Windows.Fehler_Edge.Textfeld_ED' at Center.", repo.Windows.Fehler_Edge.Textfeld_EDInfo, new RecordItemIndex(3));
            repo.Windows.Fehler_Edge.Textfeld_ED.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Text' with focus on 'Windows.Fehler_Edge.Textfeld_ED'.", repo.Windows.Fehler_Edge.Textfeld_EDInfo, new RecordItemIndex(4));
            repo.Windows.Fehler_Edge.Textfeld_ED.PressKeys(Text);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Text) on item 'Windows.Fehler_Edge.Text_ED'.", repo.Windows.Fehler_Edge.Text_EDInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.Windows.Fehler_Edge.Text_EDInfo, "Text", Text);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
