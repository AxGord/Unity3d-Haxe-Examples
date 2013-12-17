
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui
{
	public  class TintButton : global::pony.unity3d.ui.Button 
	{
		public    TintButton(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    TintButton() : base()
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				this.tint = ((float) (0.2) );
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				return new global::pony.unity3d.ui.TintButton(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				return new global::pony.unity3d.ui.TintButton();
			}
			#line default
		}
		
		
		public  float tint;
		
		public  global::UnityEngine.Texture pressedTexture;
		
		public  global::UnityEngine.Texture disabledTexture;
		
		public  global::UnityEngine.Texture secondPressedTexture;
		
		public  global::UnityEngine.Texture secondState;
		
		public  global::UnityEngine.Texture defaultTexture;
		
		public  global::UnityEngine.Texture overTexture;
		
		public  global::UnityEngine.Texture secondOverTexture;
		
		public  global::UnityEngine.Color sclr;
		
		public  global::UnityEngine.GameObject overObj;
		
		public  global::UnityEngine.GameObject secondOverObj;
		
		public  global::UnityEngine.GameObject pressObj;
		
		public  global::UnityEngine.GameObject secondPressObj;
		
		public override   void Start()
		{
			unchecked 
			{
				#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				base.Start();
				this.defaultTexture = this.guiTexture.texture;
				this.sclr = this.guiTexture.color;
				this.core.changeVisual.@add(global::pony.events._Listener.Listener_Impl_._fromFunction(global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("change"), ((int) (930255216) ))) ), 1), true), default(global::haxe.lang.Null<int>));
				{
					#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
					global::pony.ui.ButtonCore _this = this.core;
					#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
					{
						#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						global::Array args = new global::Array<object>(new object[]{_this._get_visualState(), _this.mode, false});
						#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						global::pony.events.Signal _this1 = _this.changeVisual;
						#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						_this1.dispatchEvent(new global::pony.events.Event(((global::Array) (args) ), ((object) (_this1.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
						#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						global::pony.events.Signal __temp_expr641 = _this1;
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   void change(global::pony.events.Event @event)
		{
			unchecked 
			{
				#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				if (( this.overObj != default(global::UnityEngine.GameObject) )) 
				{
					#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
					this.overObj.active = false;
				}
				
				if (( this.secondOverObj != default(global::UnityEngine.GameObject) )) 
				{
					#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
					this.secondOverObj.active = false;
				}
				
				if (( this.pressObj != default(global::UnityEngine.GameObject) )) 
				{
					#line 72 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
					this.pressObj.active = false;
				}
				
				if (( this.secondPressObj != default(global::UnityEngine.GameObject) )) 
				{
					#line 73 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
					this.secondPressObj.active = false;
				}
				
				#line 75 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				if (global::haxe.lang.Runtime.eq(@event.args[1], 1)) 
				{
					if (( this.pressedTexture != default(global::UnityEngine.Texture) )) 
					{
						if (( this.disabledTexture != default(global::UnityEngine.Texture) )) 
						{
							#line 77 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
							this.guiTexture.texture = this.disabledTexture;
						}
						 else 
						{
							#line 77 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
							this.guiTexture.texture = this.pressedTexture;
						}
						
						this.guiTexture.color = this.sclr;
					}
					 else 
					{
						this.guiTexture.color = new global::UnityEngine.Color(((float) (( this.sclr.r - ( ((double) (this.tint) ) / 2 ) )) ), ((float) (( this.sclr.g - ( ((double) (this.tint) ) / 2 ) )) ), ((float) (( this.sclr.b - ( ((double) (this.tint) ) / 2 ) )) ));
					}
					
					return ;
				}
				
				#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				if (( global::haxe.lang.Runtime.eq(@event.args[1], 2) && ( this.secondState != default(global::UnityEngine.Texture) ) )) 
				{
					this.guiTexture.texture = this.secondState;
				}
				 else 
				{
					if (( ( this.pressedTexture != default(global::UnityEngine.Texture) ) || ( this.secondState != default(global::UnityEngine.Texture) ) )) 
					{
						this.guiTexture.texture = this.defaultTexture;
					}
					
				}
				
				#line 88 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				{
					#line 88 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
					global::pony.ui.ButtonStates _g = default(global::pony.ui.ButtonStates);
					#line 88 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
					_g = ((global::pony.ui.ButtonStates) (@event.args[0]) );
					#line 88 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
					switch (global::Type.enumIndex(_g))
					{
						case 1:case 2:
						{
							#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
							if (( global::haxe.lang.Runtime.eq(@event.args[1], 2) && ( this.secondOverObj != default(global::UnityEngine.GameObject) ) )) 
							{
								this.secondOverObj.active = true;
								this.guiTexture.texture = default(global::UnityEngine.Texture);
							}
							 else 
							{
								if (( global::haxe.lang.Runtime.eq(@event.args[1], 2) && ( this.secondOverTexture != default(global::UnityEngine.Texture) ) )) 
								{
									this.guiTexture.texture = this.secondOverTexture;
									this.guiTexture.color = new global::UnityEngine.Color(((float) (( this.sclr.r - ( ((double) (this.tint) ) / 2 ) )) ), ((float) (( this.sclr.g - ( ((double) (this.tint) ) / 2 ) )) ), ((float) (( this.sclr.b - ( ((double) (this.tint) ) / 2 ) )) ));
								}
								 else 
								{
									if (( this.overObj != default(global::UnityEngine.GameObject) )) 
									{
										this.overObj.active = true;
										this.guiTexture.texture = default(global::UnityEngine.Texture);
									}
									 else 
									{
										if (( this.overTexture != default(global::UnityEngine.Texture) )) 
										{
											this.guiTexture.texture = this.overTexture;
											this.guiTexture.color = new global::UnityEngine.Color(((float) (( this.sclr.r - ( ((double) (this.tint) ) / 2 ) )) ), ((float) (( this.sclr.g - ( ((double) (this.tint) ) / 2 ) )) ), ((float) (( this.sclr.b - ( ((double) (this.tint) ) / 2 ) )) ));
										}
										 else 
										{
											#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
											this.guiTexture.color = new global::UnityEngine.Color(((float) (( this.sclr.r + this.tint )) ), ((float) (( this.sclr.g + this.tint )) ), ((float) (( this.sclr.b + this.tint )) ));
										}
										
									}
									
								}
								
							}
							
							#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
							break;
						}
						
						
						case 0:
						{
							#line 105 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
							this.guiTexture.color = this.sclr;
							#line 105 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
							break;
						}
						
						
						case 3:
						{
							#line 107 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
							if (( global::haxe.lang.Runtime.eq(@event.args[1], 2) && ( this.secondPressObj != default(global::UnityEngine.GameObject) ) )) 
							{
								this.secondPressObj.active = true;
								this.guiTexture.texture = default(global::UnityEngine.Texture);
							}
							 else 
							{
								if (( global::haxe.lang.Runtime.eq(@event.args[1], 2) && ( this.secondPressedTexture != default(global::UnityEngine.Texture) ) )) 
								{
									this.guiTexture.texture = this.secondPressedTexture;
									this.guiTexture.color = new global::UnityEngine.Color(((float) (( this.sclr.r - ( ((double) (this.tint) ) / 2 ) )) ), ((float) (( this.sclr.g - ( ((double) (this.tint) ) / 2 ) )) ), ((float) (( this.sclr.b - ( ((double) (this.tint) ) / 2 ) )) ));
								}
								 else 
								{
									if (( this.pressObj != default(global::UnityEngine.GameObject) )) 
									{
										this.pressObj.active = true;
										this.guiTexture.texture = default(global::UnityEngine.Texture);
									}
									 else 
									{
										if (( this.pressedTexture != default(global::UnityEngine.Texture) )) 
										{
											this.guiTexture.texture = this.pressedTexture;
											this.guiTexture.color = new global::UnityEngine.Color(((float) (( this.sclr.r - ( ((double) (this.tint) ) / 2 ) )) ), ((float) (( this.sclr.g - ( ((double) (this.tint) ) / 2 ) )) ), ((float) (( this.sclr.b - ( ((double) (this.tint) ) / 2 ) )) ));
										}
										 else 
										{
											#line 120 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
											this.guiTexture.color = new global::UnityEngine.Color(((float) (( this.sclr.r - this.tint )) ), ((float) (( this.sclr.g - this.tint )) ), ((float) (( this.sclr.b - this.tint )) ));
										}
										
									}
									
								}
								
							}
							
							#line 107 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
							break;
						}
						
						
					}
					
				}
				
			}
			#line default
		}
		
		
		public   void restoreColor()
		{
			unchecked 
			{
				#line 125 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				this.guiTexture.color = new global::UnityEngine.Color(((float) (( this.sclr.r - ( ((double) (this.tint) ) / 2 ) )) ), ((float) (( this.sclr.g - ( ((double) (this.tint) ) / 2 ) )) ), ((float) (( this.sclr.b - ( ((double) (this.tint) ) / 2 ) )) ));
			}
			#line default
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				switch (hash)
				{
					case 1291635963:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						this.tint = ((float) (@value) );
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return @value;
					}
					
					
					default:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				switch (hash)
				{
					case 373614536:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						this.secondPressObj = ((global::UnityEngine.GameObject) (@value) );
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return @value;
					}
					
					
					case 1879099444:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						this.pressObj = ((global::UnityEngine.GameObject) (@value) );
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return @value;
					}
					
					
					case 1845965295:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						this.secondOverObj = ((global::UnityEngine.GameObject) (@value) );
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return @value;
					}
					
					
					case 687489795:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						this.overObj = ((global::UnityEngine.GameObject) (@value) );
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return @value;
					}
					
					
					case 1280247574:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						this.sclr = ((global::UnityEngine.Color) (@value) );
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return @value;
					}
					
					
					case 475514579:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						this.secondOverTexture = ((global::UnityEngine.Texture) (@value) );
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return @value;
					}
					
					
					case 548073959:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						this.overTexture = ((global::UnityEngine.Texture) (@value) );
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return @value;
					}
					
					
					case 1310794266:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						this.defaultTexture = ((global::UnityEngine.Texture) (@value) );
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return @value;
					}
					
					
					case 313037309:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						this.secondState = ((global::UnityEngine.Texture) (@value) );
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return @value;
					}
					
					
					case 1134796013:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						this.secondPressedTexture = ((global::UnityEngine.Texture) (@value) );
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return @value;
					}
					
					
					case 1008146111:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						this.disabledTexture = ((global::UnityEngine.Texture) (@value) );
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return @value;
					}
					
					
					case 1855297113:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						this.pressedTexture = ((global::UnityEngine.Texture) (@value) );
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return @value;
					}
					
					
					case 1291635963:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						this.tint = ((float) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return @value;
					}
					
					
					default:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				switch (hash)
				{
					case 651837237:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("restoreColor"), ((int) (651837237) ))) );
					}
					
					
					case 930255216:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("change"), ((int) (930255216) ))) );
					}
					
					
					case 389604418:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Start"), ((int) (389604418) ))) );
					}
					
					
					case 373614536:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return this.secondPressObj;
					}
					
					
					case 1879099444:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return this.pressObj;
					}
					
					
					case 1845965295:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return this.secondOverObj;
					}
					
					
					case 687489795:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return this.overObj;
					}
					
					
					case 1280247574:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return this.sclr;
					}
					
					
					case 475514579:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return this.secondOverTexture;
					}
					
					
					case 548073959:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return this.overTexture;
					}
					
					
					case 1310794266:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return this.defaultTexture;
					}
					
					
					case 313037309:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return this.secondState;
					}
					
					
					case 1134796013:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return this.secondPressedTexture;
					}
					
					
					case 1008146111:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return this.disabledTexture;
					}
					
					
					case 1855297113:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return this.pressedTexture;
					}
					
					
					case 1291635963:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return this.tint;
					}
					
					
					default:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				switch (hash)
				{
					case 1291635963:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return ((double) (this.tint) );
					}
					
					
					default:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::Array dynargs)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				switch (hash)
				{
					case 389604418:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 651837237:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						this.restoreColor();
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						break;
					}
					
					
					case 930255216:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						this.change(((global::pony.events.Event) (dynargs[0]) ));
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						break;
					}
					
					
					default:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				return default(object);
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				baseArr.push("secondPressObj");
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				baseArr.push("pressObj");
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				baseArr.push("secondOverObj");
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				baseArr.push("overObj");
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				baseArr.push("sclr");
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				baseArr.push("secondOverTexture");
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				baseArr.push("overTexture");
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				baseArr.push("defaultTexture");
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				baseArr.push("secondState");
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				baseArr.push("secondPressedTexture");
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				baseArr.push("disabledTexture");
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				baseArr.push("pressedTexture");
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				baseArr.push("tint");
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				{
					#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}


