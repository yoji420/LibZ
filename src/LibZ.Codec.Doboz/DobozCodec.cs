﻿#region License

/*
 * Copyright (c) 2013-2014, Milosz Krajewski
 * 
 * Microsoft Public License (Ms-PL)
 * This license governs use of the accompanying software. 
 * If you use the software, you accept this license. 
 * If you do not accept the license, do not use the software.
 * 
 * 1. Definitions
 * The terms "reproduce," "reproduction," "derivative works," and "distribution" have the same 
 * meaning here as under U.S. copyright law.
 * A "contribution" is the original software, or any additions or changes to the software.
 * A "contributor" is any person that distributes its contribution under this license.
 * "Licensed patents" are a contributor's patent claims that read directly on its contribution.
 * 
 * 2. Grant of Rights
 * (A) Copyright Grant- Subject to the terms of this license, including the license conditions 
 * and limitations in section 3, each contributor grants you a non-exclusive, worldwide, 
 * royalty-free copyright license to reproduce its contribution, prepare derivative works of 
 * its contribution, and distribute its contribution or any derivative works that you create.
 * (B) Patent Grant- Subject to the terms of this license, including the license conditions and 
 * limitations in section 3, each contributor grants you a non-exclusive, worldwide, 
 * royalty-free license under its licensed patents to make, have made, use, sell, offer for sale, 
 * import, and/or otherwise dispose of its contribution in the software or derivative works of 
 * the contribution in the software.
 * 
 * 3. Conditions and Limitations
 * (A) No Trademark License- This license does not grant you rights to use any contributors' name, 
 * logo, or trademarks.
 * (B) If you bring a patent claim against any contributor over patents that you claim are infringed 
 * by the software, your patent license from such contributor to the software ends automatically.
 * (C) If you distribute any portion of the software, you must retain all copyright, patent, trademark, 
 * and attribution notices that are present in the software.
 * (D) If you distribute any portion of the software in source code form, you may do so only under this 
 * license by including a complete copy of this license with your distribution. If you distribute 
 * any portion of the software in compiled or object code form, you may only do so under a license 
 * that complies with this license.
 * (E) The software is licensed "as-is." You bear the risk of using it. The contributors give no express
 * warranties, guarantees or conditions. You may have additional consumer rights under your local 
 * laws which this license cannot change. To the extent permitted under your local laws, the 
 * contributors exclude the implied warranties of merchantability, fitness for a particular 
 * purpose and non-infringement.
 */

#endregion

using System;
using System.ComponentModel.Composition;
using LibZ.Tool.Interfaces;

namespace LibZ.Codec.Doboz
{
	/// <summary>Demo LZ4 codec.</summary>
	[Export(typeof(ICodec))]
	public class DobozCodec: ICodec
	{
		#region ICodec Members

		/// <summary>Initializes the codec.
		/// Leave it empty if initialization is not needed.</summary>
		public void Initialize()
		{
			Console.WriteLine("Doboz initialized as '{0}'", global::Doboz.DobozCodec.CodecName);
		}

		/// <summary>Gets the name.</summary>
		/// <value>The name.</value>
		public string Name
		{
			get { return "doboz"; }
		}

		/// <summary>Encodes the specified input data.</summary>
		/// <param name="inputData">The input data.</param>
		/// <returns>Encodec data.</returns>
		public byte[] Encode(byte[] inputData)
		{
			return global::Doboz.DobozCodec.Encode(inputData, 0, inputData.Length);
		}

		/// <summary>Decodes the specified input data.</summary>
		/// <param name="inputData">The input data.</param>
		/// <param name="outputLength">Length of the output.</param>
		/// <returns>Decoded data.</returns>
		public byte[] Decode(byte[] inputData, int outputLength)
		{
			return global::Doboz.DobozCodec.Decode(inputData, 0, inputData.Length);
		}

		#endregion
	}
}
