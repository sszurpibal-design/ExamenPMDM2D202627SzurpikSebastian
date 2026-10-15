using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float distanceFollow;

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
        
    }

    void checkPlayerDistance()
    {
    
    }

    public void death()
    {
        /*
        Este método inicia la animación de death del enemigo
        */
    }

    public void destroyEnemy(){

    }


}
