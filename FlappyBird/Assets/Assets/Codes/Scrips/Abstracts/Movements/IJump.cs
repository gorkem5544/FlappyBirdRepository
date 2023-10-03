using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Abstracts.Movements
{
    public interface IJump
    {
        void FixedJumpTick();
        void UpdateJumpTick();
    }

}