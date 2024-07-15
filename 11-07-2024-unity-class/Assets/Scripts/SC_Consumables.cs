using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SC_Consumables : MonoBehaviour
{
    [SerializeField]
    private Color color;
    [SerializeField] 
    private Transform min,max;

    [SerializeField]
    private Vector3 spawnlocation;
    [SerializeField] 
    private Transform consumable;

    private float val;

    [SerializeField]
    private bool IsHealth, IsAmmo, IsSpeedBoost, IsDamageBoost;

    void Awake()
    {
        
        val = 0.01f;
        spawnlocation = consumable.position;  
    }


    // Update is called once per frame
    void Update()
    {
        consumable.Rotate(0, 1, 0);

        float y = consumable.position.y;

        if (consumable.transform.position.y >= max.position.y) {
            val = -0.01f;
        }
        else if (consumable.transform.position.y <= min.position.y) {

            val = 0.01f;
        }

        movement(val);


    }
    void movement(float Value) {

        consumable.Translate(0,Value,0);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.tag);
    }
    void Health() { 
        
    }
}
