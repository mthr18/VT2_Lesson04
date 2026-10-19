using UnityEngine;
using UnityEngine.InputSystem;

public class TitleSceneState : IState
{
    // ===  メンバ変数  === //
    private SceneManager _sceneManager;

    public void Enter()
    {
        Debug.Log($"{GetType().Name} が始まります");

        // SceneManagerを取得
        _sceneManager = GameObject.FindAnyObjectByType<SceneManager>();
    }

    public void Execute()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            // ゲーム画面に切り替える
            _sceneManager.ChangeScene(new GameSceneState());
        }
    }

    public void Exit()
    {
        Debug.Log($"{GetType().Name} が終了します");
    }
}
