class GraphicsSystem
{
    public void Initialize()
    {
        Console.WriteLine("Графика запущена");
        Console.WriteLine(" ");
    }
}
class AudioSystem
{
    public void Initialize()
    {
        Console.WriteLine("Звук включен");
        Console.WriteLine(" ");
    }
}
class InputSystem
{
    public void Initialize()
    {
        Console.WriteLine("Система ввода запущена");
        Console.WriteLine(" ");
    }
}
class SaveSystem
{
    public void Load()
    {
        Console.WriteLine("Сохранение загружено");
        Console.WriteLine(" ");
    }
}

class PlayerSystem
{
    public void Create()
    {
        Console.WriteLine("Игрок создан");
        Console.WriteLine(" ");
    }
}
class GameFacade
{
    private GraphicsSystem graphicsSystem;
    private AudioSystem audioSystem;
    private InputSystem inputSystem;
    private SaveSystem saveSystem;
    private PlayerSystem playerSystem;
    public GameFacade()
    {
        graphicsSystem = new GraphicsSystem();
        audioSystem = new AudioSystem();
        inputSystem = new InputSystem();
        saveSystem = new SaveSystem();
        playerSystem = new PlayerSystem();
    }
    public void StartGame()
    {
        graphicsSystem.Initialize();
        audioSystem.Initialize();
        inputSystem.Initialize();
        saveSystem.Load();
        playerSystem.Create();

        Console.WriteLine("Запуск игры");
    }
}
class Program
{
    static void Main()
    {
       GameFacade facade = new GameFacade();
        facade.StartGame();
        
    }
}