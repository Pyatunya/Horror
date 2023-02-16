namespace Game.Model.Items
{
    public interface IItem
    {
        bool HasInteracted { get; }
        
        ItemData Data { get; }

        void Interact();
    }
}