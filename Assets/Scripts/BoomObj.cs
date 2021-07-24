using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomObj : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        Debug.Log("출돌 했습니다!");
        Destroy(other.gameObject);
    }
}
