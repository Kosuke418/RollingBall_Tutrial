using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    const float Gravity = 9.81f;

    public float gravityscale = 1.0f;

    public int Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector = new Vector3();
        vector.x = Input.GetAxis("Horizontal");
        vector.z = Input.GetAxis("Vertical");
        vector.y = -1.0f;

        Physics.gravity = Gravity * vector.normalized * gravityscale;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Score += 100;
    }
}
