using Microsoft.Xna.Framework;
using System;

class TickTick : GameEnvironment // yoyo robbie test
{
	// hola hola boris test ook
    // En jij bent ebola
    [STAThread]
    static void Main()
    {
        TickTick game = new TickTick();
        game.Run();
    }

    public TickTick()
    {
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void LoadContent()
    {
        base.LoadContent();
        screen = new Point(1440, 825);
        windowSize = new Point(1024, 586);
        FullScreen = false;
        
        gameStateManager.AddGameState("titleMenu", new TitleMenuState());
        gameStateManager.AddGameState("helpState", new HelpState());
        gameStateManager.AddGameState("playingState", new PlayingState(Content));
        gameStateManager.AddGameState("levelMenu", new LevelMenuState());
        gameStateManager.AddGameState("gameOverState", new GameOverState());
        gameStateManager.AddGameState("levelFinishedState", new LevelFinishedState());
        gameStateManager.SwitchTo("titleMenu");

        AssetManager.PlayMusic("Sounds/snd_music");
    }
}