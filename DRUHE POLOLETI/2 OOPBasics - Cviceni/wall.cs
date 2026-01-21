class Wall
{
    public float height;
    public float widht;
    public string material;

    public Wall(float height, float widht, string material)
    {
        this.height = height;
        this.widht = widht;
        this.material = material;

    }
    public float GetSurface()
    { 
        return height * widht;
    }

     public void PrintInfo()
    {
        Console.WriteLine($"Wall: mat={material} w={widht} h={height}" + $" surface={GetSurface()}");
    }
}