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
    ///The Recording12 recording.
    /// </summary>
    [TestModule("92e5416b-1a23-4281-b604-366aa806e50d", ModuleType.Recording, 1)]
    public partial class Recording12 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PerformanceRatingRepository repository.
        /// </summary>
        public static PerformanceRatingRepository repo = PerformanceRatingRepository.Instance;

        static Recording12 instance = new Recording12();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording12()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording12 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GoogleGoogleChrome.AdressUndSuchleiste' at 266;5.", repo.GoogleGoogleChrome.AdressUndSuchleisteInfo, new RecordItemIndex(0));
            repo.GoogleGoogleChrome.AdressUndSuchleiste.Click("266;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'h{Return}' with focus on 'GoogleGoogleChrome.AdressUndSuchleiste'.", repo.GoogleGoogleChrome.AdressUndSuchleisteInfo, new RecordItemIndex(1));
            repo.GoogleGoogleChrome.AdressUndSuchleiste.PressKeys("h{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Http192168178589000Hash' at 93;21.", repo.PerformanceRating.Http192168178589000HashInfo, new RecordItemIndex(2));
            repo.PerformanceRating.Http192168178589000Hash.Click("93;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.SignIn' at 18;8.", repo.PerformanceRating.SignInInfo, new RecordItemIndex(3));
            repo.PerformanceRating.SignIn.Click("18;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'admin' with focus on 'PerformanceRating'.", repo.PerformanceRating.SelfInfo, new RecordItemIndex(4));
            repo.PerformanceRating.Self.EnsureVisible();
            Keyboard.Press("admin");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Password' at 168;13.", repo.PerformanceRating.PasswordInfo, new RecordItemIndex(5));
            repo.PerformanceRating.Password.Click("168;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'admin' with focus on 'PerformanceRating.Password'.", repo.PerformanceRating.PasswordInfo, new RecordItemIndex(6));
            repo.PerformanceRating.Password.PressKeys("admin");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.SignIn1' at 38;5.", repo.PerformanceRating.SignIn1Info, new RecordItemIndex(7));
            repo.PerformanceRating.SignIn1.Click("38;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Administration' at 49;8.", repo.PerformanceRating.AdministrationInfo, new RecordItemIndex(8));
            repo.PerformanceRating.Administration.Click("49;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.UserManagement' at 84;3.", repo.PerformanceRating.UserManagementInfo, new RecordItemIndex(9));
            repo.PerformanceRating.UserManagement.Click("84;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.View' at 9;1.", repo.PerformanceRating.ViewInfo, new RecordItemIndex(10));
            repo.PerformanceRating.View.Click("9;1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Back' at 27;14.", repo.PerformanceRating.BackInfo, new RecordItemIndex(11));
            repo.PerformanceRating.Back.Click("27;14");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
