
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d
{
	public  class StaticAccess : global::haxe.lang.HxObject 
	{
		public    StaticAccess(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/StaticAccess.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    StaticAccess()
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/StaticAccess.hx"
				global::pony.unity3d.StaticAccess.__hx_ctor_pony_unity3d_StaticAccess(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_pony_unity3d_StaticAccess(global::pony.unity3d.StaticAccess __temp_me121)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/StaticAccess.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static   T component<T>(string gameObject, global::System.Type cl)
		{
			unchecked 
			{
				#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/StaticAccess.hx"
				return global::haxe.lang.Runtime.genericCast<T>(global::hugs.GameObjectMethods.getTypedComponent<object>(global::UnityEngine.GameObject.Find(gameObject), cl));
			}
			#line default
		}
		
		
		public static   global::pony.ui.ButtonCore tintButton(string gameObject)
		{
			unchecked 
			{
				#line 60 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/StaticAccess.hx"
				return ((global::pony.unity3d.ui.TintButton) (global::hugs.GameObjectMethods.getTypedComponent<object>(global::UnityEngine.GameObject.Find(gameObject), typeof(global::pony.unity3d.ui.TintButton))) ).core;
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/StaticAccess.hx"
				return new global::pony.unity3d.StaticAccess(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/StaticAccess.hx"
				return new global::pony.unity3d.StaticAccess();
			}
			#line default
		}
		
		
	}
}


