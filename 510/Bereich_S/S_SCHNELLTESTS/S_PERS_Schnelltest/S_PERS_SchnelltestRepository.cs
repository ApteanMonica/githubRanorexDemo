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

namespace S_PERS_Schnelltest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the S_PERS_SchnelltestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("9d2b8782-1d91-4fb1-8ac1-4ba5b31c8795")]
    public partial class S_PERS_SchnelltestRepository : RepoGenBaseFolder
    {
        static S_PERS_SchnelltestRepository instance = new S_PERS_SchnelltestRepository();
        S_PERS_SchnelltestRepositoryFolders.FrmPersAppFolder _frmpers;

        /// <summary>
        /// Gets the singleton class instance representing the S_PERS_SchnelltestRepository element repository.
        /// </summary>
        [RepositoryFolder("9d2b8782-1d91-4fb1-8ac1-4ba5b31c8795")]
        public static S_PERS_SchnelltestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public S_PERS_SchnelltestRepository() 
            : base("S_PERS_SchnelltestRepository", "/", null, 0, false, "9d2b8782-1d91-4fb1-8ac1-4ba5b31c8795", ".\\RepositoryImages\\S_PERS_SchnelltestRepository9d2b8782.rximgres")
        {
            _frmpers = new S_PERS_SchnelltestRepositoryFolders.FrmPersAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("9d2b8782-1d91-4fb1-8ac1-4ba5b31c8795")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The FrmPers folder.
        /// </summary>
        [RepositoryFolder("0ab088e0-245e-4c13-83e1-f797da034c5c")]
        public virtual S_PERS_SchnelltestRepositoryFolders.FrmPersAppFolder FrmPers
        {
            get { return _frmpers; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class S_PERS_SchnelltestRepositoryFolders
    {
        /// <summary>
        /// The FrmPersAppFolder folder.
        /// </summary>
        [RepositoryFolder("0ab088e0-245e-4c13-83e1-f797da034c5c")]
        public partial class FrmPersAppFolder : RepoGenBaseFolder
        {
            S_PERS_SchnelltestRepositoryFolders.RibbonBarFolder _ribbonbar;
            S_PERS_SchnelltestRepositoryFolders.ToolBarFolder _toolbar;
            S_PERS_SchnelltestRepositoryFolders.TabStammRegisterFolder _tabstammregister;
            RepoItemInfo _titlebar100mitarbeiterstammInfo;
            RepoItemInfo _pbnewInfo;

            /// <summary>
            /// Creates a new FrmPers  folder.
            /// </summary>
            public FrmPersAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FrmPers", "/form[@controlname='frmPers']", parentFolder, 30000, null, true, "0ab088e0-245e-4c13-83e1-f797da034c5c", "")
            {
                _ribbonbar = new S_PERS_SchnelltestRepositoryFolders.RibbonBarFolder(this);
                _toolbar = new S_PERS_SchnelltestRepositoryFolders.ToolBarFolder(this);
                _tabstammregister = new S_PERS_SchnelltestRepositoryFolders.TabStammRegisterFolder(this);
                _titlebar100mitarbeiterstammInfo = new RepoItemInfo(this, "TitleBar100Mitarbeiterstamm", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "2c37b3f1-9d05-40f2-bc17-216dcead3e27");
                _pbnewInfo = new RepoItemInfo(this, "PbNew", "container[@controlname='searchContainer']/form[@controlname='frmSearchPage']/container[@controlname='RibbonBar']/container[@controlname='SearchGroup2']/button[@controlname='pbNew']", "", 30000, null, "1cfbd8b8-ab51-42bc-96b9-965a39945ecb");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("0ab088e0-245e-4c13-83e1-f797da034c5c")]
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
            [RepositoryItemInfo("0ab088e0-245e-4c13-83e1-f797da034c5c")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar100Mitarbeiterstamm item.
            /// </summary>
            [RepositoryItem("2c37b3f1-9d05-40f2-bc17-216dcead3e27")]
            public virtual Ranorex.TitleBar TitleBar100Mitarbeiterstamm
            {
                get
                {
                    return _titlebar100mitarbeiterstammInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100Mitarbeiterstamm item info.
            /// </summary>
            [RepositoryItemInfo("2c37b3f1-9d05-40f2-bc17-216dcead3e27")]
            public virtual RepoItemInfo TitleBar100MitarbeiterstammInfo
            {
                get
                {
                    return _titlebar100mitarbeiterstammInfo;
                }
            }

            /// <summary>
            /// The PbNew item.
            /// </summary>
            [RepositoryItem("1cfbd8b8-ab51-42bc-96b9-965a39945ecb")]
            public virtual Ranorex.Button PbNew
            {
                get
                {
                    return _pbnewInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbNew item info.
            /// </summary>
            [RepositoryItemInfo("1cfbd8b8-ab51-42bc-96b9-965a39945ecb")]
            public virtual RepoItemInfo PbNewInfo
            {
                get
                {
                    return _pbnewInfo;
                }
            }

            /// <summary>
            /// The RibbonBar folder.
            /// </summary>
            [RepositoryFolder("e8025352-8bcf-41a0-9a49-c482c7f39ad5")]
            public virtual S_PERS_SchnelltestRepositoryFolders.RibbonBarFolder RibbonBar
            {
                get { return _ribbonbar; }
            }

            /// <summary>
            /// The ToolBar folder.
            /// </summary>
            [RepositoryFolder("1c000a9f-16be-4c07-8ec3-88e42e6d3749")]
            public virtual S_PERS_SchnelltestRepositoryFolders.ToolBarFolder ToolBar
            {
                get { return _toolbar; }
            }

            /// <summary>
            /// The TabStammRegister folder.
            /// </summary>
            [RepositoryFolder("588c5c34-3bf3-4c5a-8f1a-4e0c2478769f")]
            public virtual S_PERS_SchnelltestRepositoryFolders.TabStammRegisterFolder TabStammRegister
            {
                get { return _tabstammregister; }
            }
        }

        /// <summary>
        /// The RibbonBarFolder folder.
        /// </summary>
        [RepositoryFolder("e8025352-8bcf-41a0-9a49-c482c7f39ad5")]
        public partial class RibbonBarFolder : RepoGenBaseFolder
        {
            RepoItemInfo _pbdataaccessreloadInfo;
            RepoItemInfo _pbdataaccesssaveInfo;
            RepoItemInfo _pbnavigationbackInfo;

            /// <summary>
            /// Creates a new RibbonBar  folder.
            /// </summary>
            public RibbonBarFolder(RepoGenBaseFolder parentFolder) :
                    base("RibbonBar", "container[@controlname='RibbonBar']", parentFolder, 30000, null, false, "e8025352-8bcf-41a0-9a49-c482c7f39ad5", "")
            {
                _pbdataaccessreloadInfo = new RepoItemInfo(this, "PbDataAccessReload", "container[@controlname='DataAccessGroup']/button[@controlname='pbDataAccess_Reload']", "", 30000, null, "2966bb2a-10f5-45b8-9bb9-b272e10e3caa");
                _pbdataaccesssaveInfo = new RepoItemInfo(this, "PbDataAccessSave", "container[@controlname='DataAccessGroup']/button[@controlname='pbDataAccess_Save']", "", 30000, null, "a2933beb-28da-492c-ab6d-d5c53b6daa33");
                _pbnavigationbackInfo = new RepoItemInfo(this, "PbNavigationBack", "container[@controlname='NavigationGroup']/button[@controlname='pbNavigation_Back']", "", 30000, null, "4978e648-6e06-4f8d-a7e4-fa95968d7432");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("e8025352-8bcf-41a0-9a49-c482c7f39ad5")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("e8025352-8bcf-41a0-9a49-c482c7f39ad5")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The PbDataAccessReload item.
            /// </summary>
            [RepositoryItem("2966bb2a-10f5-45b8-9bb9-b272e10e3caa")]
            public virtual Ranorex.Button PbDataAccessReload
            {
                get
                {
                    return _pbdataaccessreloadInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbDataAccessReload item info.
            /// </summary>
            [RepositoryItemInfo("2966bb2a-10f5-45b8-9bb9-b272e10e3caa")]
            public virtual RepoItemInfo PbDataAccessReloadInfo
            {
                get
                {
                    return _pbdataaccessreloadInfo;
                }
            }

            /// <summary>
            /// The PbDataAccessSave item.
            /// </summary>
            [RepositoryItem("a2933beb-28da-492c-ab6d-d5c53b6daa33")]
            public virtual Ranorex.Button PbDataAccessSave
            {
                get
                {
                    return _pbdataaccesssaveInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbDataAccessSave item info.
            /// </summary>
            [RepositoryItemInfo("a2933beb-28da-492c-ab6d-d5c53b6daa33")]
            public virtual RepoItemInfo PbDataAccessSaveInfo
            {
                get
                {
                    return _pbdataaccesssaveInfo;
                }
            }

            /// <summary>
            /// The PbNavigationBack item.
            /// </summary>
            [RepositoryItem("4978e648-6e06-4f8d-a7e4-fa95968d7432")]
            public virtual Ranorex.Button PbNavigationBack
            {
                get
                {
                    return _pbnavigationbackInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbNavigationBack item info.
            /// </summary>
            [RepositoryItemInfo("4978e648-6e06-4f8d-a7e4-fa95968d7432")]
            public virtual RepoItemInfo PbNavigationBackInfo
            {
                get
                {
                    return _pbnavigationbackInfo;
                }
            }
        }

        /// <summary>
        /// The ToolBarFolder folder.
        /// </summary>
        [RepositoryFolder("1c000a9f-16be-4c07-8ec3-88e42e6d3749")]
        public partial class ToolBarFolder : RepoGenBaseFolder
        {
            RepoItemInfo _dfpersnrInfo;
            RepoItemInfo _pballeInfo;

            /// <summary>
            /// Creates a new ToolBar  folder.
            /// </summary>
            public ToolBarFolder(RepoGenBaseFolder parentFolder) :
                    base("ToolBar", "container[@controlname='ToolBar']", parentFolder, 30000, null, false, "1c000a9f-16be-4c07-8ec3-88e42e6d3749", "")
            {
                _dfpersnrInfo = new RepoItemInfo(this, "DfPersNr", "text[@controlname='dfPers_nr']", "", 30000, null, "a2de2ff0-0070-41f0-9c34-72c5301523b5");
                _pballeInfo = new RepoItemInfo(this, "PbAlle", "container[@controlname='cGueltigkeitsManager']/container[@controlname='gbGueltigkeit']/button[@controlname='pbAlle']", "", 30000, null, "e52c9db3-5ee8-40d9-92de-a6ef073811fd");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("1c000a9f-16be-4c07-8ec3-88e42e6d3749")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("1c000a9f-16be-4c07-8ec3-88e42e6d3749")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The DfPersNr item.
            /// </summary>
            [RepositoryItem("a2de2ff0-0070-41f0-9c34-72c5301523b5")]
            public virtual Ranorex.Text DfPersNr
            {
                get
                {
                    return _dfpersnrInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The DfPersNr item info.
            /// </summary>
            [RepositoryItemInfo("a2de2ff0-0070-41f0-9c34-72c5301523b5")]
            public virtual RepoItemInfo DfPersNrInfo
            {
                get
                {
                    return _dfpersnrInfo;
                }
            }

            /// <summary>
            /// The PbAlle item.
            /// </summary>
            [RepositoryItem("e52c9db3-5ee8-40d9-92de-a6ef073811fd")]
            public virtual Ranorex.Button PbAlle
            {
                get
                {
                    return _pballeInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbAlle item info.
            /// </summary>
            [RepositoryItemInfo("e52c9db3-5ee8-40d9-92de-a6ef073811fd")]
            public virtual RepoItemInfo PbAlleInfo
            {
                get
                {
                    return _pballeInfo;
                }
            }
        }

        /// <summary>
        /// The TabStammRegisterFolder folder.
        /// </summary>
        [RepositoryFolder("588c5c34-3bf3-4c5a-8f1a-4e0c2478769f")]
        public partial class TabStammRegisterFolder : RepoGenBaseFolder
        {
            S_PERS_SchnelltestRepositoryFolders.GbGrundDatenFolder _gbgrunddaten;

            /// <summary>
            /// Creates a new TabStammRegister  folder.
            /// </summary>
            public TabStammRegisterFolder(RepoGenBaseFolder parentFolder) :
                    base("TabStammRegister", "container[@controlname='ClientArea']/tabpagelist[@controlname='tabStammRegister']", parentFolder, 30000, null, false, "588c5c34-3bf3-4c5a-8f1a-4e0c2478769f", "")
            {
                _gbgrunddaten = new S_PERS_SchnelltestRepositoryFolders.GbGrundDatenFolder(this);
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("588c5c34-3bf3-4c5a-8f1a-4e0c2478769f")]
            public virtual Ranorex.TabPageList Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.TabPageList>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("588c5c34-3bf3-4c5a-8f1a-4e0c2478769f")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The GbGrundDaten folder.
            /// </summary>
            [RepositoryFolder("f0194659-0b73-4732-a80f-79009f337f93")]
            public virtual S_PERS_SchnelltestRepositoryFolders.GbGrundDatenFolder GbGrundDaten
            {
                get { return _gbgrunddaten; }
            }
        }

        /// <summary>
        /// The GbGrundDatenFolder folder.
        /// </summary>
        [RepositoryFolder("f0194659-0b73-4732-a80f-79009f337f93")]
        public partial class GbGrundDatenFolder : RepoGenBaseFolder
        {
            RepoItemInfo _dfperskbezInfo;
            RepoItemInfo _texttypInfo;
            RepoItemInfo _dfanrdcdInfo;
            RepoItemInfo _statusInfo;
            RepoItemInfo _dfvornameInfo;
            RepoItemInfo _dfnachnameInfo;

            /// <summary>
            /// Creates a new GbGrundDaten  folder.
            /// </summary>
            public GbGrundDatenFolder(RepoGenBaseFolder parentFolder) :
                    base("GbGrundDaten", "tabpage[@controlname='tpMitarbeiter']/container[@controlname='scKldvDaten']/container[@controltypename='SplitterPanel' and @instance='0']/container[@controlname='scWeitereDaten']/container[@controltypename='SplitterPanel' and @instance='0']/container[@controlname='gbGrundDaten']", parentFolder, 30000, null, false, "f0194659-0b73-4732-a80f-79009f337f93", "")
            {
                _dfperskbezInfo = new RepoItemInfo(this, "DfPersKbez", "text[@controlname='dfPers_kbez']", "", 30000, null, "8f488d63-5a8e-4ac3-a0ba-73aa21ffb1f8");
                _texttypInfo = new RepoItemInfo(this, "TextTyp", "text[@controlname='dfPers_typ']/text[@accessiblename='Typ']", "", 30000, null, "a723de3f-e4b4-4c38-9a59-341233d9d6a8");
                _dfanrdcdInfo = new RepoItemInfo(this, "DfAnrdCd", "text[@controlname='dfAnrd_cd']", "", 30000, null, "61081d78-57cd-4eb4-99f5-95e798b5d77a");
                _statusInfo = new RepoItemInfo(this, "Status", "text[@controlname='dfPers_status']/text[@accessiblename='Status']", "", 30000, null, "09ac818c-4e53-4a9c-98e3-50e91569b6e7");
                _dfvornameInfo = new RepoItemInfo(this, "DfVorname", "text[@controlname='dfVorname']", "", 30000, null, "9142afd5-14a3-450c-8eac-351bd7abffe8");
                _dfnachnameInfo = new RepoItemInfo(this, "DfNachname", "text[@controlname='dfNachname']", "", 30000, null, "7fe0f7bc-437c-4d02-b5df-12410e4a5323");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("f0194659-0b73-4732-a80f-79009f337f93")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("f0194659-0b73-4732-a80f-79009f337f93")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The DfPersKbez item.
            /// </summary>
            [RepositoryItem("8f488d63-5a8e-4ac3-a0ba-73aa21ffb1f8")]
            public virtual Ranorex.Text DfPersKbez
            {
                get
                {
                    return _dfperskbezInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The DfPersKbez item info.
            /// </summary>
            [RepositoryItemInfo("8f488d63-5a8e-4ac3-a0ba-73aa21ffb1f8")]
            public virtual RepoItemInfo DfPersKbezInfo
            {
                get
                {
                    return _dfperskbezInfo;
                }
            }

            /// <summary>
            /// The TextTyp item.
            /// </summary>
            [RepositoryItem("a723de3f-e4b4-4c38-9a59-341233d9d6a8")]
            public virtual Ranorex.Text TextTyp
            {
                get
                {
                    return _texttypInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The TextTyp item info.
            /// </summary>
            [RepositoryItemInfo("a723de3f-e4b4-4c38-9a59-341233d9d6a8")]
            public virtual RepoItemInfo TextTypInfo
            {
                get
                {
                    return _texttypInfo;
                }
            }

            /// <summary>
            /// The DfAnrdCd item.
            /// </summary>
            [RepositoryItem("61081d78-57cd-4eb4-99f5-95e798b5d77a")]
            public virtual Ranorex.Text DfAnrdCd
            {
                get
                {
                    return _dfanrdcdInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The DfAnrdCd item info.
            /// </summary>
            [RepositoryItemInfo("61081d78-57cd-4eb4-99f5-95e798b5d77a")]
            public virtual RepoItemInfo DfAnrdCdInfo
            {
                get
                {
                    return _dfanrdcdInfo;
                }
            }

            /// <summary>
            /// The Status item.
            /// </summary>
            [RepositoryItem("09ac818c-4e53-4a9c-98e3-50e91569b6e7")]
            public virtual Ranorex.Text Status
            {
                get
                {
                    return _statusInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Status item info.
            /// </summary>
            [RepositoryItemInfo("09ac818c-4e53-4a9c-98e3-50e91569b6e7")]
            public virtual RepoItemInfo StatusInfo
            {
                get
                {
                    return _statusInfo;
                }
            }

            /// <summary>
            /// The DfVorname item.
            /// </summary>
            [RepositoryItem("9142afd5-14a3-450c-8eac-351bd7abffe8")]
            public virtual Ranorex.Text DfVorname
            {
                get
                {
                    return _dfvornameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The DfVorname item info.
            /// </summary>
            [RepositoryItemInfo("9142afd5-14a3-450c-8eac-351bd7abffe8")]
            public virtual RepoItemInfo DfVornameInfo
            {
                get
                {
                    return _dfvornameInfo;
                }
            }

            /// <summary>
            /// The DfNachname item.
            /// </summary>
            [RepositoryItem("7fe0f7bc-437c-4d02-b5df-12410e4a5323")]
            public virtual Ranorex.Text DfNachname
            {
                get
                {
                    return _dfnachnameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The DfNachname item info.
            /// </summary>
            [RepositoryItemInfo("7fe0f7bc-437c-4d02-b5df-12410e4a5323")]
            public virtual RepoItemInfo DfNachnameInfo
            {
                get
                {
                    return _dfnachnameInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
