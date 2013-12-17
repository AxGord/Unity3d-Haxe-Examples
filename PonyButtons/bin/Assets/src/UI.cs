
#pragma warning disable 109, 114, 219, 429, 168, 162
public  class UI : global::haxe.lang.HxObject, global::pony.magic.StaticInit 
{
	public    UI(global::haxe.lang.EmptyObject empty)
	{
		unchecked 
		{
			#line 11 "src/UI.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public    UI()
	{
		unchecked 
		{
			#line 11 "src/UI.hx"
			global::UI.__hx_ctor__UI(this);
		}
		#line default
	}
	
	
	public static   void __hx_ctor__UI(global::UI __temp_me13)
	{
		unchecked 
		{
			#line 11 "src/UI.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public static  global::pony.ui.ButtonCore defaultButton;
	
	public static  global::pony.ui.ButtonCore tintButton;
	
	public static   void initStatic()
	{
		unchecked 
		{
			#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/magic/StaticInit.hx"
			global::UI.defaultButton = ((global::pony.unity3d.ui.TintButton) (global::hugs.GameObjectMethods.getTypedComponent<object>(global::UnityEngine.GameObject.Find("default"), typeof(global::pony.unity3d.ui.TintButton))) ).core;
			#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/magic/StaticInit.hx"
			global::UI.tintButton = ((global::pony.unity3d.ui.TintButton) (global::hugs.GameObjectMethods.getTypedComponent<object>(global::UnityEngine.GameObject.Find("tint"), typeof(global::pony.unity3d.ui.TintButton))) ).core;
		}
		#line default
	}
	
	
	public static  new object __hx_createEmpty()
	{
		unchecked 
		{
			#line 11 "src/UI.hx"
			return new global::UI(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
		}
		#line default
	}
	
	
	public static  new object __hx_create(global::Array arr)
	{
		unchecked 
		{
			#line 11 "src/UI.hx"
			return new global::UI();
		}
		#line default
	}
	
	
}


