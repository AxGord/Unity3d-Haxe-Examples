
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events
{
	public  class Signal : global::haxe.lang.HxObject 
	{
		public    Signal(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    Signal(object target)
		{
			unchecked 
			{
				#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::pony.events.Signal.__hx_ctor_pony_events_Signal(this, target);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_pony_events_Signal(global::pony.events.Signal __temp_me73, object target)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				__temp_me73.silent = false;
				#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				__temp_me73.subMap = new global::pony.Dictionary<object, object>(new global::haxe.lang.Null<int>(5, true));
				{
					#line 60 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					__temp_me73.target = target;
					#line 60 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					__temp_me73.listeners = new global::pony.Priority<object>(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (default(global::Array<object>)) ))) ));
					#line 60 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					__temp_me73.lRunCopy = new global::List<object>();
					#line 60 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal __temp_expr352 = __temp_me73;
				}
				
				{
					#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal s = default(global::pony.events.Signal);
					#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.events.Signal _this = ((global::pony.events.Signal) (global::Type.createEmptyInstance<object>(typeof(global::pony.events.Signal))) );
						#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						_this.target = __temp_me73;
						#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						_this.listeners = new global::pony.Priority<object>(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (default(global::Array<object>)) ))) ));
						#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						_this.lRunCopy = new global::List<object>();
						#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						s = _this;
					}
					
					#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					__temp_me73.lostListeners = ((global::pony.events.Signal) (s) );
				}
				
				{
					#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal s1 = default(global::pony.events.Signal);
					#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.events.Signal _this1 = ((global::pony.events.Signal) (global::Type.createEmptyInstance<object>(typeof(global::pony.events.Signal))) );
						#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						_this1.target = __temp_me73;
						#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						_this1.listeners = new global::pony.Priority<object>(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (default(global::Array<object>)) ))) ));
						#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						_this1.lRunCopy = new global::List<object>();
						#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						s1 = _this1;
					}
					
					#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					__temp_me73.takeListeners = ((global::pony.events.Signal) (s1) );
				}
				
			}
			#line default
		}
		
		
		public static   global::pony.events.Signal create<A>(A t)
		{
			unchecked 
			{
				#line 285 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
					#line 285 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal s = new global::pony.events.Signal(((object) (t) ));
					#line 285 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					return s;
				}
				
			}
			#line default
		}
		
		
		public static   global::pony.events.Signal createEmpty()
		{
			unchecked 
			{
				#line 290 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
					#line 290 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal s = new global::pony.events.Signal(((object) (default(object)) ));
					#line 290 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					return s;
				}
				
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return new global::pony.events.Signal(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return new global::pony.events.Signal(((object) (arr[0]) ));
			}
			#line default
		}
		
		
		public  bool silent;
		
		public  global::pony.events.Signal lostListeners;
		
		public  global::pony.events.Signal takeListeners;
		
		public  object data;
		
		public  object target;
		
		public  global::pony.Priority<object> listeners;
		
		public  global::List<object> lRunCopy;
		
		public  global::pony.Dictionary<object, object> subMap;
		
		public  bool haveListeners;
		
		public   global::pony.events.Signal init(object target)
		{
			unchecked 
			{
				#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.target = target;
				this.listeners = new global::pony.Priority<object>(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (default(global::Array<object>)) ))) ));
				this.lRunCopy = new global::List<object>();
				return this;
			}
			#line default
		}
		
		
		public virtual   global::pony.events.Signal @add(object listener, global::haxe.lang.Null<int> priority)
		{
			unchecked 
			{
				#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				int __temp_priority70 = ( (global::haxe.lang.Runtime.eq((priority).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (priority.@value) );
				{
					#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object __temp_getvar143 = listener;
					#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					double __temp_ret144 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar143, "used", 1303220797, true)) );
					#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::haxe.lang.Runtime.setField(__temp_getvar143, "used", 1303220797, ( __temp_ret144 + 1.0 ));
					#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					double __temp_expr320 = __temp_ret144;
				}
				
				bool f = ( this.listeners.data.length == 0 );
				this.listeners.addElement(listener, new global::haxe.lang.Null<int>(__temp_priority70, true));
				if (( f && ( this.takeListeners != default(global::pony.events.Signal) ) )) 
				{
					#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal this1 = this.takeListeners;
					#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					this1.dispatchEmpty(default(object));
					#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object __temp_expr321 = this1.target;
				}
				
				return this;
			}
			#line default
		}
		
		
		public virtual   global::pony.events.Signal @remove(object listener)
		{
			unchecked 
			{
				#line 98 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				if (( this.listeners.data.length == 0 )) 
				{
					#line 98 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					return this;
				}
				
				if (this.listeners.removeElement(listener)) 
				{
					{
						#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object __temp_iterator145 = this.lRunCopy.iterator();
						#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator145, "hasNext", 407283053, default(global::Array))) ))
						{
							#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::pony.Priority<object> c = ((global::pony.Priority<object>) (global::pony.Priority<object>.__hx_cast<object>(((global::pony.Priority) (global::haxe.lang.Runtime.callField(__temp_iterator145, "next", 1224901875, default(global::Array))) ))) );
							#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							c.removeElement(listener);
						}
						
					}
					
					{
						#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						{
							#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							object __temp_getvar146 = listener;
							#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							int __temp_ret147 = ((int) (global::haxe.lang.Runtime.getField_f(__temp_getvar146, "used", 1303220797, true)) );
							#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::haxe.lang.Runtime.setField_f(__temp_getvar146, "used", 1303220797, ((double) (( __temp_ret147 - 1 )) ));
							#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							int __temp_expr322 = __temp_ret147;
						}
						
						#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						if (( ((int) (global::haxe.lang.Runtime.getField_f(listener, "used", 1303220797, true)) ) == 0 )) 
						{
							#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::pony.events._Listener.Listener_Impl_.flist.@remove(((int) (global::haxe.lang.Runtime.getField_f(global::haxe.lang.Runtime.getField(listener, "f", 102, true), "id", 23515, true)) ));
							#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							{
								#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
								{
									#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									object __temp_getvar148 = global::haxe.lang.Runtime.getField(listener, "f", 102, true);
									#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									int __temp_ret149 = ((int) (global::haxe.lang.Runtime.getField_f(__temp_getvar148, "used", 1303220797, true)) );
									#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									global::haxe.lang.Runtime.setField_f(__temp_getvar148, "used", 1303220797, ((double) (( __temp_ret149 - 1 )) ));
									#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									int __temp_expr323 = __temp_ret149;
								}
								
								#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
								if (( global::haxe.lang.Runtime.compare(((int) (global::haxe.lang.Runtime.getField_f(global::haxe.lang.Runtime.getField(listener, "f", 102, true), "used", 1303220797, true)) ), 0) <= 0 )) 
								{
									#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									if (( global::haxe.lang.Runtime.getField(global::haxe.lang.Runtime.getField(listener, "f", 102, true), "f", 102, true) is global::haxe.lang.Closure )) 
									{
										#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
										global::pony._Function.Function_Impl_.cslist.@remove(global::pony._Function.Function_Impl_.buildCSHash(global::haxe.lang.Runtime.getField(global::haxe.lang.Runtime.getField(listener, "f", 102, true), "f", 102, true)));
									}
									 else 
									{
										#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
										global::pony._Function.Function_Impl_.list.@remove(global::pony._Function.Function_Impl_.buildCSHash(global::haxe.lang.Runtime.getField(global::haxe.lang.Runtime.getField(listener, "f", 102, true), "f", 102, true)));
									}
									
									#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									global::haxe.lang.Runtime.setField(listener, "f", 102, default(object));
									#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									global::pony._Function.Function_Impl_.unusedCount--;
								}
								
							}
							
						}
						
					}
					
					if (( ( this.listeners.data.length == 0 ) && ( this.lostListeners != default(global::pony.events.Signal) ) )) 
					{
						#line 102 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.events._Signal0.Signal0_Impl_.dispatchEmpty<object>(this.lostListeners, default(object));
					}
					
				}
				
				#line 104 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return this;
			}
			#line default
		}
		
		
		public   global::pony.events.Signal changePriority(object listener, global::haxe.lang.Null<int> priority)
		{
			unchecked 
			{
				#line 112 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				int __temp_priority71 = ( (global::haxe.lang.Runtime.eq((priority).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (priority.@value) );
				this.listeners.changeElement(listener, new global::haxe.lang.Null<int>(__temp_priority71, true));
				return this;
			}
			#line default
		}
		
		
		public   global::pony.events.Signal once(object listener, global::haxe.lang.Null<int> priority)
		{
			unchecked 
			{
				#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				int __temp_priority72 = ( (global::haxe.lang.Runtime.eq((priority).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (priority.@value) );
				#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				object __temp_stmt326 = default(object);
				#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
					#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object f = global::haxe.lang.Runtime.getField(listener, "f", 102, true);
					#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object this1 = default(object);
					#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object __temp_getvar150 = f;
						#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						double __temp_ret151 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar150, "used", 1303220797, true)) );
						#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object __temp_expr327 = ((object) (global::haxe.lang.Runtime.setField(__temp_getvar150, "used", 1303220797, ( __temp_ret151 + 1.0 ))) );
						#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						double __temp_expr328 = __temp_ret151;
					}
					
					#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						bool __temp_odecl324 = ((bool) (global::haxe.lang.Runtime.getField(listener, "event", 1975830554, true)) );
						#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						bool __temp_odecl325 = ((bool) (global::haxe.lang.Runtime.getField(listener, "ignoreReturn", 98429794, true)) );
						#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this1 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f, __temp_odecl325, true, default(global::pony.events.Event), __temp_odecl324}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (1) ), ((double) (0) )}));
					}
					
					#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					__temp_stmt326 = this1;
				}
				
				#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return this.@add(((object) (__temp_stmt326) ), new global::haxe.lang.Null<int>(__temp_priority72, true));
			}
			#line default
		}
		
		
		public virtual   global::pony.events.Signal dispatchEvent(global::pony.events.Event @event)
		{
			unchecked 
			{
				#line 138 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				@event.signal = this;
				if (this.silent) 
				{
					#line 139 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					return this;
				}
				
				global::pony.Priority<object> c = new global::pony.Priority<object>(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (this.listeners.data.copy()) ))) ));
				this.lRunCopy.@add(c);
				{
					#line 142 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object __temp_iterator152 = c.iterator();
					#line 142 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator152, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 142 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object l = ((object) (global::haxe.lang.Runtime.callField(__temp_iterator152, "next", 1224901875, default(global::Array))) );
						bool r = false;
						#line 145 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						try 
						{
							#line 145 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							r = global::pony.events._Listener.Listener_Impl_.call(l, @event);
						}
						catch (global::System.Exception __temp_catchallException331)
						{
							#line 161 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							object __temp_catchall332 = __temp_catchallException331;
							#line 161 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							if (( __temp_catchall332 is global::haxe.lang.HaxeException )) 
							{
								#line 161 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
								__temp_catchall332 = ((global::haxe.lang.HaxeException) (__temp_catchallException331) ).obj;
							}
							
							#line 146 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							if (( __temp_catchall332 is string )) 
							{
								#line 146 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
								string msg = global::haxe.lang.Runtime.toString(__temp_catchall332);
								#line 146 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
								{
									this.@remove(l);
									this.lRunCopy.@remove(c);
									#line 159 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									throw global::haxe.lang.HaxeException.wrap(msg);
								}
								
							}
							 else 
							{
								#line 161 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
								object e = __temp_catchall332;
								this.@remove(l);
								this.lRunCopy.@remove(c);
								#line 165 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
								try 
								{
									#line 165 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									global::haxe.Log.trace.__hx_invoke2_o(default(double), default(double), global::haxe.lang.Runtime.getField(e, "pos", 5594516, true), new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{302979532, 1547539107, 1648581351}), new global::Array<object>(new object[]{"dispatchEvent", "pony.events.Signal", "Signal.hx"}), new global::Array<int>(new int[]{1981972957}), new global::Array<double>(new double[]{((double) (165) )})));
								}
								catch (global::System.Exception __temp_catchallException329)
								{
									object __temp_catchall330 = __temp_catchallException329;
									#line 166 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									if (( __temp_catchall330 is global::haxe.lang.HaxeException )) 
									{
										#line 166 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
										__temp_catchall330 = ((global::haxe.lang.HaxeException) (__temp_catchallException329) ).obj;
									}
									
									#line 166 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									{
										#line 166 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
										object e1 = __temp_catchall330;
										#line 166 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
										{
										}
										
									}
									
								}
								
								
								throw global::haxe.lang.HaxeException.wrap(e);
							}
							
						}
						
						
						#line 169 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						bool br = ( ( r == false ) || @event._stopPropagation );
						if (( ((int) (global::haxe.lang.Runtime.getField_f(l, "count", 1248019663, true)) ) == 0 )) 
						{
							#line 170 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							this.@remove(l);
						}
						
						if (br) 
						{
							#line 171 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							break;
						}
						
					}
					
				}
				
				#line 173 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.lRunCopy.@remove(c);
				return this;
			}
			#line default
		}
		
		
		public   global::pony.events.Signal dispatchArgs(global::Array args)
		{
			unchecked 
			{
				#line 178 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.dispatchEvent(new global::pony.events.Event(((global::Array) (args) ), ((object) (this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
				return this;
			}
			#line default
		}
		
		
		public virtual   global::pony.events.Signal dispatchEmpty(object _)
		{
			unchecked 
			{
				#line 183 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.dispatchEvent(new global::pony.events.Event(((global::Array) (default(global::Array)) ), ((object) (this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
				return this;
			}
			#line default
		}
		
		
		public virtual   global::pony.events.Signal subArgs(global::Array args)
		{
			unchecked 
			{
				#line 197 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::pony.events.Signal s = ((global::pony.events.Signal) (this.subMap.@get(args)) );
				if (( s == default(global::pony.events.Signal) )) 
				{
					s = new global::pony.events.Signal(((object) (this.target) ));
					s.data = args;
					global::haxe.lang.Function __temp_stmt334 = default(global::haxe.lang.Function);
					#line 201 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 201 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::Array<object> a1 = new global::Array<object>(new object[]{args});
						#line 201 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::Array<object> f = new global::Array<object>(new object[]{((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("subHandler"), ((int) (1111449130) ))) )});
						#line 201 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						__temp_stmt334 = new global::pony.events.Signal_subArgs_201__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (f) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (a1) ))) ));
					}
					
					#line 201 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object __temp_stmt333 = global::pony._Function.Function_Impl_.@from(__temp_stmt334, 1);
					#line 201 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					this.@add(global::pony.events._Listener.Listener_Impl_._fromFunction(__temp_stmt333, true), default(global::haxe.lang.Null<int>));
					this.subMap.@set(args, s);
				}
				
				#line 204 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return s;
			}
			#line default
		}
		
		
		public virtual   void subHandler(global::Array args, global::pony.events.Event @event)
		{
			unchecked 
			{
				#line 208 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::Array a = ((global::Array) (global::haxe.lang.Runtime.callField(@event.args, "copy", 1103412149, default(global::Array))) );
				{
					#line 209 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					int _g = 0;
					#line 209 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					while (( global::haxe.lang.Runtime.compare(_g, ((int) (global::haxe.lang.Runtime.getField_f(args, "length", 520590566, true)) )) < 0 ))
					{
						#line 209 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object arg = args[_g];
						#line 209 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						 ++ _g;
						#line 209 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						if (( ! (global::haxe.lang.Runtime.eq(((object) (global::haxe.lang.Runtime.callField(a, "shift", 2082663554, default(global::Array))) ), arg)) )) 
						{
							#line 209 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							return ;
						}
						
					}
					
				}
				
				((global::pony.events.Signal) (this.subMap.@get(args)) ).dispatchEvent(new global::pony.events.Event(((global::Array) (a) ), ((object) (@event.target) ), ((global::pony.events.Event) (@event) )));
			}
			#line default
		}
		
		
		public virtual   global::pony.events.Signal removeSubArgs(global::Array args)
		{
			unchecked 
			{
				#line 222 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::pony.events.Signal s = ((global::pony.events.Signal) (this.subMap.@get(args)) );
				if (( s == default(global::pony.events.Signal) )) 
				{
					#line 223 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					return this;
				}
				
				s.removeAllListeners();
				this.subMap.@remove(args);
				return this;
			}
			#line default
		}
		
		
		public   global::pony.events.Signal removeAllSub()
		{
			unchecked 
			{
				#line 230 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
					#line 230 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object __temp_iterator153 = this.subMap.vs.iterator();
					#line 230 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator153, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 230 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.events.Signal e = ((global::pony.events.Signal) (global::haxe.lang.Runtime.callField(__temp_iterator153, "next", 1224901875, default(global::Array))) );
						#line 230 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						e.removeAllListeners();
					}
					
				}
				
				{
					#line 231 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.Dictionary<object, object> _this = this.subMap;
					#line 231 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					_this.ks = new global::Array<object>(new object[]{});
					#line 231 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					_this.vs = new global::Array<object>(new object[]{});
				}
				
				return this;
			}
			#line default
		}
		
		
		public virtual   global::pony.events.Signal removeAllListeners()
		{
			unchecked 
			{
				#line 236 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
					#line 236 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object __temp_iterator154 = this.lRunCopy.iterator();
					#line 236 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator154, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 236 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.Priority<object> c = ((global::pony.Priority<object>) (global::pony.Priority<object>.__hx_cast<object>(((global::pony.Priority) (global::haxe.lang.Runtime.callField(__temp_iterator154, "next", 1224901875, default(global::Array))) ))) );
						#line 236 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						c.clear();
					}
					
				}
				
				this.lRunCopy.clear();
				bool f = ( this.listeners.data.length == 0 );
				{
					#line 239 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object __temp_iterator155 = this.listeners.iterator();
					#line 239 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator155, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 239 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object l = ((object) (global::haxe.lang.Runtime.callField(__temp_iterator155, "next", 1224901875, default(global::Array))) );
						#line 239 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						{
							#line 239 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							object __temp_getvar156 = l;
							#line 239 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							int __temp_ret157 = ((int) (global::haxe.lang.Runtime.getField_f(__temp_getvar156, "used", 1303220797, true)) );
							#line 239 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::haxe.lang.Runtime.setField_f(__temp_getvar156, "used", 1303220797, ((double) (( __temp_ret157 - 1 )) ));
							#line 239 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							int __temp_expr335 = __temp_ret157;
						}
						
						#line 239 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						if (( ((int) (global::haxe.lang.Runtime.getField_f(l, "used", 1303220797, true)) ) == 0 )) 
						{
							#line 239 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::pony.events._Listener.Listener_Impl_.flist.@remove(((int) (global::haxe.lang.Runtime.getField_f(global::haxe.lang.Runtime.getField(l, "f", 102, true), "id", 23515, true)) ));
							#line 239 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							{
								#line 239 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
								{
									#line 239 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									object __temp_getvar158 = global::haxe.lang.Runtime.getField(l, "f", 102, true);
									#line 239 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									int __temp_ret159 = ((int) (global::haxe.lang.Runtime.getField_f(__temp_getvar158, "used", 1303220797, true)) );
									#line 239 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									global::haxe.lang.Runtime.setField_f(__temp_getvar158, "used", 1303220797, ((double) (( __temp_ret159 - 1 )) ));
									#line 239 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									int __temp_expr336 = __temp_ret159;
								}
								
								#line 239 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
								if (( global::haxe.lang.Runtime.compare(((int) (global::haxe.lang.Runtime.getField_f(global::haxe.lang.Runtime.getField(l, "f", 102, true), "used", 1303220797, true)) ), 0) <= 0 )) 
								{
									#line 239 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									if (( global::haxe.lang.Runtime.getField(global::haxe.lang.Runtime.getField(l, "f", 102, true), "f", 102, true) is global::haxe.lang.Closure )) 
									{
										#line 239 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
										global::pony._Function.Function_Impl_.cslist.@remove(global::pony._Function.Function_Impl_.buildCSHash(global::haxe.lang.Runtime.getField(global::haxe.lang.Runtime.getField(l, "f", 102, true), "f", 102, true)));
									}
									 else 
									{
										#line 239 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
										global::pony._Function.Function_Impl_.list.@remove(global::pony._Function.Function_Impl_.buildCSHash(global::haxe.lang.Runtime.getField(global::haxe.lang.Runtime.getField(l, "f", 102, true), "f", 102, true)));
									}
									
									#line 239 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									global::haxe.lang.Runtime.setField(l, "f", 102, default(object));
									#line 239 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									global::pony._Function.Function_Impl_.unusedCount--;
								}
								
							}
							
						}
						
					}
					
				}
				
				this.listeners.clear();
				if ( ! (f) ) 
				{
					#line 241 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal this1 = this.lostListeners;
					#line 241 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					this1.dispatchEmpty(default(object));
					#line 241 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object __temp_expr337 = this1.target;
				}
				
				return this;
			}
			#line default
		}
		
		
		public   object buildListenerEvent(global::pony.events.Event @event)
		{
			unchecked 
			{
				#line 253 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::Array<object> event1 = new global::Array<object>(new object[]{@event});
				#line 253 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::Array<object> _g = new global::Array<object>(new object[]{this});
				#line 253 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
					#line 253 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object f = global::pony._Function.Function_Impl_.@from(new global::pony.events.Signal_buildListenerEvent_253__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (event1) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (_g) ))) )), 0);
					#line 253 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					return global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
				}
				
			}
			#line default
		}
		
		
		public   object buildListenerArgs(global::Array args)
		{
			unchecked 
			{
				#line 254 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
					#line 254 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::Array<object> @event = new global::Array<object>(new object[]{new global::pony.events.Event(((global::Array) (args) ), ((object) (this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) ))});
					#line 254 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::Array<object> _g = new global::Array<object>(new object[]{this});
					#line 254 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 254 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object f = global::pony._Function.Function_Impl_.@from(new global::pony.events.Signal_buildListenerArgs_254__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (@event) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (_g) ))) )), 0);
						#line 254 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
					}
					
				}
				
			}
			#line default
		}
		
		
		public   object buildListenerEmpty()
		{
			unchecked 
			{
				#line 255 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
					#line 255 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::Array<object> @event = new global::Array<object>(new object[]{new global::pony.events.Event(((global::Array) (default(global::Array)) ), ((object) (this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) ))});
					#line 255 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::Array<object> _g = new global::Array<object>(new object[]{this});
					#line 255 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 255 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object f = global::pony._Function.Function_Impl_.@from(new global::pony.events.Signal_buildListenerEmpty_255__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (@event) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (_g) ))) )), 0);
						#line 255 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
					}
					
				}
				
			}
			#line default
		}
		
		
		public   bool _get_haveListeners()
		{
			unchecked 
			{
				#line 257 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return  ! ((( this.listeners.data.length == 0 ))) ;
			}
			#line default
		}
		
		
		public   global::pony.events.Signal listen(global::pony.events.Signal s)
		{
			unchecked 
			{
				#line 260 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				s.@add(global::pony.events._Listener.Listener_Impl_._fromFunction(global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("dispatchEvent"), ((int) (1181009664) ))) ), 1), true), default(global::haxe.lang.Null<int>));
				return this;
			}
			#line default
		}
		
		
		public virtual   global::pony.events.Signal sw(object l1, object l2)
		{
			unchecked 
			{
				#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
					#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					int priority = 0;
					#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object __temp_stmt342 = default(object);
					#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object f = global::haxe.lang.Runtime.getField(l1, "f", 102, true);
						#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object this1 = default(object);
						#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						{
							#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							object __temp_getvar160 = f;
							#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							double __temp_ret161 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar160, "used", 1303220797, true)) );
							#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							object __temp_expr343 = ((object) (global::haxe.lang.Runtime.setField(__temp_getvar160, "used", 1303220797, ( __temp_ret161 + 1.0 ))) );
							#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							double __temp_expr344 = __temp_ret161;
						}
						
						#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						{
							#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							bool __temp_odecl338 = ((bool) (global::haxe.lang.Runtime.getField(l1, "event", 1975830554, true)) );
							#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							bool __temp_odecl339 = ((bool) (global::haxe.lang.Runtime.getField(l1, "ignoreReturn", 98429794, true)) );
							#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							this1 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f, __temp_odecl339, true, default(global::pony.events.Event), __temp_odecl338}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (1) ), ((double) (0) )}));
						}
						
						#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						__temp_stmt342 = this1;
					}
					
					#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					this.@add(((object) (__temp_stmt342) ), new global::haxe.lang.Null<int>(priority, true));
				}
				
				{
					#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					int priority1 = 0;
					#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object listener = default(object);
					#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::haxe.lang.Function __temp_stmt345 = default(global::haxe.lang.Function);
						#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						{
							#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::Array<object> l21 = new global::Array<object>(new object[]{l1});
							#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::Array<object> l11 = new global::Array<object>(new object[]{l2});
							#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::Array<object> f2 = new global::Array<object>(new object[]{((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("sw"), ((int) (25764) ))) )});
							#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							__temp_stmt345 = new global::pony.events.Signal_sw_266__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (f2) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (l11) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (l21) ))) ));
						}
						
						#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object f1 = global::pony._Function.Function_Impl_.@from(__temp_stmt345, 0);
						#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						listener = global::pony.events._Listener.Listener_Impl_._fromFunction(f1, false);
					}
					
					#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object __temp_stmt346 = default(object);
					#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object f3 = global::haxe.lang.Runtime.getField(listener, "f", 102, true);
						#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object this2 = default(object);
						#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						{
							#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							object __temp_getvar162 = f3;
							#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							double __temp_ret163 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar162, "used", 1303220797, true)) );
							#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							object __temp_expr347 = ((object) (global::haxe.lang.Runtime.setField(__temp_getvar162, "used", 1303220797, ( __temp_ret163 + 1.0 ))) );
							#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							double __temp_expr348 = __temp_ret163;
						}
						
						#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						{
							#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							bool __temp_odecl340 = ((bool) (global::haxe.lang.Runtime.getField(listener, "event", 1975830554, true)) );
							#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							bool __temp_odecl341 = ((bool) (global::haxe.lang.Runtime.getField(listener, "ignoreReturn", 98429794, true)) );
							#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							this2 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f3, __temp_odecl341, true, default(global::pony.events.Event), __temp_odecl340}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (1) ), ((double) (0) )}));
						}
						
						#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						__temp_stmt346 = this2;
					}
					
					#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					this.@add(((object) (__temp_stmt346) ), new global::haxe.lang.Null<int>(priority1, true));
				}
				
				return this;
			}
			#line default
		}
		
		
		public virtual   void enableSilent()
		{
			unchecked 
			{
				#line 270 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.silent = true;
			}
			#line default
		}
		
		
		public virtual   void disableSilent()
		{
			unchecked 
			{
				#line 271 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.silent = false;
			}
			#line default
		}
		
		
		public   int _get_listenersCount()
		{
			unchecked 
			{
				#line 273 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return this.listeners.data.length;
			}
			#line default
		}
		
		
		public   void destroy()
		{
			unchecked 
			{
				#line 276 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
					#line 276 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 276 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object __temp_iterator164 = this.subMap.vs.iterator();
						#line 276 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator164, "hasNext", 407283053, default(global::Array))) ))
						{
							#line 276 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::pony.events.Signal e = ((global::pony.events.Signal) (global::haxe.lang.Runtime.callField(__temp_iterator164, "next", 1224901875, default(global::Array))) );
							#line 276 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							e.removeAllListeners();
						}
						
					}
					
					#line 276 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 276 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.Dictionary<object, object> _this = this.subMap;
						#line 276 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						_this.ks = new global::Array<object>(new object[]{});
						#line 276 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						_this.vs = new global::Array<object>(new object[]{});
					}
					
					#line 276 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal __temp_expr349 = this;
				}
				
				this.removeAllListeners();
				{
					#line 278 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal this1 = this.takeListeners;
					#line 278 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					this1.destroy();
					#line 278 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object __temp_expr350 = this1.target;
				}
				
				{
					#line 279 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal this2 = this.lostListeners;
					#line 279 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					this2.destroy();
					#line 279 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object __temp_expr351 = this2.target;
				}
				
			}
			#line default
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				switch (hash)
				{
					case 116192081:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.target = ((object) (@value) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return @value;
					}
					
					
					case 1113806378:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.data = ((object) (@value) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return @value;
					}
					
					
					default:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
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
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				switch (hash)
				{
					case 419661303:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.haveListeners = ((bool) (@value) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return @value;
					}
					
					
					case 435030268:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.subMap = ((global::pony.Dictionary<object, object>) (global::pony.Dictionary<object, object>.__hx_cast<object, object>(((global::pony.Dictionary) (@value) ))) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return @value;
					}
					
					
					case 1033575828:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.lRunCopy = ((global::List<object>) (global::List<object>.__hx_cast<object>(((global::List) (@value) ))) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return @value;
					}
					
					
					case 1938711935:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.listeners = ((global::pony.Priority<object>) (global::pony.Priority<object>.__hx_cast<object>(((global::pony.Priority) (@value) ))) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return @value;
					}
					
					
					case 116192081:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.target = ((object) (@value) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return @value;
					}
					
					
					case 1113806378:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.data = ((object) (@value) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return @value;
					}
					
					
					case 1417333816:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.takeListeners = ((global::pony.events.Signal) (@value) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return @value;
					}
					
					
					case 171917051:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.lostListeners = ((global::pony.events.Signal) (@value) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return @value;
					}
					
					
					case 936212117:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.silent = ((bool) (@value) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return @value;
					}
					
					
					default:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
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
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				switch (hash)
				{
					case 612773114:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("destroy"), ((int) (612773114) ))) );
					}
					
					
					case 899736473:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get_listenersCount"), ((int) (899736473) ))) );
					}
					
					
					case 753054365:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("disableSilent"), ((int) (753054365) ))) );
					}
					
					
					case 1650187640:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("enableSilent"), ((int) (1650187640) ))) );
					}
					
					
					case 25764:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("sw"), ((int) (25764) ))) );
					}
					
					
					case 1878640711:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("listen"), ((int) (1878640711) ))) );
					}
					
					
					case 527667534:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get_haveListeners"), ((int) (527667534) ))) );
					}
					
					
					case 2067338603:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("buildListenerEmpty"), ((int) (2067338603) ))) );
					}
					
					
					case 485177407:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("buildListenerArgs"), ((int) (485177407) ))) );
					}
					
					
					case 19112696:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("buildListenerEvent"), ((int) (19112696) ))) );
					}
					
					
					case 1214242434:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("removeAllListeners"), ((int) (1214242434) ))) );
					}
					
					
					case 783593027:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("removeAllSub"), ((int) (783593027) ))) );
					}
					
					
					case 1731362585:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("removeSubArgs"), ((int) (1731362585) ))) );
					}
					
					
					case 1111449130:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("subHandler"), ((int) (1111449130) ))) );
					}
					
					
					case 242754301:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("subArgs"), ((int) (242754301) ))) );
					}
					
					
					case 1081751923:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("dispatchEmpty"), ((int) (1081751923) ))) );
					}
					
					
					case 1530424631:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("dispatchArgs"), ((int) (1530424631) ))) );
					}
					
					
					case 1181009664:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("dispatchEvent"), ((int) (1181009664) ))) );
					}
					
					
					case 1236434305:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("once"), ((int) (1236434305) ))) );
					}
					
					
					case 343521524:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("changePriority"), ((int) (343521524) ))) );
					}
					
					
					case 76061764:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("remove"), ((int) (76061764) ))) );
					}
					
					
					case 4846113:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("add"), ((int) (4846113) ))) );
					}
					
					
					case 1169898256:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("init"), ((int) (1169898256) ))) );
					}
					
					
					case 436667088:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this._get_listenersCount();
					}
					
					
					case 419661303:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						if (handleProperties) 
						{
							#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							return this._get_haveListeners();
						}
						 else 
						{
							#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							return this.haveListeners;
						}
						
					}
					
					
					case 435030268:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.subMap;
					}
					
					
					case 1033575828:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.lRunCopy;
					}
					
					
					case 1938711935:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.listeners;
					}
					
					
					case 116192081:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.target;
					}
					
					
					case 1113806378:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.data;
					}
					
					
					case 1417333816:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.takeListeners;
					}
					
					
					case 171917051:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.lostListeners;
					}
					
					
					case 936212117:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.silent;
					}
					
					
					default:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
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
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				switch (hash)
				{
					case 436667088:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((double) (this._get_listenersCount()) );
					}
					
					
					case 116192081:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(this.target)) );
					}
					
					
					case 1113806378:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(this.data)) );
					}
					
					
					default:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
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
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				switch (hash)
				{
					case 612773114:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.destroy();
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						break;
					}
					
					
					case 899736473:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this._get_listenersCount();
					}
					
					
					case 753054365:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.disableSilent();
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						break;
					}
					
					
					case 1650187640:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.enableSilent();
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						break;
					}
					
					
					case 25764:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.sw(dynargs[0], dynargs[1]);
					}
					
					
					case 1878640711:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.listen(((global::pony.events.Signal) (dynargs[0]) ));
					}
					
					
					case 527667534:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this._get_haveListeners();
					}
					
					
					case 2067338603:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.buildListenerEmpty();
					}
					
					
					case 485177407:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.buildListenerArgs(((global::Array) (dynargs[0]) ));
					}
					
					
					case 19112696:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.buildListenerEvent(((global::pony.events.Event) (dynargs[0]) ));
					}
					
					
					case 1214242434:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.removeAllListeners();
					}
					
					
					case 783593027:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.removeAllSub();
					}
					
					
					case 1731362585:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.removeSubArgs(((global::Array) (dynargs[0]) ));
					}
					
					
					case 1111449130:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.subHandler(((global::Array) (dynargs[0]) ), ((global::pony.events.Event) (dynargs[1]) ));
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						break;
					}
					
					
					case 242754301:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.subArgs(((global::Array) (dynargs[0]) ));
					}
					
					
					case 1081751923:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.dispatchEmpty(dynargs[0]);
					}
					
					
					case 1530424631:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.dispatchArgs(((global::Array) (dynargs[0]) ));
					}
					
					
					case 1181009664:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.dispatchEvent(((global::pony.events.Event) (dynargs[0]) ));
					}
					
					
					case 1236434305:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.once(dynargs[0], global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[1]));
					}
					
					
					case 343521524:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.changePriority(dynargs[0], global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[1]));
					}
					
					
					case 76061764:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.@remove(dynargs[0]);
					}
					
					
					case 4846113:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.@add(dynargs[0], global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[1]));
					}
					
					
					case 1169898256:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.init(dynargs[0]);
					}
					
					
					default:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return default(object);
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				baseArr.push("listenersCount");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				baseArr.push("haveListeners");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				baseArr.push("subMap");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				baseArr.push("lRunCopy");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				baseArr.push("listeners");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				baseArr.push("target");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				baseArr.push("data");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				baseArr.push("takeListeners");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				baseArr.push("lostListeners");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				baseArr.push("silent");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
					#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
		public   int listenersCount
		{
			get { return _get_listenersCount(); }
		}
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events
{
	public  class Signal_subArgs_201__Fun : global::haxe.lang.Function 
	{
		public    Signal_subArgs_201__Fun(global::Array<object> f, global::Array<object> a1) : base(1, 0)
		{
			unchecked 
			{
				#line 201 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.f = f;
				#line 201 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.a1 = a1;
			}
			#line default
		}
		
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				#line 201 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::pony.events.Event a2 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::pony.events.Event) (((object) (__fn_float1) )) )) : (((global::pony.events.Event) (__fn_dyn1) )) );
				#line 201 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return ((global::haxe.lang.Function) (this.f[0]) ).__hx_invoke2_o(default(double), default(double), ((global::Array) (this.a1[0]) ), a2);
			}
			#line default
		}
		
		
		public  global::Array<object> f;
		
		public  global::Array<object> a1;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events
{
	public  class Signal_buildListenerEvent_253__Fun : global::haxe.lang.Function 
	{
		public    Signal_buildListenerEvent_253__Fun(global::Array<object> event1, global::Array<object> _g) : base(0, 0)
		{
			unchecked 
			{
				#line 253 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.event1 = event1;
				#line 253 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this._g = _g;
			}
			#line default
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				#line 253 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				((global::pony.events.Signal) (this._g[0]) ).dispatchEvent(((global::pony.events.Event) (this.event1[0]) ));
				#line 253 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return default(object);
			}
			#line default
		}
		
		
		public  global::Array<object> event1;
		
		public  global::Array<object> _g;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events
{
	public  class Signal_buildListenerArgs_254__Fun : global::haxe.lang.Function 
	{
		public    Signal_buildListenerArgs_254__Fun(global::Array<object> @event, global::Array<object> _g) : base(0, 0)
		{
			unchecked 
			{
				#line 254 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.@event = @event;
				#line 254 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this._g = _g;
			}
			#line default
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				#line 254 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				((global::pony.events.Signal) (this._g[0]) ).dispatchEvent(((global::pony.events.Event) (this.@event[0]) ));
				#line 254 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return default(object);
			}
			#line default
		}
		
		
		public  global::Array<object> @event;
		
		public  global::Array<object> _g;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events
{
	public  class Signal_buildListenerEmpty_255__Fun : global::haxe.lang.Function 
	{
		public    Signal_buildListenerEmpty_255__Fun(global::Array<object> @event, global::Array<object> _g) : base(0, 0)
		{
			unchecked 
			{
				#line 255 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.@event = @event;
				#line 255 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this._g = _g;
			}
			#line default
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				#line 255 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				((global::pony.events.Signal) (this._g[0]) ).dispatchEvent(((global::pony.events.Event) (this.@event[0]) ));
				#line 255 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return default(object);
			}
			#line default
		}
		
		
		public  global::Array<object> @event;
		
		public  global::Array<object> _g;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events
{
	public  class Signal_sw_266__Fun : global::haxe.lang.Function 
	{
		public    Signal_sw_266__Fun(global::Array<object> f2, global::Array<object> l11, global::Array<object> l21) : base(0, 0)
		{
			unchecked 
			{
				#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.f2 = f2;
				#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.l11 = l11;
				#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.l21 = l21;
			}
			#line default
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return ((global::pony.events.Signal) (((global::haxe.lang.Function) (this.f2[0]) ).__hx_invoke2_o(default(double), default(double), this.l11[0], this.l21[0])) );
			}
			#line default
		}
		
		
		public  global::Array<object> f2;
		
		public  global::Array<object> l11;
		
		public  global::Array<object> l21;
		
	}
}


