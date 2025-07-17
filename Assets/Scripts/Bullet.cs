using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [field: SerializeField, Header("ÃÑ¾Ë ¼Óµµ")]
    public float moveSpeed { get; set; } = 100.0f;
    public int damage { get; set; } = 10;
    public float destroyTime { get; set; } = 2.0f;
    void Start()
    {
        Destroy(this.gameObject, destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0,0,moveSpeed *  Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag.Contains("Enemy"))
        //{
        //    other.gameObject.GetComponent<Enemy>().Hit(damage);
        //    Destroy(this.gameObject);
        //}
    }
}
