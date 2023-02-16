using UnityEngine;

namespace Game.Model.Interactables
{
    public sealed class EnergyKnockView : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        
        public void Visualize()
        {
            //TODO:
            //_animator.Play("Knock");
        }
    }
}