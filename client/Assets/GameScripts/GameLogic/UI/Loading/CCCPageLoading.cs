using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using DBEngine;

namespace GameLogic
{
	[Window(UILayer.UI,location:"loading_CCPageLoading", fullScreen:true)]
	class CCPageLoading : UIWindow
	{
		#region 脚本工具生成的代码
        private Button _btn_close;
		protected override void ScriptGenerator()
        {
            _btn_close = FindChildComponent<Button>("m_btn_close");
			_btn_close.onClick.AddListener(UniTask.UnityAction(OnClick_loginBtn));
        }
		#endregion

		#region 事件
        private async UniTaskVoid OnClick_loginBtn()
		{
            await UniTask.Yield();
            Debug.Log("点击关闭");
            this.Close();
			// GameModule.UI.ShowUIAsync<CCPageLoading>();
		}
		#endregion

	}
}
