using System;

namespace Game.Model.Character
{
    internal class GameState
    {
        internal static void EndGame()
        {
            throw new NotImplementedException();
        }

        internal static void BadEndGame(string name)
        {
            switch (name)
            {
                case "Electricity":
                    //KillByElecticity();
                    break;
                case "Knife":
                    //KillByKnife();
                    break;
                case "Window":
                    //DoSuicideAroundWindow();
                    break;


            }
        }

        public void KillByElecticity()
        {

        }
    }
}