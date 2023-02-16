using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Game.Model.Obsession
{
    public sealed class ObsessionIncrease : MonoBehaviour
    {
        [SerializeField] private Obsession _obsession;
        [SerializeField, Min(0.01f)] private float _secondsForIncrease = 2f;
        [SerializeField, Min(0.01f)] private float _value = 10;

        private void Start() => IncreaseLoop().Forget();

        private async UniTaskVoid IncreaseLoop()
        {
            while (true)
            {
                if (_obsession.CanIncrease(_value))
                {
                    await Increase();
                }
                
                else
                {
                    var difference = _obsession.MaxValue - _obsession.Value;
                    
                    if(_obsession.CanIncrease(difference))
                        await Increase();
                }

                await UniTask.Yield();
            }
        }

        private async UniTask Increase()
        {
            await UniTask.Delay(TimeSpan.FromSeconds(_secondsForIncrease));
            _obsession.Increase(_value);
        }
    }
}