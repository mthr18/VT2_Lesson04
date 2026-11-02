using UnityEngine;
using UnityEngine.InputSystem;

public class GameSceneState : BaseSceneState
{

    // ===  HUD設定  === //
    public override string HudAddress { get; protected set; } = "Assets/_VT2_Lesson04/Prefab/GameHUDCanvas_FullHD.prefab";

    // ===  メンバ変数  === //
    private GameObject _GameCube;

    public override void Enter()
    {
        base.Enter();

        // オブジェクトを生成する
        _GameCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    public override void Execute()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            // リザルト画面に切り替える
            _sceneManager.ChangeScene(new ResultSceneState());
        }

        base.Execute();
    }

    public override void Exit()
    {
        GameObject.Destroy( _GameCube );
        base.Exit();
    }
}