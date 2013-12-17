
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui
{
	public  class Button : global::UnityEngine.MonoBehaviour, global::haxe.lang.IHxObject 
	{
		public    Button(global::haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    Button() : base()
		{
			unchecked 
			{
				#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				this.prevState = false;
				#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				this.autoSwith = false;
				#line 49 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				this.tooltip = "";
				#line 48 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				this.panel = true;
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				this.defaultMode = 0;
				#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				this.core = new global::pony.ui.ButtonCore();
			}
			#line default
		}
		
		
		public static   object __hx_createEmpty()
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				return new global::pony.unity3d.ui.Button(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static   object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				return new global::pony.unity3d.ui.Button();
			}
			#line default
		}
		
		
		public  int defaultMode;
		
		public  bool panel;
		
		public  string tooltip;
		
		public  bool autoSwith;
		
		public  global::pony.ui.ButtonCore core;
		
		public  bool prevState;
		
		public virtual   void Start()
		{
			unchecked 
			{
				#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				this.core._set_mode(this.defaultMode);
				if (this.autoSwith) 
				{
					object __temp_stmt635 = default(object);
					#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					{
						#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("sw"), ((int) (25764) ))) ), 1);
						#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						__temp_stmt635 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
					}
					
					#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					this.core.click.@add(__temp_stmt635, default(global::haxe.lang.Null<int>));
				}
				
				#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				if ( ! (string.Equals(this.tooltip, "")) ) 
				{
					object __temp_stmt636 = default(object);
					#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					{
						#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						object f1 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("over"), ((int) (1236832596) ))) ), 0);
						#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						__temp_stmt636 = global::pony.events._Listener.Listener_Impl_._fromFunction(f1, false);
					}
					
					#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					this.core.change.subArgs(new global::Array<object>(new object[]{new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Focus})})).@add(__temp_stmt636, default(global::haxe.lang.Null<int>));
					object __temp_stmt637 = default(object);
					#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					{
						#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						object f2 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("out"), ((int) (5546126) ))) ), 0);
						#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						__temp_stmt637 = global::pony.events._Listener.Listener_Impl_._fromFunction(f2, false);
					}
					
					#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					this.core.change.subArgs(new global::Array<object>(new object[]{new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Default})})).@add(__temp_stmt637, default(global::haxe.lang.Null<int>));
					object __temp_stmt638 = default(object);
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					{
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						object f3 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("out"), ((int) (5546126) ))) ), 0);
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						__temp_stmt638 = global::pony.events._Listener.Listener_Impl_._fromFunction(f3, false);
					}
					
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					this.core.change.subArgs(new global::Array<object>(new object[]{new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Press})})).@add(__temp_stmt638, default(global::haxe.lang.Null<int>));
					object __temp_stmt639 = default(object);
					#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					{
						#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						object f4 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("out"), ((int) (5546126) ))) ), 0);
						#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						__temp_stmt639 = global::pony.events._Listener.Listener_Impl_._fromFunction(f4, false);
					}
					
					#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					this.core.change.subArgs(new global::Array<object>(new object[]{new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Leave})})).@add(__temp_stmt639, default(global::haxe.lang.Null<int>));
				}
				
			}
			#line default
		}
		
		
		public virtual   void @out()
		{
			unchecked 
			{
				#line 75 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				global::pony.unity3d.Tooltip.hideText(this);
			}
			#line default
		}
		
		
		public virtual   void over()
		{
			unchecked 
			{
				#line 79 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				global::pony.unity3d.Tooltip.showText(this.tooltip, "", this, new global::haxe.lang.Null<int>(this.gameObject.layer, true), new global::haxe.lang.Null<bool>(true, true));
			}
			#line default
		}
		
		
		public virtual   void sw(int mode)
		{
			unchecked 
			{
				#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				this.core._set_mode(( (( mode == 0 )) ? (2) : (( (( mode == 2 )) ? (0) : (mode) )) ));
			}
			#line default
		}
		
		
		public virtual   void Update()
		{
			unchecked 
			{
				#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				bool h = default(bool);
				#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				if (( this.panel ||  ! (global::pony.unity3d.Fixed2dCamera.exists)  )) 
				{
					h = ( this.guiTexture as global::UnityEngine.GUIElement ).HitTest(((global::UnityEngine.Vector3) (new global::UnityEngine.Vector3(((float) (( global::UnityEngine.Input.mousePosition.x - global::pony.unity3d.Fixed2dCamera.begin )) ), ((float) (global::UnityEngine.Input.mousePosition.y) ))) ));
				}
				 else 
				{
					h = ( this.guiTexture as global::UnityEngine.GUIElement ).HitTest(((global::UnityEngine.Vector3) (new global::UnityEngine.Vector3(((float) (( global::UnityEngine.Input.mousePosition.x + ( ((double) ((( global::UnityEngine.Screen.width - global::pony.unity3d.Fixed2dCamera.begin ))) ) / 2 ) )) ), ((float) (global::UnityEngine.Input.mousePosition.y) ))) ));
				}
				
				bool down = global::UnityEngine.Input.GetMouseButton(0);
				if (( this.prevState != h )) 
				{
					if (h) 
					{
						#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.core.mouseOver(down);
					}
					 else 
					{
						this.core.mouseOut();
					}
					
					this.prevState = h;
				}
				
				#line 96 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				if (down) 
				{
					#line 96 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					this.core.mouseDown();
				}
				 else 
				{
					this.core.mouseUp();
				}
				
			}
			#line default
		}
		
		
		public virtual   bool __hx_deleteField(string field, int hash)
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				return false;
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck)
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				if (isCheck) 
				{
					#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					return global::haxe.lang.Runtime.undefined;
				}
				 else 
				{
					#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					if (throwErrors) 
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						throw global::haxe.lang.HaxeException.wrap("Field not found.");
					}
					 else 
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return default(object);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   double __hx_lookupField_f(string field, int hash, bool throwErrors)
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				if (throwErrors) 
				{
					#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					throw global::haxe.lang.HaxeException.wrap("Field not found or incompatible field type.");
				}
				 else 
				{
					#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					return default(double);
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupSetField(string field, int hash, object @value)
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing.");
			}
			#line default
		}
		
		
		public virtual   double __hx_lookupSetField_f(string field, int hash, double @value)
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing or incompatible type.");
			}
			#line default
		}
		
		
		public virtual   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				switch (hash)
				{
					case 438291652:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.defaultMode = ((int) (@value) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					default:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.__hx_lookupSetField_f(field, hash, @value);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				switch (hash)
				{
					case 1575675685:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.hideFlags = ((global::UnityEngine.HideFlags) (@value) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					case 1224700491:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.name = global::haxe.lang.Runtime.toString(@value);
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					case 5790298:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.tag = global::haxe.lang.Runtime.toString(@value);
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					case 373703110:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.active = ((bool) (@value) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					case 2117141633:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.enabled = ((bool) (@value) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					case 896046654:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.useGUILayout = ((bool) (@value) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					case 1868699166:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.prevState = ((bool) (@value) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					case 1103412575:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.core = ((global::pony.ui.ButtonCore) (@value) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					case 1679321610:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.autoSwith = ((bool) (@value) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					case 1787604227:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.tooltip = global::haxe.lang.Runtime.toString(@value);
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					case 1028815620:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.panel = ((bool) (@value) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					case 438291652:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.defaultMode = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					default:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.__hx_lookupSetField(field, hash, @value);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				switch (hash)
				{
					case 1826409040:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetType"), ((int) (1826409040) ))) );
					}
					
					
					case 304123084:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("ToString"), ((int) (304123084) ))) );
					}
					
					
					case 276486854:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetInstanceID"), ((int) (276486854) ))) );
					}
					
					
					case 295397041:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetHashCode"), ((int) (295397041) ))) );
					}
					
					
					case 1955029599:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Equals"), ((int) (1955029599) ))) );
					}
					
					
					case 1575675685:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.hideFlags;
					}
					
					
					case 1224700491:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.name;
					}
					
					
					case 294420221:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessageUpwards"), ((int) (294420221) ))) );
					}
					
					
					case 139469119:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessage"), ((int) (139469119) ))) );
					}
					
					
					case 967979664:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentsInChildren"), ((int) (967979664) ))) );
					}
					
					
					case 2122408236:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponents"), ((int) (2122408236) ))) );
					}
					
					
					case 1328964235:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentInChildren"), ((int) (1328964235) ))) );
					}
					
					
					case 1723652455:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponent"), ((int) (1723652455) ))) );
					}
					
					
					case 89600725:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CompareTag"), ((int) (89600725) ))) );
					}
					
					
					case 2134927590:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("BroadcastMessage"), ((int) (2134927590) ))) );
					}
					
					
					case 5790298:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.tag;
					}
					
					
					case 373703110:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.active;
					}
					
					
					case 1471506513:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.gameObject;
					}
					
					
					case 1751728597:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.particleSystem;
					}
					
					
					case 524620744:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.particleEmitter;
					}
					
					
					case 964013983:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.hingeJoint;
					}
					
					
					case 1238753076:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.collider;
					}
					
					
					case 674101152:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.guiTexture;
					}
					
					
					case 262266241:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.guiElement;
					}
					
					
					case 1515196979:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.networkView;
					}
					
					
					case 801759432:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.guiText;
					}
					
					
					case 662730966:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.audio;
					}
					
					
					case 853263683:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.renderer;
					}
					
					
					case 1431885287:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.constantForce;
					}
					
					
					case 1261760260:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.animation;
					}
					
					
					case 1962709206:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.light;
					}
					
					
					case 931940005:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.camera;
					}
					
					
					case 1895479501:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.rigidbody;
					}
					
					
					case 1167273324:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.transform;
					}
					
					
					case 2117141633:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.enabled;
					}
					
					
					case 2084823382:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopCoroutine"), ((int) (2084823382) ))) );
					}
					
					
					case 1856815770:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopAllCoroutines"), ((int) (1856815770) ))) );
					}
					
					
					case 832859768:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine_Auto"), ((int) (832859768) ))) );
					}
					
					
					case 987108662:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine"), ((int) (987108662) ))) );
					}
					
					
					case 602588383:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("IsInvoking"), ((int) (602588383) ))) );
					}
					
					
					case 1641152943:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("InvokeRepeating"), ((int) (1641152943) ))) );
					}
					
					
					case 1416948632:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Invoke"), ((int) (1416948632) ))) );
					}
					
					
					case 757431474:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CancelInvoke"), ((int) (757431474) ))) );
					}
					
					
					case 896046654:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.useGUILayout;
					}
					
					
					case 999946793:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Update"), ((int) (999946793) ))) );
					}
					
					
					case 25764:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("sw"), ((int) (25764) ))) );
					}
					
					
					case 1236832596:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("over"), ((int) (1236832596) ))) );
					}
					
					
					case 5546126:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("out"), ((int) (5546126) ))) );
					}
					
					
					case 389604418:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Start"), ((int) (389604418) ))) );
					}
					
					
					case 1868699166:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.prevState;
					}
					
					
					case 1103412575:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.core;
					}
					
					
					case 1679321610:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.autoSwith;
					}
					
					
					case 1787604227:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.tooltip;
					}
					
					
					case 1028815620:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.panel;
					}
					
					
					case 438291652:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.defaultMode;
					}
					
					
					default:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.__hx_lookupField(field, hash, throwErrors, isCheck);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties)
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				switch (hash)
				{
					case 438291652:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((double) (this.defaultMode) );
					}
					
					
					default:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.__hx_lookupField_f(field, hash, throwErrors);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_invokeField(string field, int hash, global::Array dynargs)
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				switch (hash)
				{
					case 757431474:case 1416948632:case 1641152943:case 602588383:case 987108662:case 832859768:case 1856815770:case 2084823382:case 2134927590:case 89600725:case 1723652455:case 1328964235:case 2122408236:case 967979664:case 139469119:case 294420221:case 1955029599:case 295397041:case 276486854:case 304123084:case 1826409040:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 999946793:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.Update();
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						break;
					}
					
					
					case 25764:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.sw(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						break;
					}
					
					
					case 1236832596:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.over();
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						break;
					}
					
					
					case 5546126:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.@out();
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						break;
					}
					
					
					case 389604418:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.Start();
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						break;
					}
					
					
					default:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
					}
					
				}
				
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				return default(object);
			}
			#line default
		}
		
		
		public virtual   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("hideFlags");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("name");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("tag");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("active");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("gameObject");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("particleSystem");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("particleEmitter");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("hingeJoint");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("collider");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("guiTexture");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("guiElement");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("networkView");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("guiText");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("audio");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("renderer");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("constantForce");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("animation");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("light");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("camera");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("rigidbody");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("transform");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("enabled");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("useGUILayout");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("prevState");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("core");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("autoSwith");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("tooltip");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("panel");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("defaultMode");
			}
			#line default
		}
		
		
	}
}


