using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void RestartGame()
    {
        Debug.Log("RestartGame button clicked");
        // 特定のシーン名に変更
        SceneManager.LoadScene("Gamescene");
    }

    public void QuitGame()
    {
        Debug.Log("QuitGame button clicked");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();  // ビルドされたゲームを終了
#endif
    }
}
