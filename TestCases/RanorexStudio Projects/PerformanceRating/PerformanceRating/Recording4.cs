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
    ///The Recording4 recording.
    /// </summary>
    [TestModule("dcd477b7-6ee1-4dac-9f98-233a62244907", ModuleType.Recording, 1)]
    public partial class Recording4 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PerformanceRatingRepository repository.
        /// </summary>
        public static PerformanceRatingRepository repo = PerformanceRatingRepository.Instance;

        static Recording4 instance = new Recording4();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording4()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording4 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'GoogleGoogleChrome.AdressUndSuchleiste' at 145;18.", repo.GoogleGoogleChrome.AdressUndSuchleisteInfo, new RecordItemIndex(0));
            repo.GoogleGoogleChrome.AdressUndSuchleiste.MoveTo("145;18");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'GoogleGoogleChrome.AdressUndSuchleiste' at 13;20.", repo.GoogleGoogleChrome.AdressUndSuchleisteInfo, new RecordItemIndex(1));
            repo.GoogleGoogleChrome.AdressUndSuchleiste.MoveTo("13;20");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GoogleGoogleChrome.AdressUndSuchleiste' at 180;15.", repo.GoogleGoogleChrome.AdressUndSuchleisteInfo, new RecordItemIndex(2));
            repo.GoogleGoogleChrome.AdressUndSuchleiste.Click("180;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'GoogleGoogleChrome.AdressUndSuchleiste' at 175;12.", repo.GoogleGoogleChrome.AdressUndSuchleisteInfo, new RecordItemIndex(3));
            repo.GoogleGoogleChrome.AdressUndSuchleiste.MoveTo("175;12");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'GoogleGoogleChrome.AdressUndSuchleiste' at -6;-2.", repo.GoogleGoogleChrome.AdressUndSuchleisteInfo, new RecordItemIndex(4));
            repo.GoogleGoogleChrome.AdressUndSuchleiste.MoveTo("-6;-2");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'http://192.168.178.58:9000/' with focus on 'Google'.", repo.Google.SelfInfo, new RecordItemIndex(5));
            repo.Google.Self.EnsureVisible();
            Keyboard.Press("http://192.168.178.58:9000/");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Enter}' with focus on 'Google'.", repo.Google.SelfInfo, new RecordItemIndex(6));
            repo.Google.Self.PressKeys("{Enter}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating' at 1870;30.", repo.PerformanceRating.SelfInfo, new RecordItemIndex(7));
            repo.PerformanceRating.Self.Click("1870;30");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.LoginItem' at 99;9.", repo.PerformanceRating.LoginItemInfo, new RecordItemIndex(8));
            repo.PerformanceRating.LoginItem.Click("99;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Username' at 65;12.", repo.PerformanceRating.UsernameInfo, new RecordItemIndex(9));
            repo.PerformanceRating.Username.Click("65;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'user3' with focus on 'PerformanceRating.Username'.", repo.PerformanceRating.UsernameInfo, new RecordItemIndex(10));
            repo.PerformanceRating.Username.PressKeys("user3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.Password' at 426;11.", repo.PerformanceRating.PasswordInfo, new RecordItemIndex(11));
            repo.PerformanceRating.Password.Click("426;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'user' with focus on 'PerformanceRating.Password'.", repo.PerformanceRating.PasswordInfo, new RecordItemIndex(12));
            repo.PerformanceRating.Password.PressKeys("user");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PerformanceRating.BtnBtnPrimary' at 59;5.", repo.PerformanceRating.BtnBtnPrimaryInfo, new RecordItemIndex(13));
            repo.PerformanceRating.BtnBtnPrimary.Click("59;5");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
