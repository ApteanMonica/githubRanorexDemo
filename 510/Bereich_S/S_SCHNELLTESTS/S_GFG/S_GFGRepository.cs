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

namespace S_GFG
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the S_GFGRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("e5bc9556-be62-4010-9237-0f9878cb2516")]
    public partial class S_GFGRepository : RepoGenBaseFolder
    {
        static S_GFGRepository instance = new S_GFGRepository();
        S_GFGRepositoryFolders.TblGefahrengutstoffeAppFolder _tblgefahrengutstoffe;

        /// <summary>
        /// Gets the singleton class instance representing the S_GFGRepository element repository.
        /// </summary>
        [RepositoryFolder("e5bc9556-be62-4010-9237-0f9878cb2516")]
        public static S_GFGRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public S_GFGRepository() 
            : base("S_GFGRepository", "/", null, 0, false, "e5bc9556-be62-4010-9237-0f9878cb2516", ".\\RepositoryImages\\S_GFGRepositorye5bc9556.rximgres")
        {
            _tblgefahrengutstoffe = new S_GFGRepositoryFolders.TblGefahrengutstoffeAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("e5bc9556-be62-4010-9237-0f9878cb2516")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The TblGefahrengutstoffe folder.
        /// </summary>
        [RepositoryFolder("050789ed-938d-467a-8ce9-09df0f81590b")]
        public virtual S_GFGRepositoryFolders.TblGefahrengutstoffeAppFolder TblGefahrengutstoffe
        {
            get { return _tblgefahrengutstoffe; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class S_GFGRepositoryFolders
    {
        /// <summary>
        /// The TblGefahrengutstoffeAppFolder folder.
        /// </summary>
        [RepositoryFolder("050789ed-938d-467a-8ce9-09df0f81590b")]
        public partial class TblGefahrengutstoffeAppFolder : RepoGenBaseFolder
        {
            S_GFGRepositoryFolders.RibbonBarFolder _ribbonbar;
            S_GFGRepositoryFolders.FlexGridFolder _flexgrid;
            RepoItemInfo _titlebar100gefahrengutstoffeInfo;

            /// <summary>
            /// Creates a new TblGefahrengutstoffe  folder.
            /// </summary>
            public TblGefahrengutstoffeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("TblGefahrengutstoffe", "/form[@controlname='tblGefahrengutstoffe']", parentFolder, 30000, null, true, "050789ed-938d-467a-8ce9-09df0f81590b", "")
            {
                _ribbonbar = new S_GFGRepositoryFolders.RibbonBarFolder(this);
                _flexgrid = new S_GFGRepositoryFolders.FlexGridFolder(this);
                _titlebar100gefahrengutstoffeInfo = new RepoItemInfo(this, "TitleBar100GefahrengutStoffe", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "138cb3bf-d3af-42a9-ad50-3c1456f28033");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("050789ed-938d-467a-8ce9-09df0f81590b")]
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
            [RepositoryItemInfo("050789ed-938d-467a-8ce9-09df0f81590b")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar100GefahrengutStoffe item.
            /// </summary>
            [RepositoryItem("138cb3bf-d3af-42a9-ad50-3c1456f28033")]
            public virtual Ranorex.TitleBar TitleBar100GefahrengutStoffe
            {
                get
                {
                    return _titlebar100gefahrengutstoffeInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100GefahrengutStoffe item info.
            /// </summary>
            [RepositoryItemInfo("138cb3bf-d3af-42a9-ad50-3c1456f28033")]
            public virtual RepoItemInfo TitleBar100GefahrengutStoffeInfo
            {
                get
                {
                    return _titlebar100gefahrengutstoffeInfo;
                }
            }

            /// <summary>
            /// The RibbonBar folder.
            /// </summary>
            [RepositoryFolder("6bfc080b-d629-4283-a085-df24147abfb1")]
            public virtual S_GFGRepositoryFolders.RibbonBarFolder RibbonBar
            {
                get { return _ribbonbar; }
            }

            /// <summary>
            /// The FlexGrid folder.
            /// </summary>
            [RepositoryFolder("23f2a644-ce55-4634-b6f1-9caae41c81e2")]
            public virtual S_GFGRepositoryFolders.FlexGridFolder FlexGrid
            {
                get { return _flexgrid; }
            }
        }

        /// <summary>
        /// The RibbonBarFolder folder.
        /// </summary>
        [RepositoryFolder("6bfc080b-d629-4283-a085-df24147abfb1")]
        public partial class RibbonBarFolder : RepoGenBaseFolder
        {
            RepoItemInfo _pbdataaccessnewInfo;
            RepoItemInfo _pbdataaccesssaveInfo;
            RepoItemInfo _pbdataaccessloadInfo;

            /// <summary>
            /// Creates a new RibbonBar  folder.
            /// </summary>
            public RibbonBarFolder(RepoGenBaseFolder parentFolder) :
                    base("RibbonBar", "container[@controlname='RibbonBar']", parentFolder, 30000, null, false, "6bfc080b-d629-4283-a085-df24147abfb1", "")
            {
                _pbdataaccessnewInfo = new RepoItemInfo(this, "PbDataAccessNew", "container[@controlname='DataAccessGroup']/button[@controlname='pbDataAccess_New']", "", 30000, null, "2381aa35-ff00-4494-b07e-08551cc98eba");
                _pbdataaccesssaveInfo = new RepoItemInfo(this, "PbDataAccessSave", "container[@controlname='DataAccessGroup']/button[@controlname='pbDataAccess_Save']", "", 30000, null, "332e040b-3989-490b-b9d8-8fa23850f471");
                _pbdataaccessloadInfo = new RepoItemInfo(this, "PbDataAccessLoad", "container[@controlname='DataAccessGroup']/button[@controlname='pbDataAccess_Load']", "", 30000, null, "5f36406d-1af7-4c0c-b4da-bf469c609ede");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("6bfc080b-d629-4283-a085-df24147abfb1")]
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
            [RepositoryItemInfo("6bfc080b-d629-4283-a085-df24147abfb1")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The PbDataAccessNew item.
            /// </summary>
            [RepositoryItem("2381aa35-ff00-4494-b07e-08551cc98eba")]
            public virtual Ranorex.Button PbDataAccessNew
            {
                get
                {
                    return _pbdataaccessnewInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbDataAccessNew item info.
            /// </summary>
            [RepositoryItemInfo("2381aa35-ff00-4494-b07e-08551cc98eba")]
            public virtual RepoItemInfo PbDataAccessNewInfo
            {
                get
                {
                    return _pbdataaccessnewInfo;
                }
            }

            /// <summary>
            /// The PbDataAccessSave item.
            /// </summary>
            [RepositoryItem("332e040b-3989-490b-b9d8-8fa23850f471")]
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
            [RepositoryItemInfo("332e040b-3989-490b-b9d8-8fa23850f471")]
            public virtual RepoItemInfo PbDataAccessSaveInfo
            {
                get
                {
                    return _pbdataaccesssaveInfo;
                }
            }

            /// <summary>
            /// The PbDataAccessLoad item.
            /// </summary>
            [RepositoryItem("5f36406d-1af7-4c0c-b4da-bf469c609ede")]
            public virtual Ranorex.Button PbDataAccessLoad
            {
                get
                {
                    return _pbdataaccessloadInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbDataAccessLoad item info.
            /// </summary>
            [RepositoryItemInfo("5f36406d-1af7-4c0c-b4da-bf469c609ede")]
            public virtual RepoItemInfo PbDataAccessLoadInfo
            {
                get
                {
                    return _pbdataaccessloadInfo;
                }
            }
        }

        /// <summary>
        /// The FlexGridFolder folder.
        /// </summary>
        [RepositoryFolder("23f2a644-ce55-4634-b6f1-9caae41c81e2")]
        public partial class FlexGridFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new FlexGrid  folder.
            /// </summary>
            public FlexGridFolder(RepoGenBaseFolder parentFolder) :
                    base("FlexGrid", "container[@controlname='ChildTableWindow']/element[@controlname='mainGrid']/table[@accessiblename='FlexGrid']", parentFolder, 30000, null, false, "23f2a644-ce55-4634-b6f1-9caae41c81e2", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("23f2a644-ce55-4634-b6f1-9caae41c81e2")]
            public virtual Ranorex.Table Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Table>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("23f2a644-ce55-4634-b6f1-9caae41c81e2")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
