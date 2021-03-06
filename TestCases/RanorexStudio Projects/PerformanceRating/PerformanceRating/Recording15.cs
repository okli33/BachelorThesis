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
    ///The Recording15 recording.
    /// </summary>
    [TestModule("b773afb5-b299-4362-ae2b-33c7f2bee22f", ModuleType.Recording, 1)]
    public partial class Recording15 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PerformanceRatingRepository repository.
        /// </summary>
        public static PerformanceRatingRepository repo = PerformanceRatingRepository.Instance;

        static Recording15 instance = new Recording15();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording15()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording15 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GoogleGoogleChrome.AdressUndSuchleiste' at 161;8.", repo.GoogleGoogleChrome.AdressUndSuchleisteInfo, new RecordItemIndex(0));
            repo.GoogleGoogleChrome.AdressUndSuchleiste.Click("161;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'http://192.168.178.58:9000/' with focus on 'GoogleGoogleChrome.AdressUndSuchleiste'.", repo.GoogleGoogleChrome.AdressUndSuchleisteInfo, new RecordItemIndex(1));
            repo.GoogleGoogleChrome.AdressUndSuchleiste.PressKeys("http://192.168.178.58:9000/");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Enter}' with focus on 'GoogleGoogleChrome.AdressUndSuchleiste'.", repo.GoogleGoogleChrome.AdressUndSuchleisteInfo, new RecordItemIndex(2));
            repo.GoogleGoogleChrome.AdressUndSuchleiste.PressKeys("{Enter}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Account' at 24;15.", repo.PerformanceRating.AccountInfo, new RecordItemIndex(3));
            repo.PerformanceRating.Account.Click("24;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.SignIn' at 19;15.", repo.PerformanceRating.SignInInfo, new RecordItemIndex(4));
            repo.PerformanceRating.SignIn.Click("19;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Username' at Center.", repo.PerformanceRating.UsernameInfo, new RecordItemIndex(5));
            repo.PerformanceRating.Username.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'admin' with focus on 'PerformanceRating.Username'.", repo.PerformanceRating.UsernameInfo, new RecordItemIndex(6));
            repo.PerformanceRating.Username.EnsureVisible();
            Keyboard.Press("admin");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Password' at 442;19.", repo.PerformanceRating.PasswordInfo, new RecordItemIndex(7));
            repo.PerformanceRating.Password.Click("442;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'admin' with focus on 'PerformanceRating.Password'.", repo.PerformanceRating.PasswordInfo, new RecordItemIndex(8));
            repo.PerformanceRating.Password.PressKeys("admin");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.SignIn1' at 42;4.", repo.PerformanceRating.SignIn1Info, new RecordItemIndex(9));
            repo.PerformanceRating.SignIn1.Click("42;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Administration' at 104;2.", repo.PerformanceRating.AdministrationInfo, new RecordItemIndex(10));
            repo.PerformanceRating.Administration.Click("104;2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Http192168178589000H2Console' at 125;3.", repo.PerformanceRating.Http192168178589000H2ConsoleInfo, new RecordItemIndex(11));
            repo.PerformanceRating.Http192168178589000H2Console.Click("125;3");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
