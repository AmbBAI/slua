﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_OffMeshLinkType : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.OffMeshLinkType o = (UnityEngine.OffMeshLinkType)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.OffMeshLinkType");
		LuaDLL.lua_pushinteger(l, 0);
		LuaDLL.lua_setfield(l, -2, "LinkTypeManual");
		LuaDLL.lua_pushinteger(l, 1);
		LuaDLL.lua_setfield(l, -2, "LinkTypeDropDown");
		LuaDLL.lua_pushinteger(l, 2);
		LuaDLL.lua_setfield(l, -2, "LinkTypeJumpAcross");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
