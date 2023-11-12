using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Managers.Abstracts;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Managers.Concretes
{
    public class EventManager : SingletonDontDestroyMonoObject<EventManager>
    {
        public event System.Action OnScoreChanged;
        
    }

}