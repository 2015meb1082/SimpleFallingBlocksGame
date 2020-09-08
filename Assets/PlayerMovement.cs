using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float halfScreenWidthInWorldUnits; 
    public float moveSpeed=7.0f;
    
     // Start is called before the first frame update
    void Start()
    {
        float playerHalfWidth = transform.localScale.x/2f;
        halfScreenWidthInWorldUnits = Camera.main.aspect * Camera.main.orthographicSize +playerHalfWidth;    
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        Vector2 velocity = Vector2.right*inputX*moveSpeed;
        transform.Translate(velocity*Time.deltaTime);
        
        if(transform.position.x<-halfScreenWidthInWorldUnits){
            transform.position = new Vector2(halfScreenWidthInWorldUnits,transform.position.y);
        }else if(transform.position.x>halfScreenWidthInWorldUnits){
            transform.position = new Vector2(-halfScreenWidthInWorldUnits,transform.position.y);    
        }   
        
    }
}
