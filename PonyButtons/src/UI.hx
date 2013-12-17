package ;

import pony.magic.StaticInit;
import pony.ui.ButtonCore;
import pony.unity3d.StaticAccess;

/**
 * UI
 * @author AxGord <axgord@gmail.com>
 */
class UI implements StaticInit {

	static public var defaultButton:ButtonCore = StaticAccess.tintButton('default');
	static public var tintButton:ButtonCore = StaticAccess.tintButton('tint');
	
}