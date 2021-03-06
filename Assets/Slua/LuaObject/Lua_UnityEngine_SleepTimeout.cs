﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SleepTimeout : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.SleepTimeout o;
		if(matchType(l,1)){
			o=new UnityEngine.SleepTimeout();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_NeverSleep(IntPtr l) {
		pushValue(l,UnityEngine.SleepTimeout.NeverSleep);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_SystemSetting(IntPtr l) {
		pushValue(l,UnityEngine.SleepTimeout.SystemSetting);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SleepTimeout");
		addMember(l,get_NeverSleep, "get_NeverSleep");
		addMember(l,get_SystemSetting, "get_SystemSetting");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.SleepTimeout));
		LuaDLL.lua_pop(l, 1);
	}
}
