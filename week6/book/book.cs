public class Book {

    private string Name { get; set; }
    private string Author { get; set; }
    private double Price { get; set; }
    private int QtyInStock { get; set; }

    public Book(){
        QtyInStock = 0;
    }

    public Book(string name, string author, double price, int qtyInStock)
    {
        this.Name = name;
        this.Author = author;
        this.Price = price;
        this.QtyInStock = qtyInStock;
    }

    // public string Name { get => name; set => name = value;}
    
    // public string Author { get => author; set => author = value;}
    
    // public string Price { get => price; set => price = value;}

    // public string QtyInStock { get => qtyInStock; set => qtyInStock = value;}
}