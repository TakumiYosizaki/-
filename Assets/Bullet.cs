using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bullet : MonoBehaviour
{
    // ����
    int lifeSpan;
    // �o�ߎ���
    float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        lifeSpan = 2;
    }
    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > lifeSpan)
        {
            Destroy(gameObject);
        }
    }
}