namespace OnlineShop.Web.Models
{
    public class ProductTagViewModel
    {
        public int ProductID { set; get; }

        public string TagID { set; get; }

        public virtual ProductViewModel ProductViewModel { set; get; }

        public virtual TagViewModel TagViewModel { set; get; }
    }
}