using UnityEngine;
using System.Collections;

namespace Bullets
{
    public class ShotgunBullet : Bullet
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Enemy")
            {
                //TODO: Deal damage to enemy
            }
            DestroyBullet();
        }
    }
}



