
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events._Listener
{
	public sealed class Listener_Impl_ 
	{
		static Listener_Impl_() 
		{
			#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
			global::pony.events._Listener.Listener_Impl_.flist = new global::haxe.ds.IntMap<object>();
		}
		public static  global::haxe.ds.IntMap<object> flist;
		
		public static   object _new(object f, global::haxe.lang.Null<bool> @event, global::haxe.lang.Null<bool> ignoreReturn, global::haxe.lang.Null<int> count)
		{
			unchecked 
			{
				#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				int __temp_count106 = ( (global::haxe.lang.Runtime.eq((count).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (-1) )) : (count.@value) );
				#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				bool __temp_ignoreReturn105 = ( (global::haxe.lang.Runtime.eq((ignoreReturn).toDynamic(), (default(global::haxe.lang.Null<bool>)).toDynamic())) ? (((bool) (true) )) : (ignoreReturn.@value) );
				#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				bool __temp_event104 = ( (global::haxe.lang.Runtime.eq((@event).toDynamic(), (default(global::haxe.lang.Null<bool>)).toDynamic())) ? (((bool) (false) )) : (@event.@value) );
				#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				object this1 = default(object);
				{
					#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					object __temp_getvar185 = f;
					#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					double __temp_ret186 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar185, "used", 1303220797, true)) );
					#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					global::haxe.lang.Runtime.setField(__temp_getvar185, "used", 1303220797, ( __temp_ret186 + 1.0 ));
					#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					double __temp_expr443 = __temp_ret186;
				}
				
				this1 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f, __temp_ignoreReturn105, true, default(global::pony.events.Event), __temp_event104}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (__temp_count106) ), ((double) (0) )}));
				#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				return this1;
			}
			#line default
		}
		
		
		public static   object fromEFunction(global::haxe.lang.Function f)
		{
			unchecked 
			{
				#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				return global::pony.events._Listener.Listener_Impl_._fromFunction(global::pony._Function.Function_Impl_.@from(f, 1), true);
			}
			#line default
		}
		
		
		public static   object fromFunction(object f)
		{
			unchecked 
			{
				#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				return global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
			}
			#line default
		}
		
		
		public static   object fromSignal(global::pony.events.Signal s)
		{
			unchecked 
			{
				#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				{
					#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					global::Array<object> @event = new global::Array<object>(new object[]{new global::pony.events.Event(((global::Array) (default(global::Array)) ), ((object) (s.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) ))});
					#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					global::Array<object> _g = new global::Array<object>(new object[]{s});
					#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					{
						#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						object f = global::pony._Function.Function_Impl_.@from(new global::pony.events._Listener.Listener_Impl__fromSignal_65__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (_g) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (@event) ))) )), 0);
						#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						return global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
					}
					
				}
				
			}
			#line default
		}
		
		
		public static   object _fromFunction(object f, bool ev)
		{
			unchecked 
			{
				#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				if (global::pony.events._Listener.Listener_Impl_.flist.exists(((int) (global::haxe.lang.Runtime.getField_f(f, "id", 23515, true)) ))) 
				{
					return (global::pony.events._Listener.Listener_Impl_.flist.@get(((int) (global::haxe.lang.Runtime.getField_f(f, "id", 23515, true)) ))).toDynamic();
				}
				 else 
				{
					#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					object o = default(object);
					#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					{
						#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						int count = -1;
						#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						bool ignoreReturn = true;
						#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						object this1 = default(object);
						#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						{
							#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							object __temp_getvar187 = f;
							#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							double __temp_ret188 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar187, "used", 1303220797, true)) );
							#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							global::haxe.lang.Runtime.setField(__temp_getvar187, "used", 1303220797, ( __temp_ret188 + 1.0 ));
							#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							double __temp_expr444 = __temp_ret188;
						}
						
						#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						this1 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f, ignoreReturn, true, default(global::pony.events.Event), ev}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (count) ), ((double) (0) )}));
						#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						o = this1;
					}
					
					global::pony.events._Listener.Listener_Impl_.flist.@set(((int) (global::haxe.lang.Runtime.getField_f(f, "id", 23515, true)) ), o);
					return o;
				}
				
			}
			#line default
		}
		
		
		public static   int _get_count(object this1)
		{
			unchecked 
			{
				#line 77 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				return ((int) (global::haxe.lang.Runtime.getField_f(this1, "count", 1248019663, true)) );
			}
			#line default
		}
		
		
		public static   bool call(object this1, global::pony.events.Event @event)
		{
			unchecked 
			{
				#line 80 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				if (( ! (((bool) (global::haxe.lang.Runtime.getField(this1, "active", 373703110, true)) )) )) 
				{
					#line 80 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					return true;
				}
				
				{
					#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					object __temp_getvar189 = this1;
					#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					int __temp_ret190 = ((int) (global::haxe.lang.Runtime.getField_f(__temp_getvar189, "count", 1248019663, true)) );
					#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					global::haxe.lang.Runtime.setField_f(__temp_getvar189, "count", 1248019663, ((double) (( __temp_ret190 - 1 )) ));
					#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					int __temp_expr445 = __temp_ret190;
				}
				
				@event.currentListener = this1;
				bool r = true;
				if (((bool) (global::haxe.lang.Runtime.getField(this1, "event", 1975830554, true)) )) 
				{
					object __temp_stmt449 = default(object);
					#line 85 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					{
						#line 85 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						global::Array args = new global::Array<object>(new object[]{@event});
						#line 85 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						object this2 = global::haxe.lang.Runtime.getField(this1, "f", 102, true);
						#line 85 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						if (( args == default(global::Array) )) 
						{
							#line 85 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							args = new global::Array<object>(new object[]{});
						}
						
						#line 85 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						__temp_stmt449 = global::Reflect.callMethod(default(object), global::haxe.lang.Runtime.getField(this2, "f", 102, true), ((global::Array) (global::haxe.lang.Runtime.callField(((global::Array) (global::haxe.lang.Runtime.getField(this2, "args", 1081380189, true)) ), "concat", 1204816148, new global::Array<object>(new object[]{args}))) ));
					}
					
					#line 85 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					bool __temp_stmt448 = global::haxe.lang.Runtime.eq(__temp_stmt449, false);
					#line 85 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					if (__temp_stmt448) 
					{
						#line 85 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						r = false;
					}
					
				}
				 else 
				{
					#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					global::Array args1 = ((global::Array) (global::haxe.lang.Runtime.callField(@event.args, "copy", 1103412149, default(global::Array))) );
					global::haxe.lang.Runtime.callField(args1, "push", 1247875546, new global::Array<object>(new object[]{@event.target}));
					global::haxe.lang.Runtime.callField(args1, "push", 1247875546, new global::Array<object>(new object[]{@event}));
					object __temp_stmt447 = default(object);
					#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					{
						#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						global::Array args2 = ((global::Array) (global::haxe.lang.Runtime.callField(args1, "slice", 2127021138, new global::Array<object>(new object[]{0, ((int) (global::haxe.lang.Runtime.getField_f(global::haxe.lang.Runtime.getField(this1, "f", 102, true), "count", 1248019663, true)) )}))) );
						#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						object this3 = global::haxe.lang.Runtime.getField(this1, "f", 102, true);
						#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						if (( args2 == default(global::Array) )) 
						{
							#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							args2 = new global::Array<object>(new object[]{});
						}
						
						#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						__temp_stmt447 = global::Reflect.callMethod(default(object), global::haxe.lang.Runtime.getField(this3, "f", 102, true), ((global::Array) (global::haxe.lang.Runtime.callField(((global::Array) (global::haxe.lang.Runtime.getField(this3, "args", 1081380189, true)) ), "concat", 1204816148, new global::Array<object>(new object[]{args2}))) ));
					}
					
					#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					bool __temp_stmt446 = global::haxe.lang.Runtime.eq(__temp_stmt447, false);
					#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					if (__temp_stmt446) 
					{
						#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						r = false;
					}
					
				}
				
				#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				global::haxe.lang.Runtime.setField(this1, "prev", 1247723251, @event);
				if (((bool) (global::haxe.lang.Runtime.getField(this1, "ignoreReturn", 98429794, true)) )) 
				{
					#line 93 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					return true;
				}
				 else 
				{
					#line 93 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					return r;
				}
				
			}
			#line default
		}
		
		
		public static   object setCount(object this1, int count)
		{
			unchecked 
			{
				#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				{
					#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					object f = global::haxe.lang.Runtime.getField(this1, "f", 102, true);
					#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					object this2 = default(object);
					#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					{
						#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						object __temp_getvar191 = f;
						#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						double __temp_ret192 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar191, "used", 1303220797, true)) );
						#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						global::haxe.lang.Runtime.setField(__temp_getvar191, "used", 1303220797, ( __temp_ret192 + 1.0 ));
						#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						double __temp_expr452 = __temp_ret192;
					}
					
					#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					{
						#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						bool __temp_odecl450 = ((bool) (global::haxe.lang.Runtime.getField(this1, "event", 1975830554, true)) );
						#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						bool __temp_odecl451 = ((bool) (global::haxe.lang.Runtime.getField(this1, "ignoreReturn", 98429794, true)) );
						#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						this2 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f, __temp_odecl451, true, default(global::pony.events.Event), __temp_odecl450}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (count) ), ((double) (0) )}));
					}
					
					#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					return this2;
				}
				
			}
			#line default
		}
		
		
		public static   void _use(object this1)
		{
			unchecked 
			{
				#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				{
					#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					object __temp_getvar193 = this1;
					#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					int __temp_ret194 = ((int) (global::haxe.lang.Runtime.getField_f(__temp_getvar193, "used", 1303220797, true)) );
					#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					global::haxe.lang.Runtime.setField_f(__temp_getvar193, "used", 1303220797, ((double) (( __temp_ret194 + 1 )) ));
					#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					int __temp_expr453 = __temp_ret194;
				}
				
			}
			#line default
		}
		
		
		public static   void unuse(object this1)
		{
			unchecked 
			{
				#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				{
					#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					object __temp_getvar195 = this1;
					#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					int __temp_ret196 = ((int) (global::haxe.lang.Runtime.getField_f(__temp_getvar195, "used", 1303220797, true)) );
					#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					global::haxe.lang.Runtime.setField_f(__temp_getvar195, "used", 1303220797, ((double) (( __temp_ret196 - 1 )) ));
					#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					int __temp_expr454 = __temp_ret196;
				}
				
				if (( ((int) (global::haxe.lang.Runtime.getField_f(this1, "used", 1303220797, true)) ) == 0 )) 
				{
					global::pony.events._Listener.Listener_Impl_.flist.@remove(((int) (global::haxe.lang.Runtime.getField_f(global::haxe.lang.Runtime.getField(this1, "f", 102, true), "id", 23515, true)) ));
					{
						#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						{
							#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							object __temp_getvar197 = global::haxe.lang.Runtime.getField(this1, "f", 102, true);
							#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							int __temp_ret198 = ((int) (global::haxe.lang.Runtime.getField_f(__temp_getvar197, "used", 1303220797, true)) );
							#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							global::haxe.lang.Runtime.setField_f(__temp_getvar197, "used", 1303220797, ((double) (( __temp_ret198 - 1 )) ));
							#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							int __temp_expr455 = __temp_ret198;
						}
						
						#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						if (( global::haxe.lang.Runtime.compare(((int) (global::haxe.lang.Runtime.getField_f(global::haxe.lang.Runtime.getField(this1, "f", 102, true), "used", 1303220797, true)) ), 0) <= 0 )) 
						{
							#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							if (( global::haxe.lang.Runtime.getField(global::haxe.lang.Runtime.getField(this1, "f", 102, true), "f", 102, true) is global::haxe.lang.Closure )) 
							{
								#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
								global::pony._Function.Function_Impl_.cslist.@remove(global::pony._Function.Function_Impl_.buildCSHash(global::haxe.lang.Runtime.getField(global::haxe.lang.Runtime.getField(this1, "f", 102, true), "f", 102, true)));
							}
							 else 
							{
								#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
								global::pony._Function.Function_Impl_.list.@remove(global::pony._Function.Function_Impl_.buildCSHash(global::haxe.lang.Runtime.getField(global::haxe.lang.Runtime.getField(this1, "f", 102, true), "f", 102, true)));
							}
							
							#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							global::haxe.lang.Runtime.setField(this1, "f", 102, default(object));
							#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							global::pony._Function.Function_Impl_.unusedCount--;
						}
						
					}
					
				}
				
			}
			#line default
		}
		
		
		public static   int _get_used(object this1)
		{
			unchecked 
			{
				#line 110 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				return ((int) (global::haxe.lang.Runtime.getField_f(this1, "used", 1303220797, true)) );
			}
			#line default
		}
		
		
		public static   int unusedCount()
		{
			unchecked 
			{
				#line 113 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				int c = 0;
				{
					#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					object __temp_iterator199 = global::pony.events._Listener.Listener_Impl_.flist.iterator();
					#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator199, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						object l = ((object) (global::haxe.lang.Runtime.callField(__temp_iterator199, "next", 1224901875, default(global::Array))) );
						#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						if (( global::haxe.lang.Runtime.compare(((int) (global::haxe.lang.Runtime.getField_f(l, "used", 1303220797, true)) ), 0) <= 0 )) 
						{
							#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							c++;
						}
						
					}
					
				}
				
				return c;
			}
			#line default
		}
		
		
		public static   bool _get_active(object this1)
		{
			unchecked 
			{
				#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				return ((bool) (global::haxe.lang.Runtime.getField(this1, "active", 373703110, true)) );
			}
			#line default
		}
		
		
		public static   bool _set_active(object this1, bool b)
		{
			unchecked 
			{
				#line 120 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				return ((bool) (global::haxe.lang.Runtime.setField(this1, "active", 373703110, b)) );
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events._Listener
{
	public  class Listener_Impl__fromSignal_65__Fun : global::haxe.lang.Function 
	{
		public    Listener_Impl__fromSignal_65__Fun(global::Array<object> _g, global::Array<object> @event) : base(0, 0)
		{
			unchecked 
			{
				#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				this._g = _g;
				#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				this.@event = @event;
			}
			#line default
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				((global::pony.events.Signal) (this._g[0]) ).dispatchEvent(((global::pony.events.Event) (this.@event[0]) ));
				#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				return default(object);
			}
			#line default
		}
		
		
		public  global::Array<object> _g;
		
		public  global::Array<object> @event;
		
	}
}


