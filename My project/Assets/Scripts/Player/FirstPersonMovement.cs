using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FirstPersonMovement : MonoBehaviour
{
    CharacterController controller;

    public List<float> walkSpeed;
    public float sprintSpeed;
    public float crouchSpeed;
    public int walkSpeedVal;
    float speed;
    float gravity = -9.81f;
    public TMP_Text moveSpeedText;

    [Header("Stamina mults")]
    public float stamIncreaseSprintMult;
    public float stamDecreaseSprintMult;

    [Header("Jumping")]
    public float jumpHeight;
    bool isGrounded;
    public Transform groundCheck;
    public float groundDistance;
    public LayerMask groundMask;

    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Jumping
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
    
        if(InputManager.instance.jump && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        //Speeds
        if(InputManager.instance.sprinting){
            if(PlayerManager.instance.stamina > 0){
                speed = sprintSpeed;
                PlayerManager.instance.stamina -= Time.deltaTime * stamDecreaseSprintMult;
            }
            if(PlayerManager.instance.stamina < 0){
                InputManager.instance.sprinting = false;
            }
        }else{
            PlayerManager.instance.stamina += Time.deltaTime * stamIncreaseSprintMult;
        }

        if(InputManager.instance.crouching){
            InputManager.instance.crouching = false;
            speed = crouchSpeed;
            PlayerManager.instance.stamina -= 15;
        }
        
        if(InputManager.instance.mouseScroll.y > 0){
            if(walkSpeedVal < 9){
                walkSpeedVal++;
            }
        }
        if(InputManager.instance.mouseScroll.y < 0){
            if(walkSpeedVal > 0){
                walkSpeedVal--;
            }
        }
        if(!InputManager.instance.sprinting && !InputManager.instance.crouch){
            speed = walkSpeed[walkSpeedVal];
        }
        moveSpeedText.text = "Speed: " +speed.ToString();

        //Movement
        float x =  InputManager.instance.movement.x;
        float z =  InputManager.instance.movement.y;
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
