﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_DepthTextureMode : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.DepthTextureMode o = (UnityEngine.DepthTextureMode)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.DepthTextureMode");
		LuaDLL.lua_pushinteger(l, 0);
		LuaDLL.lua_setfield(l, -2, "None");
		LuaDLL.lua_pushinteger(l, 1);
		LuaDLL.lua_setfield(l, -2, "Depth");
		LuaDLL.lua_pushinteger(l, 2);
		LuaDLL.lua_setfield(l, -2, "DepthNormals");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
