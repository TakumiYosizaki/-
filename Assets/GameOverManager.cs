using UnityEngine;
using UnityEngine.SceneManagement;  // シーン管理を使用するために必要

public class GameOverManager : MonoBehaviour
{
    // このメソッドを呼び出すとゲームオーバーシーンに遷移します
    public void GameOver()
    {
        // "GameOver" シーンに遷移
        SceneManager.LoadScene("GameOver");
    }
}
