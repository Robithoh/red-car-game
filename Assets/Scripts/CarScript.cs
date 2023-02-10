using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarScript : MonoBehaviour
{
    bool alive = true;

    public float speed;
    public float belok;
    private Vector3 direction;
    private CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * belok);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * belok);
        }
        if(transform.position.y < -5)
        {
            Die();
        }
    }

    private void FixedUpdate()
    {
        if (!alive) return;

        /*controller.Move(direction * Time.fixedDeltaTime);*/
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    public void Die()
    {
        alive = false;
        // restart the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
