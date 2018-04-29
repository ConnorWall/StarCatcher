using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp: MonoBehaviour {

    public float multiplier= 1.4f;

    public GameObject pickupEffect;

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")) {
            StartCoroutine(Pickup(other));
        }
    }
    IEnumerator Pickup(Collider player){
        //spawn effect
        Instantiate(pickupEffect, transform.position, transform.rotation);
        //apply effect
        Player stats = player.GetComponent<ScoreCount>();
        stats.gscore *= multiplier;

        yield return new WaitForSeconds

        stats.gscore /= multiplier;

        //remove object
        Destroy(gameObject);
    }
}
