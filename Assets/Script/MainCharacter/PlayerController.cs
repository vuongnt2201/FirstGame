using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;
    [SerializeField] private Rigidbody2D _rb;
    //IsometricCharacterRender isoRenderer;
    
    // Start is called before the first frame update
    private void Awake() 
    {
        _rb = GetComponent<Rigidbody2D>();
        //isoRenderer = GetComponentInChildren<IsometricCharacterRender>();
    }
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate() 
    {
        Vector2 currentPos = _rb.position;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 inputVector = new Vector2(horizontalInput, verticalInput);
        inputVector = Vector2.ClampMagnitude(inputVector, 1);
        Vector2 movement = inputVector * _speed;
        Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
        //isoRenderer.SetDirection(movement);
        _rb.MovePosition(newPos);
    }
}
