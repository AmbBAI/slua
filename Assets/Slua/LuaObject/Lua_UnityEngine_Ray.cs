﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Ray : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Ray o;
		if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3))){
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			o=new UnityEngine.Ray(a1,a2);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPoint(IntPtr l) {
		try{
			UnityEngine.Ray self=checkSelf<UnityEngine.Ray>(l);
			System.Single a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 ret=self.GetPoint(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_origin(IntPtr l) {
		UnityEngine.Ray o = checkSelf<UnityEngine.Ray>(l);
		pushValue(l,o.origin);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_origin(IntPtr l) {
		UnityEngine.Ray o = checkSelf<UnityEngine.Ray>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.origin=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_direction(IntPtr l) {
		UnityEngine.Ray o = checkSelf<UnityEngine.Ray>(l);
		pushValue(l,o.direction);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_direction(IntPtr l) {
		UnityEngine.Ray o = checkSelf<UnityEngine.Ray>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.direction=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Ray");
		addMember(l,GetPoint, "GetPoint");
		addMember(l,get_origin, "get_origin");
		addMember(l,set_origin, "set_origin");
		addMember(l,get_direction, "get_direction");
		addMember(l,set_direction, "set_direction");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Ray));
		LuaDLL.lua_pop(l, 1);
	}
}
