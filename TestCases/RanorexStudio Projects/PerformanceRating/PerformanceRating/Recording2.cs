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
    ///The Recording2 recording.
    /// </summary>
    [TestModule("cbc5a95b-28ba-4990-bc3d-2ff05cda6df2", ModuleType.Recording, 1)]
    public partial class Recording2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PerformanceRatingRepository repository.
        /// </summary>
        public static PerformanceRatingRepository repo = PerformanceRatingRepository.Instance;

        static Recording2 instance = new Recording2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording2 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GoogleGoogleChrome.AdressUndSuchleiste' at 150;11.", repo.GoogleGoogleChrome.AdressUndSuchleisteInfo, new RecordItemIndex(0));
            repo.GoogleGoogleChrome.AdressUndSuchleiste.Click("150;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GoogleGoogleChrome.AdressUndSuchleiste' at 102;14.", repo.GoogleGoogleChrome.AdressUndSuchleisteInfo, new RecordItemIndex(1));
            repo.GoogleGoogleChrome.AdressUndSuchleiste.Click("102;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GoogleGoogleChrome.AdressUndSuchleiste' at 106;12.", repo.GoogleGoogleChrome.AdressUndSuchleisteInfo, new RecordItemIndex(2));
            repo.GoogleGoogleChrome.AdressUndSuchleiste.Click("106;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'GoogleGoogleChrome.AdressUndSuchleiste' at 166;14.", repo.GoogleGoogleChrome.AdressUndSuchleisteInfo, new RecordItemIndex(3));
            repo.GoogleGoogleChrome.AdressUndSuchleiste.MoveTo("166;14");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'GoogleGoogleChrome.AdressUndSuchleiste' at -2;27.", repo.GoogleGoogleChrome.AdressUndSuchleisteInfo, new RecordItemIndex(4));
            repo.GoogleGoogleChrome.AdressUndSuchleiste.MoveTo("-2;27");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'http://192.168.178.58:9000/' with focus on 'GoogleGoogleChrome.AdressUndSuchleiste'.", repo.GoogleGoogleChrome.AdressUndSuchleisteInfo, new RecordItemIndex(5));
            repo.GoogleGoogleChrome.AdressUndSuchleiste.PressKeys("http://192.168.178.58:9000/");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'GoogleGoogleChrome.AdressUndSuchleiste'.", repo.GoogleGoogleChrome.AdressUndSuchleisteInfo, new RecordItemIndex(6));
            repo.GoogleGoogleChrome.AdressUndSuchleiste.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Account' at 15;10.", repo.PerformanceRating.AccountInfo, new RecordItemIndex(7));
            repo.PerformanceRating.Account.Click("15;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Register' at 31;13.", repo.PerformanceRating.RegisterInfo, new RecordItemIndex(8));
            repo.PerformanceRating.Register.Click("31;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Username' at 34;19.", repo.PerformanceRating.UsernameInfo, new RecordItemIndex(9));
            repo.PerformanceRating.Username.Click("34;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'user2' with focus on 'PerformanceRating.Username'.", repo.PerformanceRating.UsernameInfo, new RecordItemIndex(10));
            repo.PerformanceRating.Username.PressKeys("user2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Email' at 39;7.", repo.PerformanceRating.EmailInfo, new RecordItemIndex(11));
            repo.PerformanceRating.Email.Click("39;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'user2{RMenu down}{LControlKey down}{Qkey}{RMenu up}{LControlKey up}{LControlKey up}mail.com' with focus on 'PerformanceRating.Email'.", repo.PerformanceRating.EmailInfo, new RecordItemIndex(12));
            repo.PerformanceRating.Email.PressKeys("user2{RMenu down}{LControlKey down}{Qkey}{RMenu up}{LControlKey up}{LControlKey up}mail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.FirstPassword' at 134;12.", repo.PerformanceRating.FirstPasswordInfo, new RecordItemIndex(13));
            repo.PerformanceRating.FirstPassword.Click("134;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'user2' with focus on 'PerformanceRating.FirstPassword'.", repo.PerformanceRating.FirstPasswordInfo, new RecordItemIndex(14));
            repo.PerformanceRating.FirstPassword.PressKeys("user2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.SecondPassword' at 90;6.", repo.PerformanceRating.SecondPasswordInfo, new RecordItemIndex(15));
            repo.PerformanceRating.SecondPassword.Click("90;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'user' with focus on 'PerformanceRating.SecondPassword'.", repo.PerformanceRating.SecondPasswordInfo, new RecordItemIndex(16));
            repo.PerformanceRating.SecondPassword.PressKeys("user");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Register1' at 51;9.", repo.PerformanceRating.Register1Info, new RecordItemIndex(17));
            repo.PerformanceRating.Register1.Click("51;9");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}