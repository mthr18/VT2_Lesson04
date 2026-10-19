using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ResultSceneState : IState
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
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            // タイトル画面に切り替える
            _sceneManager.ChangeScene(new TitleSceneState());
        }
    }

    public void Exit()
    {
        Debug.Log($"{GetType().Name} が終了します");
    }
}