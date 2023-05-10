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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace B_JOUR_004
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the B_JOUR_004Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("57426aa4-5767-460d-99be-15f95be04fd0")]
    public partial class B_JOUR_004Repository : RepoGenBaseFolder
    {
        static B_JOUR_004Repository instance = new B_JOUR_004Repository();
        B_JOUR_004RepositoryFolders.FrmJournalAppFolder _frmjournal;
        B_JOUR_004RepositoryFolders.DlgMessageBoxAppFolder _dlgmessagebox;
        B_JOUR_004RepositoryFolders.BJOURAppFolder _bjour;
        B_JOUR_004RepositoryFolders.DlgWebSupportAppFolder _dlgwebsupport;

        /// <summary>
        /// Gets the singleton class instance representing the B_JOUR_004Repository element repository.
        /// </summary>
        [RepositoryFolder("57426aa4-5767-460d-99be-15f95be04fd0")]
        public static B_JOUR_004Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public B_JOUR_004Repository() 
            : base("B_JOUR_004Repository", "/", null, 0, false, "57426aa4-5767-460d-99be-15f95be04fd0", ".\\RepositoryImages\\B_JOUR_004Repository57426aa4.rximgres")
        {
            _frmjournal = new B_JOUR_004RepositoryFolders.FrmJournalAppFolder(this);
            _dlgmessagebox = new B_JOUR_004RepositoryFolders.DlgMessageBoxAppFolder(this);
            _bjour = new B_JOUR_004RepositoryFolders.BJOURAppFolder(this);
            _dlgwebsupport = new B_JOUR_004RepositoryFolders.DlgWebSupportAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("57426aa4-5767-460d-99be-15f95be04fd0")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The FrmJournal folder.
        /// </summary>
        [RepositoryFolder("529f7167-c07f-4b99-9e46-437761c7d900")]
        public virtual B_JOUR_004RepositoryFolders.FrmJournalAppFolder FrmJournal
        {
            get { return _frmjournal; }
        }

        /// <summary>
        /// The DlgMessageBox folder.
        /// </summary>
        [RepositoryFolder("0a4ee5b5-e4e7-4466-8db0-b60390905388")]
        public virtual B_JOUR_004RepositoryFolders.DlgMessageBoxAppFolder DlgMessageBox
        {
            get { return _dlgmessagebox; }
        }

        /// <summary>
        /// The BJOUR folder.
        /// </summary>
        [RepositoryFolder("ce9fd968-3a1b-4121-b272-4647bf31141c")]
        public virtual B_JOUR_004RepositoryFolders.BJOURAppFolder BJOUR
        {
            get { return _bjour; }
        }

        /// <summary>
        /// The DlgWebSupport folder.
        /// </summary>
        [RepositoryFolder("63981b24-bdbb-4643-a0f9-a3f9dd147b77")]
        public virtual B_JOUR_004RepositoryFolders.DlgWebSupportAppFolder DlgWebSupport
        {
            get { return _dlgwebsupport; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class B_JOUR_004RepositoryFolders
    {
        /// <summary>
        /// The FrmJournalAppFolder folder.
        /// </summary>
        [RepositoryFolder("529f7167-c07f-4b99-9e46-437761c7d900")]
        public partial class FrmJournalAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _titlebar100erfassungsjournalInfo;
            RepoItemInfo _pbcommonbenutzerloeschenInfo;
            RepoItemInfo _pbsystemhilfeinfoInfo;

            /// <summary>
            /// Creates a new FrmJournal  folder.
            /// </summary>
            public FrmJournalAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FrmJournal", "/form[@controlname='frmJournal']", parentFolder, 30000, null, true, "529f7167-c07f-4b99-9e46-437761c7d900", "")
            {
                _titlebar100erfassungsjournalInfo = new RepoItemInfo(this, "TitleBar100ErfassungsJournal", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "64a47630-dc57-42b3-851b-b86a1d1d875b");
                _pbcommonbenutzerloeschenInfo = new RepoItemInfo(this, "PbCommonBenutzerloeschen", "?/?/container[@controlname='CommonGroup']/button[@controlname='pbCommon_Benutzerloeschen']", "", 30000, null, "aef0b20c-91fe-420d-bc66-a7bd72b78787");
                _pbsystemhilfeinfoInfo = new RepoItemInfo(this, "PbSystemHilfeInfo", "?/?/container[@controlname='SystemGroup']/button[@controlname='pbSystem_HilfeInfo']", "", 30000, null, "63e0cf7c-188f-4814-b12d-ee774b88ad0d");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("529f7167-c07f-4b99-9e46-437761c7d900")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("529f7167-c07f-4b99-9e46-437761c7d900")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar100ErfassungsJournal item.
            /// </summary>
            [RepositoryItem("64a47630-dc57-42b3-851b-b86a1d1d875b")]
            public virtual Ranorex.TitleBar TitleBar100ErfassungsJournal
            {
                get
                {
                    return _titlebar100erfassungsjournalInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100ErfassungsJournal item info.
            /// </summary>
            [RepositoryItemInfo("64a47630-dc57-42b3-851b-b86a1d1d875b")]
            public virtual RepoItemInfo TitleBar100ErfassungsJournalInfo
            {
                get
                {
                    return _titlebar100erfassungsjournalInfo;
                }
            }

            /// <summary>
            /// The PbCommonBenutzerloeschen item.
            /// </summary>
            [RepositoryItem("aef0b20c-91fe-420d-bc66-a7bd72b78787")]
            public virtual Ranorex.Button PbCommonBenutzerloeschen
            {
                get
                {
                    return _pbcommonbenutzerloeschenInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbCommonBenutzerloeschen item info.
            /// </summary>
            [RepositoryItemInfo("aef0b20c-91fe-420d-bc66-a7bd72b78787")]
            public virtual RepoItemInfo PbCommonBenutzerloeschenInfo
            {
                get
                {
                    return _pbcommonbenutzerloeschenInfo;
                }
            }

            /// <summary>
            /// The PbSystemHilfeInfo item.
            /// </summary>
            [RepositoryItem("63e0cf7c-188f-4814-b12d-ee774b88ad0d")]
            public virtual Ranorex.Button PbSystemHilfeInfo
            {
                get
                {
                    return _pbsystemhilfeinfoInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbSystemHilfeInfo item info.
            /// </summary>
            [RepositoryItemInfo("63e0cf7c-188f-4814-b12d-ee774b88ad0d")]
            public virtual RepoItemInfo PbSystemHilfeInfoInfo
            {
                get
                {
                    return _pbsystemhilfeinfoInfo;
                }
            }
        }

        /// <summary>
        /// The DlgMessageBoxAppFolder folder.
        /// </summary>
        [RepositoryFolder("0a4ee5b5-e4e7-4466-8db0-b60390905388")]
        public partial class DlgMessageBoxAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _labelmeldungstextInfo;
            RepoItemInfo _button1Info;
            RepoItemInfo _button0Info;
            RepoItemInfo _journaldruckInfo;

            /// <summary>
            /// Creates a new DlgMessageBox  folder.
            /// </summary>
            public DlgMessageBoxAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DlgMessageBox", "/form[@controlname='dlgMessageBox']", parentFolder, 30000, null, true, "0a4ee5b5-e4e7-4466-8db0-b60390905388", "")
            {
                _labelmeldungstextInfo = new RepoItemInfo(this, "LabelMeldungstext", "text[@controlname='labelMeldungstext']", "", 30000, null, "c7e96f82-63e3-49f6-a8f5-06c0f095fa39");
                _button1Info = new RepoItemInfo(this, "Button1", "button[@controlname='button1']", "", 30000, null, "04d2efe7-93e8-4066-a52b-38b0c4f51fc7");
                _button0Info = new RepoItemInfo(this, "Button0", "button[@controlname='button0']", "", 30000, null, "dcf7b093-c6d9-406b-af2f-b515f3c25bf5");
                _journaldruckInfo = new RepoItemInfo(this, "Journaldruck", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "4c65e29f-7bbc-4acc-8926-89d2a57bdb36");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("0a4ee5b5-e4e7-4466-8db0-b60390905388")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("0a4ee5b5-e4e7-4466-8db0-b60390905388")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The LabelMeldungstext item.
            /// </summary>
            [RepositoryItem("c7e96f82-63e3-49f6-a8f5-06c0f095fa39")]
            public virtual Ranorex.Text LabelMeldungstext
            {
                get
                {
                    return _labelmeldungstextInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The LabelMeldungstext item info.
            /// </summary>
            [RepositoryItemInfo("c7e96f82-63e3-49f6-a8f5-06c0f095fa39")]
            public virtual RepoItemInfo LabelMeldungstextInfo
            {
                get
                {
                    return _labelmeldungstextInfo;
                }
            }

            /// <summary>
            /// The Button1 item.
            /// </summary>
            [RepositoryItem("04d2efe7-93e8-4066-a52b-38b0c4f51fc7")]
            public virtual Ranorex.Button Button1
            {
                get
                {
                    return _button1Info.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Button1 item info.
            /// </summary>
            [RepositoryItemInfo("04d2efe7-93e8-4066-a52b-38b0c4f51fc7")]
            public virtual RepoItemInfo Button1Info
            {
                get
                {
                    return _button1Info;
                }
            }

            /// <summary>
            /// The Button0 item.
            /// </summary>
            [RepositoryItem("dcf7b093-c6d9-406b-af2f-b515f3c25bf5")]
            public virtual Ranorex.Button Button0
            {
                get
                {
                    return _button0Info.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Button0 item info.
            /// </summary>
            [RepositoryItemInfo("dcf7b093-c6d9-406b-af2f-b515f3c25bf5")]
            public virtual RepoItemInfo Button0Info
            {
                get
                {
                    return _button0Info;
                }
            }

            /// <summary>
            /// The Journaldruck item.
            /// </summary>
            [RepositoryItem("4c65e29f-7bbc-4acc-8926-89d2a57bdb36")]
            public virtual Ranorex.TitleBar Journaldruck
            {
                get
                {
                    return _journaldruckInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The Journaldruck item info.
            /// </summary>
            [RepositoryItemInfo("4c65e29f-7bbc-4acc-8926-89d2a57bdb36")]
            public virtual RepoItemInfo JournaldruckInfo
            {
                get
                {
                    return _journaldruckInfo;
                }
            }
        }

        /// <summary>
        /// The BJOURAppFolder folder.
        /// </summary>
        [RepositoryFolder("ce9fd968-3a1b-4121-b272-4647bf31141c")]
        public partial class BJOURAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _support_510_511Info;
            RepoItemInfo _support_521Info;

            /// <summary>
            /// Creates a new BJOUR  folder.
            /// </summary>
            public BJOURAppFolder(RepoGenBaseFolder parentFolder) :
                    base("BJOUR", "/contextmenu[@processname='B_JOUR']", parentFolder, 30000, null, true, "ce9fd968-3a1b-4121-b272-4647bf31141c", "")
            {
                _support_510_511Info = new RepoItemInfo(this, "Support_510_511", "menuitem[@accessiblename='Support']", "", 30000, null, "424a8f31-6a0c-4160-99a5-0551eb4f38c6");
                _support_521Info = new RepoItemInfo(this, "Support_521", "menuitem[@name='Support']", "", 90000, null, "e06adefb-a420-4bde-8ddd-034728e2151f");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("ce9fd968-3a1b-4121-b272-4647bf31141c")]
            public virtual Ranorex.ContextMenu Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ContextMenu>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("ce9fd968-3a1b-4121-b272-4647bf31141c")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Support_510_511 item.
            /// </summary>
            [RepositoryItem("424a8f31-6a0c-4160-99a5-0551eb4f38c6")]
            public virtual Ranorex.MenuItem Support_510_511
            {
                get
                {
                    return _support_510_511Info.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The Support_510_511 item info.
            /// </summary>
            [RepositoryItemInfo("424a8f31-6a0c-4160-99a5-0551eb4f38c6")]
            public virtual RepoItemInfo Support_510_511Info
            {
                get
                {
                    return _support_510_511Info;
                }
            }

            /// <summary>
            /// The Support_521 item.
            /// </summary>
            [RepositoryItem("e06adefb-a420-4bde-8ddd-034728e2151f")]
            public virtual Ranorex.MenuItem Support_521
            {
                get
                {
                    return _support_521Info.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The Support_521 item info.
            /// </summary>
            [RepositoryItemInfo("e06adefb-a420-4bde-8ddd-034728e2151f")]
            public virtual RepoItemInfo Support_521Info
            {
                get
                {
                    return _support_521Info;
                }
            }
        }

        /// <summary>
        /// The DlgWebSupportAppFolder folder.
        /// </summary>
        [RepositoryFolder("63981b24-bdbb-4643-a0f9-a3f9dd147b77")]
        public partial class DlgWebSupportAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _meldungstextInfo;
            RepoItemInfo _titlebar100supportanfrageuebermitteInfo;
            RepoItemInfo _schliessenInfo;

            /// <summary>
            /// Creates a new DlgWebSupport  folder.
            /// </summary>
            public DlgWebSupportAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DlgWebSupport", "/form[@controlname='dlgWebSupport']", parentFolder, 30000, null, true, "63981b24-bdbb-4643-a0f9-a3f9dd147b77", "")
            {
                _meldungstextInfo = new RepoItemInfo(this, "Meldungstext", "?/?/text[@accessiblename='Meldungstext']", "", 30000, null, "1c204102-06ce-41c1-a31b-c1908ad568de");
                _titlebar100supportanfrageuebermitteInfo = new RepoItemInfo(this, "TitleBar100SupportanfrageUebermitte", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "fa471d18-85e0-444e-a342-6f1d1bb017d1");
                _schliessenInfo = new RepoItemInfo(this, "Schliessen", "?/?/button[@accessiblename='Schließen']", "", 30000, null, "d154f67c-4899-44bb-a745-2364ddd97cd8");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("63981b24-bdbb-4643-a0f9-a3f9dd147b77")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("63981b24-bdbb-4643-a0f9-a3f9dd147b77")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Meldungstext item.
            /// </summary>
            [RepositoryItem("1c204102-06ce-41c1-a31b-c1908ad568de")]
            public virtual Ranorex.Text Meldungstext
            {
                get
                {
                    return _meldungstextInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Meldungstext item info.
            /// </summary>
            [RepositoryItemInfo("1c204102-06ce-41c1-a31b-c1908ad568de")]
            public virtual RepoItemInfo MeldungstextInfo
            {
                get
                {
                    return _meldungstextInfo;
                }
            }

            /// <summary>
            /// The TitleBar100SupportanfrageUebermitte item.
            /// </summary>
            [RepositoryItem("fa471d18-85e0-444e-a342-6f1d1bb017d1")]
            public virtual Ranorex.TitleBar TitleBar100SupportanfrageUebermitte
            {
                get
                {
                    return _titlebar100supportanfrageuebermitteInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100SupportanfrageUebermitte item info.
            /// </summary>
            [RepositoryItemInfo("fa471d18-85e0-444e-a342-6f1d1bb017d1")]
            public virtual RepoItemInfo TitleBar100SupportanfrageUebermitteInfo
            {
                get
                {
                    return _titlebar100supportanfrageuebermitteInfo;
                }
            }

            /// <summary>
            /// The Schliessen item.
            /// </summary>
            [RepositoryItem("d154f67c-4899-44bb-a745-2364ddd97cd8")]
            public virtual Ranorex.Button Schliessen
            {
                get
                {
                    return _schliessenInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Schliessen item info.
            /// </summary>
            [RepositoryItemInfo("d154f67c-4899-44bb-a745-2364ddd97cd8")]
            public virtual RepoItemInfo SchliessenInfo
            {
                get
                {
                    return _schliessenInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
