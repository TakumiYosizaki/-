using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void RestartGame()
    {
        Debug.Log("RestartGame button clicked");
        // ����̃V�[�����ɕύX
        SceneManager.LoadScene("Gamescene");
    }

    public void QuitGame()
    {
        Debug.Log("QuitGame button clicked");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();  // �r���h���ꂽ�Q�[�����I��
#endif
    }
}
