﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_MatchTargetWeightMask : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.MatchTargetWeightMask o;
		if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(System.Single))){
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			o=new UnityEngine.MatchTargetWeightMask(a1,a2);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_positionXYZWeight(IntPtr l) {
		UnityEngine.MatchTargetWeightMask o = checkSelf<UnityEngine.MatchTargetWeightMask>(l);
		pushValue(l,o.positionXYZWeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_positionXYZWeight(IntPtr l) {
		UnityEngine.MatchTargetWeightMask o = checkSelf<UnityEngine.MatchTargetWeightMask>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.positionXYZWeight=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotationWeight(IntPtr l) {
		UnityEngine.MatchTargetWeightMask o = checkSelf<UnityEngine.MatchTargetWeightMask>(l);
		pushValue(l,o.rotationWeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotationWeight(IntPtr l) {
		UnityEngine.MatchTargetWeightMask o = checkSelf<UnityEngine.MatchTargetWeightMask>(l);
		System.Single v;
		checkType(l,2,out v);
		o.rotationWeight=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.MatchTargetWeightMask");
		addMember(l,get_positionXYZWeight, "get_positionXYZWeight");
		addMember(l,set_positionXYZWeight, "set_positionXYZWeight");
		addMember(l,get_rotationWeight, "get_rotationWeight");
		addMember(l,set_rotationWeight, "set_rotationWeight");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.MatchTargetWeightMask));
		LuaDLL.lua_pop(l, 1);
	}
}
