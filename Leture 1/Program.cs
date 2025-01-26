// See https://aka.ms/new-console-template for more information

class printToScreenRandomNumber
{
    Random myRand = new Random();

    public void printToScreen()
    {
        Console.WriteLine(myRand.Next().ToString("N0"));
    }

    private void printToPrivate()
    {
        Console.WriteLine(myRand.Next().ToString("N0"));
    }
    protected void printToProtected()
    {
        Console.WriteLine(myRand.Next().ToString("N0"));
    }
}

class printScreenV2 : printToScreenRandomNumber
{
    public void printProtected()
    {
       this.printToProtected();
    }
}