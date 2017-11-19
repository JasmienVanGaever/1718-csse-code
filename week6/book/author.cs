public class Author : Book
{
    string email;
    char gender;


    public string Email { get => email; set => email = value; }
    public char Gender { get => gender; set => gender = value; }


    public Author()
    {

    }

    public Author(string name, double price, int qtyInStock) {
        this.Name = name;
        this.Price = price;
        this.QtyInStock = qtyInStock;
    }
    private List<author> authors;
}