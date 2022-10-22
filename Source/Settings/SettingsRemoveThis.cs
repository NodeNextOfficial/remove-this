using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using HugsLib.Settings;
using ThatCodyGuy.RemoveThis;
using Verse;

public class SettingsRemoveThis : ModBase
{
		public override string ModIdentifier
	{
			get { return "SettingsRemoveThis"; }
		}
		private SettingHandle<bool> toggle;
		public override void DefsLoaded()
		{
			toggle = Settings.GetHandle<bool>(
				"myToggle",
			"toggleSetting_title".Translate(),
			"toggleSetting_desc".Translate(),
			false);
	}
