using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Ball : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb_Ball;
    [SerializeField]
    private ForceMode forcemode;
    // Start is called before the first frame update
    void Awake()
    {
        
    }
    void Start()
    {
        rb_Ball = this.transform.GetComponent<Rigidbody>();
        if (rb_Ball == null) {
            Debug.LogError("ball RB is null");
        }
        rb_Ball.AddForce(Vector3.forward*5, forcemode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
