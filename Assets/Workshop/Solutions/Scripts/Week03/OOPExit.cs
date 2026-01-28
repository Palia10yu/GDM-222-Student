using UnityEngine;

namespace Solution
{
    public class OOPExit : Identity
    {
       public GameObject WinUi;
       public override void Hit(Identity hitby)
        {
            base.Hit(hitby);
            if (hitby is OOPPlayer)
            {
                mapGenerator.UpdatePositionIdentity(hitby,positionX,positionY);
                WinUi.gameObject.SetActive(true);
                hitby.enabled = false;
            }
        }
    }
}