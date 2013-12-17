
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events._Signal1
{
	public sealed class Signal1_Impl_ 
	{
		public static   global::pony.events.Signal _new<Target, T1>(global::pony.events.Signal s)
		{
			unchecked 
			{
				#line 48 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				return s;
			}
			#line default
		}
		
		
		public static   bool _get_silent<Target, T1>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				return this1.silent;
			}
			#line default
		}
		
		
		public static   bool _set_silent<Target, T1>(global::pony.events.Signal this1, bool b)
		{
			unchecked 
			{
				#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				return this1.silent = b;
			}
			#line default
		}
		
		
		public static   global::pony.events.Signal _get_lostListeners<Target, T1>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				return ((global::pony.events.Signal) (this1.lostListeners) );
			}
			#line default
		}
		
		
		public static   global::pony.events.Signal _get_takeListeners<Target, T1>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				return ((global::pony.events.Signal) (this1.takeListeners) );
			}
			#line default
		}
		
		
		public static   bool _get_haveListeners<Target, T1>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 55 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				return ((bool) ( ! ((( this1.listeners.data.length == 0 ))) ) );
			}
			#line default
		}
		
		
		public static   object _get_data<Target, T1>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				return this1.data;
			}
			#line default
		}
		
		
		public static   object _set_data<Target, T1>(global::pony.events.Signal this1, object d)
		{
			unchecked 
			{
				#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				return this1.data = d;
			}
			#line default
		}
		
		
		public static   Target _get_target<Target, T1>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   int _get_listenersCount<Target, T1>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 60 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				return this1.listeners.data.length;
			}
			#line default
		}
		
		
		public static   Target @add<Target, T1>(global::pony.events.Signal this1, object listener, global::haxe.lang.Null<int> priority)
		{
			unchecked 
			{
				#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				int __temp_priority109 = ( (global::haxe.lang.Runtime.eq((priority).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (priority.@value) );
				this1.@add(((object) (listener) ), new global::haxe.lang.Null<int>(__temp_priority109, true));
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target once<Target, T1>(global::pony.events.Signal this1, object listener)
		{
			unchecked 
			{
				#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				{
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					int priority = 0;
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					object listener1 = ((object) (listener) );
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					object __temp_stmt477 = default(object);
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					{
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						object f = global::haxe.lang.Runtime.getField(listener1, "f", 102, true);
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						object this2 = default(object);
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						{
							#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							object __temp_getvar206 = f;
							#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							double __temp_ret207 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar206, "used", 1303220797, true)) );
							#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							object __temp_expr478 = ((object) (global::haxe.lang.Runtime.setField(__temp_getvar206, "used", 1303220797, ( __temp_ret207 + 1.0 ))) );
							#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							double __temp_expr479 = __temp_ret207;
						}
						
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						{
							#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							bool __temp_odecl475 = ((bool) (global::haxe.lang.Runtime.getField(listener1, "event", 1975830554, true)) );
							#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							bool __temp_odecl476 = ((bool) (global::haxe.lang.Runtime.getField(listener1, "ignoreReturn", 98429794, true)) );
							#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							this2 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f, __temp_odecl476, true, default(global::pony.events.Event), __temp_odecl475}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (1) ), ((double) (0) )}));
						}
						
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						__temp_stmt477 = this2;
					}
					
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					this1.@add(((object) (__temp_stmt477) ), new global::haxe.lang.Null<int>(priority, true));
				}
				
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target @remove<Target, T1>(global::pony.events.Signal this1, object listener)
		{
			unchecked 
			{
				#line 73 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				this1.@remove(((object) (listener) ));
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target changePriority<Target, T1>(global::pony.events.Signal this1, object listener, global::haxe.lang.Null<int> priority)
		{
			unchecked 
			{
				#line 77 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				int __temp_priority110 = ( (global::haxe.lang.Runtime.eq((priority).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (priority.@value) );
				{
					#line 78 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					this1.listeners.changeElement(((object) (listener) ), new global::haxe.lang.Null<int>(__temp_priority110, true));
					#line 78 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					global::pony.events.Signal __temp_expr480 = this1;
				}
				
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target dispatch<Target, T1>(global::pony.events.Signal this1, T1 a)
		{
			unchecked 
			{
				#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				{
					#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					{
						#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						this1.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<T1>(new T1[]{a})) ), ((object) (this1.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
						#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						global::pony.events.Signal __temp_expr481 = this1;
					}
					
					#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
				}
				
			}
			#line default
		}
		
		
		public static   Target dispatchEvent<Target, T1>(global::pony.events.Signal this1, global::pony.events.Event @event)
		{
			unchecked 
			{
				#line 85 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				this1.dispatchEvent(@event);
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target dispatchArgs<Target, T1>(global::pony.events.Signal this1, global::Array<T1> args)
		{
			unchecked 
			{
				#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				{
					#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					this1.dispatchEvent(new global::pony.events.Event(((global::Array) (args) ), ((object) (this1.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
					#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					global::pony.events.Signal __temp_expr482 = this1;
				}
				
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target dispatchEmpty<Target, T1>(global::pony.events.Signal this1, object _)
		{
			unchecked 
			{
				#line 95 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				this1.dispatchEmpty(default(object));
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   global::pony.events.Signal sub<Target, T1>(global::pony.events.Signal this1, T1 a)
		{
			unchecked 
			{
				#line 99 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				{
					#line 99 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					global::pony.events.Signal s = this1.subArgs(new global::Array<T1>(new T1[]{a}));
					#line 99 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					return ((global::pony.events.Signal) (s) );
				}
				
			}
			#line default
		}
		
		
		public static   global::pony.events.Signal subArgs<Target, T1>(global::pony.events.Signal this1, global::Array<T1> args)
		{
			unchecked 
			{
				#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				{
					#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					global::pony.events.Signal s = this1.subArgs(args);
					#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					return ((global::pony.events.Signal) (s) );
				}
				
			}
			#line default
		}
		
		
		public static   Target removeSub<Target, T1>(global::pony.events.Signal this1, T1 a)
		{
			unchecked 
			{
				#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				{
					#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					this1.removeSubArgs(new global::Array<T1>(new T1[]{a}));
					#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
				}
				
			}
			#line default
		}
		
		
		public static   Target removeSubArgs<Target, T1>(global::pony.events.Signal this1, global::Array<T1> args)
		{
			unchecked 
			{
				#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				this1.removeSubArgs(args);
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target removeAllSub<Target, T1>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				{
					#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					{
						#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						object __temp_iterator208 = this1.subMap.vs.iterator();
						#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator208, "hasNext", 407283053, default(global::Array))) ))
						{
							#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							global::pony.events.Signal e = ((global::pony.events.Signal) (global::haxe.lang.Runtime.callField(__temp_iterator208, "next", 1224901875, default(global::Array))) );
							#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							e.removeAllListeners();
						}
						
					}
					
					#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					{
						#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						global::pony.Dictionary<object, object> _this = this1.subMap;
						#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						_this.ks = new global::Array<object>(new object[]{});
						#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						_this.vs = new global::Array<object>(new object[]{});
					}
					
					#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					global::pony.events.Signal __temp_expr483 = this1;
				}
				
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target removeAllListeners<Target, T1>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 116 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				this1.removeAllListeners();
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target listen<T, Target, T1>(global::pony.events.Signal this1, global::pony.events.Signal s)
		{
			unchecked 
			{
				#line 121 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				{
					#line 121 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					int priority = 0;
					#line 121 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					object listener = default(object);
					#line 121 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					object __temp_stmt484 = default(object);
					#line 121 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					{
						#line 121 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						object l = global::pony.events._Listener.Listener_Impl_._fromFunction(global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this1) ), global::haxe.lang.Runtime.toString("dispatchEvent"), ((int) (1181009664) ))) ), 1), true);
						#line 121 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						__temp_stmt484 = l;
					}
					
					#line 121 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					listener = ((object) (__temp_stmt484) );
					#line 121 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					s.@add(((object) (listener) ), new global::haxe.lang.Null<int>(priority, true));
					#line 121 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					object __temp_expr485 = s.target;
				}
				
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target sw<Target, T1>(global::pony.events.Signal this1, object l1, object l2)
		{
			unchecked 
			{
				#line 126 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				{
					#line 126 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					int priority = 0;
					#line 126 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					object listener = ((object) (l1) );
					#line 126 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					object __temp_stmt490 = default(object);
					#line 126 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					{
						#line 126 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						object f = global::haxe.lang.Runtime.getField(listener, "f", 102, true);
						#line 126 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						object this2 = default(object);
						#line 126 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						{
							#line 126 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							object __temp_getvar209 = f;
							#line 126 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							double __temp_ret210 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar209, "used", 1303220797, true)) );
							#line 126 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							object __temp_expr491 = ((object) (global::haxe.lang.Runtime.setField(__temp_getvar209, "used", 1303220797, ( __temp_ret210 + 1.0 ))) );
							#line 126 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							double __temp_expr492 = __temp_ret210;
						}
						
						#line 126 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						{
							#line 126 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							bool __temp_odecl486 = ((bool) (global::haxe.lang.Runtime.getField(listener, "event", 1975830554, true)) );
							#line 126 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							bool __temp_odecl487 = ((bool) (global::haxe.lang.Runtime.getField(listener, "ignoreReturn", 98429794, true)) );
							#line 126 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							this2 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f, __temp_odecl487, true, default(global::pony.events.Event), __temp_odecl486}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (1) ), ((double) (0) )}));
						}
						
						#line 126 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						__temp_stmt490 = this2;
					}
					
					#line 126 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					this1.@add(((object) (__temp_stmt490) ), new global::haxe.lang.Null<int>(priority, true));
				}
				
				{
					#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					int priority1 = 0;
					#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					object listener1 = default(object);
					#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					{
						#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						global::haxe.lang.Function __temp_stmt493 = default(global::haxe.lang.Function);
						#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						{
							#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							global::Array<object> l21 = new global::Array<object>(new object[]{((object) (l1) )});
							#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							global::Array<object> l11 = new global::Array<object>(new object[]{((object) (l2) )});
							#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							global::Array<object> f2 = new global::Array<object>(new object[]{((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this1) ), global::haxe.lang.Runtime.toString("sw"), ((int) (25764) ))) )});
							#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							__temp_stmt493 = new global::pony.events._Signal1.Signal1_Impl__sw_127__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (f2) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (l11) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (l21) ))) ));
						}
						
						#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						object f1 = global::pony._Function.Function_Impl_.@from(__temp_stmt493, 0);
						#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						listener1 = global::pony.events._Listener.Listener_Impl_._fromFunction(f1, false);
					}
					
					#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					object __temp_stmt494 = default(object);
					#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					{
						#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						object f3 = global::haxe.lang.Runtime.getField(listener1, "f", 102, true);
						#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						object this3 = default(object);
						#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						{
							#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							object __temp_getvar211 = f3;
							#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							double __temp_ret212 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar211, "used", 1303220797, true)) );
							#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							object __temp_expr495 = ((object) (global::haxe.lang.Runtime.setField(__temp_getvar211, "used", 1303220797, ( __temp_ret212 + 1.0 ))) );
							#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							double __temp_expr496 = __temp_ret212;
						}
						
						#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						{
							#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							bool __temp_odecl488 = ((bool) (global::haxe.lang.Runtime.getField(listener1, "event", 1975830554, true)) );
							#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							bool __temp_odecl489 = ((bool) (global::haxe.lang.Runtime.getField(listener1, "ignoreReturn", 98429794, true)) );
							#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							this3 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f3, __temp_odecl489, true, default(global::pony.events.Event), __temp_odecl488}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (1) ), ((double) (0) )}));
						}
						
						#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						__temp_stmt494 = this3;
					}
					
					#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					this1.@add(((object) (__temp_stmt494) ), new global::haxe.lang.Null<int>(priority1, true));
				}
				
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target destroy<Target, T1>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				{
					#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					{
						#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						{
							#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							object __temp_iterator213 = this1.subMap.vs.iterator();
							#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator213, "hasNext", 407283053, default(global::Array))) ))
							{
								#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
								global::pony.events.Signal e = ((global::pony.events.Signal) (global::haxe.lang.Runtime.callField(__temp_iterator213, "next", 1224901875, default(global::Array))) );
								#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
								e.removeAllListeners();
							}
							
						}
						
						#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						{
							#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							global::pony.Dictionary<object, object> _this = this1.subMap;
							#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							_this.ks = new global::Array<object>(new object[]{});
							#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
							_this.vs = new global::Array<object>(new object[]{});
						}
						
						#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						global::pony.events.Signal __temp_expr497 = this1;
					}
					
					#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					this1.removeAllListeners();
					#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					{
						#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						global::pony.events.Signal this2 = this1.takeListeners;
						#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						this2.destroy();
						#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						object __temp_expr498 = this2.target;
					}
					
					#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
					{
						#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						global::pony.events.Signal this3 = this1.lostListeners;
						#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						this3.destroy();
						#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
						object __temp_expr499 = this3.target;
					}
					
				}
				
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   void enableSilent<Target, T1>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 136 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				this1.silent = true;
			}
			#line default
		}
		
		
		public static   void disableSilent<Target, T1>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 137 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				this1.silent = false;
			}
			#line default
		}
		
		
		public static   global::pony.events.Signal @from<A, B>(global::pony.events.Signal s)
		{
			unchecked 
			{
				#line 139 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				return ((global::pony.events.Signal) (s) );
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events._Signal1
{
	public  class Signal1_Impl__sw_127__Fun : global::haxe.lang.Function 
	{
		public    Signal1_Impl__sw_127__Fun(global::Array<object> f2, global::Array<object> l11, global::Array<object> l21) : base(0, 0)
		{
			unchecked 
			{
				#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				this.f2 = f2;
				#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				this.l11 = l11;
				#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				this.l21 = l21;
			}
			#line default
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal1.hx"
				return ((global::pony.events.Signal) (((global::haxe.lang.Function) (this.f2[0]) ).__hx_invoke2_o(default(double), default(double), this.l11[0], this.l21[0])) );
			}
			#line default
		}
		
		
		public  global::Array<object> f2;
		
		public  global::Array<object> l11;
		
		public  global::Array<object> l21;
		
	}
}


