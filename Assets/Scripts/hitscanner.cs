using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Opsive.UltimateCharacterController.Events;

public class hitscanner : MonoBehaviour
{

    public void Awake()
    {
        EventHandler.RegisterEvent<float, Vector3, Vector3, GameObject, Collider>(gameObject, "OnObjectImpact", OnImpact);
    }

    private void OnImpact(float amount, Vector3 position, Vector3 forceDirection, GameObject attacker, Collider hitCollider)
    {
        Debug.Log(name + " impacted by " + attacker + " on collider " + hitCollider + ".");
        Destroy(gameObject);
    }

    public void OnDestroy()
    {
        EventHandler.UnregisterEvent<float, Vector3, Vector3, GameObject, Collider>(gameObject, "OnObjectImpact", OnImpact);
    }
}
