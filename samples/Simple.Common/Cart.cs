namespace Simple.Common
{
    public class Cart : Grain, ICart
    {       
        public Task Add(Product product)
        {
            throw new NotImplementedException();
        }
    }
}