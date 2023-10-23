using HB.NTier.BL.Manager;
using HB.NTier.DAL.Uow;

namespace HB.NTier.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {


            UserManager manager = new UserManager(new Uow(new DAL.Context.AppDbContext()));
            OrderManager orderManger = new OrderManager(new Uow(new DAL.Context.AppDbContext()));


            //manager.Add(new Entity.Entities.AppUser() { AppUserCategory = new() { AppUserCategoryName = "cate1" }, Password = "123", UserName = "hasan1" });



            //manager.Add(new Entity.Entities.AppUser() { CategoryId=1, Password = "123", UserName = "hasan1",Balance=2000 });


            orderManger.SiparişAl(4, 100, "xxxx");



        }
    }
}