using UnityEngine;
using UnityEngine.SceneManagement;  // �V�[���Ǘ����g�p���邽�߂ɕK�v

public class GameOverManager : MonoBehaviour
{
    // ���̃��\�b�h���Ăяo���ƃQ�[���I�[�o�[�V�[���ɑJ�ڂ��܂�
    public void GameOver()
    {
        // "GameOver" �V�[���ɑJ��
        SceneManager.LoadScene("GameOver");
    }
}
