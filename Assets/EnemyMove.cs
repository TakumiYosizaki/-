using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyMove : MonoBehaviour
{
    [SerializeField]
    [Tooltip("追いかける対象")]
    private GameObject player;

    private NavMeshAgent navMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        // NavMeshAgentを保持しておく
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // プレイヤーを目指して進む
        navMeshAgent.destination = player.transform.position;
    }

    // 衝突検出
    void OnCollisionEnter(Collision collision)
    {
        // 衝突したオブジェクトのタグが "Bullet" である場合
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // 敵キャラクターを消す
            Destroy(gameObject);
        }
    }

}
