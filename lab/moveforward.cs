using UnityEngine;

public class moveforward : MonoBehaviour
{
    public float speed = 10f;
    public bool canMove = false;
    private void Update()
    {
        if (canMove)
        {
            getcomponent<Rigidbody>().Velocity =
            new vector2(transform.forward.x, 0)* speed;
        }
    }
    private void OncollisionEnter(Collision collision)
    {
        canMove = collision.gameObject.CompareTag("Ground");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
