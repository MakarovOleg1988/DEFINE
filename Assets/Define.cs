#define DEFINE_ONE
#define DEFINE_TWO
#define DEFINE_THREE

using UnityEngine;

namespace DefineExample
{
    public class Define : MonoBehaviour
    {
        public void Start()
        {
            #if DEFINE_ONE && (UNITY_IOS || UNITY_ANDROID || UNITY_STANDALONE)
                Debug.Log("DEFINE_ONE");
            #endif

            #if DEFINE_TWO && (UNITY_IOS || UNITY_ANDROID || UNITY_STANDALONE)
                Debug.Log("DEFINE_ONE");
            #endif

            #if DEFINE_THREE && (UNITY_IOS || UNITY_ANDROID || UNITY_STANDALONE)
                Debug.Log("DEFINE_THREE");
            #elif DEFINE_FOUR
                Debug.Log("DEFINE_FOUR");
            #endif
        }
    }
}
