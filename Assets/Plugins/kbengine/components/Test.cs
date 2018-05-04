namespace KBEngine
	{
		using UnityEngine; 
		using System; 
		using System.Collections; 
		using System.Collections.Generic;

		public class Test : TestBase
		{
			public Test() : base()
			{
			}

			public override void onOwnChanged(Int32 oldValue) {
				Dbg.DEBUG_MSG("Test::onOwnChanged: own(" + own + ")!");
			}
			public override void onStateChanged(Int32 oldValue) {
				Dbg.DEBUG_MSG("Test::onOwnChanged: state(" + state + ")!");
			}

			public override void helloCB(Int32 arg1)
			{
			    Dbg.DEBUG_MSG("Test::helloCB: arg1(" + arg1 + ")!");
                //((Avatar)owner).cellEntityCall.component1.hello(795);
			}
		}
	} 
