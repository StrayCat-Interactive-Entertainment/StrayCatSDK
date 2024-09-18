using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrayCatSDK
{
    public abstract class Singleton<T> where T : Singleton<T>, new()
    {
        private static T _instance;
        private static readonly object lockObject = new object();

        protected Singleton() { }

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (lockObject)
                    {
                        _instance ??= new T();
                    }
                }
                return _instance;
            }
        }
    }
}