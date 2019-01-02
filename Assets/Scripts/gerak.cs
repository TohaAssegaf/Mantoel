using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerak : MonoBehaviour {
    //public untuk global variabel
    public int kecepatan, cepatLompat;
    Vector2 ball;
    Rigidbody2D lompat;

    public bool tanah;
    public LayerMask targetlayer;
    public float jangkauan;
    public Transform deteksitanah;
	// Use this for initialization
	void Start () {
        //harus diinialisasi
        lompat = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        tanah = Physics2D.OverlapCircle(deteksitanah.position, jangkauan, targetlayer);
        //Get key sebagai inputan tombol, keycode berdasarkan code tombol
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Translate untuk pergerakan object, vector2 merupakan vector x dan y, vector3 xyz
            //transform.position = transform.position + (Vector2.right * kecepatan * Time.deltaTime);
            transform.position = lompat.transform.position + (Vector3.right * kecepatan * Time.deltaTime);
            //transform.Translate(Vector2.right * kecepatan * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = lompat.transform.position + (Vector3.left * kecepatan * Time.deltaTime);
            //transform.Translate(Vector2.left * kecepatan * Time.deltaTime);
        }
        if (tanah == true && (Input.GetKey(KeyCode.UpArrow)))
        {
            lompat.AddForce(new Vector2(0, cepatLompat));
        }


	}
}
