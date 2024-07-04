using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] public float moveSpeed=10f;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horInput=Input.GetAxisRaw("Horizontal")*moveSpeed;
        float verInput=Input.GetAxisRaw("Vertical")*moveSpeed;

        Vector3 movement = new Vector3(horInput, 0, verInput); // Crea un vector de movimiento

        rb.velocity=movement;
        
        bool isStopped = rb.velocity.magnitude == 0f;
        animator.SetBool("IsStopped",isStopped);

        //IsStopped();
        IsRunningForward();
        IsRunningBackwards();
        IsAttacking();

        
    }

    /*private void IsStopped(){
        bool isStopped=false;
        if(Input.GetKey(KeyCode.S)){
            isStopped=true;
        }else{
            isStopped=false;
        }
        animator.SetBool("IsStopped",isStopped);
    }*/

    private void IsRunningBackwards(){
        bool isRunningBackwards=false;
        if(Input.GetKey(KeyCode.S)){
            isRunningBackwards=true;
        }else{
            isRunningBackwards=false;
        }
        animator.SetBool("IsRunningBackwards",isRunningBackwards);
    }

    private void IsRunningForward(){
        bool isRunningForward=false;
        if(Input.GetKey(KeyCode.W)){
            isRunningForward=true;
        }else{
            isRunningForward=false;
        }
        animator.SetBool("IsRunningForward",isRunningForward);
    }

    private void IsAttacking(){
        bool isAttacking=false;
        if(Input.GetKey(KeyCode.Mouse0)){
            isAttacking=true;
        }else{
            isAttacking=false;
        }
        animator.SetBool("IsAttacking",isAttacking);
    }
}
