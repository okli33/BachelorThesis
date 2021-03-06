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

namespace PerformanceRating
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording13 recording.
    /// </summary>
    [TestModule("136cde29-6ac6-4bc9-8791-96e08286a818", ModuleType.Recording, 1)]
    public partial class Recording13 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PerformanceRatingRepository repository.
        /// </summary>
        public static PerformanceRatingRepository repo = PerformanceRatingRepository.Instance;

        static Recording13 instance = new Recording13();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording13()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording13 Instance
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
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GoogleGoogleChrome.AdressUndSuchleiste' at 207;16.", repo.GoogleGoogleChrome.AdressUndSuchleisteInfo, new RecordItemIndex(0));
            repo.GoogleGoogleChrome.AdressUndSuchleiste.Click("207;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'http://192.168.178.58:9000/' with focus on 'GoogleGoogleChrome.AdressUndSuchleiste'.", repo.GoogleGoogleChrome.AdressUndSuchleisteInfo, new RecordItemIndex(1));
            repo.GoogleGoogleChrome.AdressUndSuchleiste.EnsureVisible();
            Keyboard.Press("http://192.168.178.58:9000/");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Enter}' with focus on 'GoogleGoogleChrome.AdressUndSuchleiste'.", repo.GoogleGoogleChrome.AdressUndSuchleisteInfo, new RecordItemIndex(2));
            repo.GoogleGoogleChrome.AdressUndSuchleiste.PressKeys("{Enter}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Http192168178589000Hash' at 88;13.", repo.PerformanceRating.Http192168178589000HashInfo, new RecordItemIndex(3));
            repo.PerformanceRating.Http192168178589000Hash.Click("88;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.LoginItem' at 108;13.", repo.PerformanceRating.LoginItemInfo, new RecordItemIndex(4));
            repo.PerformanceRating.LoginItem.Click("108;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'admin' with focus on 'PerformanceRating.Username'.", repo.PerformanceRating.UsernameInfo, new RecordItemIndex(5));
            repo.PerformanceRating.Username.EnsureVisible();
            Keyboard.Press("admin");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Password' at 307;10.", repo.PerformanceRating.PasswordInfo, new RecordItemIndex(6));
            repo.PerformanceRating.Password.Click("307;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'admin' with focus on 'PerformanceRating.Password'.", repo.PerformanceRating.PasswordInfo, new RecordItemIndex(7));
            repo.PerformanceRating.Password.PressKeys("admin");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.BtnBtnPrimary' at 51;29.", repo.PerformanceRating.BtnBtnPrimaryInfo, new RecordItemIndex(8));
            repo.PerformanceRating.BtnBtnPrimary.Click("51;29");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Http192168178589000Hash1' at 145;18.", repo.PerformanceRating.Http192168178589000Hash1Info, new RecordItemIndex(9));
            repo.PerformanceRating.Http192168178589000Hash1.Click("145;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.UserManagement' at 106;6.", repo.PerformanceRating.UserManagementInfo, new RecordItemIndex(10));
            repo.PerformanceRating.UserManagement.Click("106;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Edit' at 5;9.", repo.PerformanceRating.EditInfo, new RecordItemIndex(11));
            repo.PerformanceRating.Edit.Click("5;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.LastName' at 86;14.", repo.PerformanceRating.LastNameInfo, new RecordItemIndex(12));
            repo.PerformanceRating.LastName.Click("86;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'PerformanceRating.LastName' at 63;25.", repo.PerformanceRating.LastNameInfo, new RecordItemIndex(13));
            repo.PerformanceRating.LastName.MoveTo("63;25");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'PerformanceRating.LastName' at -161;-7.", repo.PerformanceRating.LastNameInfo, new RecordItemIndex(14));
            repo.PerformanceRating.LastName.MoveTo("-161;-7");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'user' with focus on 'PerformanceRating'.", repo.PerformanceRating.SelfInfo, new RecordItemIndex(15));
            repo.PerformanceRating.Self.EnsureVisible();
            Keyboard.Press("user");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.BtnBtnPrimary2' at 40;3.", repo.PerformanceRating.BtnBtnPrimary2Info, new RecordItemIndex(16));
            repo.PerformanceRating.BtnBtnPrimary2.Click("40;3");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
