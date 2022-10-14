﻿partial struct PSTR
{
	public static implicit operator PCSTR(PSTR value) => new PCSTR(value.Value);

	/// <inheritdoc cref="PCSTR.Length"/>
	internal int Length => new PCSTR(this.Value).Length;

	/// <inheritdoc cref="PCSTR.ToString()"/>
	public override string ToString() => new PCSTR(this.Value).ToString();

#if canUseSpan
	/// <summary>
	/// Returns a span of the characters in this string.
	/// </summary>
	internal Span<byte> AsSpan() => this.Value is null ? default(Span<byte>) : new Span<byte>(this.Value, this.Length);
#endif
}
