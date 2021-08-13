using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomObj : MonoBehaviour
{
    public GameObject boomVFX;
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("PlayerShip"))
        {
            Debug.Log("플레이어가 출돌 했습니다!");
            Destroy(other.gameObject);

            Instantiate(boomVFX, gameObject.transform.position, Quaternion.identity);

            GameObject gameManagerObj = GameObject.Find("GameManager");
            gameManagerObj.GetComponent<GameManager>().GameOver();
        }
        else if(other.CompareTag("PlayerBolt"))
        {
            Debug.Log("플레이어의 총알이 충돌 했습니다!");

            Destroy(gameObject);
            Instantiate(boomVFX, gameObject.transform.position, Quaternion.identity);
        }
    }
}
