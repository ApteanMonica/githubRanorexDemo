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
    ///The Ticket_Fail_ED recording.
    /// </summary>
    [TestModule("f088661b-fb7a-41a0-92bf-8d91f263da60", ModuleType.Recording, 1)]
    public partial class Ticket_Fail_ED : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Servicecenter.ServicecenterRepository repository.
        /// </summary>
        public static global::Servicecenter.ServicecenterRepository repo = global::Servicecenter.ServicecenterRepository.Instance;

        static Ticket_Fail_ED instance = new Ticket_Fail_ED();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Ticket_Fail_ED()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Ticket_Fail_ED Instance
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(0));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 200 units.", new RecordItemIndex(1));
            Mouse.ScrollWheel(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Windows.TicketErstellen'.", repo.Windows.TicketErstellenInfo, new RecordItemIndex(2));
            Validate.Exists(repo.Windows.TicketErstellenInfo);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Windows.TicketErstellen' at Center.", repo.Windows.TicketErstellenInfo, new RecordItemIndex(3));
            repo.Windows.TicketErstellen.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Windows.Speichern' at Center.", repo.Windows.SpeichernInfo, new RecordItemIndex(4));
            repo.Windows.Speichern.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Windows.Fehler_Edge.Fehler_Bereich'.", repo.Windows.Fehler_Edge.Fehler_BereichInfo, new RecordItemIndex(5));
            Validate.Exists(repo.Windows.Fehler_Edge.Fehler_BereichInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Windows.Fehler_Edge.Fehler_Bereich'.", repo.Windows.Fehler_Edge.Fehler_BereichInfo, new RecordItemIndex(6));
            Validate.Exists(repo.Windows.Fehler_Edge.Fehler_BereichInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Windows.Fehler_Edge.Fehler_Programm'.", repo.Windows.Fehler_Edge.Fehler_ProgrammInfo, new RecordItemIndex(7));
            Validate.Exists(repo.Windows.Fehler_Edge.Fehler_ProgrammInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Windows.Fehler_Edge.Fehler_Titel'.", repo.Windows.Fehler_Edge.Fehler_TitelInfo, new RecordItemIndex(8));
            Validate.Exists(repo.Windows.Fehler_Edge.Fehler_TitelInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Windows.Fehler_Edge.Fehler_Text'.", repo.Windows.Fehler_Edge.Fehler_TextInfo, new RecordItemIndex(9));
            Validate.Exists(repo.Windows.Fehler_Edge.Fehler_TextInfo);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
