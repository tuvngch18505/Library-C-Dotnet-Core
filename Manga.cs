class Manga
{
    private int id;
    private string name;
    private string author;
    private string category;
    private double price;
    private int page;
    private DateTime datetime;

    public int Id { set => id = value; get => id; }
    public string Name { get => name; set => name = value; }
    public string Author { get => author; set => author = value; }
    public string Category { get => category; set => category = value; }
    public double Price { get => price; set => price = value; }
    public int Page { get => page; set => page = value; }
    public DateTime Datetime { get => datetime; set => datetime = value; }
    public int Size { get => size; set => size = value; }

    private int size;

    public int Count(){
        return size;
    }

    static int count = 1;

    public Manga()
    {
        id = count++;
        name = "No Name";
        author = "No Author";
        category = "No category";
        price = 0;
        page = 0;
        datetime = DateTime.Now;
    }

    public Manga(string _name, string _author, string _category, double _price, int _page)
    {
        this.id = count++;
        this.Name = _name;
        this.Author = _author;
        this.Category = _category;
        this.Price = _price;
        this.Page = _page;
        this.Datetime = DateTime.Now;
    }
    public override string ToString()
    {
       
        string info = $"| { Id,0}   | {Name,20} | {Author,20} | {Category,15} | {Price ,10} VND  | {Page,15} | {DateTime.Now, 30} | ";
        return info;
    }
}