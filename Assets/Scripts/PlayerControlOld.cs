using UnityEngine;

public class PlayerControlOld : MonoBehaviour
{
    private Animator animator;
    public float fuerzaSalto; 
    private Rigidbody2D rigidbody2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("Jumping", true);
            rigidbody2. AddForce(new Vector2(0.0f, fuerzaSalto));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            animator.SetBool("Jumping", false);
        }
    }
}
