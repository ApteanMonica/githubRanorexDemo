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

namespace B_KTO_002
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the B_KTO_002Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("5bf679aa-b587-491f-b7c1-9eeb4a536bae")]
    public partial class B_KTO_002Repository : RepoGenBaseFolder
    {
        static B_KTO_002Repository instance = new B_KTO_002Repository();
        B_KTO_002RepositoryFolders.FrmKtoAppFolder _frmkto;
        B_KTO_002RepositoryFolders.FrmKto1AppFolder _frmkto1;
        B_KTO_002RepositoryFolders.DlgMessageBoxAppFolder _dlgmessagebox;
        B_KTO_002RepositoryFolders.List1000AppFolder _list1000;

        /// <summary>
        /// Gets the singleton class instance representing the B_KTO_002Repository element repository.
        /// </summary>
        [RepositoryFolder("5bf679aa-b587-491f-b7c1-9eeb4a536bae")]
        public static B_KTO_002Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public B_KTO_002Repository() 
            : base("B_KTO_002Repository", "/", null, 0, false, "5bf679aa-b587-491f-b7c1-9eeb4a536bae", ".\\RepositoryImages\\B_KTO_002Repository5bf679aa.rximgres")
        {
            _frmkto = new B_KTO_002RepositoryFolders.FrmKtoAppFolder(this);
            _frmkto1 = new B_KTO_002RepositoryFolders.FrmKto1AppFolder(this);
            _dlgmessagebox = new B_KTO_002RepositoryFolders.DlgMessageBoxAppFolder(this);
            _list1000 = new B_KTO_002RepositoryFolders.List1000AppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("5bf679aa-b587-491f-b7c1-9eeb4a536bae")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The FrmKto folder.
        /// </summary>
        [RepositoryFolder("cfa0f2d3-183c-4cc0-b07a-afb5a7822377")]
        public virtual B_KTO_002RepositoryFolders.FrmKtoAppFolder FrmKto
        {
            get { return _frmkto; }
        }

        /// <summary>
        /// The FrmKto1 folder.
        /// </summary>
        [RepositoryFolder("616e513d-94cd-4e43-a8fb-666f8c8aefff")]
        public virtual B_KTO_002RepositoryFolders.FrmKto1AppFolder FrmKto1
        {
            get { return _frmkto1; }
        }

        /// <summary>
        /// The DlgMessageBox folder.
        /// </summary>
        [RepositoryFolder("7931a3b2-af97-43c5-99e1-9c41a0c1dc2b")]
        public virtual B_KTO_002RepositoryFolders.DlgMessageBoxAppFolder DlgMessageBox
        {
            get { return _dlgmessagebox; }
        }

        /// <summary>
        /// The List1000 folder.
        /// </summary>
        [RepositoryFolder("fdfb261b-f2ea-4934-82ea-045ed84a7bb9")]
        public virtual B_KTO_002RepositoryFolders.List1000AppFolder List1000
        {
            get { return _list1000; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class B_KTO_002RepositoryFolders
    {
        /// <summary>
        /// The FrmKtoAppFolder folder.
        /// </summary>
        [RepositoryFolder("cfa0f2d3-183c-4cc0-b07a-afb5a7822377")]
        public partial class FrmKtoAppFolder : RepoGenBaseFolder
        {
            B_KTO_002RepositoryFolders.PicTabsFolder _pictabs;
            RepoItemInfo _titlebar100sachkontenverwaltenInfo;
            RepoItemInfo _textInfo;
            RepoItemInfo _row1column0Info;
            RepoItemInfo _verwendungInfo;
            RepoItemInfo _speichernInfo;
            RepoItemInfo _bezeichnungInfo;

            /// <summary>
            /// Creates a new FrmKto  folder.
            /// </summary>
            public FrmKtoAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FrmKto", "/form[@controlname='frmKto']", parentFolder, 30000, null, true, "cfa0f2d3-183c-4cc0-b07a-afb5a7822377", "")
            {
                _pictabs = new B_KTO_002RepositoryFolders.PicTabsFolder(this);
                _titlebar100sachkontenverwaltenInfo = new RepoItemInfo(this, "TitleBar100SachkontenVerwalten", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "a901c716-e16c-46ea-8807-103f9b2a8a00");
                _textInfo = new RepoItemInfo(this, "Text", "container[@controlname='searchContainer']/form[@controlname='frmSearchPage']/?/?/container[@controlname='SearchGroup1']//text[@accessiblerole='Text']", "", 30000, null, "b2deb94a-433b-4077-a8b2-eaf09e0ce17f");
                _row1column0Info = new RepoItemInfo(this, "Row1Column0", "container[@controlname='searchContainer']/form[@controlname='frmSearchPage']//table[@accessiblename='FlexGrid']/row[@accessiblename='Row 1']/cell[@accessiblename='Row 1 Column 0']", "", 30000, null, "c4842c8c-a8c6-4140-8c43-2c20a20feaa6");
                _verwendungInfo = new RepoItemInfo(this, "Verwendung", "?/?/tabpagelist[@controlname='picTabs']/tabpage[@controlname='tpAllgemein']/?/?/text[@accessiblename='Verwendung']", "", 30000, null, "cb14c805-44f3-43e7-bc7d-6158b7370b92");
                _speichernInfo = new RepoItemInfo(this, "Speichern", "container[@controlname='RibbonBar']/?/?/button[@controlname='pbDataAccess_Save']", "", 30000, null, "095f5e09-8cf1-4808-bf36-1cde418f4e66");
                _bezeichnungInfo = new RepoItemInfo(this, "Bezeichnung", "container[@controlname='ClientArea']/?/?/text[@accessiblename='Bezeichnung']", "", 30000, null, "b073f6c6-73db-4adc-a29c-73ffbc78b961");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("cfa0f2d3-183c-4cc0-b07a-afb5a7822377")]
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
            [RepositoryItemInfo("cfa0f2d3-183c-4cc0-b07a-afb5a7822377")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar100SachkontenVerwalten item.
            /// </summary>
            [RepositoryItem("a901c716-e16c-46ea-8807-103f9b2a8a00")]
            public virtual Ranorex.TitleBar TitleBar100SachkontenVerwalten
            {
                get
                {
                    return _titlebar100sachkontenverwaltenInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100SachkontenVerwalten item info.
            /// </summary>
            [RepositoryItemInfo("a901c716-e16c-46ea-8807-103f9b2a8a00")]
            public virtual RepoItemInfo TitleBar100SachkontenVerwaltenInfo
            {
                get
                {
                    return _titlebar100sachkontenverwaltenInfo;
                }
            }

            /// <summary>
            /// The Text item.
            /// </summary>
            [RepositoryItem("b2deb94a-433b-4077-a8b2-eaf09e0ce17f")]
            public virtual Ranorex.Text Text
            {
                get
                {
                    return _textInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text item info.
            /// </summary>
            [RepositoryItemInfo("b2deb94a-433b-4077-a8b2-eaf09e0ce17f")]
            public virtual RepoItemInfo TextInfo
            {
                get
                {
                    return _textInfo;
                }
            }

            /// <summary>
            /// The Row1Column0 item.
            /// </summary>
            [RepositoryItem("c4842c8c-a8c6-4140-8c43-2c20a20feaa6")]
            public virtual Ranorex.Cell Row1Column0
            {
                get
                {
                    return _row1column0Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Row1Column0 item info.
            /// </summary>
            [RepositoryItemInfo("c4842c8c-a8c6-4140-8c43-2c20a20feaa6")]
            public virtual RepoItemInfo Row1Column0Info
            {
                get
                {
                    return _row1column0Info;
                }
            }

            /// <summary>
            /// The Verwendung item.
            /// </summary>
            [RepositoryItem("cb14c805-44f3-43e7-bc7d-6158b7370b92")]
            public virtual Ranorex.Text Verwendung
            {
                get
                {
                    return _verwendungInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Verwendung item info.
            /// </summary>
            [RepositoryItemInfo("cb14c805-44f3-43e7-bc7d-6158b7370b92")]
            public virtual RepoItemInfo VerwendungInfo
            {
                get
                {
                    return _verwendungInfo;
                }
            }

            /// <summary>
            /// The Speichern item.
            /// </summary>
            [RepositoryItem("095f5e09-8cf1-4808-bf36-1cde418f4e66")]
            public virtual Ranorex.Button Speichern
            {
                get
                {
                    return _speichernInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Speichern item info.
            /// </summary>
            [RepositoryItemInfo("095f5e09-8cf1-4808-bf36-1cde418f4e66")]
            public virtual RepoItemInfo SpeichernInfo
            {
                get
                {
                    return _speichernInfo;
                }
            }

            /// <summary>
            /// The Bezeichnung item.
            /// </summary>
            [RepositoryItem("b073f6c6-73db-4adc-a29c-73ffbc78b961")]
            public virtual Ranorex.Text Bezeichnung
            {
                get
                {
                    return _bezeichnungInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Bezeichnung item info.
            /// </summary>
            [RepositoryItemInfo("b073f6c6-73db-4adc-a29c-73ffbc78b961")]
            public virtual RepoItemInfo BezeichnungInfo
            {
                get
                {
                    return _bezeichnungInfo;
                }
            }

            /// <summary>
            /// The PicTabs folder.
            /// </summary>
            [RepositoryFolder("7fb4e80a-3302-48c4-80a1-374afca44eda")]
            public virtual B_KTO_002RepositoryFolders.PicTabsFolder PicTabs
            {
                get { return _pictabs; }
            }
        }

        /// <summary>
        /// The PicTabsFolder folder.
        /// </summary>
        [RepositoryFolder("7fb4e80a-3302-48c4-80a1-374afca44eda")]
        public partial class PicTabsFolder : RepoGenBaseFolder
        {
            RepoItemInfo _tabpagegruppenInfo;
            RepoItemInfo _gruppeInfo;
            RepoItemInfo _gruppe_guvInfo;
            RepoItemInfo _bereicheInfo;
            RepoItemInfo _kostenstelleInfo;
            RepoItemInfo _kostentraegerInfo;
            RepoItemInfo _tabpageallgemeinInfo;

            /// <summary>
            /// Creates a new PicTabs  folder.
            /// </summary>
            public PicTabsFolder(RepoGenBaseFolder parentFolder) :
                    base("PicTabs", "?/?/tabpagelist[@controlname='picTabs']", parentFolder, 30000, null, false, "7fb4e80a-3302-48c4-80a1-374afca44eda", "")
            {
                _tabpagegruppenInfo = new RepoItemInfo(this, "TabPageGruppen", "tabpage[@accessiblename='&Gruppen']", "", 30000, null, "a99a89dc-1e9a-413f-a6a4-6f69097ba6a9");
                _gruppeInfo = new RepoItemInfo(this, "Gruppe", "tabpage[@controlname='tpGruppen']//table[@accessiblename='FlexGrid']/?/?/cell[@accessiblename='colKtgr_cd Row 1']", "", 30000, null, "a30797b1-a204-4f01-bb29-4db9f9fca290");
                _gruppe_guvInfo = new RepoItemInfo(this, "Gruppe_GuV", "tabpage[@controlname='tpGruppen']//table[@accessiblename='FlexGrid']/?/?/cell[@accessiblename='colKtgr_cd Row 2']", "", 30000, null, "8dd82ab8-8b18-4219-baec-f9c47cb63080");
                _bereicheInfo = new RepoItemInfo(this, "Bereiche", "tabpage[@accessiblename='Be&reiche']", "", 30000, null, "e5f5db34-6dd4-4a8e-8ede-19826aa74f6e");
                _kostenstelleInfo = new RepoItemInfo(this, "Kostenstelle", "tabpage[@controlname='tpBereiche']//table[@accessiblename='FlexGrid']/?/?/cell[@accessiblename='colKtbz_kz Row 1']", "", 30000, null, "6d16c3e2-fe4e-45fa-bc00-bcde0857eacc");
                _kostentraegerInfo = new RepoItemInfo(this, "Kostentraeger", "tabpage[@controlname='tpBereiche']//table[@accessiblename='FlexGrid']/?/?/cell[@accessiblename='colKtbz_kz Row 3']", "", 30000, null, "9b3e66e5-2b92-4fc5-aa14-8be3bf79e665");
                _tabpageallgemeinInfo = new RepoItemInfo(this, "TabPageAllgemein", "tabpage[@accessiblename='&Allgemein']", "", 30000, null, "2ac493a9-e83c-4087-9d8c-2e1c5e249125");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("7fb4e80a-3302-48c4-80a1-374afca44eda")]
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
            [RepositoryItemInfo("7fb4e80a-3302-48c4-80a1-374afca44eda")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TabPageGruppen item.
            /// </summary>
            [RepositoryItem("a99a89dc-1e9a-413f-a6a4-6f69097ba6a9")]
            public virtual Ranorex.TabPage TabPageGruppen
            {
                get
                {
                    return _tabpagegruppenInfo.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The TabPageGruppen item info.
            /// </summary>
            [RepositoryItemInfo("a99a89dc-1e9a-413f-a6a4-6f69097ba6a9")]
            public virtual RepoItemInfo TabPageGruppenInfo
            {
                get
                {
                    return _tabpagegruppenInfo;
                }
            }

            /// <summary>
            /// The Gruppe item.
            /// </summary>
            [RepositoryItem("a30797b1-a204-4f01-bb29-4db9f9fca290")]
            public virtual Ranorex.Cell Gruppe
            {
                get
                {
                    return _gruppeInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Gruppe item info.
            /// </summary>
            [RepositoryItemInfo("a30797b1-a204-4f01-bb29-4db9f9fca290")]
            public virtual RepoItemInfo GruppeInfo
            {
                get
                {
                    return _gruppeInfo;
                }
            }

            /// <summary>
            /// The Gruppe_GuV item.
            /// </summary>
            [RepositoryItem("8dd82ab8-8b18-4219-baec-f9c47cb63080")]
            public virtual Ranorex.Cell Gruppe_GuV
            {
                get
                {
                    return _gruppe_guvInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Gruppe_GuV item info.
            /// </summary>
            [RepositoryItemInfo("8dd82ab8-8b18-4219-baec-f9c47cb63080")]
            public virtual RepoItemInfo Gruppe_GuVInfo
            {
                get
                {
                    return _gruppe_guvInfo;
                }
            }

            /// <summary>
            /// The Bereiche item.
            /// </summary>
            [RepositoryItem("e5f5db34-6dd4-4a8e-8ede-19826aa74f6e")]
            public virtual Ranorex.TabPage Bereiche
            {
                get
                {
                    return _bereicheInfo.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The Bereiche item info.
            /// </summary>
            [RepositoryItemInfo("e5f5db34-6dd4-4a8e-8ede-19826aa74f6e")]
            public virtual RepoItemInfo BereicheInfo
            {
                get
                {
                    return _bereicheInfo;
                }
            }

            /// <summary>
            /// The Kostenstelle item.
            /// </summary>
            [RepositoryItem("6d16c3e2-fe4e-45fa-bc00-bcde0857eacc")]
            public virtual Ranorex.Cell Kostenstelle
            {
                get
                {
                    return _kostenstelleInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Kostenstelle item info.
            /// </summary>
            [RepositoryItemInfo("6d16c3e2-fe4e-45fa-bc00-bcde0857eacc")]
            public virtual RepoItemInfo KostenstelleInfo
            {
                get
                {
                    return _kostenstelleInfo;
                }
            }

            /// <summary>
            /// The Kostentraeger item.
            /// </summary>
            [RepositoryItem("9b3e66e5-2b92-4fc5-aa14-8be3bf79e665")]
            public virtual Ranorex.Cell Kostentraeger
            {
                get
                {
                    return _kostentraegerInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Kostentraeger item info.
            /// </summary>
            [RepositoryItemInfo("9b3e66e5-2b92-4fc5-aa14-8be3bf79e665")]
            public virtual RepoItemInfo KostentraegerInfo
            {
                get
                {
                    return _kostentraegerInfo;
                }
            }

            /// <summary>
            /// The TabPageAllgemein item.
            /// </summary>
            [RepositoryItem("2ac493a9-e83c-4087-9d8c-2e1c5e249125")]
            public virtual Ranorex.TabPage TabPageAllgemein
            {
                get
                {
                    return _tabpageallgemeinInfo.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The TabPageAllgemein item info.
            /// </summary>
            [RepositoryItemInfo("2ac493a9-e83c-4087-9d8c-2e1c5e249125")]
            public virtual RepoItemInfo TabPageAllgemeinInfo
            {
                get
                {
                    return _tabpageallgemeinInfo;
                }
            }
        }

        /// <summary>
        /// The FrmKto1AppFolder folder.
        /// </summary>
        [RepositoryFolder("616e513d-94cd-4e43-a8fb-666f8c8aefff")]
        public partial class FrmKto1AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _pbcommonstatusInfo;
            RepoItemInfo _oeffnenInfo;
            RepoItemInfo _kontostatusInfo;

            /// <summary>
            /// Creates a new FrmKto1  folder.
            /// </summary>
            public FrmKto1AppFolder(RepoGenBaseFolder parentFolder) :
                    base("FrmKto1", "/form[@controltypename='frmKto']", parentFolder, 30000, null, true, "616e513d-94cd-4e43-a8fb-666f8c8aefff", "")
            {
                _pbcommonstatusInfo = new RepoItemInfo(this, "PbCommonStatus", "?/?/container[@controlname='CommonGroup']/button[@controlname='pbCommon_Status']", "", 30000, null, "51781977-892c-427c-9e80-6a367fa5f29b");
                _oeffnenInfo = new RepoItemInfo(this, "OEffnen", "?/?/combobox[@controlname='cmbKto_status']/button[@accessiblename='Öffnen']", "", 30000, null, "a36f4b61-9556-49ab-89f1-0e2d864506fc");
                _kontostatusInfo = new RepoItemInfo(this, "Kontostatus", "?/?/combobox[@controlname='cmbKto_status']/text[@controlid='1001']", "", 30000, null, "799d640a-10bc-48fe-b455-339f71827da1");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("616e513d-94cd-4e43-a8fb-666f8c8aefff")]
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
            [RepositoryItemInfo("616e513d-94cd-4e43-a8fb-666f8c8aefff")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The PbCommonStatus item.
            /// </summary>
            [RepositoryItem("51781977-892c-427c-9e80-6a367fa5f29b")]
            public virtual Ranorex.Button PbCommonStatus
            {
                get
                {
                    return _pbcommonstatusInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbCommonStatus item info.
            /// </summary>
            [RepositoryItemInfo("51781977-892c-427c-9e80-6a367fa5f29b")]
            public virtual RepoItemInfo PbCommonStatusInfo
            {
                get
                {
                    return _pbcommonstatusInfo;
                }
            }

            /// <summary>
            /// The OEffnen item.
            /// </summary>
            [RepositoryItem("a36f4b61-9556-49ab-89f1-0e2d864506fc")]
            public virtual Ranorex.Button OEffnen
            {
                get
                {
                    return _oeffnenInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The OEffnen item info.
            /// </summary>
            [RepositoryItemInfo("a36f4b61-9556-49ab-89f1-0e2d864506fc")]
            public virtual RepoItemInfo OEffnenInfo
            {
                get
                {
                    return _oeffnenInfo;
                }
            }

            /// <summary>
            /// The Kontostatus item.
            /// </summary>
            [RepositoryItem("799d640a-10bc-48fe-b455-339f71827da1")]
            public virtual Ranorex.Text Kontostatus
            {
                get
                {
                    return _kontostatusInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Kontostatus item info.
            /// </summary>
            [RepositoryItemInfo("799d640a-10bc-48fe-b455-339f71827da1")]
            public virtual RepoItemInfo KontostatusInfo
            {
                get
                {
                    return _kontostatusInfo;
                }
            }
        }

        /// <summary>
        /// The DlgMessageBoxAppFolder folder.
        /// </summary>
        [RepositoryFolder("7931a3b2-af97-43c5-99e1-9c41a0c1dc2b")]
        public partial class DlgMessageBoxAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _meldungstextInfo;
            RepoItemInfo _button0Info;

            /// <summary>
            /// Creates a new DlgMessageBox  folder.
            /// </summary>
            public DlgMessageBoxAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DlgMessageBox", "/form[@controlname='dlgMessageBox']", parentFolder, 30000, null, true, "7931a3b2-af97-43c5-99e1-9c41a0c1dc2b", "")
            {
                _meldungstextInfo = new RepoItemInfo(this, "Meldungstext", "text[@controlname='labelMeldungstext']", "", 30000, null, "08131370-b9e7-4b56-bca3-3beba7227077");
                _button0Info = new RepoItemInfo(this, "Button0", "button[@controlname='button0']", "", 30000, null, "7188eae2-7df6-4961-93af-9aeaa0cdbb92");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("7931a3b2-af97-43c5-99e1-9c41a0c1dc2b")]
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
            [RepositoryItemInfo("7931a3b2-af97-43c5-99e1-9c41a0c1dc2b")]
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
            [RepositoryItem("08131370-b9e7-4b56-bca3-3beba7227077")]
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
            [RepositoryItemInfo("08131370-b9e7-4b56-bca3-3beba7227077")]
            public virtual RepoItemInfo MeldungstextInfo
            {
                get
                {
                    return _meldungstextInfo;
                }
            }

            /// <summary>
            /// The Button0 item.
            /// </summary>
            [RepositoryItem("7188eae2-7df6-4961-93af-9aeaa0cdbb92")]
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
            [RepositoryItemInfo("7188eae2-7df6-4961-93af-9aeaa0cdbb92")]
            public virtual RepoItemInfo Button0Info
            {
                get
                {
                    return _button0Info;
                }
            }
        }

        /// <summary>
        /// The List1000AppFolder folder.
        /// </summary>
        [RepositoryFolder("fdfb261b-f2ea-4934-82ea-045ed84a7bb9")]
        public partial class List1000AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _inaktivInfo;

            /// <summary>
            /// Creates a new List1000  folder.
            /// </summary>
            public List1000AppFolder(RepoGenBaseFolder parentFolder) :
                    base("List1000", "/list[@controlid='1000']", parentFolder, 30000, null, true, "fdfb261b-f2ea-4934-82ea-045ed84a7bb9", "")
            {
                _inaktivInfo = new RepoItemInfo(this, "Inaktiv", "listitem[@text='inaktiv']", "", 30000, null, "186bb8f0-a614-4da6-be4b-76ae3438217d");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("fdfb261b-f2ea-4934-82ea-045ed84a7bb9")]
            public virtual Ranorex.List Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.List>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("fdfb261b-f2ea-4934-82ea-045ed84a7bb9")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Inaktiv item.
            /// </summary>
            [RepositoryItem("186bb8f0-a614-4da6-be4b-76ae3438217d")]
            public virtual Ranorex.ListItem Inaktiv
            {
                get
                {
                    return _inaktivInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The Inaktiv item info.
            /// </summary>
            [RepositoryItemInfo("186bb8f0-a614-4da6-be4b-76ae3438217d")]
            public virtual RepoItemInfo InaktivInfo
            {
                get
                {
                    return _inaktivInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
