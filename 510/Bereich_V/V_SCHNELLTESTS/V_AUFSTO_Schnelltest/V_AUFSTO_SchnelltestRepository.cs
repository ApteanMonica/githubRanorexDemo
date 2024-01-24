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

namespace V_AUFSTO_Schnelltest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the V_AUFSTO_SchnelltestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("de87bfab-bcdc-4ba5-8605-c53a92b51d0b")]
    public partial class V_AUFSTO_SchnelltestRepository : RepoGenBaseFolder
    {
        static V_AUFSTO_SchnelltestRepository instance = new V_AUFSTO_SchnelltestRepository();
        V_AUFSTO_SchnelltestRepositoryFolders.FrmKLRAppFolder _frmklr;
        V_AUFSTO_SchnelltestRepositoryFolders.FrmKLR1AppFolder _frmklr1;
        V_AUFSTO_SchnelltestRepositoryFolders.ExplorerAppFolder _explorer;
        V_AUFSTO_SchnelltestRepositoryFolders.DlgMessageBoxAppFolder _dlgmessagebox;
        V_AUFSTO_SchnelltestRepositoryFolders.VAUFSTOAppFolder _vaufsto;
        V_AUFSTO_SchnelltestRepositoryFolders.TblAuftragAppFolder _tblauftrag;

        /// <summary>
        /// Gets the singleton class instance representing the V_AUFSTO_SchnelltestRepository element repository.
        /// </summary>
        [RepositoryFolder("de87bfab-bcdc-4ba5-8605-c53a92b51d0b")]
        public static V_AUFSTO_SchnelltestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public V_AUFSTO_SchnelltestRepository() 
            : base("V_AUFSTO_SchnelltestRepository", "/", null, 0, false, "de87bfab-bcdc-4ba5-8605-c53a92b51d0b", ".\\RepositoryImages\\V_AUFSTO_SchnelltestRepositoryde87bfab.rximgres")
        {
            _frmklr = new V_AUFSTO_SchnelltestRepositoryFolders.FrmKLRAppFolder(this);
            _frmklr1 = new V_AUFSTO_SchnelltestRepositoryFolders.FrmKLR1AppFolder(this);
            _explorer = new V_AUFSTO_SchnelltestRepositoryFolders.ExplorerAppFolder(this);
            _dlgmessagebox = new V_AUFSTO_SchnelltestRepositoryFolders.DlgMessageBoxAppFolder(this);
            _vaufsto = new V_AUFSTO_SchnelltestRepositoryFolders.VAUFSTOAppFolder(this);
            _tblauftrag = new V_AUFSTO_SchnelltestRepositoryFolders.TblAuftragAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("de87bfab-bcdc-4ba5-8605-c53a92b51d0b")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The FrmKLR folder.
        /// </summary>
        [RepositoryFolder("ecd76d1e-18d8-413d-b997-e937b36e43ec")]
        public virtual V_AUFSTO_SchnelltestRepositoryFolders.FrmKLRAppFolder FrmKLR
        {
            get { return _frmklr; }
        }

        /// <summary>
        /// The FrmKLR1 folder.
        /// </summary>
        [RepositoryFolder("fea9e574-e582-498f-8e4e-95429f53e303")]
        public virtual V_AUFSTO_SchnelltestRepositoryFolders.FrmKLR1AppFolder FrmKLR1
        {
            get { return _frmklr1; }
        }

        /// <summary>
        /// The Explorer folder.
        /// </summary>
        [RepositoryFolder("cb7f4733-61c4-415d-9023-69c8997ae0ce")]
        public virtual V_AUFSTO_SchnelltestRepositoryFolders.ExplorerAppFolder Explorer
        {
            get { return _explorer; }
        }

        /// <summary>
        /// The DlgMessageBox folder.
        /// </summary>
        [RepositoryFolder("17b9049f-be7e-4a50-b50d-d8f5b52d7419")]
        public virtual V_AUFSTO_SchnelltestRepositoryFolders.DlgMessageBoxAppFolder DlgMessageBox
        {
            get { return _dlgmessagebox; }
        }

        /// <summary>
        /// The VAUFSTO folder.
        /// </summary>
        [RepositoryFolder("aa988b7c-6dc2-4d71-85c6-3cb1893aee59")]
        public virtual V_AUFSTO_SchnelltestRepositoryFolders.VAUFSTOAppFolder VAUFSTO
        {
            get { return _vaufsto; }
        }

        /// <summary>
        /// The TblAuftrag folder.
        /// </summary>
        [RepositoryFolder("c6b073e3-b275-4d77-83a4-b242daa67088")]
        public virtual V_AUFSTO_SchnelltestRepositoryFolders.TblAuftragAppFolder TblAuftrag
        {
            get { return _tblauftrag; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class V_AUFSTO_SchnelltestRepositoryFolders
    {
        /// <summary>
        /// The FrmKLRAppFolder folder.
        /// </summary>
        [RepositoryFolder("ecd76d1e-18d8-413d-b997-e937b36e43ec")]
        public partial class FrmKLRAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _titlebar100stornovonkoscheinrueInfo;
            RepoItemInfo _pbcommon2stornierenInfo;
            RepoItemInfo _dfkmsknrInfo;
            RepoItemInfo _pbmdiauftragstornoInfo;

            /// <summary>
            /// Creates a new FrmKLR  folder.
            /// </summary>
            public FrmKLRAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FrmKLR", "/form[@controlname='frmKLR']", parentFolder, 30000, null, true, "ecd76d1e-18d8-413d-b997-e937b36e43ec", "")
            {
                _titlebar100stornovonkoscheinrueInfo = new RepoItemInfo(this, "TitleBar100StornoVonKoscheinRue", "titlebar[@accessiblerole='TitleBar']", "titlebar[@accessiblerole='TitleBar']", 30000, null, "54becf67-e715-49dc-bbc2-030b06fa395e");
                _pbcommon2stornierenInfo = new RepoItemInfo(this, "PbCommon2Stornieren", "?/?/container[@controlname='Common2Group']/button[@controlname='pbCommon2_Stornieren']", ".//button[@controlname='pbCommon2_Stornieren']", 30000, null, "3135f26b-9dae-466f-8aac-1ab5cd8a1762");
                _dfkmsknrInfo = new RepoItemInfo(this, "DfKmskNr", "?/?/text[@controlname='dfKmsk_nr']", "?/?/text[@controlname='dfKmsk_nr']", 30000, null, "16a38a32-44b2-4abf-bbf1-6db72539d6c3");
                _pbmdiauftragstornoInfo = new RepoItemInfo(this, "PbMDIAuftragstorno", "?/?/container[@controlname='MDIGroup']/button[@controlname='pbMDI_Auftragstorno']", ".//button[@controlname='pbMDI_Auftragstorno']", 30000, null, "15bdf4d0-7bb2-4820-ae5b-073e9b9d9911");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("ecd76d1e-18d8-413d-b997-e937b36e43ec")]
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
            [RepositoryItemInfo("ecd76d1e-18d8-413d-b997-e937b36e43ec")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar100StornoVonKoscheinRue item.
            /// </summary>
            [RepositoryItem("54becf67-e715-49dc-bbc2-030b06fa395e")]
            public virtual Ranorex.TitleBar TitleBar100StornoVonKoscheinRue
            {
                get
                {
                    return _titlebar100stornovonkoscheinrueInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100StornoVonKoscheinRue item info.
            /// </summary>
            [RepositoryItemInfo("54becf67-e715-49dc-bbc2-030b06fa395e")]
            public virtual RepoItemInfo TitleBar100StornoVonKoscheinRueInfo
            {
                get
                {
                    return _titlebar100stornovonkoscheinrueInfo;
                }
            }

            /// <summary>
            /// The PbCommon2Stornieren item.
            /// </summary>
            [RepositoryItem("3135f26b-9dae-466f-8aac-1ab5cd8a1762")]
            public virtual Ranorex.Button PbCommon2Stornieren
            {
                get
                {
                    return _pbcommon2stornierenInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbCommon2Stornieren item info.
            /// </summary>
            [RepositoryItemInfo("3135f26b-9dae-466f-8aac-1ab5cd8a1762")]
            public virtual RepoItemInfo PbCommon2StornierenInfo
            {
                get
                {
                    return _pbcommon2stornierenInfo;
                }
            }

            /// <summary>
            /// The DfKmskNr item.
            /// </summary>
            [RepositoryItem("16a38a32-44b2-4abf-bbf1-6db72539d6c3")]
            public virtual Ranorex.Text DfKmskNr
            {
                get
                {
                    return _dfkmsknrInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The DfKmskNr item info.
            /// </summary>
            [RepositoryItemInfo("16a38a32-44b2-4abf-bbf1-6db72539d6c3")]
            public virtual RepoItemInfo DfKmskNrInfo
            {
                get
                {
                    return _dfkmsknrInfo;
                }
            }

            /// <summary>
            /// The PbMDIAuftragstorno item.
            /// </summary>
            [RepositoryItem("15bdf4d0-7bb2-4820-ae5b-073e9b9d9911")]
            public virtual Ranorex.Button PbMDIAuftragstorno
            {
                get
                {
                    return _pbmdiauftragstornoInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbMDIAuftragstorno item info.
            /// </summary>
            [RepositoryItemInfo("15bdf4d0-7bb2-4820-ae5b-073e9b9d9911")]
            public virtual RepoItemInfo PbMDIAuftragstornoInfo
            {
                get
                {
                    return _pbmdiauftragstornoInfo;
                }
            }
        }

        /// <summary>
        /// The FrmKLR1AppFolder folder.
        /// </summary>
        [RepositoryFolder("fea9e574-e582-498f-8e4e-95429f53e303")]
        public partial class FrmKLR1AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _kommissionsscheinInfo;

            /// <summary>
            /// Creates a new FrmKLR1  folder.
            /// </summary>
            public FrmKLR1AppFolder(RepoGenBaseFolder parentFolder) :
                    base("FrmKLR1", "/form[@controltypename='frmKLR']", parentFolder, 30000, null, true, "fea9e574-e582-498f-8e4e-95429f53e303", "")
            {
                _kommissionsscheinInfo = new RepoItemInfo(this, "Kommissionsschein", "container/?/?/text", ".//text", 30000, null, "9ec5124c-b007-479d-afff-ea695c0c151b");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("fea9e574-e582-498f-8e4e-95429f53e303")]
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
            [RepositoryItemInfo("fea9e574-e582-498f-8e4e-95429f53e303")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Kommissionsschein item.
            /// </summary>
            [RepositoryItem("9ec5124c-b007-479d-afff-ea695c0c151b")]
            public virtual Ranorex.Text Kommissionsschein
            {
                get
                {
                    return _kommissionsscheinInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Kommissionsschein item info.
            /// </summary>
            [RepositoryItemInfo("9ec5124c-b007-479d-afff-ea695c0c151b")]
            public virtual RepoItemInfo KommissionsscheinInfo
            {
                get
                {
                    return _kommissionsscheinInfo;
                }
            }
        }

        /// <summary>
        /// The ExplorerAppFolder folder.
        /// </summary>
        [RepositoryFolder("cb7f4733-61c4-415d-9023-69c8997ae0ce")]
        public partial class ExplorerAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _list1Info;

            /// <summary>
            /// Creates a new Explorer  folder.
            /// </summary>
            public ExplorerAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Explorer", "/form[@title='']", parentFolder, 30000, null, true, "cb7f4733-61c4-415d-9023-69c8997ae0ce", "")
            {
                _list1Info = new RepoItemInfo(this, "List1", "?/?/list[@controlid='1']", "?/?/list[@controlid='1']", 30000, null, "f72df998-bf61-4bf8-a40e-f0052626b2f7");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("cb7f4733-61c4-415d-9023-69c8997ae0ce")]
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
            [RepositoryItemInfo("cb7f4733-61c4-415d-9023-69c8997ae0ce")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The List1 item.
            /// </summary>
            [RepositoryItem("f72df998-bf61-4bf8-a40e-f0052626b2f7")]
            public virtual Ranorex.List List1
            {
                get
                {
                    return _list1Info.CreateAdapter<Ranorex.List>(true);
                }
            }

            /// <summary>
            /// The List1 item info.
            /// </summary>
            [RepositoryItemInfo("f72df998-bf61-4bf8-a40e-f0052626b2f7")]
            public virtual RepoItemInfo List1Info
            {
                get
                {
                    return _list1Info;
                }
            }
        }

        /// <summary>
        /// The DlgMessageBoxAppFolder folder.
        /// </summary>
        [RepositoryFolder("17b9049f-be7e-4a50-b50d-d8f5b52d7419")]
        public partial class DlgMessageBoxAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new DlgMessageBox  folder.
            /// </summary>
            public DlgMessageBoxAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DlgMessageBox", "/form[@controlname='dlgMessageBox']", parentFolder, 30000, null, true, "17b9049f-be7e-4a50-b50d-d8f5b52d7419", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("17b9049f-be7e-4a50-b50d-d8f5b52d7419")]
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
            [RepositoryItemInfo("17b9049f-be7e-4a50-b50d-d8f5b52d7419")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

        /// <summary>
        /// The VAUFSTOAppFolder folder.
        /// </summary>
        [RepositoryFolder("aa988b7c-6dc2-4d71-85c6-3cb1893aee59")]
        public partial class VAUFSTOAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _dropdownInfo;

            /// <summary>
            /// Creates a new VAUFSTO  folder.
            /// </summary>
            public VAUFSTOAppFolder(RepoGenBaseFolder parentFolder) :
                    base("VAUFSTO", "/toolbar", parentFolder, 30000, null, true, "aa988b7c-6dc2-4d71-85c6-3cb1893aee59", "")
            {
                _dropdownInfo = new RepoItemInfo(this, "DropDown", "contextmenu[@accessiblename='DropDown']", "contextmenu[@accessiblename='DropDown']", 30000, null, "8d7a2d10-d203-4d86-8e41-674532f5c57b");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("aa988b7c-6dc2-4d71-85c6-3cb1893aee59")]
            public virtual Ranorex.ToolBar Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ToolBar>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("aa988b7c-6dc2-4d71-85c6-3cb1893aee59")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The DropDown item.
            /// </summary>
            [RepositoryItem("8d7a2d10-d203-4d86-8e41-674532f5c57b")]
            public virtual Ranorex.ContextMenu DropDown
            {
                get
                {
                    return _dropdownInfo.CreateAdapter<Ranorex.ContextMenu>(true);
                }
            }

            /// <summary>
            /// The DropDown item info.
            /// </summary>
            [RepositoryItemInfo("8d7a2d10-d203-4d86-8e41-674532f5c57b")]
            public virtual RepoItemInfo DropDownInfo
            {
                get
                {
                    return _dropdownInfo;
                }
            }
        }

        /// <summary>
        /// The TblAuftragAppFolder folder.
        /// </summary>
        [RepositoryFolder("c6b073e3-b275-4d77-83a4-b242daa67088")]
        public partial class TblAuftragAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _pbspec1alleInfo;
            RepoItemInfo _pbcommonloadInfo;
            RepoItemInfo _pbcommon2stornierenInfo;
            RepoItemInfo _spec1groupInfo;
            RepoItemInfo _titlebar100auftragsrueckstaendestorInfo;

            /// <summary>
            /// Creates a new TblAuftrag  folder.
            /// </summary>
            public TblAuftragAppFolder(RepoGenBaseFolder parentFolder) :
                    base("TblAuftrag", "/form[@controlname='tblAuftrag']", parentFolder, 30000, null, true, "c6b073e3-b275-4d77-83a4-b242daa67088", "")
            {
                _pbspec1alleInfo = new RepoItemInfo(this, "PbSpec1Alle", "container[@controlname='RibbonBar']/?/?/button[@controlname='pbSpec1_Alle']", ".//button[@controlname='pbSpec1_Alle']", 30000, null, "93ca27d2-623f-418b-a6eb-1860a175b917");
                _pbcommonloadInfo = new RepoItemInfo(this, "PbCommonLoad", "container[@controlname='RibbonBar']/?/?/button[@controlname='pbCommon_Load']", ".//button[@controlname='pbCommon_Load']", 30000, null, "2a256881-837d-4292-8c0d-f1f41f199f0b");
                _pbcommon2stornierenInfo = new RepoItemInfo(this, "PbCommon2Stornieren", "container[@controlname='RibbonBar']/?/?/button[@controlname='pbCommon2_Stornieren']", ".//button[@controlname='pbCommon2_Stornieren']", 30000, null, "6f228c05-a236-433f-8f20-4a26a543b53d");
                _spec1groupInfo = new RepoItemInfo(this, "Spec1Group", "?/?/container[@controlname='Spec1Group']", "?/?/container[@controlname='Spec1Group']", 30000, null, "91c43132-516a-479f-a339-bf61e9cc0412");
                _titlebar100auftragsrueckstaendestorInfo = new RepoItemInfo(this, "TitleBar100AuftragsrueckstaendeStor", "titlebar[@accessiblerole='TitleBar']", "titlebar[@accessiblerole='TitleBar']", 30000, null, "96fb6a68-fdfa-41f6-81d1-bf19c64149c8");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("c6b073e3-b275-4d77-83a4-b242daa67088")]
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
            [RepositoryItemInfo("c6b073e3-b275-4d77-83a4-b242daa67088")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The PbSpec1Alle item.
            /// </summary>
            [RepositoryItem("93ca27d2-623f-418b-a6eb-1860a175b917")]
            public virtual Ranorex.Button PbSpec1Alle
            {
                get
                {
                    return _pbspec1alleInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbSpec1Alle item info.
            /// </summary>
            [RepositoryItemInfo("93ca27d2-623f-418b-a6eb-1860a175b917")]
            public virtual RepoItemInfo PbSpec1AlleInfo
            {
                get
                {
                    return _pbspec1alleInfo;
                }
            }

            /// <summary>
            /// The PbCommonLoad item.
            /// </summary>
            [RepositoryItem("2a256881-837d-4292-8c0d-f1f41f199f0b")]
            public virtual Ranorex.Button PbCommonLoad
            {
                get
                {
                    return _pbcommonloadInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbCommonLoad item info.
            /// </summary>
            [RepositoryItemInfo("2a256881-837d-4292-8c0d-f1f41f199f0b")]
            public virtual RepoItemInfo PbCommonLoadInfo
            {
                get
                {
                    return _pbcommonloadInfo;
                }
            }

            /// <summary>
            /// The PbCommon2Stornieren item.
            /// </summary>
            [RepositoryItem("6f228c05-a236-433f-8f20-4a26a543b53d")]
            public virtual Ranorex.Button PbCommon2Stornieren
            {
                get
                {
                    return _pbcommon2stornierenInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbCommon2Stornieren item info.
            /// </summary>
            [RepositoryItemInfo("6f228c05-a236-433f-8f20-4a26a543b53d")]
            public virtual RepoItemInfo PbCommon2StornierenInfo
            {
                get
                {
                    return _pbcommon2stornierenInfo;
                }
            }

            /// <summary>
            /// The Spec1Group item.
            /// </summary>
            [RepositoryItem("91c43132-516a-479f-a339-bf61e9cc0412")]
            public virtual Ranorex.Container Spec1Group
            {
                get
                {
                    return _spec1groupInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Spec1Group item info.
            /// </summary>
            [RepositoryItemInfo("91c43132-516a-479f-a339-bf61e9cc0412")]
            public virtual RepoItemInfo Spec1GroupInfo
            {
                get
                {
                    return _spec1groupInfo;
                }
            }

            /// <summary>
            /// The TitleBar100AuftragsrueckstaendeStor item.
            /// </summary>
            [RepositoryItem("96fb6a68-fdfa-41f6-81d1-bf19c64149c8")]
            public virtual Ranorex.TitleBar TitleBar100AuftragsrueckstaendeStor
            {
                get
                {
                    return _titlebar100auftragsrueckstaendestorInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100AuftragsrueckstaendeStor item info.
            /// </summary>
            [RepositoryItemInfo("96fb6a68-fdfa-41f6-81d1-bf19c64149c8")]
            public virtual RepoItemInfo TitleBar100AuftragsrueckstaendeStorInfo
            {
                get
                {
                    return _titlebar100auftragsrueckstaendestorInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
