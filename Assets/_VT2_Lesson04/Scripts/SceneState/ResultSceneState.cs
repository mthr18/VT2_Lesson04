using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ResultSceneState : BaseSceneState
{
    // ===  HUD設定  === //
    public override string HudAddress { get; protected set; } = "Assets/_VT2_Lesson04/Prefab/ResultHUDCanvas_FullHD.prefab";

    public override void Enter()
    {
        Debug.Log($"{GetType().Name} が始まります");

        base.Enter();
    }

    public override void Execute()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            // タイトル画面に切り替える
            _sceneManager.ChangeScene(new TitleSceneState());
        }

        base.Execute();
    }

    public override void Exit()
    {
        base.Exit();
    }
}