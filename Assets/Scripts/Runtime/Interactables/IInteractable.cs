namespace Game.Model.Interactables
{
    public interface IInteractable
    {
        bool HasInteracted { get; }

        void Interact();
    }
}