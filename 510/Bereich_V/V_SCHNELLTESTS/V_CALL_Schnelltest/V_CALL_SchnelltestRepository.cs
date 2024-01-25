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

namespace V_CALL_Schnelltest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the V_CALL_SchnelltestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("2e31bf54-50b0-4dd6-b50b-4dcb6edc9793")]
    public partial class V_CALL_SchnelltestRepository : RepoGenBaseFolder
    {
        static V_CALL_SchnelltestRepository instance = new V_CALL_SchnelltestRepository();
        V_CALL_SchnelltestRepositoryFolders.FrmCallAuftragAppFolder _frmcallauftrag;
        V_CALL_SchnelltestRepositoryFolders.DlgKldvAppFolder _dlgkldv;

        /// <summary>
        /// Gets the singleton class instance representing the V_CALL_SchnelltestRepository element repository.
        /// </summary>
        [RepositoryFolder("2e31bf54-50b0-4dd6-b50b-4dcb6edc9793")]
        public static V_CALL_SchnelltestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public V_CALL_SchnelltestRepository() 
            : base("V_CALL_SchnelltestRepository", "/", null, 0, false, "2e31bf54-50b0-4dd6-b50b-4dcb6edc9793", ".\\RepositoryImages\\V_CALL_SchnelltestRepository2e31bf54.rximgres")
        {
            _frmcallauftrag = new V_CALL_SchnelltestRepositoryFolders.FrmCallAuftragAppFolder(this);
            _dlgkldv = new V_CALL_SchnelltestRepositoryFolders.DlgKldvAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("2e31bf54-50b0-4dd6-b50b-4dcb6edc9793")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The FrmCallAuftrag folder.
        /// </summary>
        [RepositoryFolder("bd1421a0-6bc7-42f1-ac03-bc5692bf1cbb")]
        public virtual V_CALL_SchnelltestRepositoryFolders.FrmCallAuftragAppFolder FrmCallAuftrag
        {
            get { return _frmcallauftrag; }
        }

        /// <summary>
        /// The DlgKldv folder.
        /// </summary>
        [RepositoryFolder("e77ac386-0475-4e2c-967b-ea72269c3f62")]
        public virtual V_CALL_SchnelltestRepositoryFolders.DlgKldvAppFolder DlgKldv
        {
            get { return _dlgkldv; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class V_CALL_SchnelltestRepositoryFolders
    {
        /// <summary>
        /// The FrmCallAuftragAppFolder folder.
        /// </summary>
        [RepositoryFolder("bd1421a0-6bc7-42f1-ac03-bc5692bf1cbb")]
        public partial class FrmCallAuftragAppFolder : RepoGenBaseFolder
        {
            V_CALL_SchnelltestRepositoryFolders.TpKopfFolder _tpkopf;
            RepoItemInfo _titlebar100callauftragInfo;
            RepoItemInfo _pbnewInfo;

            /// <summary>
            /// Creates a new FrmCallAuftrag  folder.
            /// </summary>
            public FrmCallAuftragAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FrmCallAuftrag", "/form[@controlname='frmCallAuftrag']", parentFolder, 30000, null, true, "bd1421a0-6bc7-42f1-ac03-bc5692bf1cbb", "")
            {
                _tpkopf = new V_CALL_SchnelltestRepositoryFolders.TpKopfFolder(this);
                _titlebar100callauftragInfo = new RepoItemInfo(this, "TitleBar100CallAuftrag", "titlebar[@accessiblerole='TitleBar']", "titlebar[@accessiblerole='TitleBar']", 30000, null, "99952c0d-ed3a-4d70-a505-c1e211914830");
                _pbnewInfo = new RepoItemInfo(this, "PbNew", "?/?/form[@controlname='frmSearchPage']/?/?/container[@controlname='SearchGroup2']/button[@controlname='pbNew']", ".//button[@controlname='pbNew']", 30000, null, "4529a7a6-1539-415c-8c21-f8f8433cdf69");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("bd1421a0-6bc7-42f1-ac03-bc5692bf1cbb")]
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
            [RepositoryItemInfo("bd1421a0-6bc7-42f1-ac03-bc5692bf1cbb")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar100CallAuftrag item.
            /// </summary>
            [RepositoryItem("99952c0d-ed3a-4d70-a505-c1e211914830")]
            public virtual Ranorex.TitleBar TitleBar100CallAuftrag
            {
                get
                {
                    return _titlebar100callauftragInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100CallAuftrag item info.
            /// </summary>
            [RepositoryItemInfo("99952c0d-ed3a-4d70-a505-c1e211914830")]
            public virtual RepoItemInfo TitleBar100CallAuftragInfo
            {
                get
                {
                    return _titlebar100callauftragInfo;
                }
            }

            /// <summary>
            /// The PbNew item.
            /// </summary>
            [RepositoryItem("4529a7a6-1539-415c-8c21-f8f8433cdf69")]
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
            [RepositoryItemInfo("4529a7a6-1539-415c-8c21-f8f8433cdf69")]
            public virtual RepoItemInfo PbNewInfo
            {
                get
                {
                    return _pbnewInfo;
                }
            }

            /// <summary>
            /// The TpKopf folder.
            /// </summary>
            [RepositoryFolder("d2979397-dfc7-44cd-ae0d-cb6a51d6c7d8")]
            public virtual V_CALL_SchnelltestRepositoryFolders.TpKopfFolder TpKopf
            {
                get { return _tpkopf; }
            }
        }

        /// <summary>
        /// The TpKopfFolder folder.
        /// </summary>
        [RepositoryFolder("d2979397-dfc7-44cd-ae0d-cb6a51d6c7d8")]
        public partial class TpKopfFolder : RepoGenBaseFolder
        {
            RepoItemInfo _dfadrnrInfo;
            RepoItemInfo _dfadrnrwareInfo;
            RepoItemInfo _dfcaacdInfo;
            RepoItemInfo _dflagnrInfo;
            RepoItemInfo _mlcaktextfehlerInfo;

            /// <summary>
            /// Creates a new TpKopf  folder.
            /// </summary>
            public TpKopfFolder(RepoGenBaseFolder parentFolder) :
                    base("TpKopf", ".//tabpage[@controlname='tpKopf']", parentFolder, 30000, null, false, "d2979397-dfc7-44cd-ae0d-cb6a51d6c7d8", "")
            {
                _dfadrnrInfo = new RepoItemInfo(this, "DfAdrNr", "text[@controlname='dfAdr_nr']", "", 30000, null, "f7fd5c76-8318-4624-917b-8e7b8c4d783d");
                _dfadrnrwareInfo = new RepoItemInfo(this, "DfAdrNrWare", "text[@controlname='dfAdr_nr_ware']", "", 30000, null, "3f0bbb01-2d39-487c-ac9c-1692e737a490");
                _dfcaacdInfo = new RepoItemInfo(this, "DfCaaCd", "text[@controlname='dfCaa_cd']", "", 30000, null, "f6eae65e-b03d-465f-b034-60dacd7c1ce7");
                _dflagnrInfo = new RepoItemInfo(this, "DfLagNr", "text[@controlname='dfLag_nr']", "", 30000, null, "9c547078-5721-41dc-8c7d-f0e8e6dae639");
                _mlcaktextfehlerInfo = new RepoItemInfo(this, "MlCakTextfehler", "container[@controlname='mlCak_textfehler']", "", 30000, null, "610f4e4c-0db2-497d-8828-5786e2f3fa58");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("d2979397-dfc7-44cd-ae0d-cb6a51d6c7d8")]
            public virtual Ranorex.TabPage Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("d2979397-dfc7-44cd-ae0d-cb6a51d6c7d8")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The DfAdrNr item.
            /// </summary>
            [RepositoryItem("f7fd5c76-8318-4624-917b-8e7b8c4d783d")]
            public virtual Ranorex.Text DfAdrNr
            {
                get
                {
                    return _dfadrnrInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The DfAdrNr item info.
            /// </summary>
            [RepositoryItemInfo("f7fd5c76-8318-4624-917b-8e7b8c4d783d")]
            public virtual RepoItemInfo DfAdrNrInfo
            {
                get
                {
                    return _dfadrnrInfo;
                }
            }

            /// <summary>
            /// The DfAdrNrWare item.
            /// </summary>
            [RepositoryItem("3f0bbb01-2d39-487c-ac9c-1692e737a490")]
            public virtual Ranorex.Text DfAdrNrWare
            {
                get
                {
                    return _dfadrnrwareInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The DfAdrNrWare item info.
            /// </summary>
            [RepositoryItemInfo("3f0bbb01-2d39-487c-ac9c-1692e737a490")]
            public virtual RepoItemInfo DfAdrNrWareInfo
            {
                get
                {
                    return _dfadrnrwareInfo;
                }
            }

            /// <summary>
            /// The DfCaaCd item.
            /// </summary>
            [RepositoryItem("f6eae65e-b03d-465f-b034-60dacd7c1ce7")]
            public virtual Ranorex.Text DfCaaCd
            {
                get
                {
                    return _dfcaacdInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The DfCaaCd item info.
            /// </summary>
            [RepositoryItemInfo("f6eae65e-b03d-465f-b034-60dacd7c1ce7")]
            public virtual RepoItemInfo DfCaaCdInfo
            {
                get
                {
                    return _dfcaacdInfo;
                }
            }

            /// <summary>
            /// The DfLagNr item.
            /// </summary>
            [RepositoryItem("9c547078-5721-41dc-8c7d-f0e8e6dae639")]
            public virtual Ranorex.Text DfLagNr
            {
                get
                {
                    return _dflagnrInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The DfLagNr item info.
            /// </summary>
            [RepositoryItemInfo("9c547078-5721-41dc-8c7d-f0e8e6dae639")]
            public virtual RepoItemInfo DfLagNrInfo
            {
                get
                {
                    return _dflagnrInfo;
                }
            }

            /// <summary>
            /// The MlCakTextfehler item.
            /// </summary>
            [RepositoryItem("610f4e4c-0db2-497d-8828-5786e2f3fa58")]
            public virtual Ranorex.Container MlCakTextfehler
            {
                get
                {
                    return _mlcaktextfehlerInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The MlCakTextfehler item info.
            /// </summary>
            [RepositoryItemInfo("610f4e4c-0db2-497d-8828-5786e2f3fa58")]
            public virtual RepoItemInfo MlCakTextfehlerInfo
            {
                get
                {
                    return _mlcaktextfehlerInfo;
                }
            }
        }

        /// <summary>
        /// The DlgKldvAppFolder folder.
        /// </summary>
        [RepositoryFolder("e77ac386-0475-4e2c-967b-ea72269c3f62")]
        public partial class DlgKldvAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _row1column0Info;

            /// <summary>
            /// Creates a new DlgKldv  folder.
            /// </summary>
            public DlgKldvAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DlgKldv", "/form[@controlname='dlgKldv']", parentFolder, 30000, null, true, "e77ac386-0475-4e2c-967b-ea72269c3f62", "")
            {
                _row1column0Info = new RepoItemInfo(this, "Row1Column0", "container[@controlname='tblKldv']/?/?/table[@accessiblename='FlexGrid']/?/?/cell[@accessiblename='Row 1 Column 0']", ".//cell[@accessiblename='Row 1 Column 0']", 30000, null, "7b8cac1a-5283-4f7d-8f76-854bfb0a2f22");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("e77ac386-0475-4e2c-967b-ea72269c3f62")]
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
            [RepositoryItemInfo("e77ac386-0475-4e2c-967b-ea72269c3f62")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Row1Column0 item.
            /// </summary>
            [RepositoryItem("7b8cac1a-5283-4f7d-8f76-854bfb0a2f22")]
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
            [RepositoryItemInfo("7b8cac1a-5283-4f7d-8f76-854bfb0a2f22")]
            public virtual RepoItemInfo Row1Column0Info
            {
                get
                {
                    return _row1column0Info;
                }
            }
        }

    }
#pragma warning restore 0436
}