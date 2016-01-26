/*
The MIT License (MIT)

Copyright (c) 2016 Orbital Games, LLC.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System;

namespace OrbitalGames.SystemExtensions
{
	public static class DateTimeExtensions
	{
		/// <summary>DateTime representing unix time 0</summary>
		public static readonly DateTime UNIX_EPOCH = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

		/// <summary>
		/// Gets the unix time representation; i.e., the number of seconds since January 1st, 1970 UTC
		/// </summary>
		/// <param name="instance">The DateTime instance on which to operate</param>
		/// <returns>Unix time representation of given DateTime</returns>
		public static Int64 GetUnixTime(this DateTime instance)
		{
			return (Int64)((instance - UNIX_EPOCH).TotalSeconds);
		}

		/// <summary>
		/// Converts a unix time to a DateTime
		/// </summary>
		/// <param name="unixTime">Unix time; i.e., number of seconds since January 1st, 1970 UTC</param>
		/// <returns>DateTime representation of the given unix time</returns>
		public static DateTime FromUnixTime(Int64 unixTime)
		{
			return UNIX_EPOCH.AddSeconds((double)unixTime);
		}
	}
}
