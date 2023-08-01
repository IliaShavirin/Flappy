using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goken : MonoBehaviour
{
    [SerializeField] private AudioSource Gok;
    public float force;
    Rigidbody2D GokuRigid;
    public GameObject RestartButton;
    public GameObject BackButton;
    void Start()
    {
        Time.timeScale = 1;
        GokuRigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GokuRigid.velocity = Vector2.up * force;
            Gok.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            RestartButton.SetActive(true);
            BackButton.SetActive(true);
        }
    }
}
