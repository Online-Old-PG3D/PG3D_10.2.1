using System;
using System.Collections;
using UnityEngine;

namespace GAMERSUNITE
{
    // Token: 0x02000A32 RID: 2610
    public class PolarmodsManager : MonoBehaviour
    {
        // Token: 0x06004E21 RID: 20001
        public IEnumerator GetLogo()
        {
            WWW logo = new WWW("https://polarmods.com/styles/io_dark/io/images/logo1.png");
            yield return logo;
            yield break;
        }

        // Token: 0x06004E22 RID: 20002
        public PolarmodsManager()
        {
        }
    }
}
