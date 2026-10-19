using UnityEngine;
using UnityEngine.InputSystem;

public class GameSceneState : IState
{
    // ===  メンバ変数  === //
    private SceneManager _sceneManager;

    private GameObject _GameCube;

    public void Enter()
    {
        Debug.Log($"{GetType().Name} が始まります");

        // SceneManagerを取得
        _sceneManager = GameObject.FindAnyObjectByType<SceneManager>();

        // オブジェクトを生成する
        _GameCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    public void Execute()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            // リザルト画面に切り替える
            _sceneManager.ChangeScene(new ResultSceneState());
        }
    }

    public void Exit()
    {
        Debug.Log($"{GetType().Name} が終了します");

        GameObject.Destroy( _GameCube );
    }
}