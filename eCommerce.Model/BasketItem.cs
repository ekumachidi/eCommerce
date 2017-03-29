namespace eCommerce.Model
{
    public class BasketItem
    {
        public int BasketItemId { get; set; }
        public int BasketId { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}