using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Game.View
{
    public sealed class ObsessionView : MonoBehaviour
    {
        [SerializeField] private Slider _slider;
        [SerializeField, Min(0.1f)] private float _timeToVisualize = 0.5f;
        
        public async void Visualize(float health)
        {
            float time = 0;

            while (time < _timeToVisualize)
            {
                time += Time.deltaTime;
                _slider.value = Mathf.Lerp(_slider.value, health / 100f, time);
                await UniTask.Yield();
            }
        }
    }
}