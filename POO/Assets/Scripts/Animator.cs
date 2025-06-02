using UnityEngine;

public class Animator : MonoBehaviour
{
   private Animator animator;
   private Vector2 input;
   
   
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");

        bool andando = input.magnitude > 0.1f;
        
        animator.SetBool("andando", andando);
    }
}
