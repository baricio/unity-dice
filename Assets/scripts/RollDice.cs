using UnityEngine;
using System.Collections;

public class RollDice : MonoBehaviour {

    public float thrust;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    
    void FixedUpdate()
    {
        //AddTorque(Vector3.Cross(lastPos, initPos) * 1000, orceMode.Impulse); - See more at: http://www.theappguruz.com/blog/roll-a-dice-unity-3d#sthash.xtjMU669.dpuf
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(Vector3.forward * thrust, ForceMode.Acceleration);
        }
    }
}
