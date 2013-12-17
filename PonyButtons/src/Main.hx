package ;

import unityengine.MonoBehaviour;
using hugs.HUGSWrapper;

/**
 * Main
 * @author AxGord <axgord@gmail.com>
 */

class Main extends MonoBehaviour {
	
	private function Start():Void {
		UI.initStatic();
		UI.defaultButton.click.add(function() trace('click'));
		UI.tintButton.click.add(function() UI.defaultButton.mode = UI.defaultButton.mode == 1 ? 0 : 1);
	}
	
	private function Update():Void {
		
	}
	
	private static function main(){}
}