using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using ns0;

namespace DreamPoeBot.Loki.Common;

public static class Algorithms
{
	public class MaximalRectangle
	{
		[CompilerGenerated]
		private sealed class _003CFindMaximalRectanglesGreedy_003Ed__3 : IEnumerable<Tuple<Vector2i, Vector2i>>, IEnumerable, IEnumerator<Tuple<Vector2i, Vector2i>>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Tuple<Vector2i, Vector2i> _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public MaximalRectangle _003C_003E4__this;

			private Vector2i _003Cvector2i_003E5__2;

			private Vector2i _003Crs_003E5__3;

			private int _003Cnum_003E5__4;

			private Vector2i _003Cvector2i2_003E5__5;

			private static _003CFindMaximalRectanglesGreedy_003Ed__3 _003CFindMaximalRectanglesGreedy_003Ed__3_0;

			Tuple<Vector2i, Vector2i> IEnumerator<Tuple<Vector2i, Vector2i>>.Current => null;

			object IEnumerator.Current => null;

			public _003CFindMaximalRectanglesGreedy_003Ed__3(int _003C_003E1__state)
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

			IEnumerator<Tuple<Vector2i, Vector2i>> IEnumerable<Tuple<Vector2i, Vector2i>>.GetEnumerator()
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

			internal static _003CFindMaximalRectanglesGreedy_003Ed__3 smethod_1()
			{
				return null;
			}

			static _003CFindMaximalRectanglesGreedy_003Ed__3()
			{
				Class200.smethod_34();
			}
		}

		private readonly int int_0;

		private readonly BitArray bitArray_0;

		private readonly int int_1;

		internal static MaximalRectangle maximalRectangle_0;

		public MaximalRectangle(BitArray matrix, int width, int height)
		{
		}

		private bool method_0(int int_2, int int_3)
		{
			return true;
		}

		private int method_1(int int_2, int int_3)
		{
			return 0;
		}

		[IteratorStateMachine(typeof(_003CFindMaximalRectanglesGreedy_003Ed__3))]
		public IEnumerable<Tuple<Vector2i, Vector2i>> FindMaximalRectanglesGreedy()
		{
			return null;
		}

		private bool method_2(Vector2i vector2i_0, Vector2i vector2i_1)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static MaximalRectangle smethod_1()
		{
			return null;
		}

		static MaximalRectangle()
		{
			Class200.smethod_34();
		}
	}

	static Algorithms()
	{
		Class200.smethod_34();
	}
}
