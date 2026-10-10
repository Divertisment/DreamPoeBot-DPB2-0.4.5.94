using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DreamPoeBot.Common;
using ns0;

namespace DreamPoeBot.DreamPoe;

public partial class GlobalSettingsGui : UserControl, IComponentConnector
{
	internal class Class169
	{
		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private int int_2;

		[CompilerGenerated]
		private string string_2;

		[CompilerGenerated]
		private string string_3;

		[CompilerGenerated]
		private Vector2i vector2i_0;

		[CompilerGenerated]
		private Vector2i vector2i_1;

		[CompilerGenerated]
		private Vector2i vector2i_2;

		internal static Class169 class169_0;

		public string Data
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int Rows
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector2i Start
		{
			[CompilerGenerated]
			get
			{
				return (Vector2i)(object)null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector2i End
		{
			[CompilerGenerated]
			get
			{
				return (Vector2i)(object)null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public string method_0()
		{
			return null;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_1(string string_4)
		{
		}

		[SpecialName]
		[CompilerGenerated]
		public int method_2()
		{
			return 0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_3(int int_3)
		{
		}

		[SpecialName]
		[CompilerGenerated]
		public int method_4()
		{
			return 0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_5(int int_3)
		{
		}

		[SpecialName]
		[CompilerGenerated]
		public string method_6()
		{
			return null;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_7(string string_4)
		{
		}

		[SpecialName]
		[CompilerGenerated]
		public string method_8()
		{
			return null;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_9(string string_4)
		{
		}

		[SpecialName]
		[CompilerGenerated]
		public Vector2i method_10()
		{
			return (Vector2i)(object)null;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_11(Vector2i vector2i_3)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class169 smethod_1()
		{
			return null;
		}

		static Class169()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDumpTerrainData_OnClick_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private TaskAwaiter _003C_003Eu__1;

		private static object object_0;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static _003CDumpTerrainData_OnClick_003Ed__4()
		{
			Class200.smethod_34();
		}
	}

	internal Slider BackgroundFpsStepSlider;

	internal Slider HumanLikeMouseMaxStepSlider;

	private bool bool_0;

	internal static GlobalSettingsGui globalSettingsGui_0;

	public GlobalSettingsGui(object context)
	{
	}

	private void method_0(object sender, SelectionChangedEventArgs e)
	{
	}

	private void method_1(object sender, SelectionChangedEventArgs e)
	{
	}

	private void method_2(object sender, RoutedEventArgs e)
	{
	}

	[AsyncStateMachine(typeof(_003CDumpTerrainData_OnClick_003Ed__4))]
	private void method_3(object sender, RoutedEventArgs e)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static GlobalSettingsGui smethod_1()
	{
		return null;
	}

	static GlobalSettingsGui()
	{
		Class200.smethod_34();
	}
}
