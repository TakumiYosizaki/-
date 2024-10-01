using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField]
    private GameOverManager gameOverManager;  // �Q�[���I�[�o�[�Ǘ��X�N���v�g���A�T�C�����邽�߂̕ϐ�

    private void OnTriggerEnter(Collider other)
    {
        // �v���C���[�ƏՓ˂������ǂ����̊m�F
        if (other.CompareTag("Player"))
        {
            if (gameOverManager != null)
            {
                gameOverManager.GameOver();  // �Q�[���I�[�o�[�������Ăяo��
            }
            else
            {
                Debug.LogError("GameOverManager is not assigned!");
            }

            // �G���g��j�󂷂�i�K�v�ɉ����āj
            Destroy(gameObject);
        }
    }
}
