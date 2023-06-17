using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float addIntensity = 1f;
    [SerializeField] float restoreAngle = 90f;
    //[SerializeField] AmmoType ammoType;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.GetComponentInChildren<FlashLightSystem>().RestoreLightAngle(restoreAngle);
            other.GetComponentInChildren<FlashLightSystem>().AddLightIntensity(addIntensity);
            Destroy(gameObject);
        }      
    }
}
