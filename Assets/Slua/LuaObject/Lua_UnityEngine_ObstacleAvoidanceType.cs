﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ObstacleAvoidanceType : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.ObstacleAvoidanceType o = (UnityEngine.ObstacleAvoidanceType)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ObstacleAvoidanceType");
		LuaDLL.lua_pushinteger(l, 0);
		LuaDLL.lua_setfield(l, -2, "NoObstacleAvoidance");
		LuaDLL.lua_pushinteger(l, 1);
		LuaDLL.lua_setfield(l, -2, "LowQualityObstacleAvoidance");
		LuaDLL.lua_pushinteger(l, 2);
		LuaDLL.lua_setfield(l, -2, "MedQualityObstacleAvoidance");
		LuaDLL.lua_pushinteger(l, 3);
		LuaDLL.lua_setfield(l, -2, "GoodQualityObstacleAvoidance");
		LuaDLL.lua_pushinteger(l, 4);
		LuaDLL.lua_setfield(l, -2, "HighQualityObstacleAvoidance");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
