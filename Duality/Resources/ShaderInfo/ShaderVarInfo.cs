﻿using System;
using System.Collections.Generic;
using System.Linq;

using Duality.Drawing;


namespace Duality.Resources
{
	/// <summary>
	/// Provides information about a <see cref="AbstractShader">shader</see> variable.
	/// </summary>
	public struct ShaderVarInfo
	{
		/// <summary>
		/// The default variable name for a materials main texture.
		/// </summary>
		public const string VarName_MainTex = "mainTex";

		/// <summary>
		/// The <see cref="ShaderVarScope">scope</see> of the variable
		/// </summary>
		public	ShaderVarScope	Scope;
		/// <summary>
		/// The <see cref="ShaderVarType">type</see> of the variable
		/// </summary>
		public	ShaderVarType	Type;
		/// <summary>
		/// If the variable is an array, this is its length. Arrays
		/// are only supported for <see cref="ShaderVarType.Int"/> and
		/// <see cref="ShaderVarType.Float"/>.
		/// </summary>
		public	int				ArrayLength;
		/// <summary>
		/// The name of the variable, as declared in the shader.
		/// </summary>
		public	string			Name;
		/// <summary>
		/// OpenGL handle of the variables memory location.
		/// </summary>
		public	int				Handle;

		/// <summary>
		/// [GET] Returns whether the shader variable should be considered private.
		/// </summary>
		public bool IsPrivate
		{
			get { return string.IsNullOrEmpty(this.Name) || this.Name[0] == '_'; }
		}

		public override string ToString()
		{
			return string.Format("{1} {0}{2}", 
				this.Name, 
				this.Type, 
				this.ArrayLength > 1 ? string.Format("[{0}]", this.ArrayLength) : "");
		}
	}
}
