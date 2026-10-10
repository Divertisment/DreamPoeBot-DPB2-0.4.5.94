using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Utilities;
using DreamPoeBot.Loki.Models;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class LocalPlayer : Player
{
	[Serializable]
	private sealed class Class102
	{
		public static readonly Class102 class102_0;

		private static Class102 class102_1;

		internal bool method_0(DatPassiveSkillWrapper datPassiveSkillWrapper_0)
		{
			return true;
		}

		internal bool method_1(Skill skill_0)
		{
			return true;
		}

		internal bool method_2(Skill skill_0)
		{
			return true;
		}

		internal bool method_3(Skill skill_0)
		{
			return true;
		}

		internal bool method_4(Skill skill_0)
		{
			return true;
		}

		internal bool method_5(Skill skill_0)
		{
			return true;
		}

		internal bool method_6(Skill skill_0)
		{
			return true;
		}

		internal bool method_7(Skill skill_0)
		{
			return true;
		}

		internal bool method_8(Skill skill_0)
		{
			return true;
		}

		internal bool method_9(Skill skill_0)
		{
			return true;
		}

		internal bool method_10(Skill skill_0)
		{
			return true;
		}

		internal bool method_11(Skill skill_0)
		{
			return true;
		}

		internal bool method_12(Skill skill_0)
		{
			return true;
		}

		internal bool method_13(Skill skill_0)
		{
			return true;
		}

		static Class102()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			class102_0 = new Class102();
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class102 smethod_1()
		{
			return null;
		}
	}

	private sealed class Class103
	{
		public string string_0;

		internal static Class103 class103_0;

		internal bool method_0(Skill skill_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class103 smethod_1()
		{
			return null;
		}

		static Class103()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetKeysComboForSkill_003Ed__35 : IEnumerable<LokiPoe.Input.KeysCombo>, IEnumerable, IEnumerator<LokiPoe.Input.KeysCombo>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private LokiPoe.Input.KeysCombo _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private Skill skill;

		public Skill _003C_003E3__skill;

		public LocalPlayer _003C_003E4__this;

		private bool _003Cflag_003E5__2;

		private uint _003Cid_003E5__3;

		private List<uint> _003CskillBarIds_003E5__4;

		private int _003Ci_003E5__5;

		private static _003CGetKeysComboForSkill_003Ed__35 _003CGetKeysComboForSkill_003Ed__35_0;

		LokiPoe.Input.KeysCombo IEnumerator<LokiPoe.Input.KeysCombo>.Current => null;

		object IEnumerator.Current => null;

		public _003CGetKeysComboForSkill_003Ed__35(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}

		IEnumerator<LokiPoe.Input.KeysCombo> IEnumerable<LokiPoe.Input.KeysCombo>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static _003CGetKeysComboForSkill_003Ed__35 smethod_1()
		{
			return null;
		}

		static _003CGetKeysComboForSkill_003Ed__35()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetKeysForSkill_003Ed__34 : IEnumerable<Keys>, IEnumerable, IEnumerator<Keys>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private Keys _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private Skill skill;

		public Skill _003C_003E3__skill;

		public LocalPlayer _003C_003E4__this;

		private bool _003Cflag_003E5__2;

		private uint _003Cid_003E5__3;

		private List<uint> _003CskillBarIds_003E5__4;

		private int _003Ci_003E5__5;

		private static _003CGetKeysForSkill_003Ed__34 _003CGetKeysForSkill_003Ed__34_0;

		Keys IEnumerator<Keys>.Current => (Keys)(object)null;

		object IEnumerator.Current => null;

		public _003CGetKeysForSkill_003Ed__34(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}

		IEnumerator<Keys> IEnumerable<Keys>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static _003CGetKeysForSkill_003Ed__34 smethod_1()
		{
			return null;
		}

		static _003CGetKeysForSkill_003Ed__34()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_EquippedItems_003Ed__27 : IEnumerable<Item>, IEnumerable, IEnumerator<Item>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private Item _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IEnumerator<Inventory> _003C_003E7__wrap1;

		internal static _003Cget_EquippedItems_003Ed__27 _003Cget_EquippedItems_003Ed__27_0;

		Item IEnumerator<Item>.Current => null;

		object IEnumerator.Current => null;

		public _003Cget_EquippedItems_003Ed__27(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}

		IEnumerator<Item> IEnumerable<Item>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static _003Cget_EquippedItems_003Ed__27 smethod_1()
		{
			return null;
		}

		static _003Cget_EquippedItems_003Ed__27()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_Passives_003Ed__41 : IEnumerable<DatPassiveSkillWrapper>, IEnumerable, IEnumerator<DatPassiveSkillWrapper>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private DatPassiveSkillWrapper _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private List<ushort>.Enumerator _003C_003E7__wrap1;

		internal static _003Cget_Passives_003Ed__41 _003Cget_Passives_003Ed__41_0;

		DatPassiveSkillWrapper IEnumerator<DatPassiveSkillWrapper>.Current => null;

		object IEnumerator.Current => null;

		public _003Cget_Passives_003Ed__41(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}

		IEnumerator<DatPassiveSkillWrapper> IEnumerable<DatPassiveSkillWrapper>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static _003Cget_Passives_003Ed__41 smethod_1()
		{
			return null;
		}

		static _003Cget_Passives_003Ed__41()
		{
			Class200.smethod_34();
		}
	}

	private static readonly ILog ilog_1;

	private PerFrameCachedValue<int> perFrameCachedValue_6;

	internal static LocalPlayer localPlayer_0;

	public SpiritData Spirit => (SpiritData)(object)null;

	public int BestiaryNetVariation => 0;

	public Portal TownPortal => null;

	public string League => null;

	public List<uint> SkillBarIds => null;

	public List<Skill> SkillBarSkills => null;

	public bool IsInHideout => true;

	public bool IsInTown => true;

	public bool IsInOverworld => true;

	public bool IsInCorruptedArea => true;

	public bool IsInMapRoom => true;

	public IEnumerable<Item> EquippedItems
	{
		[IteratorStateMachine(typeof(_003Cget_EquippedItems_003Ed__27))]
		get
		{
			return null;
		}
	}

	public int NumberOfDeployedBrand => 0;

	public int TotalCursesAllowed => 0;

	public IEnumerable<DatPassiveSkillWrapper> Passives
	{
		[IteratorStateMachine(typeof(_003Cget_Passives_003Ed__41))]
		get
		{
			return null;
		}
	}

	public List<DatPassiveSkillWrapper> PassiveSkills => null;

	public int PassiveSkillPointsAvailable => 0;

	public uint AscendencySkillPointsAvailable => 0u;

	public List<Item> EquippedSkillGems => null;

	public SpiritData GetSpirit(int weaponSet)
	{
		return (SpiritData)(object)null;
	}

	internal LocalPlayer(EntityWrapper entry)
	{
	}

	[SpecialName]
	private static IEnumerable<Inventory> smethod_28()
	{
		return null;
	}

	public Keys GetKeyForSkill(Skill skill)
	{
		return (Keys)(object)null;
	}

	public LokiPoe.Input.KeysCombo GetKeyComboForSkill(Skill skill)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetKeysForSkill_003Ed__34))]
	public IEnumerable<Keys> GetKeysForSkill(Skill skill)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetKeysComboForSkill_003Ed__35))]
	public IEnumerable<LokiPoe.Input.KeysCombo> GetKeysComboForSkill(Skill skill)
	{
		return null;
	}

	public Skill FromActionKey(ActionKeys key)
	{
		return null;
	}

	public Skill FromKey(Keys key)
	{
		return null;
	}

	public Skill FromKeyCombo(LokiPoe.Input.KeysCombo key)
	{
		return null;
	}

	public bool HasSkillOnBarByName(string name)
	{
		return true;
	}

	public bool HasPassive(string value)
	{
		return true;
	}

	public override string ToString()
	{
		return null;
	}

	private int method_12()
	{
		return 0;
	}

	static LocalPlayer()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_1 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_29()
	{
		return true;
	}

	internal static LocalPlayer smethod_30()
	{
		return null;
	}
}
