using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using DBEngine;

namespace GameLogic
{
	[Window(UILayer.UI, location: "login_CCPageLogin")]
	class CCPageLogin : UIWindow
	{
		#region 脚本工具生成的代码
		private Button _btn_login;
		protected override void ScriptGenerator()
		{
			_btn_login = FindChildComponent<Button>("m_btn_login");
			_btn_login.onClick.AddListener(UniTask.UnityAction(OnClick_loginBtn));
		}
		#endregion

		#region 事件
		private async UniTaskVoid OnClick_loginBtn()
		{
            await UniTask.Yield();
            Debug.Log("点击登录");
		}
		#endregion

	}
}
