using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentodoNegão : MonoBehaviour
{
    public CharacterController moveNegão;

    public float speedNegão = 10f;
    public float gravidade = -9.81f;
    public float jumpHeigh = 3f;
    
    public Transform éChão;
    public float tamanhoChão = 0.4f;
    public LayerMask groundMask;

    Vector3 velocidadeNegão;

    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      isGrounded = Physics.CheckSphere(éChão.position, tamanhoChão,groundMask);

      if (isGrounded && velocidadeNegão.y<0)
      {
       velocidadeNegão.y = -2f;
      }

      float x = Input.GetAxis("Horizontal");
      float z = Input.GetAxis("Vertical");

      Vector3 move = transform.right * x + transform.forward * z; 

      
      
      moveNegão.Move(move * speedNegão * Time.deltaTime);

      if (Input.GetButtonDown("Jump") && isGrounded)
      {
       velocidadeNegão.y = Mathf.Sqrt(jumpHeigh* -2 * gravidade);
      }

      velocidadeNegão.y += gravidade * Time.deltaTime;
      moveNegão.Move(velocidadeNegão * Time.deltaTime);
    }
}
