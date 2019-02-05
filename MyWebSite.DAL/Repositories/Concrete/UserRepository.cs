using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MyWebSite.DAL.MyEntities;
using MyWebSite.DAL.Repositories.Abstract;

namespace MyWebSite.DAL.Repositories.Concrete
{
    public class UserRepository : IUserRepository
    {
        MyWebSiteContext _db;

        public UserRepository()
        {
            _db = new MyWebSiteContext();
        }

        public int AddItem(User item)
        {
            _db.User.Add(item);
            var sonuc = _db.SaveChanges();
            return sonuc;
        }

        public int DeleteItem(User item)
        {
            _db.User.Remove(item);
            var sonuc = _db.SaveChanges();
            return sonuc;
        }

        public int UpdateItem(User item)
        {
            User oldUser = _db.User.FirstOrDefault(x => x.UserId == item.UserId);
            oldUser.FirstName = item.FirstName;
            oldUser.LastName = item.LastName;
            oldUser.Gender = item.Gender;
            oldUser.Password = item.Password;
            oldUser.EMail = item.EMail;
            var sonuc = _db.SaveChanges();
            return sonuc;
        }

        public User GetItem(Expression<Func<User, bool>> lambda = null)
        {
            return _db.User.Where(lambda).FirstOrDefault();
        }

        public ICollection<User> GetAllItem(Expression<Func<User, bool>> lambda = null)
        {
            return lambda != null ? 
                _db.User.Where(lambda).ToList() : 
                _db.User.ToList();
        }
    }
}
