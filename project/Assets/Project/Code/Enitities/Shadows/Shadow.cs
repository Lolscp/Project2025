using UnityEngine;

namespace Project.Code.Enitities {
    public abstract class Shadow : MonoBehaviour {
        [Header("Properties")]
        [SerializeField] private float _Health;
        [SerializeField] private float _Move;
        [SerializeField] private float _Speed;
        //[Header("Components")]
        //[SerializeField] private Movement _Movement;

    }
}
