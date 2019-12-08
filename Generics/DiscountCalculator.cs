namespace Generics
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public decimal CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }
}