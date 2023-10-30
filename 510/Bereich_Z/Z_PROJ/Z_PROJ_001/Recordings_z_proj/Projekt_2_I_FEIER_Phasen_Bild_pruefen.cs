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

namespace Z_PROJ_001.Recordings_z_proj
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Projekt_2_I_FEIER_Phasen_Bild_pruefen recording.
    /// </summary>
    [TestModule("20b33095-b9db-49a1-b743-5eca6e532ff1", ModuleType.Recording, 1)]
    public partial class Projekt_2_I_FEIER_Phasen_Bild_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_PROJ_001.Z_PROJ_001Repository repository.
        /// </summary>
        public static global::Z_PROJ_001.Z_PROJ_001Repository repo = global::Z_PROJ_001.Z_PROJ_001Repository.Instance;

        static Projekt_2_I_FEIER_Phasen_Bild_pruefen instance = new Projekt_2_I_FEIER_Phasen_Bild_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Projekt_2_I_FEIER_Phasen_Bild_pruefen()
        {
            PROJ_NR_2_IP = "I-FEIER";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Projekt_2_I_FEIER_Phasen_Bild_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable PROJ_NR_2_IP.
        /// </summary>
        [TestVariable("72322abd-3e01-4706-b0e5-f63e6f3de5a4")]
        public string PROJ_NR_2_IP
        {
            get { return repo.PROJ_NR_2_IP; }
            set { repo.PROJ_NR_2_IP = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$PROJ_NR_2_IP) on item 'FrmTabProjekt_alt.Projektnr'.", repo.FrmTabProjekt_alt.ProjektnrInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FrmTabProjekt_alt.ProjektnrInfo, "Text", PROJ_NR_2_IP);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt_alt.Phasen_Tab_regex_Sonderzeichen' at Center.", repo.FrmTabProjekt_alt.Phasen_Tab_regex_SonderzeichenInfo, new RecordItemIndex(1));
            repo.FrmTabProjekt_alt.Phasen_Tab_regex_Sonderzeichen.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(2));
            Delay.Duration(2000, false);
            
            // Fenster maximieren
            //Report.Log(ReportLevel.Info, "Keyboard", "Fenster maximieren\r\nKey sequence '{LWin down}{Up}{LWin up}' with focus on 'TitleBar100ProjektVerwalten'.", repo.TitleBar100ProjektVerwaltenInfo, new RecordItemIndex(3));
            //repo.TitleBar100ProjektVerwalten.PressKeys("{LWin down}{Up}{LWin up}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt_alt.Maximieren' at Center.", repo.FrmTabProjekt_alt.MaximierenInfo, new RecordItemIndex(4));
            repo.FrmTabProjekt_alt.Maximieren.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(5));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt_alt.PbDataAccessReload' at Center.", repo.FrmTabProjekt_alt.PbDataAccessReloadInfo, new RecordItemIndex(6));
            repo.FrmTabProjekt_alt.PbDataAccessReload.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(7));
            Delay.Duration(2000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'FrmTabProjekt_alt.Register_Phasen.FlexGrid_Phasen' at LowerCenter.", repo.FrmTabProjekt_alt.Register_Phasen.FlexGrid_PhasenInfo, new RecordItemIndex(8));
            //repo.FrmTabProjekt_alt.Register_Phasen.FlexGrid_Phasen.MoveTo(Location.LowerCenter);
            
            // Spalten 2. Teil
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nSpalten 2. Teil\r\nValidating ContainsImage (Screenshot: 'Screenshot_I_FEIER_Phasen_Spalten_einzeln' with region {X=21,Y=32,Width=45,Height=187}) on item 'FrmTabProjekt_alt.Register_Phasen.FlexGrid_Phasen'.", repo.FrmTabProjekt_alt.Register_Phasen.FlexGrid_PhasenInfo, new RecordItemIndex(9));
                Validate.ContainsImage(repo.FrmTabProjekt_alt.Register_Phasen.FlexGrid_PhasenInfo, FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln, FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_Options, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            // Spalten 2. Teil
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nSpalten 2. Teil\r\nValidating ContainsImage (Screenshot: 'Screenshot_I_FEIER_Phasen_Spalten_einzeln' with region {X=75,Y=33,Width=37,Height=186}) on item 'FrmTabProjekt_alt.Register_Phasen.FlexGrid_Phasen'.", repo.FrmTabProjekt_alt.Register_Phasen.FlexGrid_PhasenInfo, new RecordItemIndex(10));
                Validate.ContainsImage(repo.FrmTabProjekt_alt.Register_Phasen.FlexGrid_PhasenInfo, FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_2, FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_2_Options, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(10)); }
            
            // Spalten 2. Teil
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nSpalten 2. Teil\r\nValidating ContainsImage (Screenshot: 'Screenshot_I_FEIER_Phasen_Spalten_einzeln' with region {X=122,Y=32,Width=28,Height=187}) on item 'FrmTabProjekt_alt.Register_Phasen.FlexGrid_Phasen'.", repo.FrmTabProjekt_alt.Register_Phasen.FlexGrid_PhasenInfo, new RecordItemIndex(11));
                Validate.ContainsImage(repo.FrmTabProjekt_alt.Register_Phasen.FlexGrid_PhasenInfo, FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_3, FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_3_Options, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(11)); }
            
            // Spalten 2. Teil
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nSpalten 2. Teil\r\nValidating ContainsImage (Screenshot: 'Screenshot_I_FEIER_Phasen_Spalten_einzeln' with region {X=162,Y=33,Width=181,Height=184}) on item 'FrmTabProjekt_alt.Register_Phasen.FlexGrid_Phasen'.", repo.FrmTabProjekt_alt.Register_Phasen.FlexGrid_PhasenInfo, new RecordItemIndex(12));
                Validate.ContainsImage(repo.FrmTabProjekt_alt.Register_Phasen.FlexGrid_PhasenInfo, FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_4, FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_4_Options, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(12)); }
            
            // Spalten 2. Teil
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nSpalten 2. Teil\r\nValidating ContainsImage (Screenshot: 'Screenshot_I_FEIER_Phasen_Spalten_einzeln' with region {X=357,Y=33,Width=21,Height=186}) on item 'FrmTabProjekt_alt.Register_Phasen.FlexGrid_Phasen'.", repo.FrmTabProjekt_alt.Register_Phasen.FlexGrid_PhasenInfo, new RecordItemIndex(13));
                Validate.ContainsImage(repo.FrmTabProjekt_alt.Register_Phasen.FlexGrid_PhasenInfo, FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_5, FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_5_Options, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(13)); }
            
            // Spalten 2. Teil
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nSpalten 2. Teil\r\nValidating ContainsImage (Screenshot: 'Screenshot_I_FEIER_Phasen_Spalten_einzeln' with region {X=792,Y=33,Width=57,Height=184}) on item 'FrmTabProjekt_alt.Register_Phasen.FlexGrid_Phasen'.", repo.FrmTabProjekt_alt.Register_Phasen.FlexGrid_PhasenInfo, new RecordItemIndex(14));
                Validate.ContainsImage(repo.FrmTabProjekt_alt.Register_Phasen.FlexGrid_PhasenInfo, FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_6, FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_6_Options, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(14)); }
            
            // Spalten 2. Teil
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nSpalten 2. Teil\r\nValidating ContainsImage (Screenshot: 'Screenshot_I_FEIER_Phasen_Spalten_einzeln' with region {X=1047,Y=34,Width=14,Height=183}) on item 'FrmTabProjekt_alt.Register_Phasen.FlexGrid_Phasen'.", repo.FrmTabProjekt_alt.Register_Phasen.FlexGrid_PhasenInfo, new RecordItemIndex(15));
                Validate.ContainsImage(repo.FrmTabProjekt_alt.Register_Phasen.FlexGrid_PhasenInfo, FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_7, FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_7_Options, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(15)); }
            
            // Fenster minimieren
            //Report.Log(ReportLevel.Info, "Keyboard", "Fenster minimieren\r\nKey sequence '{LWin down}{Down}{LWin up}' with focus on 'TitleBar100ProjektVerwalten'.", repo.TitleBar100ProjektVerwaltenInfo, new RecordItemIndex(16));
            //repo.TitleBar100ProjektVerwalten.PressKeys("{LWin down}{Down}{LWin up}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt_alt.Wiederherstellen' at Center.", repo.FrmTabProjekt_alt.WiederherstellenInfo, new RecordItemIndex(17));
            repo.FrmTabProjekt_alt.Wiederherstellen.Click();
            
        }

