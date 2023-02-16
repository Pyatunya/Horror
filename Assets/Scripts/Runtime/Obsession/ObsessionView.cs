using UnityEngine;
using UnityEngine.UI;

namespace Game.View
{
    public sealed class ObsessionView : MonoBehaviour
    {
        [SerializeField] private Slider _slider;

        public void Visualize(int health)
        {
            _slider.value = health / 100f;
        }
    }
}