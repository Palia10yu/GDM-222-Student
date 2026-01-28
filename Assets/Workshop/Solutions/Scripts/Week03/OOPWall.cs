using UnityEngine;

namespace Solution
{

    public class OOPWall : Identity
    {
        public int Damage;
        public bool IsIceWall;

        public override void Hit(Identity hitby)
        {
            base.Hit(hitby);
            if (hitby is OOPPlayer)
            {
                OOPPlayer p = hitby as OOPPlayer;
                p.TakeDamage(Damage);
                Debug.Log("Hit Wall");
            }
        }
    }
}