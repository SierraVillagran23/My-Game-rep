using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 10.0f;
    private float turnSpeed = 20.0f;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody playerRb;
    public float jumpforce;
    public float gravityModifier;
    private Animator anim;
    public GameObject thePlayer;
    public bool isOnGround = true;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        anim = GetComponent<Animator>();
        playerRb.constraints = RigidbodyConstraints.FreezePositionY;
        playerRb.constraints = RigidbodyConstraints.FreezePositionX;
        playerRb.constraints = RigidbodyConstraints.FreezePositionZ;
    }

    // Update is called once per frame

    private void Update()
    {
        // player movement forward and sideways
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        Rotation();
        // player jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
            playerRb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
      
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
         anim.SetTrigger("FWD");
            anim.SetBool("IsMoving", true);
       
        }
        else
        {
            anim.SetBool("IsMoving", false);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           anim.SetTrigger("BWD");

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetTrigger("RGT");

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetTrigger("LFT");

        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            anim.SetTrigger("Attack");

        }
    }
    void Rotation()
    {
        // easier way to rotate the player
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * 4f, 0));
    }
    
}
