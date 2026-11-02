using Unity.VisualScripting;
using UnityEngine;

public class TitleHUDController
{
    // === メンバ変数  === //
    private TitleHUDView _view;
    private TitleSceneState _sceneState;

    // === コンストラクタ
    public TitleHUDController(TitleHUDView view, TitleSceneState sceneState)
    {
        _view = view;
        _sceneState = sceneState;

        // ボタン押下時のイベントを登録
        _view.OnClickButtonAction += OnClickButtonRequest;
    }

    private void OnClickButtonRequest()
    {
        _sceneState.AddScore();
    }
}