#region Image Feature Data
        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln
        { get { return repo.FrmTabProjekt_alt.Register_Phasen.FlexGrid_PhasenInfo.GetScreenshot_I_FEIER_Phasen_Spalten_einzeln(new Rectangle(21, 32, 45, 187)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_Options
        { get { return Imaging.FindOptions.Default; } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_2
        { get { return repo.FrmTabProjekt_alt.Register_Phasen.FlexGrid_PhasenInfo.GetScreenshot_I_FEIER_Phasen_Spalten_einzeln(new Rectangle(75, 33, 37, 186)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_2_Options
        { get { return Imaging.FindOptions.Default; } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_3
        { get { return repo.FrmTabProjekt_alt.Register_Phasen.FlexGrid_PhasenInfo.GetScreenshot_I_FEIER_Phasen_Spalten_einzeln(new Rectangle(122, 32, 28, 187)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_3_Options
        { get { return Imaging.FindOptions.Default; } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_4
        { get { return repo.FrmTabProjekt_alt.Register_Phasen.FlexGrid_PhasenInfo.GetScreenshot_I_FEIER_Phasen_Spalten_einzeln(new Rectangle(162, 33, 181, 184)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_4_Options
        { get { return Imaging.FindOptions.Default; } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_5
        { get { return repo.FrmTabProjekt_alt.Register_Phasen.FlexGrid_PhasenInfo.GetScreenshot_I_FEIER_Phasen_Spalten_einzeln(new Rectangle(357, 33, 21, 186)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_5_Options
        { get { return Imaging.FindOptions.Default; } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_6
        { get { return repo.FrmTabProjekt_alt.Register_Phasen.FlexGrid_PhasenInfo.GetScreenshot_I_FEIER_Phasen_Spalten_einzeln(new Rectangle(792, 33, 57, 184)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_6_Options
        { get { return Imaging.FindOptions.Default; } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_7
        { get { return repo.FrmTabProjekt_alt.Register_Phasen.FlexGrid_PhasenInfo.GetScreenshot_I_FEIER_Phasen_Spalten_einzeln(new Rectangle(1047, 34, 14, 183)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions FlexGrid_Phasen_Screenshot_I_FEIER_Phasen_Spalten_einzeln_7_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
