using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private bool isActice = true;

    public GameObject MarkPrefab;

    private void OnCollisionEnter(Collision collision)
    {
        if (!isActice) return;
        isActice = false;

        GetComponent<Rigidbody>().useGravity = true;
        Debug.Log(collision.gameObject.name);

        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy)
        {
            enemy.OnHit();
        }

        if (collision.gameObject.tag == "BulletMarkReceiver")
        {
            Vector3 position = collision.contacts[0].point;
            Quaternion rotation = Quaternion.LookRotation(collision.contacts[0].normal);
            Instantiate(MarkPrefab, position, rotation);
        }
    }
}
