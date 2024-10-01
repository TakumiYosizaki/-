using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField]
    private GameOverManager gameOverManager;  // ゲームオーバー管理スクリプトをアサインするための変数

    private void OnTriggerEnter(Collider other)
    {
        // プレイヤーと衝突したかどうかの確認
        if (other.CompareTag("Player"))
        {
            if (gameOverManager != null)
            {
                gameOverManager.GameOver();  // ゲームオーバー処理を呼び出す
            }
            else
            {
                Debug.LogError("GameOverManager is not assigned!");
            }

            // 敵自身を破壊する（必要に応じて）
            Destroy(gameObject);
        }
    }
}
