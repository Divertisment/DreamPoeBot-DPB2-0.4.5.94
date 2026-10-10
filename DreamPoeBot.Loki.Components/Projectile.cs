using System.Runtime.InteropServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game.Objects;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Projectile : Component
{
	[StructLayout(LayoutKind.Explicit, Size = 88)]
	internal struct Struct241
	{
		[FieldOffset(0)]
		public uint uint_0;

		[FieldOffset(40)]
		public long Value;

		[FieldOffset(72)]
		public byte byte_0;
	}

	[StructLayout(LayoutKind.Explicit, Size = 1176)]
	private struct Struct242
	{
		[FieldOffset(0)]
		public long long_0;

		[FieldOffset(8)]
		public long long_1;

		[FieldOffset(1100)]
		public float float_0;

		[FieldOffset(1168)]
		public Vector2 Center;
	}

	private PerFrameCachedValue<ProjectileSnapshot> perFrameCachedValue_0;

	private long long_2;

	private long long_3;

	private int int_0;

	internal static Projectile projectile_0;

	public ProjectileSnapshot Snapshot => null;

	public NetworkObject Caster => null;

	public Vector2 Center => (Vector2)(object)null;

	public Vector2 Direction => (Vector2)(object)null;

	public Vector2 GetPointAlongTrajectory(float distance)
	{
		return (Vector2)(object)null;
	}

	private bool method_2()
	{
		return true;
	}

	private ProjectileSnapshot method_3()
	{
		return null;
	}

	internal static bool smethod_4(Struct241[] struct241_0, out long long_4, out int int_1)
	{
		return true;
	}

	internal static bool smethod_5()
	{
		return true;
	}

	internal static Projectile smethod_6()
	{
		return null;
	}

	static Projectile()
	{
		Class200.smethod_34();
	}
}
