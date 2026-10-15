using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public CheckGround checkGround;
    public bool isRunning;
    public bool isJumping;

    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidBody;
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _rigidBody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();   
 
    }

    // Update is called once per frame
    void Update()
    {
        checkMovement();
        CheckJump();
    }

    void FixedUpdate()
    {
        
    }

    private void checkMovement()
    {

        if(Input.GetKeyDown(KeyCode.A)){
            _rigidBody.velocity = new Vector2(-speed, _rigidBody.velocity.y);

        }
        if(Input.GetKeyDown(KeyCode.D)){
            _rigidBody.velocity = new Vector2(speed, _rigidBody.velocity.y);

        }
        else{
            
        }
        
    }       
    
    private void CheckJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && checkGround)
        {
            _rigidBody.velocity = new Vector2(_rigidBody.velocity.x, jumpForce);
        }
    }

    public void impulse(float impulse)
    {
        /*
        Este método se ejecutará cuando el jugador salte sobre 
        la cabeza del enemigo impulsado al jugador hacia arriba.
        */

    }



}




