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

namespace K_KST_Schnelltest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the K_KST_SchnelltestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("2731b73d-d8ed-46a2-9a64-f6bac5b14186")]
    public partial class K_KST_SchnelltestRepository : RepoGenBaseFolder
    {
        static K_KST_SchnelltestRepository instance = new K_KST_SchnelltestRepository();
        K_KST_SchnelltestRepositoryFolders.Form100PlanVariantenAppFolder _form100planvarianten;
        K_KST_SchnelltestRepositoryFolders.TblZlcdAppFolder _tblzlcd;
        K_KST_SchnelltestRepositoryFolders.TblZlgrAppFolder _tblzlgr;

        /// <summary>
        /// Gets the singleton class instance representing the K_KST_SchnelltestRepository element repository.
        /// </summary>
        [RepositoryFolder("2731b73d-d8ed-46a2-9a64-f6bac5b14186")]
        public static K_KST_SchnelltestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public K_KST_SchnelltestRepository() 
            : base("K_KST_SchnelltestRepository", "/", null, 0, false, "2731b73d-d8ed-46a2-9a64-f6bac5b14186", ".\\RepositoryImages\\K_KST_SchnelltestRepository2731b73d.rximgres")
        {
            _form100planvarianten = new K_KST_SchnelltestRepositoryFolders.Form100PlanVariantenAppFolder(this);
            _tblzlcd = new K_KST_SchnelltestRepositoryFolders.TblZlcdAppFolder(this);
            _tblzlgr = new K_KST_SchnelltestRepositoryFolders.TblZlgrAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("2731b73d-d8ed-46a2-9a64-f6bac5b14186")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Form100PlanVarianten folder.
        /// </summary>
        [RepositoryFolder("50454f68-5da1-4212-90d8-f631317c6d36")]
        public virtual K_KST_SchnelltestRepositoryFolders.Form100PlanVariantenAppFolder Form100PlanVarianten
        {
            get { return _form100planvarianten; }
        }

        /// <summary>
        /// The TblZlcd folder.
        /// </summary>
        [RepositoryFolder("661e2f37-8a57-4102-97cb-d2437fede215")]
        public virtual K_KST_SchnelltestRepositoryFolders.TblZlcdAppFolder TblZlcd
        {
            get { return _tblzlcd; }
        }

        /// <summary>
        /// The TblZlgr folder.
        /// </summary>
        [RepositoryFolder("e233dc4b-43d3-465c-8e63-1e511aae0b74")]
        public virtual K_KST_SchnelltestRepositoryFolders.TblZlgrAppFolder TblZlgr
        {
            get { return _tblzlgr; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class K_KST_SchnelltestRepositoryFolders
    {
        /// <summary>
        /// The Form100PlanVariantenAppFolder folder.
        /// </summary>
        [RepositoryFolder("50454f68-5da1-4212-90d8-f631317c6d36")]
        public partial class Form100PlanVariantenAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _titlebar100planvariantenInfo;
            RepoItemInfo _pbcommonplcdInfo;
            RepoItemInfo _pbcommonplvjInfo;

            /// <summary>
            /// Creates a new Form100PlanVarianten  folder.
            /// </summary>
            public Form100PlanVariantenAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Form100PlanVarianten", "/form[@title='[100]  Plan-Varianten']", parentFolder, 30000, null, true, "50454f68-5da1-4212-90d8-f631317c6d36", "")
            {
                _titlebar100planvariantenInfo = new RepoItemInfo(this, "TitleBar100PlanVarianten", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "383fa0aa-33a7-4f72-b874-3568255138ba");
                _pbcommonplcdInfo = new RepoItemInfo(this, "PbCommonPlcd", "container[@controlname='RibbonBar']/container[@controlname='ToolbarGroup']/button[@controlname='pbCommon_Plcd']", "", 30000, null, "1a179697-60fd-48fb-a607-2f9f07d06561");
                _pbcommonplvjInfo = new RepoItemInfo(this, "PbCommonPlvj", "container[@controlname='RibbonBar']/container[@controlname='ToolbarGroup']/button[@controlname='pbCommon_Plvj']", "", 30000, null, "acd13359-778e-4fc1-a2b2-e48189e6f2f6");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("50454f68-5da1-4212-90d8-f631317c6d36")]
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
            [RepositoryItemInfo("50454f68-5da1-4212-90d8-f631317c6d36")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar100PlanVarianten item.
            /// </summary>
            [RepositoryItem("383fa0aa-33a7-4f72-b874-3568255138ba")]
            public virtual Ranorex.TitleBar TitleBar100PlanVarianten
            {
                get
                {
                    return _titlebar100planvariantenInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100PlanVarianten item info.
            /// </summary>
            [RepositoryItemInfo("383fa0aa-33a7-4f72-b874-3568255138ba")]
            public virtual RepoItemInfo TitleBar100PlanVariantenInfo
            {
                get
                {
                    return _titlebar100planvariantenInfo;
                }
            }

            /// <summary>
            /// The PbCommonPlcd item.
            /// </summary>
            [RepositoryItem("1a179697-60fd-48fb-a607-2f9f07d06561")]
            public virtual Ranorex.Button PbCommonPlcd
            {
                get
                {
                    return _pbcommonplcdInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbCommonPlcd item info.
            /// </summary>
            [RepositoryItemInfo("1a179697-60fd-48fb-a607-2f9f07d06561")]
            public virtual RepoItemInfo PbCommonPlcdInfo
            {
                get
                {
                    return _pbcommonplcdInfo;
                }
            }

            /// <summary>
            /// The PbCommonPlvj item.
            /// </summary>
            [RepositoryItem("acd13359-778e-4fc1-a2b2-e48189e6f2f6")]
            public virtual Ranorex.Button PbCommonPlvj
            {
                get
                {
                    return _pbcommonplvjInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbCommonPlvj item info.
            /// </summary>
            [RepositoryItemInfo("acd13359-778e-4fc1-a2b2-e48189e6f2f6")]
            public virtual RepoItemInfo PbCommonPlvjInfo
            {
                get
                {
                    return _pbcommonplvjInfo;
                }
            }
        }

        /// <summary>
        /// The TblZlcdAppFolder folder.
        /// </summary>
        [RepositoryFolder("661e2f37-8a57-4102-97cb-d2437fede215")]
        public partial class TblZlcdAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _titlebar100zahlcodeInfo;
            RepoItemInfo _pbcommonzlgrInfo;

            /// <summary>
            /// Creates a new TblZlcd  folder.
            /// </summary>
            public TblZlcdAppFolder(RepoGenBaseFolder parentFolder) :
                    base("TblZlcd", "/form[@controlname='tblZlcd']", parentFolder, 30000, null, true, "661e2f37-8a57-4102-97cb-d2437fede215", "")
            {
                _titlebar100zahlcodeInfo = new RepoItemInfo(this, "TitleBar100ZahlCode", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "17375fc2-b267-46a4-95c2-9f923a8a22fd");
                _pbcommonzlgrInfo = new RepoItemInfo(this, "PbCommonZlgr", "container[@controlname='RibbonBar']/container[@controlname='ToolbarGroup']/button[@controlname='pbCommon_Zlgr']", "", 30000, null, "1be95046-735e-4469-82a2-0d41e180ac6c");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("661e2f37-8a57-4102-97cb-d2437fede215")]
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
            [RepositoryItemInfo("661e2f37-8a57-4102-97cb-d2437fede215")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar100ZahlCode item.
            /// </summary>
            [RepositoryItem("17375fc2-b267-46a4-95c2-9f923a8a22fd")]
            public virtual Ranorex.TitleBar TitleBar100ZahlCode
            {
                get
                {
                    return _titlebar100zahlcodeInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100ZahlCode item info.
            /// </summary>
            [RepositoryItemInfo("17375fc2-b267-46a4-95c2-9f923a8a22fd")]
            public virtual RepoItemInfo TitleBar100ZahlCodeInfo
            {
                get
                {
                    return _titlebar100zahlcodeInfo;
                }
            }

            /// <summary>
            /// The PbCommonZlgr item.
            /// </summary>
            [RepositoryItem("1be95046-735e-4469-82a2-0d41e180ac6c")]
            public virtual Ranorex.Button PbCommonZlgr
            {
                get
                {
                    return _pbcommonzlgrInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbCommonZlgr item info.
            /// </summary>
            [RepositoryItemInfo("1be95046-735e-4469-82a2-0d41e180ac6c")]
            public virtual RepoItemInfo PbCommonZlgrInfo
            {
                get
                {
                    return _pbcommonzlgrInfo;
                }
            }
        }

        /// <summary>
        /// The TblZlgrAppFolder folder.
        /// </summary>
        [RepositoryFolder("e233dc4b-43d3-465c-8e63-1e511aae0b74")]
        public partial class TblZlgrAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _titlebar100zahlgruppenInfo;

            /// <summary>
            /// Creates a new TblZlgr  folder.
            /// </summary>
            public TblZlgrAppFolder(RepoGenBaseFolder parentFolder) :
                    base("TblZlgr", "/form[@controlname='tblZlgr']", parentFolder, 30000, null, true, "e233dc4b-43d3-465c-8e63-1e511aae0b74", "")
            {
                _titlebar100zahlgruppenInfo = new RepoItemInfo(this, "TitleBar100ZahlGruppen", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "8363fbce-4503-4c6f-b46c-8f776edd30a2");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("e233dc4b-43d3-465c-8e63-1e511aae0b74")]
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
            [RepositoryItemInfo("e233dc4b-43d3-465c-8e63-1e511aae0b74")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar100ZahlGruppen item.
            /// </summary>
            [RepositoryItem("8363fbce-4503-4c6f-b46c-8f776edd30a2")]
            public virtual Ranorex.TitleBar TitleBar100ZahlGruppen
            {
                get
                {
                    return _titlebar100zahlgruppenInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100ZahlGruppen item info.
            /// </summary>
            [RepositoryItemInfo("8363fbce-4503-4c6f-b46c-8f776edd30a2")]
            public virtual RepoItemInfo TitleBar100ZahlGruppenInfo
            {
                get
                {
                    return _titlebar100zahlgruppenInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
