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
    ///The Recording9 recording.
    /// </summary>
    [TestModule("79031b7d-2d25-40ed-b12e-0055392b8d1a", ModuleType.Recording, 1)]
    public partial class Recording9 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PerformanceRatingRepository repository.
        /// </summary>
        public static PerformanceRatingRepository repo = PerformanceRatingRepository.Instance;

        static Recording9 instance = new Recording9();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording9()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording9 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GoogleGoogleChrome.AdressUndSuchleiste' at 194;14.", repo.GoogleGoogleChrome.AdressUndSuchleisteInfo, new RecordItemIndex(0));
            repo.GoogleGoogleChrome.AdressUndSuchleiste.Click("194;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'h{Return}' with focus on 'GoogleGoogleChrome.AdressUndSuchleiste'.", repo.GoogleGoogleChrome.AdressUndSuchleisteInfo, new RecordItemIndex(1));
            repo.GoogleGoogleChrome.AdressUndSuchleiste.PressKeys("h{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Http192168178589000Hash' at 95;14.", repo.PerformanceRating.Http192168178589000HashInfo, new RecordItemIndex(2));
            repo.PerformanceRating.Http192168178589000Hash.Click("95;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.LoginItem' at 113;16.", repo.PerformanceRating.LoginItemInfo, new RecordItemIndex(3));
            repo.PerformanceRating.LoginItem.Click("113;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'user' with focus on 'PerformanceRating'.", repo.PerformanceRating.SelfInfo, new RecordItemIndex(4));
            repo.PerformanceRating.Self.EnsureVisible();
            Keyboard.Press("user");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Password' at 452;20.", repo.PerformanceRating.PasswordInfo, new RecordItemIndex(5));
            repo.PerformanceRating.Password.Click("452;20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'user' with focus on 'PerformanceRating.Password'.", repo.PerformanceRating.PasswordInfo, new RecordItemIndex(6));
            repo.PerformanceRating.Password.PressKeys("user");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.SignIn1' at 43;0.", repo.PerformanceRating.SignIn1Info, new RecordItemIndex(7));
            repo.PerformanceRating.SignIn1.Click("43;0");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Http192168178589000Hash' at 97;15.", repo.PerformanceRating.Http192168178589000HashInfo, new RecordItemIndex(8));
            repo.PerformanceRating.Http192168178589000Hash.Click("97;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Http192168178589000AccountPassw' at 129;12.", repo.PerformanceRating.Http192168178589000AccountPasswInfo, new RecordItemIndex(9));
            repo.PerformanceRating.Http192168178589000AccountPassw.Click("129;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.CurrentPassword' at 465;34.", repo.PerformanceRating.CurrentPasswordInfo, new RecordItemIndex(10));
            repo.PerformanceRating.CurrentPassword.Click("465;34");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'user' with focus on 'PerformanceRating.CurrentPassword'.", repo.PerformanceRating.CurrentPasswordInfo, new RecordItemIndex(11));
            repo.PerformanceRating.CurrentPassword.PressKeys("user");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.NewPassword' at 463;9.", repo.PerformanceRating.NewPasswordInfo, new RecordItemIndex(12));
            repo.PerformanceRating.NewPassword.Click("463;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'user2' with focus on 'PerformanceRating.NewPassword'.", repo.PerformanceRating.NewPasswordInfo, new RecordItemIndex(13));
            repo.PerformanceRating.NewPassword.PressKeys("user2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.ConfirmPassword' at 429;15.", repo.PerformanceRating.ConfirmPasswordInfo, new RecordItemIndex(14));
            repo.PerformanceRating.ConfirmPassword.Click("429;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'user2' with focus on 'PerformanceRating.ConfirmPassword'.", repo.PerformanceRating.ConfirmPasswordInfo, new RecordItemIndex(15));
            repo.PerformanceRating.ConfirmPassword.PressKeys("user2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.BtnBtnSuccess' at 48;8.", repo.PerformanceRating.BtnBtnSuccessInfo, new RecordItemIndex(16));
            repo.PerformanceRating.BtnBtnSuccess.Click("48;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRatingGoogleChrome.NeuLaden' at 24;13.", repo.PerformanceRatingGoogleChrome.NeuLadenInfo, new RecordItemIndex(17));
            repo.PerformanceRatingGoogleChrome.NeuLaden.Click("24;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.CurrentPassword' at 193;10.", repo.PerformanceRating.CurrentPasswordInfo, new RecordItemIndex(18));
            repo.PerformanceRating.CurrentPassword.Click("193;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'user2' with focus on 'PerformanceRating.CurrentPassword'.", repo.PerformanceRating.CurrentPasswordInfo, new RecordItemIndex(19));
            repo.PerformanceRating.CurrentPassword.PressKeys("user2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.NewPassword' at 175;11.", repo.PerformanceRating.NewPasswordInfo, new RecordItemIndex(20));
            repo.PerformanceRating.NewPassword.Click("175;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'user' with focus on 'PerformanceRating.NewPassword'.", repo.PerformanceRating.NewPasswordInfo, new RecordItemIndex(21));
            repo.PerformanceRating.NewPassword.PressKeys("user");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.ConfirmPassword' at 225;13.", repo.PerformanceRating.ConfirmPasswordInfo, new RecordItemIndex(22));
            repo.PerformanceRating.ConfirmPassword.Click("225;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'user' with focus on 'PerformanceRating.ConfirmPassword'.", repo.PerformanceRating.ConfirmPasswordInfo, new RecordItemIndex(23));
            repo.PerformanceRating.ConfirmPassword.PressKeys("user");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Save' at 25;0.", repo.PerformanceRating.SaveInfo, new RecordItemIndex(24));
            repo.PerformanceRating.Save.Click("25;0");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}