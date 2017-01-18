using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    public Text countText;
    public Text victoryText;
    public AudioClip clickAudio;
    public bool isGrounded;
    private Rigidbody rb;
    private int count;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        victoryText.text = " ";
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }


    void Update()
    {

        // float inputX = Input.GetAxis("horizontal");
        //float inputZ = Input.GetAxis("Vertical");

        // float moveX = inputX*moveSpeed*Time.deltaTime;
        // float moveZ = inputZ*moveSpeed*Time.deltaTime;


        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            //  rb.AddForce(moveX,0f,moveZ);

            isGrounded = false;
        }

    }
    //movement 
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * moveSpeed);



        /*if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(-Vector3.up * moveSpeed * Time.deltaTime);*/

    }

    //pick up
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {

            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();

        }

    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 14)
        {
            victoryText.text = "Winner !!! ";
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "GameObject")
            if (gameObject.CompareTag("GameObject"))
            {
                var velocity = Vector3.zero;
            }
    }
}

